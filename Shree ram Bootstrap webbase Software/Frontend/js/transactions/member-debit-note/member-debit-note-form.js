// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: FORM
// ═══════════════════════════════════════════════════════

var MemberDebitNoteForm = (function () {

  var currentNote = null;
  var originalMember = null;

  function newNote() {
    currentNote = {
      dnNo: MemberDebitNoteState.generateDnNo(),
      dnDate: new Date().toISOString().split('T')[0],
      memberCode: '',
      memberName: '',
      wingFlat: '',
      mobile: '',
      period: '',
      dueDate: '',
      items: [],
      principalIncrease: 0,
      interestIncrease: 0,
      gstAmount: 0,
      totalAmount: 0,
      status: 'Draft',
      notes: ''
    };
    originalMember = null;
    populateMembers();
    bindData();
    MemberDebitNoteGrid.init([]);
    updateBalancePanel();
  }

  function loadNote(dnNo) {
    var note = MemberDebitNoteState.getByNo(dnNo);
    if (note) {
      currentNote = JSON.parse(JSON.stringify(note)); // clone
      populateMembers();
      originalMember = MemberDebitNoteMockData.getMemberByCode(currentNote.memberCode);
      bindData();
      MemberDebitNoteGrid.init(currentNote.items);
      updateBalancePanel();
    }
  }

  function populateMembers() {
    var select = document.getElementById('mdn-form-membercode');
    if (!select) return;
    var members = MemberDebitNoteMockData.getMembers();
    select.innerHTML = '<option value="">— Select Member —</option>' + 
                       members.map(function(m) { return '<option value="'+m.code+'">'+m.code+' - '+m.name+' ('+m.wingFlat+')</option>'; }).join('');
    if (currentNote && currentNote.memberCode) {
      select.value = currentNote.memberCode;
    }
  }

  function onMemberSelect() {
    var select = document.getElementById('mdn-form-membercode');
    var val = select.value;
    if (val) {
      var member = MemberDebitNoteMockData.getMemberByCode(val);
      if (member) {
        originalMember = member;
        currentNote.memberCode = member.code;
        currentNote.memberName = member.name;
        currentNote.wingFlat = member.wingFlat;
        currentNote.mobile = member.mobile;
        bindData();
        updateBalancePanel();
      }
    } else {
      originalMember = null;
      currentNote.memberCode = '';
      currentNote.memberName = '';
      currentNote.wingFlat = '';
      currentNote.mobile = '';
      bindData();
      updateBalancePanel();
    }
  }

  function bindData() {
    setVal('mdn-form-dnno', currentNote.dnNo);
    setVal('mdn-form-dndate', currentNote.dnDate);
    setVal('mdn-form-membername', currentNote.memberName);
    setVal('mdn-form-wingflat', currentNote.wingFlat);
    setVal('mdn-form-mobile', currentNote.mobile);
    setVal('mdn-form-period', currentNote.period);
    setVal('mdn-form-duedate', currentNote.dueDate);
    setVal('mdn-form-notes', currentNote.notes);
    
    var stat = document.getElementById('mdn-form-status-badge');
    if (stat) stat.innerText = currentNote.status;
  }

  function updateBalancePanel() {
    var panel = document.getElementById('mdn-balance-panel');
    if (!panel) return;
    
    if (!originalMember) {
      panel.style.display = 'none';
      return;
    }
    panel.style.display = 'block';

    var oldPrin = originalMember.osPrincipal;
    var oldInt = originalMember.osInterest;
    var oldTot = oldPrin + oldInt;

    setHtml('mdn-os-before-prin', '₹' + oldPrin.toFixed(2));
    setHtml('mdn-os-before-int', '₹' + oldInt.toFixed(2));
    setHtml('mdn-os-before-tot', '₹' + oldTot.toFixed(2));

    setHtml('mdn-add-prin', '<span style="color:#C62828;">+₹' + currentNote.principalIncrease.toFixed(2) + '</span>');
    setHtml('mdn-add-int', '<span style="color:#C62828;">+₹' + currentNote.interestIncrease.toFixed(2) + '</span>');
    setHtml('mdn-add-gst', '<span style="color:#C62828;">+₹' + currentNote.gstAmount.toFixed(2) + '</span>');

    var finalPrin = oldPrin + currentNote.principalIncrease;
    var finalInt = oldInt + currentNote.interestIncrease;
    var finalTot = oldTot + currentNote.totalAmount;

    setHtml('mdn-os-after-prin', '₹' + finalPrin.toFixed(2));
    setHtml('mdn-os-after-int', '₹' + finalInt.toFixed(2));
    setHtml('mdn-os-after-tot', '<span style="color:#C62828;font-weight:bold;">₹' + finalTot.toFixed(2) + '</span>');
  }

  function onGridUpdate(totals) {
    currentNote.principalIncrease = totals.principal;
    currentNote.interestIncrease = totals.interest;
    currentNote.gstAmount = totals.gstAmount;
    currentNote.totalAmount = totals.principal + totals.interest + totals.gstAmount;
    updateBalancePanel();
  }

  function setVal(id, val) {
    var el = document.getElementById(id);
    if (el) el.value = val;
  }
  function setHtml(id, val) {
    var el = document.getElementById(id);
    if (el) el.innerHTML = val;
  }

  function saveNote() {
    if (!currentNote.memberCode) {
      alert('Please select a Member.');
      return;
    }
    currentNote.dnDate = document.getElementById('mdn-form-dndate').value;
    currentNote.period = document.getElementById('mdn-form-period').value;
    currentNote.dueDate = document.getElementById('mdn-form-duedate').value;
    currentNote.notes = document.getElementById('mdn-form-notes').value;
    currentNote.status = 'Posted';
    currentNote.items = MemberDebitNoteGrid.getItems();

    MemberDebitNoteState.save(currentNote);
    MemberDebitNoteRouter.showList();
  }

  function saveAndPreview() {
    saveNote();
    MemberDebitNoteRouter.showPreview(currentNote.dnNo);
  }

  return {
    newNote: newNote,
    loadNote: loadNote,
    onMemberSelect: onMemberSelect,
    onGridUpdate: onGridUpdate,
    saveNote: saveNote,
    saveAndPreview: saveAndPreview
  };
})();
