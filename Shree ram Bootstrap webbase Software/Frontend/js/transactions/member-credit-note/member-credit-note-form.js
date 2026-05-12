// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: FORM
// ═══════════════════════════════════════════════════════

var MemberCreditNoteForm = (function () {

  var currentNote = null;
  var originalMember = null;

  function newNote() {
    currentNote = {
      cnNo: MemberCreditNoteState.generateCnNo(),
      cnDate: new Date().toISOString().split('T')[0],
      memberCode: '',
      memberName: '',
      wingFlat: '',
      mobile: '',
      period: '',
      adjustDate: '',
      items: [],
      principalReduction: 0,
      interestReduction: 0,
      gstReduction: 0,
      totalReduction: 0,
      status: 'Draft',
      notes: ''
    };
    originalMember = null;
    populateMembers();
    bindData();
    MemberCreditNoteGrid.init([]);
    updateBalancePanel();
  }

  function loadNote(cnNo) {
    var note = MemberCreditNoteState.getByNo(cnNo);
    if (note) {
      currentNote = JSON.parse(JSON.stringify(note)); // clone
      populateMembers();
      originalMember = MemberCreditNoteMockData.getMemberByCode(currentNote.memberCode);
      bindData();
      MemberCreditNoteGrid.init(currentNote.items);
      updateBalancePanel();
    }
  }

  function populateMembers() {
    var select = document.getElementById('mcn-form-membercode');
    if (!select) return;
    var members = MemberCreditNoteMockData.getMembers();
    select.innerHTML = '<option value="">— Select Member —</option>' + 
                       members.map(function(m) { return '<option value="'+m.code+'">'+m.code+' - '+m.name+' ('+m.wingFlat+')</option>'; }).join('');
    if (currentNote && currentNote.memberCode) {
      select.value = currentNote.memberCode;
    }
  }

  function onMemberSelect() {
    var select = document.getElementById('mcn-form-membercode');
    var val = select.value;
    if (val) {
      var member = MemberCreditNoteMockData.getMemberByCode(val);
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
    setVal('mcn-form-cnno', currentNote.cnNo);
    setVal('mcn-form-cndate', currentNote.cnDate);
    setVal('mcn-form-membername', currentNote.memberName);
    setVal('mcn-form-wingflat', currentNote.wingFlat);
    setVal('mcn-form-mobile', currentNote.mobile);
    setVal('mcn-form-period', currentNote.period);
    setVal('mcn-form-adjustdate', currentNote.adjustDate);
    setVal('mcn-form-notes', currentNote.notes);
    
    var stat = document.getElementById('mcn-form-status-badge');
    if (stat) stat.innerText = currentNote.status;
  }

  function updateBalancePanel() {
    var panel = document.getElementById('mcn-balance-panel');
    if (!panel) return;
    
    if (!originalMember) {
      panel.style.display = 'none';
      return;
    }
    panel.style.display = 'block';

    var oldPrin = originalMember.osPrincipal;
    var oldInt = originalMember.osInterest;
    var oldTot = oldPrin + oldInt;

    setHtml('mcn-os-before-prin', '₹' + oldPrin.toFixed(2));
    setHtml('mcn-os-before-int', '₹' + oldInt.toFixed(2));
    setHtml('mcn-os-before-tot', '₹' + oldTot.toFixed(2));

    setHtml('mcn-red-prin', '<span style="color:#2E7D32;">-₹' + currentNote.principalReduction.toFixed(2) + '</span>');
    setHtml('mcn-red-int', '<span style="color:#2E7D32;">-₹' + currentNote.interestReduction.toFixed(2) + '</span>');
    setHtml('mcn-red-gst', '<span style="color:#2E7D32;">-₹' + currentNote.gstReduction.toFixed(2) + '</span>');

    // Make sure we don't drop below 0 for display, though accounting allows negative (advance)
    var finalPrin = oldPrin - currentNote.principalReduction;
    var finalInt = oldInt - currentNote.interestReduction;
    var finalTot = oldTot - currentNote.totalReduction;

    setHtml('mcn-os-after-prin', '₹' + finalPrin.toFixed(2));
    setHtml('mcn-os-after-int', '₹' + finalInt.toFixed(2));
    setHtml('mcn-os-after-tot', '<span style="color:#2E7D32;font-weight:bold;">₹' + finalTot.toFixed(2) + '</span>');
  }

  function onGridUpdate(totals) {
    currentNote.principalReduction = totals.principal;
    currentNote.interestReduction = totals.interest;
    currentNote.gstReduction = totals.gstAmount;
    currentNote.totalReduction = totals.principal + totals.interest + totals.gstAmount;
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
    currentNote.cnDate = document.getElementById('mcn-form-cndate').value;
    currentNote.period = document.getElementById('mcn-form-period').value;
    currentNote.adjustDate = document.getElementById('mcn-form-adjustdate').value;
    currentNote.notes = document.getElementById('mcn-form-notes').value;
    currentNote.status = 'Posted';
    currentNote.items = MemberCreditNoteGrid.getItems();

    // Basic Validation: Warn if reduction > outstanding
    var maxPrin = originalMember.osPrincipal;
    var maxInt = originalMember.osInterest;
    if (currentNote.principalReduction > maxPrin || currentNote.interestReduction > maxInt) {
      if(!confirm('Reduction amount exceeds current outstanding dues. This will result in an advance balance. Continue?')) {
        return;
      }
    }

    MemberCreditNoteState.save(currentNote);
    MemberCreditNoteRouter.showList();
  }

  function saveAndPreview() {
    saveNote();
    MemberCreditNoteRouter.showPreview(currentNote.cnNo);
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
