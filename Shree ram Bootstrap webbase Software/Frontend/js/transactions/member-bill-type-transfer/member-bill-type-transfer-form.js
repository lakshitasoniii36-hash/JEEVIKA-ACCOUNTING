// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: FORM
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferForm = (function () {

  var currentTransfer = null;
  var originalMember = null;
  var simulatedMember = null;

  function newTransfer() {
    currentTransfer = {
      transferNo: MemberBillTypeTransferState.generateTransferNo(),
      transferDate: new Date().toISOString().split('T')[0],
      memberCode: '',
      memberName: '',
      wingFlat: '',
      period: '',
      effectiveDate: '',
      items: [],
      totalShifted: 0,
      totalGstShifted: 0,
      totalInterestShifted: 0,
      status: 'Draft',
      notes: ''
    };
    originalMember = null;
    simulatedMember = null;
    populateMembers();
    bindData();
    MemberBillTypeTransferGrid.init([]);
    updateBalancePanel();
  }

  function loadTransfer(trNo) {
    var tr = MemberBillTypeTransferState.getByNo(trNo);
    if (tr) {
      currentTransfer = JSON.parse(JSON.stringify(tr)); // clone
      populateMembers();
      var m = MemberBillTypeTransferMockData.getMemberByCode(currentTransfer.memberCode);
      if (m) {
        originalMember = JSON.parse(JSON.stringify(m));
        simulatedMember = JSON.parse(JSON.stringify(m));
      }
      bindData();
      MemberBillTypeTransferGrid.init(currentTransfer.items);
      updateBalancePanel();
    }
  }

  function populateMembers() {
    var select = document.getElementById('mbtt-form-membercode');
    if (!select) return;
    var members = MemberBillTypeTransferMockData.getMembers();
    select.innerHTML = '<option value="">— Select Member —</option>' + 
                       members.map(function(m) { return '<option value="'+m.code+'">'+m.code+' - '+m.name+' ('+m.wingFlat+')</option>'; }).join('');
    if (currentTransfer && currentTransfer.memberCode) {
      select.value = currentTransfer.memberCode;
    }
  }

  function onMemberSelect() {
    var select = document.getElementById('mbtt-form-membercode');
    var val = select.value;
    if (val) {
      var member = MemberBillTypeTransferMockData.getMemberByCode(val);
      if (member) {
        originalMember = JSON.parse(JSON.stringify(member));
        simulatedMember = JSON.parse(JSON.stringify(member));
        currentTransfer.memberCode = member.code;
        currentTransfer.memberName = member.name;
        currentTransfer.wingFlat = member.wingFlat;
        bindData();
        updateBalancePanel();
      }
    } else {
      originalMember = null;
      simulatedMember = null;
      currentTransfer.memberCode = '';
      currentTransfer.memberName = '';
      currentTransfer.wingFlat = '';
      bindData();
      updateBalancePanel();
    }
  }

  function bindData() {
    setVal('mbtt-form-trno', currentTransfer.transferNo);
    setVal('mbtt-form-trdate', currentTransfer.transferDate);
    setVal('mbtt-form-membername', currentTransfer.memberName);
    setVal('mbtt-form-wingflat', currentTransfer.wingFlat);
    setVal('mbtt-form-period', currentTransfer.period);
    setVal('mbtt-form-effdate', currentTransfer.effectiveDate);
    setVal('mbtt-form-notes', currentTransfer.notes);
    
    var stat = document.getElementById('mbtt-form-status-badge');
    if (stat) stat.innerText = currentTransfer.status;
  }

  function getHeadKey(headName) {
    if(headName === 'Maintenance') return 'maintenance';
    if(headName === 'Club House') return 'clubHouse';
    if(headName === 'Parking') return 'parking';
    if(headName === 'Utility') return 'utility';
    if(headName === 'Interest') return 'interest';
    return null;
  }

  function updateBalancePanel() {
    var panel = document.getElementById('mbtt-balance-panel');
    if (!panel) return;
    
    if (!originalMember) {
      panel.style.display = 'none';
      return;
    }
    panel.style.display = 'block';

    // Before
    var o = originalMember.dues;
    setHtml('mbtt-os-maint', '₹' + o.maintenance.toFixed(2));
    setHtml('mbtt-os-club', '₹' + o.clubHouse.toFixed(2));
    setHtml('mbtt-os-park', '₹' + o.parking.toFixed(2));
    setHtml('mbtt-os-util', '₹' + o.utility.toFixed(2));
    setHtml('mbtt-os-int', '₹' + o.interest.toFixed(2));
    var oTot = o.maintenance + o.clubHouse + o.parking + o.utility + o.interest;
    setHtml('mbtt-os-tot', '₹' + oTot.toFixed(2));

    // Simulate transfer
    simulatedMember = JSON.parse(JSON.stringify(originalMember));
    var s = simulatedMember.dues;
    var shiftTotal = 0;

    currentTransfer.items.forEach(function(item) {
      var fKey = getHeadKey(item.fromHead);
      var tKey = getHeadKey(item.toHead);
      if(fKey && tKey && fKey !== tKey) {
        var amt = item.amount || 0;
        s[fKey] -= amt;
        s[tKey] += amt;
        shiftTotal += amt;
      }
    });

    // After
    setHtml('mbtt-new-maint', formatDiff(s.maintenance, o.maintenance));
    setHtml('mbtt-new-club', formatDiff(s.clubHouse, o.clubHouse));
    setHtml('mbtt-new-park', formatDiff(s.parking, o.parking));
    setHtml('mbtt-new-util', formatDiff(s.utility, o.utility));
    setHtml('mbtt-new-int', formatDiff(s.interest, o.interest));
    var sTot = s.maintenance + s.clubHouse + s.parking + s.utility + s.interest;
    setHtml('mbtt-new-tot', '₹' + sTot.toFixed(2) + ' (Net: ₹0)');
  }

  function formatDiff(newVal, oldVal) {
    if (newVal === oldVal) return '₹' + newVal.toFixed(2);
    var color = newVal > oldVal ? '#2E7D32' : '#C62828';
    var icon = newVal > oldVal ? '↑' : '↓';
    return '<span style="color:' + color + ';">₹' + newVal.toFixed(2) + ' ' + icon + '</span>';
  }

  function onGridUpdate(totals, items) {
    currentTransfer.items = items;
    currentTransfer.totalShifted = totals.amount;
    currentTransfer.totalGstShifted = totals.gst;
    currentTransfer.totalInterestShifted = totals.interest;
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

  function saveTransfer() {
    if (!currentTransfer.memberCode) {
      alert('Please select a Member.');
      return;
    }

    // Validation: Check negative balances
    var s = simulatedMember.dues;
    if (s.maintenance < 0 || s.clubHouse < 0 || s.parking < 0 || s.utility < 0 || s.interest < 0) {
      if(!confirm('This transfer will result in a negative balance for one or more billing heads. Are you sure you want to proceed?')) {
        return;
      }
    }

    currentTransfer.transferDate = document.getElementById('mbtt-form-trdate').value;
    currentTransfer.period = document.getElementById('mbtt-form-period').value;
    currentTransfer.effectiveDate = document.getElementById('mbtt-form-effdate').value;
    currentTransfer.notes = document.getElementById('mbtt-form-notes').value;
    currentTransfer.status = 'Posted';

    MemberBillTypeTransferState.save(currentTransfer);
    MemberBillTypeTransferRouter.showList();
  }

  function saveAndPreview() {
    saveTransfer();
    MemberBillTypeTransferRouter.showPreview(currentTransfer.transferNo);
  }

  return {
    newTransfer: newTransfer,
    loadTransfer: loadTransfer,
    onMemberSelect: onMemberSelect,
    onGridUpdate: onGridUpdate,
    saveTransfer: saveTransfer,
    saveAndPreview: saveAndPreview
  };
})();
