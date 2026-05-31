// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: FORM
// ═══════════════════════════════════════════════════════

var MemberBillForm = (function () {

  var currentPrinTot = 0;
  var currentIntTot = 0;
  var specialNotes = [''];

  function renderSpecialNotes() {
    var container = document.getElementById('mb-special-notes-container');
    if (!container) return;
    
    container.innerHTML = '';
    specialNotes.forEach(function(note, idx) {
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
      input.oninput = function() {
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
        addBtn.onclick = function() {
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
        deleteBtn.onclick = function() {
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

  function initForm() {
    populateMembersDropdown();
    
    var bNo = MemberBillState.getActiveBill();
    var b = MemberBillState.getBill(bNo);

    if (b) {
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
      
      MemberBillGrid.loadItems(b.items);
    } else {
      document.getElementById('mb-form-title').innerHTML = '<i class="bi bi-plus-circle" style="color:#1565C0;margin-right:6px;"></i>New Bill';
      document.getElementById('mb-form-edit-billno').value = '';
      document.getElementById('mb-form-billno').value = MemberBillMockData.getNextBillNo();
      
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
      
      MemberBillGrid.loadItems([]);
    }
    calculateTotals();
  }

  function populateMembersDropdown() {
    var sel = document.getElementById('mb-form-membercode');
    var members = MemberBillMockData.getMembers();
    sel.innerHTML = '<option value="">— Select Member —</option>';
    members.forEach(function(m) {
      sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
    });
  }

  function onMemberSelect() {
    var code = document.getElementById('mb-form-membercode').value;
    var m = MemberBillMockData.getMembers().find(function(x) { return x.code === code; });
    if(m) {
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
    var prevBal = parseFloat(document.getElementById('mb-form-prevbal').value) || 0;
    var arrears = parseFloat(document.getElementById('mb-form-arrears').value) || 0;
    var adjustment = parseFloat(document.getElementById('mb-form-adjustment').value) || 0;

    var finalTotal = currentPrinTot + currentIntTot + prevBal + arrears - adjustment;

    document.getElementById('mb-summary-principal').innerText = '₹' + currentPrinTot.toFixed(2);
    document.getElementById('mb-summary-interest').innerText = '₹' + currentIntTot.toFixed(2);
    document.getElementById('mb-summary-final').innerText = '₹' + finalTotal.toFixed(2);
  }

  function gatherFormData() {
    MemberBillGrid.saveRow(); // Ensure active edit is saved
    var items = MemberBillGrid.getItems();
    
    if(items.length === 0) { alert('Please add at least one bill item.'); return null; }
    var code = document.getElementById('mb-form-membercode').value;
    if(!code) { alert('Please select a member.'); return null; }

    var prevBal = parseFloat(document.getElementById('mb-form-prevbal').value) || 0;
    var arrears = parseFloat(document.getElementById('mb-form-arrears').value) || 0;
    var adjustment = parseFloat(document.getElementById('mb-form-adjustment').value) || 0;
    var finalTotal = currentPrinTot + currentIntTot + prevBal + arrears - adjustment;

    var m = MemberBillMockData.getMembers().find(function(x) { return x.code === code; });
    var wing = m ? (m.wing || m.wingFlat.split('-')[0]) : '';
    var flatType = m ? (m.flatType || '1BHK') : '';
    
    var filteredNotes = specialNotes.map(function(n) { return n.trim(); }).filter(function(n) { return n.length > 0; });
    var specialNoteJoined = filteredNotes.join(' | ');

    return {
      id: document.getElementById('mb-form-edit-billno').value ? undefined : null, // will be set in state if null
      billNo: document.getElementById('mb-form-billno').value,
      billDate: document.getElementById('mb-form-billdate').value,
      dueDate: document.getElementById('mb-form-duedate').value,
      period: document.getElementById('mb-form-period').value,
      billType: MemberBillList.getActiveBillType(),
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

  function saveBill() {
    var obj = gatherFormData();
    if(obj) {
      if(document.getElementById('mb-form-edit-billno').value) {
        // Find existing ID to preserve it
        var ex = MemberBillState.getBill(obj.billNo);
        if(ex) obj.id = ex.id;
      }
      MemberBillState.saveBill(obj);
      MemberBillRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      if(document.getElementById('mb-form-edit-billno').value) {
        var ex = MemberBillState.getBill(obj.billNo);
        if(ex) obj.id = ex.id;
      }
      MemberBillState.saveBill(obj);
      MemberBillRouter.showPreview(obj.billNo);
    }
  }

  // Dynamic notes are updated directly in the specialNotes array via oninput handlers.

  function cancelForm() {
    MemberBillRouter.showList();
  }

  function clearForm() {
    if(confirm("Are you sure you want to clear the form?")) {
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
