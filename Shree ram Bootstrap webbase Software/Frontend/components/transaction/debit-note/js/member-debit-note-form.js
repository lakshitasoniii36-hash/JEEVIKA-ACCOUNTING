// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberDebitNoteForm = (function () {

  var currentFormBillType = 'Maintenance';

  function initForm(billType) {
    populateMembersDropdown();
    
    var dnNo = MemberDebitNoteState.getActiveNote();
    var n = MemberDebitNoteState.getNote(dnNo);
    var bType = 'Maintenance';
    if (n) {
      bType = n.billType || 'Maintenance';
      currentFormBillType = bType;
      document.getElementById('mdn-form-edit-id').value = n.id;
      document.getElementById('mdn-form-dnno').value = n.dnNo;
      document.getElementById('mdn-form-dndate').value = n.dnDate;
      document.getElementById('mdn-form-period').value = n.period || '';
      document.getElementById('mdn-form-duedate').value = n.dueDate || '';
      if (document.getElementById('mdn-form-membercode')) document.getElementById('mdn-form-membercode').value = n.memberCode;
      if (document.getElementById('mdn-form-membername')) document.getElementById('mdn-form-membername').value = n.memberCode;
      document.getElementById('mdn-form-part1').value = n.particular1 || '';
      document.getElementById('mdn-form-part2').value = n.particular2 || '';
      document.getElementById('mdn-form-status-badge').innerText = 'Posted';
      document.getElementById('mdn-form-status-badge').className = 'mdn-status-badge mdn-status-posted';

      if(typeof MemberDebitNoteGrid !== 'undefined') MemberDebitNoteGrid.loadItems(n.lineItems || [], bType);
      onMemberSelect();

    } else {
      bType = billType || (typeof MemberDebitNoteList !== 'undefined' ? MemberDebitNoteList.getActiveBillType() : 'Maintenance');
      if (bType === 'All') bType = 'Maintenance';
      currentFormBillType = bType;
      document.getElementById('mdn-form-edit-id').value = '';
      document.getElementById('mdn-form-dnno').value = 'Loading...';
      fetch('http://localhost:5002/api/member-notes/next-no?type=Debit')
        .then(function(res) { return res.json(); })
        .then(function(res) {
          if (res.success) {
            document.getElementById('mdn-form-dnno').value = res.noteNo;
          } else {
            document.getElementById('mdn-form-dnno').value = MemberDebitNoteMockData.getNextDnNo();
          }
        })
        .catch(function(err) {
          console.error(err);
          document.getElementById('mdn-form-dnno').value = MemberDebitNoteMockData.getNextDnNo();
        });
      document.getElementById('mdn-form-dndate').value = new Date().toISOString().split('T')[0];
      document.getElementById('mdn-form-period').value = '';
      document.getElementById('mdn-form-duedate').value = '';
      if (document.getElementById('mdn-form-membercode')) document.getElementById('mdn-form-membercode').value = '';
      if (document.getElementById('mdn-form-membername')) document.getElementById('mdn-form-membername').value = '';
      document.getElementById('mdn-form-part1').value = '';
      document.getElementById('mdn-form-part2').value = '';
      document.getElementById('mdn-form-status-badge').innerText = 'Draft';
      document.getElementById('mdn-form-status-badge').className = 'mdn-status-badge mdn-status-draft';

      if(typeof MemberDebitNoteGrid !== 'undefined') MemberDebitNoteGrid.loadItems([], bType);
      resetBalancePanel();
    }
    if (typeof MemberDebitNoteRouter !== 'undefined' && MemberDebitNoteRouter.updateWorkspaceTitleAndTab) {
      MemberDebitNoteRouter.updateWorkspaceTitleAndTab(currentFormBillType);
    }
  }

  function populateMembersDropdown() {
    var codeSel = document.getElementById('mdn-form-membercode');
    var nameSel = document.getElementById('mdn-form-membername');
    var members = MemberDebitNoteMockData.getMembers();
    
    if (codeSel) {
      codeSel.innerHTML = '<option value="">— Select Code —</option>';
      members.forEach(function(m) {
        codeSel.innerHTML += '<option value="' + m.code + '">' + m.code + '</option>';
      });
    }
    if (nameSel) {
      nameSel.innerHTML = '<option value="">— Select Member —</option>';
      members.forEach(function(m) {
        nameSel.innerHTML += '<option value="' + m.code + '">' + m.name + ' (' + m.wingFlat + ')</option>';
      });
    }
  }

  function onMemberCodeSelect() {
    var code = document.getElementById('mdn-form-membercode').value;
    var nameSel = document.getElementById('mdn-form-membername');
    if (nameSel) nameSel.value = code;
    onMemberSelect();
  }

  function onMemberNameSelect() {
    var code = document.getElementById('mdn-form-membername').value;
    var codeSel = document.getElementById('mdn-form-membercode');
    if (codeSel) codeSel.value = code;
    onMemberSelect();
  }

  function onMemberSelect() {
    var code = document.getElementById('mdn-form-membercode').value;
    
    // Clear sidebar details if no code is selected
    var flatNo = '—';
    var area = '—';
    var mobile1 = '—';
    var mobile2 = '—';
    var nocFrom = '—';
    var nocTo = '—';

    if(!code) {
      if (document.getElementById('mdn-preview-flat')) document.getElementById('mdn-preview-flat').innerText = flatNo;
      if (document.getElementById('mdn-preview-area')) document.getElementById('mdn-preview-area').innerText = area;
      if (document.getElementById('mdn-preview-mobile1')) document.getElementById('mdn-preview-mobile1').innerText = mobile1;
      if (document.getElementById('mdn-preview-mobile2')) document.getElementById('mdn-preview-mobile2').innerText = mobile2;
      if (document.getElementById('mdn-preview-noc-from')) document.getElementById('mdn-preview-noc-from').value = nocFrom;
      if (document.getElementById('mdn-preview-noc-to')) document.getElementById('mdn-preview-noc-to').value = nocTo;
      resetBalancePanel(); 
      return; 
    }

    var m = MemberDebitNoteMockData.getMembers().find(function(x) { return x.code === code; });
    
    // Find the detailed member object from the cached list or fallback
    var memberList = [];
    if (typeof MemberReceiptState !== 'undefined' && typeof MemberReceiptState.getMembersList === 'function') {
      memberList = MemberReceiptState.getMembersList();
    }
    var detailedMember = memberList.find(function(x) { return (x.MemCode || x.code) === code; }) || m;

    if (detailedMember) {
      var w = detailedMember.Wing || detailedMember.wing || '';
      var f = detailedMember.FlatNo || detailedMember.flatNo || '';
      flatNo = w && f ? w + '-' + f : (f || w || detailedMember.wingFlat || '—');
      
      if (detailedMember.Sqft || detailedMember.sqft) {
        area = (detailedMember.Sqft || detailedMember.sqft) + ' Sq.Ft';
      }
      
      mobile1 = detailedMember.ContactNo || detailedMember.contactNo || detailedMember.MemMobile || detailedMember.memMobile || detailedMember.mobile || '—';
      mobile2 = detailedMember.MemMobile2 || detailedMember.memMobile2 || '—';
      
      var nocDetail = detailedMember.NocDetail || detailedMember.nocDetail || '';
      if (nocDetail) {
        var sh = nocDetail.split('|');
        nocFrom = sh[2] || '—';
        nocTo = sh[3] || '—';
      }
    }

    if (document.getElementById('mdn-preview-flat')) document.getElementById('mdn-preview-flat').innerText = flatNo;
    if (document.getElementById('mdn-preview-area')) document.getElementById('mdn-preview-area').innerText = area;
    if (document.getElementById('mdn-preview-mobile1')) document.getElementById('mdn-preview-mobile1').innerText = mobile1;
    if (document.getElementById('mdn-preview-mobile2')) document.getElementById('mdn-preview-mobile2').innerText = mobile2;
    if (document.getElementById('mdn-preview-noc-from')) document.getElementById('mdn-preview-noc-from').value = nocFrom;
    if (document.getElementById('mdn-preview-noc-to')) document.getElementById('mdn-preview-noc-to').value = nocTo;

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
      billType: currentFormBillType,
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

  async function saveNote() {
    var obj = gatherFormData();
    if(obj) {
      await MemberDebitNoteState.saveNote(obj);
      MemberDebitNoteRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      await MemberDebitNoteState.saveNote(obj);
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
    onMemberCodeSelect: onMemberCodeSelect, onMemberNameSelect: onMemberNameSelect,
    saveNote: saveNote, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateNote: duplicateNote
  };
})();
