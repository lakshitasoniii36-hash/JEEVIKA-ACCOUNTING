// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: FORM
// ═══════════════════════════════════════════════════════

var MemberBillForm = (function () {

  var currentPrinTot = 0;
  var currentIntTot = 0;
  var specialNotes = ['', ''];
  var currentFormBillType = 'Maintenance';
  var activeFormMembers = [];
  var currentFormParticular = '';

  function ensureFixedAccounts(items) {
    var hasCgst = items.some(function(it) { return it.accountHead === 'CGST'; });
    var hasSgst = items.some(function(it) { return it.accountHead === 'SGST'; });
    var hasInterest = items.some(function(it) { return it.accountHead === 'Penalty / Interest' || it.accountHead === 'Interest'; });

    if (!hasCgst) {
      items.push({
        sr: items.length + 1,
        accountCode: 'LIA-1032',
        accountHead: 'CGST',
        qty: 1,
        rate: 0,
        principal: 0,
        interest: 0,
        total: 0
      });
    }
    if (!hasSgst) {
      items.push({
        sr: items.length + 1,
        accountCode: 'LIA-1033',
        accountHead: 'SGST',
        qty: 1,
        rate: 0,
        principal: 0,
        interest: 0,
        total: 0
      });
    }
    if (!hasInterest) {
      items.push({
        sr: items.length + 1,
        accountCode: 'INC-1008',
        accountHead: 'Penalty / Interest',
        qty: 1,
        rate: 0,
        principal: 0,
        interest: 0,
        total: 0
      });
    }
    items.forEach(function(it, idx) {
      it.sr = idx + 1;
    });
    return items;
  }

  function renderSpecialNotes() {
    var container = document.getElementById('mb-special-notes-container');
    if (!container) return;

    container.innerHTML = '';
    specialNotes.forEach(function (note, idx) {
      var row = document.createElement('div');
      row.style.display = 'flex';
      row.style.gap = '10px';
      row.style.width = '100%';
      row.style.alignItems = 'center';

      var input = document.createElement('input');
      input.type = 'text';
      input.id = 'mb-form-particular' + (idx === 0 ? '' : '2');
      input.style.flex = '1';
      input.style.height = '30px';
      input.style.border = '1px solid #CFD8DC';
      input.style.borderRadius = '4px';
      input.style.padding = '4px 8px';
      input.style.fontSize = '12px';
      input.style.outline = 'none';
      input.placeholder = 'Particulars ' + (idx + 1) + '...';
      input.value = note;
      input.oninput = function () {
        specialNotes[idx] = this.value;
      };

      row.appendChild(input);

      var btn = document.createElement('div');
      btn.id = 'mb-particular' + (idx + 1) + '-shortcut-btn';
      btn.style.width = '100px';
      btn.style.background = '#E0E0E0';
      btn.style.border = '1px solid #BDBDBD';
      btn.style.borderRadius = '4px';
      btn.style.textAlign = 'center';
      btn.style.padding = '4px';
      btn.style.fontSize = '10px';
      btn.style.fontWeight = 'bold';
      btn.style.cursor = 'pointer';
      btn.style.color = '#424242';
      btn.style.userSelect = 'none';
      btn.style.transition = 'background 0.2s';
      btn.style.height = '30px';
      btn.style.lineHeight = '20px';
      btn.style.flexShrink = '0';
      btn.innerText = 'Ctrl + L';
      btn.title = 'Click to repeat last Particular ' + (idx + 1);
      btn.onmouseover = function() { this.style.background = '#D5D5D5'; };
      btn.onmouseout = function() { this.style.background = '#E0E0E0'; };
      btn.onclick = function() {
        if (idx === 0) {
          repeatLastParticular1();
        } else {
          repeatLastParticular2();
        }
      };
      row.appendChild(btn);

      container.appendChild(row);
    });
  }

  function getFallbackHeads(billType) {
    if (billType === 'Maintenance') {
      return [
        { accCode: 'INC-1004', accName: 'Service Charges' },
        { accCode: 'INC-1002', accName: 'Water Charges' },
        { accCode: 'INC-1006', accName: '4-Wheeler Parking Charges' },
        { accCode: 'LIA-1004', accName: 'Sinking Fund' },
        { accCode: 'INC-1005', accName: 'Non Occupancy Charges' },
        { accCode: 'INC-1001', accName: 'Property Tax' }
      ];
    } else if (billType === 'Clubhouse') {
      return [];
    } else if (billType === 'Major Repair') {
      return [
        { accCode: 'LIA-1005', accName: 'Major Repair Fund' }
      ];
    }
    return [];
  }

  function loadBillTypeAccounts(billType, callback) {
    fetch('http://localhost:5002/api/bill-type-master')
      .then(function (res) {
        if (res.ok) return res.json();
        throw new Error('API offline');
      })
      .then(function (data) {
        if (data && data[billType]) {
          callback(data[billType].heads || []);
        } else {
          callback(getFallbackHeads(billType));
        }
      })
      .catch(function (err) {
        console.warn("Error fetching bill types, using localStorage/fallback:", err);
        var saved = localStorage.getItem('jeevika_btm_config');
        if (saved) {
          try {
            var data = JSON.parse(saved);
            if (data && data[billType]) {
              callback(data[billType].heads || []);
              return;
            }
          } catch (e) { }
        }
        callback(getFallbackHeads(billType));
      });
  }

  function initForm(billType) {
    populateMembersDropdown(function () {
      var bNo = MemberBillState.getActiveBill();
      var b = MemberBillState.getBill(bNo);

      if (b) {
        currentFormBillType = b.billType || 'Maintenance';
        currentFormParticular = b.particular || '';
        document.getElementById('mb-form-title').innerHTML = '<i class="bi bi-pencil-square" style="color:#1565C0;margin-right:6px;"></i>Edit Bill: ' + b.billNo;
        document.getElementById('mb-form-edit-billno').value = b.billNo;
        document.getElementById('mb-form-billno').value = b.billNo;
        document.getElementById('mb-form-billdate').value = b.billDate;
        document.getElementById('mb-form-duedate').value = b.dueDate;
        document.getElementById('mb-form-period').value = b.period;

        document.getElementById('mb-form-membercode').value = b.memberCode;
        document.getElementById('mb-form-membername').value = b.memberName;
        document.getElementById('mb-form-wingflat').value = b.wingFlat;

        document.getElementById('mb-form-prevbal').value = b.prevBalance || 0;
        document.getElementById('mb-form-arrears').value = b.arrears || 0;
        document.getElementById('mb-form-adjustment').value = b.adjustment || 0;

        if (b.specialNotes && Array.isArray(b.specialNotes)) {
          specialNotes = b.specialNotes.slice();
        } else {
          var legacyNote = b.specialNote || b.particular || '';
          specialNotes = legacyNote ? [legacyNote] : [];
        }
        while (specialNotes.length < 2) specialNotes.push('');
        specialNotes = specialNotes.slice(0, 2);
        renderSpecialNotes();

        if (!b.items || b.items.length === 0) {
          loadBillTypeAccounts(currentFormBillType, function (heads) {
            var savedMatrix = [];
            try { savedMatrix = JSON.parse(localStorage.getItem('jeevika_bm_matrix') || '[]'); } catch (e) { }
            var matrixMember = savedMatrix.find(function (x) {
              return (x.memNo || '').trim().toLowerCase() === b.memberCode.trim().toLowerCase();
            });
            var typeKey = currentFormBillType + '_amounts';
            var memberAmounts = matrixMember ? (matrixMember[typeKey] || matrixMember.amounts || {}) : {};

            var items = heads
              .filter(function (h) {
                return h.accCode && h.accName && h.accName !== 'Interest' && h.accName !== 'CGST' && h.accName !== 'SGST' && h.accName !== 'Penalty / Interest';
              })
              .map(function (h, idx) {
                var amt = parseFloat(memberAmounts[h.accName]) || 0;
                return {
                  sr: idx + 1,
                  accountCode: h.accCode,
                  accountHead: h.accName,
                  qty: 1,
                  rate: amt,
                  principal: amt,
                  interest: 0,
                  total: amt
                };
              });

            var subtotal = items.reduce(function (acc, it) { return acc + it.total; }, 0);
            
            // 1. CGST
            var cgstVal = parseFloat(memberAmounts['CGST']) || parseFloat(memberAmounts['CGST 9%']) || 0;
            if (cgstVal === 0) {
              var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'AUTO' || localStorage.getItem('jeevika_bm_gst_calc') === 'YES';
              if (gstEnabled) cgstVal = subtotal * 0.09;
            }
            items.push({
              sr: items.length + 1,
              accountCode: 'LIA-1032',
              accountHead: 'CGST',
              qty: 1,
              rate: cgstVal,
              principal: cgstVal,
              interest: 0,
              total: cgstVal
            });

            // 2. SGST
            var sgstVal = parseFloat(memberAmounts['SGST']) || parseFloat(memberAmounts['SGST 9%']) || 0;
            if (sgstVal === 0) {
              var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'AUTO' || localStorage.getItem('jeevika_bm_gst_calc') === 'YES';
              if (gstEnabled) sgstVal = subtotal * 0.09;
            }
            items.push({
              sr: items.length + 1,
              accountCode: 'LIA-1033',
              accountHead: 'SGST',
              qty: 1,
              rate: sgstVal,
              principal: sgstVal,
              interest: 0,
              total: sgstVal
            });

            // 3. Interest
            var interestVal = parseFloat(memberAmounts['Interest']) || parseFloat(memberAmounts['Penalty / Interest']) || 0;
            items.push({
              sr: items.length + 1,
              accountCode: 'INC-1008',
              accountHead: 'Penalty / Interest',
              qty: 1,
              rate: interestVal,
              principal: 0,
              interest: interestVal,
              total: interestVal
            });

            MemberBillGrid.loadItems(items);
            calculateTotals();
          });
        } else {
          var loadedItems = b.items || [];
          loadedItems = ensureFixedAccounts(loadedItems);
          MemberBillGrid.loadItems(loadedItems);
          calculateTotals();
        }
        if (typeof MemberBillRouter !== 'undefined' && MemberBillRouter.updateWorkspaceTitleAndTab) {
          MemberBillRouter.updateWorkspaceTitleAndTab(currentFormBillType);
        }
      } else {
        currentFormBillType = billType || MemberBillList.getActiveBillType() || 'Maintenance';
        if (currentFormBillType === 'All') currentFormBillType = 'Maintenance';
        currentFormParticular = '';

        document.getElementById('mb-form-title').innerHTML = '<i class="bi bi-plus-circle" style="color:#1565C0;margin-right:6px;"></i>Bill / Invoice Generation [' + currentFormBillType + ']';
        document.getElementById('mb-form-edit-billno').value = '';
        document.getElementById('mb-form-billno').value = 'Loading...';
        fetch('http://localhost:5002/api/member-bills/next-no')
          .then(function (res) { return res.json(); })
          .then(function (res) {
            if (res.success) {
              document.getElementById('mb-form-billno').value = res.voucherNo;
            } else {
              document.getElementById('mb-form-billno').value = MemberBillMockData.getNextBillNo();
            }
          })
          .catch(function (err) {
            console.error(err);
            document.getElementById('mb-form-billno').value = MemberBillMockData.getNextBillNo();
          });

        var today = new Date().toISOString().split('T')[0];
        var due = new Date(); due.setDate(due.getDate() + 15);

        document.getElementById('mb-form-billdate').value = today;
        document.getElementById('mb-form-duedate').value = due.toISOString().split('T')[0];
        document.getElementById('mb-form-period').value = 'May 2025';

        document.getElementById('mb-form-membercode').value = '';
        document.getElementById('mb-form-membername').value = '';
        document.getElementById('mb-form-wingflat').value = '';

        document.getElementById('mb-form-prevbal').value = '0';
        document.getElementById('mb-form-arrears').value = '0';
        document.getElementById('mb-form-adjustment').value = '0';

        specialNotes = ['', ''];
        renderSpecialNotes();

        loadBillTypeAccounts(currentFormBillType, function (heads) {
          var items = heads
            .filter(function (h) {
              return h.accCode && h.accName && h.accName !== 'Interest' && h.accName !== 'CGST' && h.accName !== 'SGST' && h.accName !== 'Penalty / Interest';
            })
            .map(function (h, idx) {
              return {
                sr: idx + 1,
                accountCode: h.accCode,
                accountHead: h.accName,
                qty: 1,
                rate: 0,
                principal: 0,
                interest: 0,
                total: 0
              };
            });

          items.push({
            sr: items.length + 1,
            accountCode: 'LIA-1032',
            accountHead: 'CGST',
            qty: 1,
            rate: 0,
            principal: 0,
            interest: 0,
            total: 0
          });
          items.push({
            sr: items.length + 1,
            accountCode: 'LIA-1033',
            accountHead: 'SGST',
            qty: 1,
            rate: 0,
            principal: 0,
            interest: 0,
            total: 0
          });
          items.push({
            sr: items.length + 1,
            accountCode: 'INC-1008',
            accountHead: 'Penalty / Interest',
            qty: 1,
            rate: 0,
            principal: 0,
            interest: 0,
            total: 0
          });

          MemberBillGrid.loadItems(items);
          if (typeof MemberBillRouter !== 'undefined' && MemberBillRouter.updateWorkspaceTitleAndTab) {
            MemberBillRouter.updateWorkspaceTitleAndTab(currentFormBillType);
          }
          calculateTotals();
        });
      }
    });
  }

  function populateMembersDropdown(callback) {
    var codeSel = document.getElementById('mb-form-membercode');
    var nameSel = document.getElementById('mb-form-membername');
    
    if (codeSel) codeSel.innerHTML = '<option value="">Select Code</option>';
    if (nameSel) nameSel.innerHTML = '<option value="">— Select Name —</option>';

    fetch('http://localhost:5002/api/member')
      .then(function (r) { return r.json(); })
      .then(function (d) {
        activeFormMembers = [];
        if (d.success && d.data) {
          activeFormMembers = d.data.map(function (m) {
            var w = m.Wing || m.wing || '';
            var f = m.FlatNo || m.flatNo || '';
            var wf = w && f ? w + '-' + f : (f || w || '');
            return {
              code: m.MemCode || m.memCode || '',
              name: m.MemName || m.memName || '',
              wingFlat: wf
            };
          });
        }
        if (activeFormMembers.length === 0 && typeof MemberBillMockData !== 'undefined') {
          activeFormMembers = MemberBillMockData.getMembers();
        }

        if (codeSel) {
          activeFormMembers.forEach(function (m) {
            codeSel.innerHTML += '<option value="' + m.code + '">' + m.code + '</option>';
          });
        }
        if (nameSel) {
          activeFormMembers.forEach(function (m) {
            nameSel.innerHTML += '<option value="' + m.code + '">' + m.name + ' (' + m.wingFlat + ')</option>';
          });
        }

        if (callback) callback();
      })
      .catch(function (e) {
        console.error("Failed to fetch live members for form dropdown:", e);
        if (typeof MemberBillMockData !== 'undefined') {
          activeFormMembers = MemberBillMockData.getMembers();
        }
        if (codeSel) {
          activeFormMembers.forEach(function (m) {
            codeSel.innerHTML += '<option value="' + m.code + '">' + m.code + '</option>';
          });
        }
        if (nameSel) {
          activeFormMembers.forEach(function (m) {
            nameSel.innerHTML += '<option value="' + m.code + '">' + m.name + ' (' + m.wingFlat + ')</option>';
          });
        }
        if (callback) callback();
      });
  }

  function onMemberCodeSelect() {
    var code = document.getElementById('mb-form-membercode').value;
    var nameSel = document.getElementById('mb-form-membername');
    if (nameSel) nameSel.value = code;
    onMemberChanged(code);
  }

  function onMemberNameSelect() {
    var code = document.getElementById('mb-form-membername').value;
    var codeSel = document.getElementById('mb-form-membercode');
    if (codeSel) codeSel.value = code;
    onMemberChanged(code);
  }

  function onMemberSelect() {
    var code = document.getElementById('mb-form-membercode').value;
    onMemberChanged(code);
  }

  function onMemberChanged(code) {
    var m = activeFormMembers.find(function (x) { return x.code === code; });
    var wingFlatEl = document.getElementById('mb-form-wingflat');
    if (wingFlatEl) {
      wingFlatEl.value = m ? m.wingFlat : '';
    }

    if (m) {
      // Load matrix amounts for the selected member
      loadBillTypeAccounts(currentFormBillType, function (heads) {
        var savedMatrix = [];
        try { savedMatrix = JSON.parse(localStorage.getItem('jeevika_bm_matrix') || '[]'); } catch (e) { }
        var matrixMember = savedMatrix.find(function (x) {
          return (x.memNo || '').trim().toLowerCase() === code.trim().toLowerCase();
        });
        var typeKey = currentFormBillType + '_amounts';
        var memberAmounts = matrixMember ? (matrixMember[typeKey] || matrixMember.amounts || {}) : {};

        var items = heads
          .filter(function (h) {
            return h.accCode && h.accName && h.accName !== 'Interest' && h.accName !== 'CGST' && h.accName !== 'SGST' && h.accName !== 'Penalty / Interest';
          })
          .map(function (h, idx) {
            var amt = parseFloat(memberAmounts[h.accName]) || 0;
            return {
              sr: idx + 1,
              accountCode: h.accCode,
              accountHead: h.accName,
              qty: 1,
              rate: amt,
              principal: amt,
              interest: 0,
              total: amt
            };
          });

        var subtotal = items.reduce(function (acc, it) { return acc + it.total; }, 0);
        
        // 1. CGST
        var cgstVal = parseFloat(memberAmounts['CGST']) || parseFloat(memberAmounts['CGST 9%']) || 0;
        if (cgstVal === 0) {
          var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'AUTO' || localStorage.getItem('jeevika_bm_gst_calc') === 'YES';
          if (gstEnabled) cgstVal = subtotal * 0.09;
        }
        items.push({
          sr: items.length + 1,
          accountCode: 'LIA-1032',
          accountHead: 'CGST',
          qty: 1,
          rate: cgstVal,
          principal: cgstVal,
          interest: 0,
          total: cgstVal
        });

        // 2. SGST
        var sgstVal = parseFloat(memberAmounts['SGST']) || parseFloat(memberAmounts['SGST 9%']) || 0;
        if (sgstVal === 0) {
          var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'AUTO' || localStorage.getItem('jeevika_bm_gst_calc') === 'YES';
          if (gstEnabled) sgstVal = subtotal * 0.09;
        }
        items.push({
          sr: items.length + 1,
          accountCode: 'LIA-1033',
          accountHead: 'SGST',
          qty: 1,
          rate: sgstVal,
          principal: sgstVal,
          interest: 0,
          total: sgstVal
        });

        // 3. Interest
        var interestVal = parseFloat(memberAmounts['Interest']) || parseFloat(memberAmounts['Penalty / Interest']) || 0;
        items.push({
          sr: items.length + 1,
          accountCode: 'INC-1008',
          accountHead: 'Penalty / Interest',
          qty: 1,
          rate: interestVal,
          principal: 0,
          interest: interestVal,
          total: interestVal
        });

        MemberBillGrid.loadItems(items);
        calculateTotals();
      });

    } else {
      // Reset items to 0
      loadBillTypeAccounts(currentFormBillType, function (heads) {
        var items = heads
          .filter(function (h) {
            return h.accCode && h.accName && h.accName !== 'Interest' && h.accName !== 'CGST' && h.accName !== 'SGST' && h.accName !== 'Penalty / Interest';
          })
          .map(function (h, idx) {
            return {
              sr: idx + 1,
              accountCode: h.accCode,
              accountHead: h.accName,
              qty: 1,
              rate: 0,
              principal: 0,
              interest: 0,
              total: 0
            };
          });

        items.push({
          sr: items.length + 1,
          accountCode: 'LIA-1032',
          accountHead: 'CGST',
          qty: 1,
          rate: 0,
          principal: 0,
          interest: 0,
          total: 0
        });
        items.push({
          sr: items.length + 1,
          accountCode: 'LIA-1033',
          accountHead: 'SGST',
          qty: 1,
          rate: 0,
          principal: 0,
          interest: 0,
          total: 0
        });
        items.push({
          sr: items.length + 1,
          accountCode: 'INC-1008',
          accountHead: 'Penalty / Interest',
          qty: 1,
          rate: 0,
          principal: 0,
          interest: 0,
          total: 0
        });

        MemberBillGrid.loadItems(items);
        calculateTotals();
      });
    }
  }

  function updateGridTotals(prin, int) {
    currentPrinTot = prin;
    currentIntTot = int;
    calculateTotals();
  }

  function calculateTotals() {
    var prevBalInput = document.getElementById('mb-form-prevbal');
    var arrearsInput = document.getElementById('mb-form-arrears');
    var adjInput = document.getElementById('mb-form-adjustment');

    var prevBal = prevBalInput ? (parseFloat(prevBalInput.value) || 0) : 0;
    var arrears = arrearsInput ? (parseFloat(arrearsInput.value) || 0) : 0;
    var adjustment = adjInput ? (parseFloat(adjInput.value) || 0) : 0;

    var finalTotal = currentPrinTot + currentIntTot + prevBal + arrears - adjustment;

    var prinEl = document.getElementById('mb-summary-principal');
    if (prinEl) prinEl.innerText = '₹' + currentPrinTot.toFixed(2);
    var intEl = document.getElementById('mb-summary-interest');
    if (intEl) intEl.innerText = '₹' + currentIntTot.toFixed(2);
    var finalEl = document.getElementById('mb-summary-final');
    if (finalEl) finalEl.innerText = '₹' + finalTotal.toFixed(2);
  }

  function gatherFormData() {
    MemberBillGrid.saveRow(); // Ensure active edit is saved
    var items = MemberBillGrid.getItems();

    if (items.length === 0) { alert('Please add at least one bill item.'); return null; }
    var code = document.getElementById('mb-form-membercode').value;
    if (!code) { alert('Please select a member.'); return null; }

    var prevBalInput = document.getElementById('mb-form-prevbal');
    var arrearsInput = document.getElementById('mb-form-arrears');
    var adjInput = document.getElementById('mb-form-adjustment');

    var prevBal = prevBalInput ? (parseFloat(prevBalInput.value) || 0) : 0;
    var arrears = arrearsInput ? (parseFloat(arrearsInput.value) || 0) : 0;
    var adjustment = adjInput ? (parseFloat(adjInput.value) || 0) : 0;
    var finalTotal = currentPrinTot + currentIntTot + prevBal + arrears - adjustment;

    var m = activeFormMembers.find(function (x) { return x.code === code; });
    var wing = m ? (m.wing || (m.wingFlat ? m.wingFlat.split('-')[0] : '')) : '';
    var flatType = m ? (m.flatType || '1BHK') : '';

    var filteredNotes = specialNotes.map(function (n) { return n.trim(); }).filter(function (n) { return n.length > 0; });
    var specialNoteJoined = filteredNotes.join(' | ');

    return {
      id: document.getElementById('mb-form-edit-billno').value ? undefined : null, // will be set in state if null
      billNo: document.getElementById('mb-form-billno').value,
      billDate: document.getElementById('mb-form-billdate').value,
      dueDate: document.getElementById('mb-form-duedate').value,
      period: document.getElementById('mb-form-period').value,
      billType: currentFormBillType,
      memberCode: code,
      memberName: document.getElementById('mb-form-membername').value,
      wingFlat: document.getElementById('mb-form-wingflat').value,
      wing: wing,
      flatType: flatType,
      particular: currentFormParticular || filteredNotes[0] || '',
      specialNote: specialNoteJoined,
      specialNotes: filteredNotes,
      mobile: '', // mock

      items: items,

      principalTotal: currentPrinTot,
      interestTotal: currentIntTot,
      prevBalance: prevBal,
      arrears: arrears,
      adjustment: adjustment,
      finalTotal: finalTotal,

      status: 'Unpaid'
    };
  }

  async function saveBill() {
    var obj = gatherFormData();
    if (obj) {
      if (document.getElementById('mb-form-edit-billno').value) {
        // Find existing ID to preserve it
        var ex = MemberBillState.getBill(obj.billNo);
        if (ex) obj.id = ex.id;
      }
      await MemberBillState.saveBill(obj);
      MemberBillRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if (obj) {
      if (document.getElementById('mb-form-edit-billno').value) {
        var ex = MemberBillState.getBill(obj.billNo);
        if (ex) obj.id = ex.id;
      }
      await MemberBillState.saveBill(obj);
      MemberBillRouter.showPreview(obj.billNo);
    }
  }

  // Dynamic notes are updated directly in the specialNotes array via oninput handlers.

  function cancelForm() {
    MemberBillRouter.showList();
  }

  function clearForm() {
    if (confirm("Are you sure you want to clear the form?")) {
      initForm();
    }
  }

  function printBill() {
    window.print();
  }

  function repeatLastParticular1() {
    var code = document.getElementById('mb-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var bills = MemberBillState.getBills() || [];
    var currentNo = document.getElementById('mb-form-billno').value;

    var memberBills = bills.filter(function(b) {
      return b.memberCode === code && b.billNo !== currentNo && b.particular;
    });

    if (memberBills.length > 0) {
      memberBills.sort(function(a, b) {
        return new Date(b.billDate) - new Date(a.billDate);
      });
      var lastVal = memberBills[0].particular;
      specialNotes[0] = lastVal;
      var el = document.getElementById('mb-form-particular');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 1 found for this member.");
    }
  }

  function repeatLastParticular2() {
    var code = document.getElementById('mb-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var bills = MemberBillState.getBills() || [];
    var currentNo = document.getElementById('mb-form-billno').value;

    var memberBills = bills.filter(function(b) {
      return b.memberCode === code && b.billNo !== currentNo && b.specialNotes && b.specialNotes[1];
    });

    if (memberBills.length > 0) {
      memberBills.sort(function(a, b) {
        return new Date(b.billDate) - new Date(a.billDate);
      });
      var lastVal = memberBills[0].specialNotes[1];
      specialNotes[1] = lastVal;
      var el = document.getElementById('mb-form-particular2');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 2 found for this member.");
    }
  }

  return {
    initForm: initForm,
    onMemberSelect: onMemberSelect,
    onMemberCodeSelect: onMemberCodeSelect,
    onMemberNameSelect: onMemberNameSelect,
    updateGridTotals: updateGridTotals,
    calculateTotals: calculateTotals,
    saveBill: saveBill,
    saveAndPreview: saveAndPreview,
    cancelForm: cancelForm,
    clearForm: clearForm,
    printBill: printBill,
    repeatLastParticular1: repeatLastParticular1,
    repeatLastParticular2: repeatLastParticular2
  };
})();
