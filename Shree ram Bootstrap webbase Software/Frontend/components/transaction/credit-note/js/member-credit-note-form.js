// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberCreditNoteForm = (function () {

  var currentFormBillType = 'Maintenance';

  function initForm(billType) {
    populateMembersDropdown();
    
    var cnNo = MemberCreditNoteState.getActiveNote();
    var n = MemberCreditNoteState.getNote(cnNo);
    var bType = 'Maintenance';
    if (n) {
      bType = n.billType || 'Maintenance';
      currentFormBillType = bType;
      document.getElementById('mcn-form-edit-id').value = n.id;
      document.getElementById('mcn-form-cnno').value = n.cnNo;
      document.getElementById('mcn-form-cndate').value = n.cnDate;
      document.getElementById('mcn-form-period').value = n.period || '';
      document.getElementById('mcn-form-duedate').value = n.dueDate || '';
      if (document.getElementById('mcn-form-membercode')) document.getElementById('mcn-form-membercode').value = n.memberCode;
      if (document.getElementById('mcn-form-membername')) document.getElementById('mcn-form-membername').value = n.memberCode;
      document.getElementById('mcn-form-part1').value = n.particular1 || '';
      document.getElementById('mcn-form-part2').value = n.particular2 || '';
      document.getElementById('mcn-form-status-badge').innerText = 'Posted';
      document.getElementById('mcn-form-status-badge').className = 'mcn-status-badge mcn-status-posted';

      if(typeof MemberCreditNoteGrid !== 'undefined') MemberCreditNoteGrid.loadItems(n.lineItems || [], bType);
      onMemberSelect();

    } else {
      bType = billType || (typeof MemberCreditNoteList !== 'undefined' ? MemberCreditNoteList.getActiveBillType() : 'Maintenance');
      if (bType === 'All') bType = 'Maintenance';
      currentFormBillType = bType;
      document.getElementById('mcn-form-edit-id').value = '';
      document.getElementById('mcn-form-cnno').value = 'Loading...';
      fetch('http://localhost:5002/api/member-notes/next-no?type=Credit')
        .then(function(res) { return res.json(); })
        .then(function(res) {
          if (res.success) {
            document.getElementById('mcn-form-cnno').value = res.noteNo;
          } else {
            document.getElementById('mcn-form-cnno').value = MemberCreditNoteMockData.getNextCnNo();
          }
        })
        .catch(function(err) {
          console.error(err);
          document.getElementById('mcn-form-cnno').value = MemberCreditNoteMockData.getNextCnNo();
        });
      document.getElementById('mcn-form-cndate').value = new Date().toISOString().split('T')[0];
      document.getElementById('mcn-form-period').value = '';
      document.getElementById('mcn-form-duedate').value = '';
      if (document.getElementById('mcn-form-membercode')) document.getElementById('mcn-form-membercode').value = '';
      if (document.getElementById('mcn-form-membername')) document.getElementById('mcn-form-membername').value = '';
      document.getElementById('mcn-form-part1').value = '';
      document.getElementById('mcn-form-part2').value = '';
      document.getElementById('mcn-form-status-badge').innerText = 'Draft';
      document.getElementById('mcn-form-status-badge').className = 'mcn-status-badge mcn-status-draft';

      if(typeof MemberCreditNoteGrid !== 'undefined') MemberCreditNoteGrid.loadItems([], bType);
      resetBalancePanel();
    }
    if (typeof MemberCreditNoteRouter !== 'undefined' && MemberCreditNoteRouter.updateWorkspaceTitleAndTab) {
      MemberCreditNoteRouter.updateWorkspaceTitleAndTab(currentFormBillType);
    }
  }

  function populateMembersDropdown() {
    var codeSel = document.getElementById('mcn-form-membercode');
    var nameSel = document.getElementById('mcn-form-membername');
    var members = MemberCreditNoteMockData.getMembers();
    
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
    var code = document.getElementById('mcn-form-membercode').value;
    var nameSel = document.getElementById('mcn-form-membername');
    if (nameSel) nameSel.value = code;
    onMemberSelect();
  }

  function onMemberNameSelect() {
    var code = document.getElementById('mcn-form-membername').value;
    var codeSel = document.getElementById('mcn-form-membercode');
    if (codeSel) codeSel.value = code;
    onMemberSelect();
  }

  function onMemberSelect() {
    var code = document.getElementById('mcn-form-membercode').value;
    
    // Clear sidebar details if no code is selected
    var flatNo = '—';
    var area = '—';
    var mobile1 = '—';
    var mobile2 = '—';
    var nocFrom = '—';
    var nocTo = '—';

    if(!code) {
      if (document.getElementById('mcn-preview-flat')) document.getElementById('mcn-preview-flat').innerText = flatNo;
      if (document.getElementById('mcn-preview-area')) document.getElementById('mcn-preview-area').innerText = area;
      if (document.getElementById('mcn-preview-mobile1')) document.getElementById('mcn-preview-mobile1').innerText = mobile1;
      if (document.getElementById('mcn-preview-mobile2')) document.getElementById('mcn-preview-mobile2').innerText = mobile2;
      if (document.getElementById('mcn-preview-noc-from')) document.getElementById('mcn-preview-noc-from').value = nocFrom;
      if (document.getElementById('mcn-preview-noc-to')) document.getElementById('mcn-preview-noc-to').value = nocTo;
      resetBalancePanel(); 
      return; 
    }

    var m = MemberCreditNoteMockData.getMembers().find(function(x) { return x.code === code; });
    
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

    if (document.getElementById('mcn-preview-flat')) document.getElementById('mcn-preview-flat').innerText = flatNo;
    if (document.getElementById('mcn-preview-area')) document.getElementById('mcn-preview-area').innerText = area;
    if (document.getElementById('mcn-preview-mobile1')) document.getElementById('mcn-preview-mobile1').innerText = mobile1;
    if (document.getElementById('mcn-preview-mobile2')) document.getElementById('mcn-preview-mobile2').innerText = mobile2;
    if (document.getElementById('mcn-preview-noc-from')) document.getElementById('mcn-preview-noc-from').value = nocFrom;
    if (document.getElementById('mcn-preview-noc-to')) document.getElementById('mcn-preview-noc-to').value = nocTo;

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
      billType: currentFormBillType,
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

  async function saveNote() {
    var obj = gatherFormData();
    if(obj) {
      await MemberCreditNoteState.saveNote(obj);
      MemberCreditNoteRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      await MemberCreditNoteState.saveNote(obj);
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

  function repeatLastParticular1() {
    var code = document.getElementById('mcn-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var allNotes = MemberCreditNoteMockData.getNotes() || [];
    var currentNo = document.getElementById('mcn-form-cnno').value;

    var memberNotes = allNotes.filter(function(n) {
      return n.memberCode === code && n.cnNo !== currentNo && n.particular1;
    });

    if (memberNotes.length > 0) {
      memberNotes.sort(function(a, b) {
        return new Date(b.cnDate) - new Date(a.cnDate);
      });
      var lastVal = memberNotes[0].particular1;
      document.getElementById('mcn-form-part1').value = lastVal;
    } else {
      alert("No last Particular 1 found for this member.");
    }
  }

  function repeatLastParticular2() {
    var code = document.getElementById('mcn-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var allNotes = MemberCreditNoteMockData.getNotes() || [];
    var currentNo = document.getElementById('mcn-form-cnno').value;

    var memberNotes = allNotes.filter(function(n) {
      return n.memberCode === code && n.cnNo !== currentNo && n.particular2;
    });

    if (memberNotes.length > 0) {
      memberNotes.sort(function(a, b) {
        return new Date(b.cnDate) - new Date(a.cnDate);
      });
      var lastVal = memberNotes[0].particular2;
      document.getElementById('mcn-form-part2').value = lastVal;
    } else {
      alert("No last Particular 2 found for this member.");
    }
  }

  return {
    initForm: initForm, onMemberSelect: onMemberSelect, updateBalanceSummary: updateBalanceSummary,
    onMemberCodeSelect: onMemberCodeSelect, onMemberNameSelect: onMemberNameSelect,
    saveNote: saveNote, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateNote: duplicateNote,
    repeatLastParticular1: repeatLastParticular1, repeatLastParticular2: repeatLastParticular2
  };
})();
