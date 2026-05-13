// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberDebitNoteForm = (function () {

  function initForm() {
    populateMembersDropdown();
    
    var dnNo = MemberDebitNoteState.getActiveNote();
    var n = MemberDebitNoteState.getNote(dnNo);

    if (n) {
      document.getElementById('mdn-form-edit-id').value = n.id;
      document.getElementById('mdn-form-dnno').value = n.dnNo;
      document.getElementById('mdn-form-dndate').value = n.dnDate;
      document.getElementById('mdn-form-period').value = n.period || '';
      document.getElementById('mdn-form-duedate').value = n.dueDate || '';
      document.getElementById('mdn-form-membercode').value = n.memberCode;
      document.getElementById('mdn-form-wingflat').value = n.wingFlat || '';
      document.getElementById('mdn-form-part1').value = n.particular1 || '';
      document.getElementById('mdn-form-part2').value = n.particular2 || '';
      document.getElementById('mdn-form-status-badge').innerText = 'Posted';
      document.getElementById('mdn-form-status-badge').className = 'mdn-status-badge mdn-status-posted';

      if(typeof MemberDebitNoteGrid !== 'undefined') MemberDebitNoteGrid.loadItems(n.lineItems || []);
      onMemberSelect();

    } else {
      document.getElementById('mdn-form-edit-id').value = '';
      document.getElementById('mdn-form-dnno').value = MemberDebitNoteMockData.getNextDnNo();
      document.getElementById('mdn-form-dndate').value = new Date().toISOString().split('T')[0];
      document.getElementById('mdn-form-period').value = '';
      document.getElementById('mdn-form-duedate').value = '';
      document.getElementById('mdn-form-membercode').value = '';
      document.getElementById('mdn-form-wingflat').value = '';
      document.getElementById('mdn-form-part1').value = '';
      document.getElementById('mdn-form-part2').value = '';
      document.getElementById('mdn-form-status-badge').innerText = 'Draft';
      document.getElementById('mdn-form-status-badge').className = 'mdn-status-badge mdn-status-draft';

      if(typeof MemberDebitNoteGrid !== 'undefined') MemberDebitNoteGrid.loadItems([{ sr: 1, account: '', amount: 0 }]);
      resetBalancePanel();
    }
  }

  function populateMembersDropdown() {
    var sel = document.getElementById('mdn-form-membercode');
    var members = MemberDebitNoteMockData.getMembers();
    sel.innerHTML = '<option value="">— Select Member —</option>';
    members.forEach(function(m) {
      sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
    });
  }

  function onMemberSelect() {
    var code = document.getElementById('mdn-form-membercode').value;
    if(!code) { resetBalancePanel(); return; }

    var m = MemberDebitNoteMockData.getMembers().find(function(x) { return x.code === code; });
    document.getElementById('mdn-form-wingflat').value = m ? m.wingFlat : '';

    // Mock current outstanding
    document.getElementById('mdn-os-before-prin').innerText = '₹5,000.00';
    document.getElementById('mdn-os-before-int').innerText = '₹1,200.00';
    document.getElementById('mdn-os-before-tot').innerText = '₹6,200.00';
    
    updateBalanceSummary();
  }

  function updateBalanceSummary() {
    var gridTotal = 0;
    if(typeof MemberDebitNoteGrid !== 'undefined') gridTotal = MemberDebitNoteGrid.getTotal();

    var prinAdd = gridTotal;
    var intAdd = 0;

    document.getElementById('mdn-add-prin').innerText = '₹' + prinAdd.toFixed(2);
    document.getElementById('mdn-add-int').innerText = '₹' + intAdd.toFixed(2);
    document.getElementById('mdn-add-tot').innerText = '₹' + (prinAdd + intAdd).toFixed(2);

    var curPrin = 5000; var curInt = 1200;
    document.getElementById('mdn-os-after-prin').innerText = '₹' + (curPrin + prinAdd).toFixed(2);
    document.getElementById('mdn-os-after-int').innerText = '₹' + (curInt + intAdd).toFixed(2);
    document.getElementById('mdn-os-after-tot').innerText = '₹' + (curPrin + curInt + prinAdd + intAdd).toFixed(2);
  }

  function resetBalancePanel() {
    ['mdn-os-before-prin','mdn-os-before-int','mdn-os-before-tot','mdn-add-prin','mdn-add-int','mdn-add-tot','mdn-os-after-prin','mdn-os-after-int','mdn-os-after-tot'].forEach(function(id) {
      document.getElementById(id).innerText = '₹0.00';
    });
  }

  function gatherFormData() {
    var code = document.getElementById('mdn-form-membercode').value;
    if(!code) { alert('Please select a member.'); return null; }

    var m = MemberDebitNoteMockData.getMembers().find(function(x) { return x.code === code; });
    var items = (typeof MemberDebitNoteGrid !== 'undefined') ? MemberDebitNoteGrid.getItems() : [];
    var total = (typeof MemberDebitNoteGrid !== 'undefined') ? MemberDebitNoteGrid.getTotal() : 0;

    if(total <= 0) { alert('Total amount must be greater than zero.'); return null; }

    return {
      id: document.getElementById('mdn-form-edit-id').value || null,
      dnNo: document.getElementById('mdn-form-dnno').value,
      dnDate: document.getElementById('mdn-form-dndate').value,
      dueDate: document.getElementById('mdn-form-duedate').value,
      period: document.getElementById('mdn-form-period').value,
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      principal: total,
      interest: 0,
      total: total,
      particular1: document.getElementById('mdn-form-part1').value,
      particular2: document.getElementById('mdn-form-part2').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function saveNote() {
    var obj = gatherFormData();
    if(obj) {
      MemberDebitNoteState.saveNote(obj);
      MemberDebitNoteRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      MemberDebitNoteState.saveNote(obj);
      MemberDebitNoteRouter.showPreview(obj.dnNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      MemberDebitNoteState.setActiveNote(null);
      initForm();
    }
  }

  function duplicateNote() {
    document.getElementById('mdn-form-edit-id').value = '';
    document.getElementById('mdn-form-dnno').value = MemberDebitNoteMockData.getNextDnNo();
    document.getElementById('mdn-form-status-badge').innerText = 'Draft';
    document.getElementById('mdn-form-status-badge').className = 'mdn-status-badge mdn-status-draft';
    alert('Duplicated. Edit and save as new debit note.');
  }

  return {
    initForm: initForm, onMemberSelect: onMemberSelect, updateBalanceSummary: updateBalanceSummary,
    saveNote: saveNote, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateNote: duplicateNote
  };
})();
