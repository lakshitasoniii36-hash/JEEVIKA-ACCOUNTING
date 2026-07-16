// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: LIST VIEW & ACTIONS
// ═══════════════════════════════════════════════════════

var MemberBillList = (function () {

  var sortCol = 'billNo';
  var sortDesc = true;
  var activeBillTypeFilter = 'Maintenance';
  var pillsRendered = false;

  // ── Bill Type Pill Bar ──
  function getBillTypes() {
    var types = ['All'];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        if (Array.isArray(parsed)) {
          parsed.forEach(function (t) {
            var name = (typeof t === 'string') ? t : (t.name || t.typeName || '');
            if (name && types.indexOf(name) === -1) types.push(name);
          });
        } else if (parsed && typeof parsed === 'object') {
          Object.keys(parsed).forEach(function (key) {
            if (key && types.indexOf(key) === -1) types.push(key);
          });
        }
      }
    } catch (e) { }
    // Fallback: if only 'All' exists, add defaults
    if (types.length === 1) {
      types.push('Maintenance', 'Clubhouse', 'Major Repair');
    }
    return types;
  }

  function updateAddBillDropdown(types) {
    var dropdown = document.getElementById('mb-add-dropdown-menu');
    var arrow = document.getElementById('mb-add-arrow');
    if (dropdown) {
      if (activeBillTypeFilter === 'All') {
        var subTypes = types.filter(function (t) { return t !== 'All'; });
        var html = '';
        subTypes.forEach(function (t) {
          html += '<div class="mb-dropdown-item" onclick="MemberBillRouter.showForm(null, \'' + t + '\')" style="padding:6px 16px; font-size:11px; cursor:pointer; color:#424242; font-weight:600; text-align:left; transition:background 0.15s; user-select:none;">' + t + '</div>';
        });
        dropdown.innerHTML = html;
        dropdown.classList.add('hoverable');
        if (arrow) arrow.style.display = 'inline';

        dropdown.querySelectorAll('.mb-dropdown-item').forEach(function (el) {
          el.addEventListener('mouseenter', function () { this.style.background = '#E3F2FD'; this.style.color = '#1565C0'; });
          el.addEventListener('mouseleave', function () { this.style.background = ''; this.style.color = ''; });
        });
      } else {
        dropdown.classList.remove('hoverable');
        dropdown.style.display = 'none';
        if (arrow) arrow.style.display = 'none';
      }
    }
  }

  function renderBillTypePills() {
    var container = document.getElementById('mb-bill-type-pills');
    if (!container) return;
    var types = getBillTypes();
    var html = '';
    types.forEach(function (t) {
      var active = (t === activeBillTypeFilter) ? ' active' : '';
      html += '<span class="mb-type-pill' + active + '" onclick="MemberBillList.switchBillType(\'' + t + '\')">' + t + '</span>';
    });
    container.innerHTML = html;
    pillsRendered = true;

    // Update Add Bill dropdown
    updateAddBillDropdown(types);

    // Dynamically populate bill type dropdown in filter bar
    var filterSel = document.getElementById('mb-filter-billtype');
    if (filterSel) {
      var selVal = filterSel.value;
      var optHtml = '<option value="">All</option>';
      types.forEach(function (t) {
        if (t !== 'All') {
          optHtml += '<option value="' + t + '">' + t + '</option>';
        }
      });
      filterSel.innerHTML = optHtml;
      filterSel.value = selVal;
    }
  }

  function switchBillType(type) {
    activeBillTypeFilter = type;
    renderBillTypePills();
    refresh();
  }

  function refresh() {
    // Render pills on first call
    if (!pillsRendered) renderBillTypePills();

    // Show/hide bill type filter and toggle table class
    var filterGroup = document.querySelector('.mb-bill-type-filter');
    if (filterGroup) {
      filterGroup.style.display = (activeBillTypeFilter === 'All') ? 'block' : 'none';
    }
    var tbl = document.querySelector('.mb-list-table');
    if (tbl) {
      if (activeBillTypeFilter === 'All') {
        tbl.classList.add('show-bill-type-col');
      } else {
        tbl.classList.remove('show-bill-type-col');
      }
    }

    var data = MemberBillState.getAllBills();

    // ── Bill Type Filter (from pill bar) ──
    if (activeBillTypeFilter && activeBillTypeFilter !== 'All') {
      data = data.filter(function (b) {
        return (b.billType || '') === activeBillTypeFilter;
      });
    } else if (activeBillTypeFilter === 'All') {
      var filterBillType = (document.getElementById('mb-filter-billtype') || {}).value || '';
      if (filterBillType) {
        data = data.filter(function (b) {
          return (b.billType || '') === filterBillType;
        });
      }
    }

    // Apply filters
    var search = (document.getElementById('mb-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (b) {
        return (b.billNo.toLowerCase().includes(search) ||
          b.memberName.toLowerCase().includes(search) ||
          b.memberCode.toLowerCase().includes(search) ||
          b.period.toLowerCase().includes(search) ||
          b.dueDate.toLowerCase().includes(search));
      });
    }

    var filterBillNo = (document.getElementById('mb-filter-billno') || {}).value || '';
    if (filterBillNo) data = data.filter(function (b) { return b.billNo.toLowerCase().includes(filterBillNo.toLowerCase()); });

    var filterCode = (document.getElementById('mb-filter-membercode') || {}).value || '';
    if (filterCode) data = data.filter(function (b) { return b.memberCode.toLowerCase().includes(filterCode.toLowerCase()); });

    var filterName = (document.getElementById('mb-filter-membername') || {}).value || '';
    if (filterName) data = data.filter(function (b) { return b.memberName.toLowerCase().includes(filterName.toLowerCase()); });

    var periodFilter = (document.getElementById('mb-filter-period') || {}).value;
    if (periodFilter) data = data.filter(function (b) { return b.period === periodFilter; });

    var dueFilter = (document.getElementById('mb-filter-duedate') || {}).value;
    if (dueFilter) data = data.filter(function (b) { return b.dueDate === dueFilter; });

    var statusFilter = (document.getElementById('mb-filter-status') || {}).value;
    if (statusFilter) data = data.filter(function (b) { return b.status === statusFilter; });

    // Sort
    data.sort(function (a, b) {
      var valA = a[sortCol];
      var valB = b[sortCol];

      // Fallbacks for derived sorting columns
      if (sortCol === 'wing' && valA === undefined) valA = (a.wing || (a.wingFlat ? a.wingFlat.split('-')[0] : ''));
      if (sortCol === 'wing' && valB === undefined) valB = (b.wing || (b.wingFlat ? b.wingFlat.split('-')[0] : ''));
      if (sortCol === 'flatType' && valA === undefined) valA = a.flatType || '1BHK';
      if (sortCol === 'flatType' && valB === undefined) valB = b.flatType || '1BHK';
      if (sortCol === 'particular' && valA === undefined) valA = a.particular || (a.items && a.items[0] ? a.items[0].particular1 : '');
      if (sortCol === 'particular' && valB === undefined) valB = b.particular || (b.items && b.items[0] ? b.items[0].particular1 : '');

      if (valA === undefined || valA === null) valA = '';
      if (valB === undefined || valB === null) valB = '';

      if (typeof valA === 'string') valA = valA.toLowerCase();
      if (typeof valB === 'string') valB = valB.toLowerCase();
      if (valA < valB) return sortDesc ? 1 : -1;
      if (valA > valB) return sortDesc ? -1 : 1;
      return 0;
    });

    renderTable(data);
    updateSummary(data);
  }

  function renderTable(data) {
    var tbody = document.getElementById('mb-list-tbody');
    if (!tbody) return;

    document.getElementById('mb-list-count').innerText = data.length + ' bills';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="13" style="text-align:center;padding:20px;color:#9E9E9E;">No Bills Found</td></tr>';
      return;
    }

    var html = '';
    var selected = MemberBillState.getSelected();

    data.forEach(function (b) {
      var isSelected = selected.includes(b.billNo);
      var rowClass = isSelected ? 'mb-row-active' : '';

      html += '<tr class="mb-list-row ' + rowClass + '"' +
        ' onclick="MemberBillState.toggleSelection(\'' + b.billNo + '\')"' +
        ' ondblclick="MemberBillRouter.showForm(\'' + b.billNo + '\')">';

      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-circle-fill"></i> ' : '') + b.billNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(b.billDate) + '</td>';
      html += '<td class="mb-bill-type-col">' + (b.billType || '') + '</td>';
      html += '<td>' + b.memberCode + '</td>';
      html += '<td>' + (b.wing || (b.wingFlat ? b.wingFlat.split('-')[0] : '')) + '</td>';
      html += '<td>' + (b.flatType || '1BHK') + '</td>';
      html += '<td>' + b.memberName + '</td>';
      html += '<td>' + b.period + '</td>';

      var isOverdue = b.status === 'Unpaid' && b.dueDate < new Date().toISOString().split('T')[0];
      html += '<td style="' + (isOverdue ? 'color:#C62828;font-weight:bold;' : '') + '">' + window.formatDateToDDMMYYYY(b.dueDate) + '</td>';

      html += '<td class="mb-td-right">₹' + b.principalTotal.toFixed(2) + '</td>';
      html += '<td class="mb-td-right">₹' + b.interestTotal.toFixed(2) + '</td>';
      html += '<td class="mb-td-right mb-td-total">₹' + b.finalTotal.toFixed(2) + '</td>';

      var particular = b.particular || (b.items && b.items[0] ? b.items[0].particular1 : '');
      var specialNote = b.specialNote || '';
      html += '<td>' + particular + '</td>';
      html += '<td>' + specialNote + '</td>';

      var statCls = b.status === 'Paid' ? 'mb-status-paid' : (b.status === 'Unpaid' ? 'mb-status-unpaid' : 'mb-status-partial');
      html += '<td class="mb-td-center"><span class="mb-status-badge ' + statCls + '">' + b.status + '</span></td>';

      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('mb-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var prinTot = 0, intTot = 0, finalTot = 0;

    data.forEach(function (b) {
      prinTot += b.principalTotal;
      intTot += b.interestTotal;
      finalTot += b.finalTotal;
    });

    summaryEl.innerHTML = '<span class="mb-summary-item"><strong>Total Bills:</strong> ' + count + '</span>' +
      '<span class="mb-summary-item"><strong>Principal:</strong> ₹' + prinTot.toLocaleString('en-IN', { minimumFractionDigits: 2 }) + '</span>' +
      '<span class="mb-summary-item"><strong>Interest:</strong> ₹' + intTot.toLocaleString('en-IN', { minimumFractionDigits: 2 }) + '</span>' +
      '<span class="mb-summary-item"><strong>Total Amount:</strong> ₹' + finalTot.toLocaleString('en-IN', { minimumFractionDigits: 2 }) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.mb-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('mb-sort-asc', 'mb-sort-desc');
      if (th.dataset.sort === sortCol) th.classList.add(sortDesc ? 'mb-sort-desc' : 'mb-sort-asc');
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mb-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.mb-filter-input, .mb-filter-select').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = MemberBillState.getSelected();
    if (sel.length !== 1) {
      JeevikaDialog.alert("Please select exactly one bill to edit.", "Edit Bill");
      return;
    }
    MemberBillRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = MemberBillState.getSelected();
    if (sel.length === 0) {
      JeevikaDialog.alert("Please select at least one bill to delete.", "Delete Bills");
      return;
    }
    JeevikaDialog.confirm("Are you sure you want to delete the selected " + sel.length + " bill(s)?", function () {
      sel.forEach(function (b) { MemberBillState.deleteBill(b); });
      MemberBillState.clearSelection();
    }, "Delete Bills");
  }

  function previewSelected() {
    var sel = MemberBillState.getSelected();
    if (sel.length !== 1) {
      JeevikaDialog.alert("Please select exactly one bill to preview.", "Preview Bill");
      return;
    }
    MemberBillRouter.showPreview(sel[0]);
  }

  function getAccountName(code) {
    try {
      var accountsVal = localStorage.getItem('jeevika_master_account');
      if (accountsVal) {
        var accounts = JSON.parse(accountsVal);
        if (Array.isArray(accounts)) {
          var match = accounts.find(function (a) {
            return (a.accCode || a.AccCode || '') === code;
          });
          if (match) return match.accName || match.AccName || code;
        }
      }
    } catch (e) { }
    return code;
  }

  // ── OLD ERP ACTIONS ──

  async function runAutoGenerate() {
    var period = document.getElementById('ag-period').value;
    var particular = document.getElementById('ag-particular').value;
    var bDate = document.getElementById('ag-bill-date').value;
    var dDate = document.getElementById('ag-due-date').value;
    var fromVal = document.getElementById('ag-member-from').value;
    var toVal = document.getElementById('ag-member-to').value;

    if (!period || !bDate) { JeevikaDialog.alert("Please fill mandatory fields.", "Auto Generate"); return; }

    MemberBillRouter.closeModal('mb-modal-auto-generate');
    MemberBillRouter.showLoading('Generating Bills for ' + period + '...');

    var billType = activeBillTypeFilter || 'Maintenance';
    if (billType === 'All') billType = 'Maintenance';

    // Fetch latest matrix data and active members list from backend dynamically
    var savedMatrix = [];
    var members = [];
    var allowedCodes = [];
    var allowedHeads = [];
    try {
      // 0. Fetch configured heads for this bill type
      try {
        var btmRes = await fetch('http://localhost:5002/api/bill-type-master');
        if (btmRes.ok) {
          var btmConfig = await btmRes.json();
          if (btmConfig && btmConfig[billType]) {
            var heads = btmConfig[billType].heads || [];
            heads.forEach(function (h) {
              if (h.accCode && h.accName) {
                allowedCodes.push(h.accCode);
                allowedHeads.push(h.accName);
                allowedHeads.push(h.accName.toLowerCase().trim());
              }
            });
          }
        }
      } catch (e) {
        console.warn("Failed to fetch bill type config", e);
      }

      if (allowedCodes.length === 0) {
        if (billType === 'Maintenance') {
          allowedCodes = ['INC-1004', 'INC-1002', 'INC-1006', 'LIA-1004', 'INC-1005', 'INC-1001'];
          allowedHeads = ['service charges', 'water charges', '4-wheeler parking charges', 'sinking fund', 'non occupancy charges', 'property tax'];
        } else if (billType === 'Clubhouse') {
          allowedCodes = [];
          allowedHeads = [];
        } else if (billType === 'Major Repair') {
          allowedCodes = ['LIA-1005'];
          allowedHeads = ['major repair fund'];
        }
      }

      // 1. Fetch Matrix adjustments
      // 1. Fetch Matrix adjustments
      var res = await fetch('http://localhost:5002/api/billing-master?billType=' + encodeURIComponent(billType));
      if (res.ok) {
        var result = await res.json();
        console.log("runAutoGenerate: Fetched matrix data from API:", result);
        if (result.success && result.data) {
          savedMatrix = result.data.map(function (row) {
            return {
              memNo: row.memNo || row.MemNo || '',
              amounts: row[billType + '_amounts'] || row.amounts || row.Amounts || {}
            };
          });
        }
      }

      // 2. Fetch active members list
      var memRes = await fetch('http://localhost:5002/api/member');
      if (memRes.ok) {
        var memData = await memRes.json();
        if (memData.success && memData.data) {
          members = memData.data.map(function (m) {
            var w = m.Wing || m.wing || '';
            var f = m.FlatNo || m.flatNo || '';
            var wf = w && f ? w + '-' + f : (f || w || '');
            return {
              code: m.MemCode || m.memCode || '',
              name: m.MemName || m.memName || '',
              wingFlat: wf,
              wing: w,
              flatType: m.FlatType || m.flatType || '2BHK',
              mobile: m.MemMobile || m.memMobile || ''
            };
          });
        }
      }
    } catch (e) {
      console.error("Failed to fetch matrix/members from API, trying localStorage fallback:", e);
      try {
        var savedVal = localStorage.getItem('jeevika_bm_matrix');
        if (savedVal) savedMatrix = JSON.parse(savedVal);
      } catch (ex) { }
    }

    // Normalize savedMatrix to map segregated amounts for the active billType
    if (Array.isArray(savedMatrix)) {
      savedMatrix.forEach(function (row) {
        var typeKey = billType + '_amounts';
        row.amounts = row[typeKey] || row.amounts || row.Amounts || {};
      });
    }

    if (members.length === 0) {
      members = MemberBillMockData.getMembers();
    }

    setTimeout(function () {
      console.log("runAutoGenerate: Active members:", members);

      // Filter members based on range selection
      var filteredMembers = members;
      if (fromVal !== 'All' && toVal !== 'All') {
        var fromIdx = members.findIndex(function (m) { return m.code === fromVal; });
        var toIdx = members.findIndex(function (m) { return m.code === toVal; });
        if (fromIdx > -1 && toIdx > -1) {
          var start = Math.min(fromIdx, toIdx);
          var end = Math.max(fromIdx, toIdx);
          filteredMembers = members.slice(start, end + 1);
        }
      } else if (fromVal !== 'All') {
        var fromIdx = members.findIndex(function (m) { return m.code === fromVal; });
        if (fromIdx > -1) filteredMembers = members.slice(fromIdx);
      } else if (toVal !== 'All') {
        var toIdx = members.findIndex(function (m) { return m.code === toVal; });
        if (toIdx > -1) filteredMembers = members.slice(0, toIdx + 1);
      }

      var newBills = [];
      var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'AUTO' || localStorage.getItem('jeevika_bm_gst_calc') === 'YES';

      var interestCode = 'INC-1008';
      try {
        var accountsVal = localStorage.getItem('jeevika_master_account');
        if (accountsVal) {
          var accounts = JSON.parse(accountsVal);
          if (Array.isArray(accounts)) {
            var match = accounts.find(function (a) {
              var name = (a.accName || a.AccName || '').toLowerCase();
              return name === 'interest from member' || name === 'interest';
            });
            if (!match) {
              match = accounts.find(function (a) {
                var name = (a.accName || a.AccName || '').toLowerCase();
                return name.indexOf('interest') > -1 && name.indexOf('fdr') === -1 && name.indexOf('sb') === -1;
              });
            }
            if (match) interestCode = match.accCode || match.AccCode || 'INC-1008';
          }
        }
      } catch (e) { }
      console.log("runAutoGenerate: Resolved interestCode as:", interestCode);

      // Parse starting bill number and dynamic prefix/sequence from the modal input
      var startBillNo = document.getElementById('ag-start-no').value || 'MBIL/2025-26/1';
      var prefix = "MBIL/2025-26/";
      var lastSlashIdx = startBillNo.lastIndexOf('/');
      if (lastSlashIdx > -1) {
        prefix = startBillNo.substring(0, lastSlashIdx + 1);
      }

      var startNum = 1;
      var numPart = startBillNo.substring(lastSlashIdx + 1);
      if (numPart) {
        startNum = parseInt(numPart) || 1;
      }

      filteredMembers.forEach(function (m, idx) {
        var items = [];
        var principalTotal = 0;
        var interestTotal = 0;

        // Load amounts from matrix adjustments
        var matrixMember = savedMatrix.find(function (x) { return (x.memNo || '').trim().toLowerCase() === m.code.trim().toLowerCase(); });
        console.log("runAutoGenerate: Member:", m.code, "Matrix record:", matrixMember);
        if (matrixMember && matrixMember.amounts) {
          var itemSr = 1;
          Object.keys(matrixMember.amounts).forEach(function (headName) {
            if (headName === 'Interest' || headName === interestCode) return; // Interest handled separately below

            var keyLower = headName.toLowerCase().trim();
            var isAllowed = (allowedCodes.indexOf(headName) > -1) ||
              (allowedHeads.indexOf(headName) > -1) ||
              (allowedHeads.indexOf(keyLower) > -1);
            if (!isAllowed) return; // Skip accounts not configured for this bill type

            var val = parseFloat(matrixMember.amounts[headName]) || 0;
            if (val > 0) {
              var accName = getAccountName(headName);
              items.push({
                sr: itemSr++,
                accountHead: accName,
                particular1: accName + ' for ' + period,
                particular2: period,
                qty: 1,
                rate: val,
                principal: val,
                interest: 0,
                total: val
              });
              principalTotal += val;
            }
          });
        }

        // Fallback default Maintenance charges if no matrix items found
        if (items.length === 0) {
          var maintAmt = 2500;
          items.push({
            sr: 1,
            accountHead: 'Maintenance Charges',
            particular1: particular,
            particular2: period,
            qty: 1,
            rate: maintAmt,
            principal: maintAmt,
            interest: 0,
            total: maintAmt
          });
          principalTotal += maintAmt;
        }

        if (gstEnabled) {
          var cgstAmt = principalTotal * 0.09;
          var sgstAmt = principalTotal * 0.09;
          items.push({
            sr: items.length + 1,
            accountHead: 'CGST',
            particular1: 'CGST @ 9%',
            particular2: '',
            qty: 1,
            rate: cgstAmt,
            principal: cgstAmt,
            interest: 0,
            total: cgstAmt
          });
          items.push({
            sr: items.length + 1,
            accountHead: 'SGST',
            particular1: 'SGST @ 9%',
            particular2: '',
            qty: 1,
            rate: sgstAmt,
            principal: sgstAmt,
            interest: 0,
            total: sgstAmt
          });
          principalTotal += (cgstAmt + sgstAmt);
        }

        // Align interest directly from the matrix
        var interestAmt = 0;
        if (matrixMember && matrixMember.amounts) {
          if (matrixMember.amounts['Interest'] !== undefined) {
            interestAmt = parseFloat(matrixMember.amounts['Interest']) || 0;
          } else if (matrixMember.amounts[interestCode] !== undefined) {
            interestAmt = parseFloat(matrixMember.amounts[interestCode]) || 0;
          }
        }
        console.log("runAutoGenerate: Calculated Interest for:", m.code, "InterestAmt:", interestAmt);

        if (interestAmt > 0) {
          var isInterestAllowed = (allowedCodes.indexOf('INC-1008') > -1) ||
            (allowedHeads.indexOf('penalty / interest') > -1) ||
            (allowedHeads.indexOf('penalty') > -1) ||
            (allowedHeads.indexOf('interest') > -1);
          if (isInterestAllowed) {
            items.push({
              sr: items.length + 1,
              accountHead: 'Penalty / Interest',
              particular1: 'Interest on Arrears',
              particular2: 'From Billing Master',
              qty: 1,
              rate: interestAmt,
              principal: 0,
              interest: interestAmt,
              total: interestAmt
            });
          }
          interestTotal += interestAmt;
        }

        var finalTotal = principalTotal + interestTotal;
        var billNo = prefix + String(startNum + idx).padStart(2, '0');

        newBills.push({
          billNo: billNo,
          billDate: bDate,
          dueDate: dDate,
          period: period,
          billType: billType,
          memberCode: m.code,
          memberName: m.name,
          wingFlat: m.wingFlat,
          wing: m.wing || m.wingFlat.split('-')[0],
          flatType: m.flatType || '1BHK',
          particular: particular,
          mobile: m.mobile,
          items: items,
          principalTotal: principalTotal,
          interestTotal: interestTotal,
          prevBalance: 0,
          arrears: 0,
          adjustment: 0,
          finalTotal: finalTotal,
          status: 'Unpaid'
        });
      });

      console.log("runAutoGenerate: Final generated bills:", newBills);
      MemberBillState.addGeneratedBills(newBills);
      MemberBillRouter.hideLoading();
      JeevikaDialog.alert("Successfully auto-generated " + newBills.length + " bills.", "Auto Generate");
    }, 1500);
  }

  function runMultiDelete() {
    var from = document.getElementById('md-from').value;
    var to = document.getElementById('md-to').value;
    if (!from || !to) { JeevikaDialog.alert("Please specify the range.", "Multi Delete"); return; }

    var all = MemberBillState.getAllBills();
    var toDelete = all.filter(function (b) {
      return b.billNo >= from && b.billNo <= to;
    }).map(function (b) { return b.billNo; });

    if (toDelete.length === 0) {
      JeevikaDialog.alert("No bills found in this range.", "Multi Delete");
      return;
    }

    JeevikaDialog.confirm("Permanently delete " + toDelete.length + " bills?", function () {
      MemberBillRouter.closeModal('mb-modal-multi-delete');
      MemberBillRouter.showLoading('Deleting...');
      setTimeout(function () {
        MemberBillState.deleteBills(toDelete);
        MemberBillRouter.hideLoading();
      }, 500);
    }, "Multi Delete");
  }

  function runMultiChange() {
    var from = document.getElementById('mc-from').value;
    var to = document.getElementById('mc-to').value;
    var field = document.getElementById('mc-field').value;
    var newVal = document.getElementById('mc-value').value;

    if (!from || !to || !newVal) { JeevikaDialog.alert("Please specify the range and new value.", "Multi Change"); return; }

    var all = MemberBillState.getAllBills();
    var toUpdate = all.filter(function (b) {
      return b.billNo >= from && b.billNo <= to;
    }).map(function (b) { return b.billNo; });

    if (toUpdate.length === 0) {
      JeevikaDialog.alert("No bills found in this range.", "Multi Change");
      return;
    }

    JeevikaDialog.confirm("Are you sure you want to update " + toUpdate.length + " bills?", function () {
      MemberBillRouter.closeModal('mb-modal-multi-change');
      MemberBillRouter.showLoading('Updating...');

      setTimeout(function () {
        MemberBillState.updateBillsField(toUpdate, field, newVal);
        MemberBillRouter.hideLoading();
        JeevikaDialog.alert("Updated " + toUpdate.length + " bills successfully.", "Multi Change");
      }, 800);
    }, "Multi Change");
  }

  function executePrintRegister() {
    window.print();
  }

  MemberBillState.subscribe(refresh);

  return {
    refresh: refresh,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters,
    editSelected: editSelected,
    deleteSelected: deleteSelected,
    previewSelected: previewSelected,
    switchBillType: switchBillType,
    renderBillTypePills: renderBillTypePills,

    // Actions
    runAutoGenerate: runAutoGenerate,
    runMultiDelete: runMultiDelete,
    runMultiChange: runMultiChange,
    executePrintRegister: executePrintRegister,
    getActiveBillType: function () { return activeBillTypeFilter; }
  };
})();
