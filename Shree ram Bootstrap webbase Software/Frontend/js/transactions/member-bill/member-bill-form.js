// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: FORM
// ═══════════════════════════════════════════════════════

var MemberBillForm = (function () {

  var currentPrinTot = 0;
  var currentIntTot = 0;
  var specialNotes = [''];
  var currentFormBillType = 'Maintenance';
  var activeFormMembers = [];

  function renderSpecialNotes() {
    var container = document.getElementById('mb-special-notes-container');
    if (!container) return;

    container.innerHTML = '';
    specialNotes.forEach(function (note, idx) {
      var row = document.createElement('div');
      row.style.display = 'flex';
      row.style.gap = '8px';
      row.style.width = '100%';
      row.style.alignItems = 'center';

      var input = document.createElement('input');
      input.type = 'text';
      input.style.flex = '1';
      input.style.height = '30px';
      input.style.border = '1px solid #CFD8DC';
      input.style.borderRadius = '4px';
      input.style.padding = '4px 8px';
      input.style.fontSize = '12px';
      input.style.outline = 'none';
      input.placeholder = 'Enter special note...';
      input.value = note;
      input.oninput = function () {
        specialNotes[idx] = this.value;
      };

      row.appendChild(input);

      if (idx === 0) {
        var addBtn = document.createElement('button');
        addBtn.type = 'button';
        addBtn.className = 'mb-action-btn mb-action-primary';
        addBtn.style.whiteSpace = 'nowrap';
        addBtn.style.padding = '0 16px';
        addBtn.style.height = '30px';
        addBtn.style.display = 'flex';
        addBtn.style.alignItems = 'center';
        addBtn.style.gap = '4px';
        addBtn.innerHTML = '<i class="bi bi-plus-lg"></i> Add';
        addBtn.onclick = function () {
          addSpecialNoteRow();
        };
        row.appendChild(addBtn);
      } else {
        var deleteBtn = document.createElement('button');
        deleteBtn.type = 'button';
        deleteBtn.className = 'mb-action-btn mb-action-danger';
        deleteBtn.style.whiteSpace = 'nowrap';
        deleteBtn.style.padding = '0 12px';
        deleteBtn.style.height = '30px';
        deleteBtn.style.display = 'flex';
        deleteBtn.style.alignItems = 'center';
        deleteBtn.style.justifyContent = 'center';
        deleteBtn.innerHTML = '<i class="bi bi-trash"></i>';
        deleteBtn.onclick = function () {
          removeSpecialNoteRow(idx);
        };
        row.appendChild(deleteBtn);
      }

      container.appendChild(row);
    });
  }

  function addSpecialNoteRow() {
    specialNotes.push('');
    renderSpecialNotes();
    var container = document.getElementById('mb-special-notes-container');
    if (container && container.lastChild) {
      var input = container.lastChild.querySelector('input');
      if (input) input.focus();
    }
  }

  function removeSpecialNoteRow(idx) {
    if (idx > 0) {
      specialNotes.splice(idx, 1);
      renderSpecialNotes();
    }
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
          specialNotes = legacyNote ? [legacyNote] : [''];
        }
        if (specialNotes.length === 0) specialNotes = [''];
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
                return h.accCode && h.accName && h.accName !== 'Interest' && h.accName !== 'CGST' && h.accName !== 'SGST';
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
            var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'AUTO' || localStorage.getItem('jeevika_bm_gst_calc') === 'YES';
            if (gstEnabled) {
              var cgst = subtotal * 0.09;
              var sgst = subtotal * 0.09;
              items.push({
                sr: items.length + 1,
                accountCode: 'LIA-1032',
                accountHead: 'CGST',
                qty: 1,
                rate: cgst,
                principal: cgst,
                interest: 0,
                total: cgst
              });
              items.push({
                sr: items.length + 1,
                accountCode: 'LIA-1033',
                accountHead: 'SGST',
                qty: 1,
                rate: sgst,
                principal: sgst,
                interest: 0,
                total: sgst
              });
            }

            var interestVal = parseFloat(memberAmounts['Interest']) || parseFloat(memberAmounts['Penalty / Interest']) || 0;
            if (interestVal > 0) {
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
            }

            MemberBillGrid.loadItems(items);
            calculateTotals();
          });
        } else {
          MemberBillGrid.loadItems(b.items);
          calculateTotals();
        }
        if (typeof MemberBillRouter !== 'undefined' && MemberBillRouter.updateWorkspaceTitleAndTab) {
          MemberBillRouter.updateWorkspaceTitleAndTab(currentFormBillType);
        }
      } else {
        currentFormBillType = billType || MemberBillList.getActiveBillType() || 'Maintenance';
        if (currentFormBillType === 'All') currentFormBillType = 'Maintenance';

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

        specialNotes = [''];
        renderSpecialNotes();

        loadBillTypeAccounts(currentFormBillType, function (heads) {
          var items = heads
            .filter(function (h) {
              return h.accCode && h.accName && h.accName !== 'Interest' && h.accName !== 'CGST' && h.accName !== 'SGST';
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
    var sel = document.getElementById('mb-form-membercode');
    if (!sel) {
      if (callback) callback();
      return;
    }
    sel.innerHTML = '<option value="">— Select Member —</option>';

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

        sel.innerHTML = '<option value="">— Select Member —</option>';
        activeFormMembers.forEach(function (m) {
          sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
        });

        if (callback) callback();
      })
      .catch(function (e) {
        console.error("Failed to fetch live members for form dropdown:", e);
        if (typeof MemberBillMockData !== 'undefined') {
          activeFormMembers = MemberBillMockData.getMembers();
          activeFormMembers.forEach(function (m) {
            sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
          });
        }
        if (callback) callback();
      });
  }

  function onMemberSelect() {
    var code = document.getElementById('mb-form-membercode').value;
    var m = activeFormMembers.find(function (x) { return x.code === code; });
    if (m) {
      document.getElementById('mb-form-membername').value = m.name;
      document.getElementById('mb-form-wingflat').value = m.wingFlat;
    } else {
      document.getElementById('mb-form-membername').value = '';
      document.getElementById('mb-form-wingflat').value = '';
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
      particular: filteredNotes[0] || '',
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

  return {
    initForm: initForm,
    onMemberSelect: onMemberSelect,
    updateGridTotals: updateGridTotals,
    calculateTotals: calculateTotals,
    saveBill: saveBill,
    saveAndPreview: saveAndPreview,
    cancelForm: cancelForm,
    clearForm: clearForm,
    printBill: printBill,
    addSpecialNoteRow: addSpecialNoteRow,
    removeSpecialNoteRow: removeSpecialNoteRow
  };
})();
