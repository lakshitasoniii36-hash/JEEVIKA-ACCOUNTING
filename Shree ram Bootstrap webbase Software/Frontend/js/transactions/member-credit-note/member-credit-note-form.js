// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberCreditNoteForm = (function () {

  function initForm() {
    populateMembersDropdown();
    
    var cnNo = MemberCreditNoteState.getActiveNote();
    var n = MemberCreditNoteState.getNote(cnNo);

    if (n) {
      document.getElementById('mcn-form-edit-id').value = n.id;
      document.getElementById('mcn-form-cnno').value = n.cnNo;
      document.getElementById('mcn-form-cndate').value = n.cnDate;
      document.getElementById('mcn-form-period').value = n.period || '';
      document.getElementById('mcn-form-duedate').value = n.dueDate || '';
      document.getElementById('mcn-form-membercode').value = n.memberCode;
      document.getElementById('mcn-form-wingflat').value = n.wingFlat || '';
      document.getElementById('mcn-form-part1').value = n.particular1 || '';
      document.getElementById('mcn-form-part2').value = n.particular2 || '';
      document.getElementById('mcn-form-status-badge').innerText = 'Posted';
      document.getElementById('mcn-form-status-badge').className = 'mcn-status-badge mcn-status-posted';

      if(typeof MemberCreditNoteGrid !== 'undefined') MemberCreditNoteGrid.loadItems(n.lineItems || []);
      onMemberSelect();

    } else {
      document.getElementById('mcn-form-edit-id').value = '';
      document.getElementById('mcn-form-cnno').value = MemberCreditNoteMockData.getNextCnNo();
      document.getElementById('mcn-form-cndate').value = new Date().toISOString().split('T')[0];
      document.getElementById('mcn-form-period').value = '';
      document.getElementById('mcn-form-duedate').value = '';
      document.getElementById('mcn-form-membercode').value = '';
      document.getElementById('mcn-form-wingflat').value = '';
      document.getElementById('mcn-form-part1').value = '';
      document.getElementById('mcn-form-part2').value = '';
      document.getElementById('mcn-form-status-badge').innerText = 'Draft';
      document.getElementById('mcn-form-status-badge').className = 'mcn-status-badge mcn-status-draft';

      if(typeof MemberCreditNoteGrid !== 'undefined') MemberCreditNoteGrid.loadItems([]);
      resetBalancePanel();
    }
  }

  function populateMembersDropdown() {
    var sel = document.getElementById('mcn-form-membercode');
    var members = MemberCreditNoteMockData.getMembers();
    sel.innerHTML = '<option value="">— Select Member —</option>';
    members.forEach(function(m) {
      sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
    });
  }

  function onMemberSelect() {
    var code = document.getElementById('mcn-form-membercode').value;
    if(!code) { resetBalancePanel(); return; }

    var m = MemberCreditNoteMockData.getMembers().find(function(x) { return x.code === code; });
    document.getElementById('mcn-form-wingflat').value = m ? m.wingFlat : '';

    // Mock current outstanding
    document.getElementById('mcn-os-before-prin').innerText = '₹5,000.00';
    document.getElementById('mcn-os-before-int').innerText = '₹1,200.00';
    document.getElementById('mcn-os-before-tot').innerText = '₹6,200.00';
    
    updateBalanceSummary();
  }

  function updateBalanceSummary() {
    var gridTotal = 0;
    if(typeof MemberCreditNoteGrid !== 'undefined') gridTotal = MemberCreditNoteGrid.getTotal();

    var prinRed = gridTotal;
    var intRed = 0;

    document.getElementById('mcn-red-prin').innerText = '₹' + prinRed.toFixed(2);
    document.getElementById('mcn-red-int').innerText = '₹' + intRed.toFixed(2);
    document.getElementById('mcn-red-tot').innerText = '₹' + (prinRed + intRed).toFixed(2);

    var curPrin = 5000; var curInt = 1200;
    document.getElementById('mcn-os-after-prin').innerText = '₹' + Math.max(0, curPrin - prinRed).toFixed(2);
    document.getElementById('mcn-os-after-int').innerText = '₹' + Math.max(0, curInt - intRed).toFixed(2);
    document.getElementById('mcn-os-after-tot').innerText = '₹' + Math.max(0, (curPrin + curInt) - (prinRed + intRed)).toFixed(2);
  }

  function resetBalancePanel() {
    ['mcn-os-before-prin','mcn-os-before-int','mcn-os-before-tot','mcn-red-prin','mcn-red-int','mcn-red-tot','mcn-os-after-prin','mcn-os-after-int','mcn-os-after-tot'].forEach(function(id) {
      document.getElementById(id).innerText = '₹0.00';
    });
  }

  function gatherFormData() {
    var code = document.getElementById('mcn-form-membercode').value;
    if(!code) { alert('Please select a member.'); return null; }

    var m = MemberCreditNoteMockData.getMembers().find(function(x) { return x.code === code; });
    var items = (typeof MemberCreditNoteGrid !== 'undefined') ? MemberCreditNoteGrid.getItems() : [];
    var total = (typeof MemberCreditNoteGrid !== 'undefined') ? MemberCreditNoteGrid.getTotal() : 0;

    if(total <= 0) { alert('Total amount must be greater than zero.'); return null; }

    return {
      id: document.getElementById('mcn-form-edit-id').value || null,
      cnNo: document.getElementById('mcn-form-cnno').value,
      cnDate: document.getElementById('mcn-form-cndate').value,
      dueDate: document.getElementById('mcn-form-duedate').value,
      period: document.getElementById('mcn-form-period').value,
      billType: MemberCreditNoteList.getActiveBillType(),
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      principal: total,
      interest: 0,
      total: total,
      particular1: document.getElementById('mcn-form-part1').value,
      particular2: document.getElementById('mcn-form-part2').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function saveNote() {
    var obj = gatherFormData();
    if(obj) {
      MemberCreditNoteState.saveNote(obj);
      MemberCreditNoteRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      MemberCreditNoteState.saveNote(obj);
      MemberCreditNoteRouter.showPreview(obj.cnNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      MemberCreditNoteState.setActiveNote(null);
      initForm();
    }
  }

  function duplicateNote() {
    document.getElementById('mcn-form-edit-id').value = '';
    document.getElementById('mcn-form-cnno').value = MemberCreditNoteMockData.getNextCnNo();
    document.getElementById('mcn-form-status-badge').innerText = 'Draft';
    document.getElementById('mcn-form-status-badge').className = 'mcn-status-badge mcn-status-draft';
    alert('Duplicated. Edit and save as new credit note.');
  }

  return {
    initForm: initForm, onMemberSelect: onMemberSelect, updateBalanceSummary: updateBalanceSummary,
    saveNote: saveNote, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateNote: duplicateNote
  };
})();
