// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: FORM
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferForm = (function () {

  function initForm() {
    populateMembersDropdown();
    
    var vNo = MemberBillTypeTransferState.getActiveVoucher();
    var t = MemberBillTypeTransferState.getTransfer(vNo);

    if (t) {
      document.getElementById('mbtt-form-edit-id').value = t.id;
      document.getElementById('mbtt-form-vno').value = t.voucherNo;
      document.getElementById('mbtt-form-date').value = t.date;
      document.getElementById('mbtt-form-membercode').value = t.memberCode;
      document.getElementById('mbtt-form-type').value = t.type || 'Debit';
      
      document.getElementById('mbtt-form-chqno').value = t.chqNo || '';
      document.getElementById('mbtt-form-chqdate').value = t.chqDate || '';
      document.getElementById('mbtt-form-bank').value = t.bank || '';
      document.getElementById('mbtt-form-billno').value = t.billNo || '';
      document.getElementById('mbtt-form-part1').value = t.particular1 || '';
      document.getElementById('mbtt-form-part2').value = t.particular2 || '';
      document.getElementById('mbtt-form-person').value = t.personName || '';
      document.getElementById('mbtt-form-cleardate').value = t.clearDate || '';

      document.getElementById('mbtt-form-status-badge').innerText = 'Posted';
      document.getElementById('mbtt-form-status-badge').className = 'mbtt-status-badge mbtt-status-posted';

      if(typeof MemberBillTypeTransferGrid !== 'undefined') MemberBillTypeTransferGrid.loadItems(t.lineItems || []);
      onMemberSelect();

    } else {
      document.getElementById('mbtt-form-edit-id').value = '';
      document.getElementById('mbtt-form-vno').value = MemberBillTypeTransferMockData.getNextVoucherNo();
      document.getElementById('mbtt-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('mbtt-form-membercode').value = '';
      document.getElementById('mbtt-form-type').value = 'Debit';
      
      document.getElementById('mbtt-form-chqno').value = '';
      document.getElementById('mbtt-form-chqdate').value = '';
      document.getElementById('mbtt-form-bank').value = '';
      document.getElementById('mbtt-form-billno').value = '';
      document.getElementById('mbtt-form-part1').value = '';
      document.getElementById('mbtt-form-part2').value = '';
      document.getElementById('mbtt-form-person').value = '';
      document.getElementById('mbtt-form-cleardate').value = '';

      document.getElementById('mbtt-form-status-badge').innerText = 'Draft';
      document.getElementById('mbtt-form-status-badge').className = 'mbtt-status-badge mbtt-status-draft';

      if(typeof MemberBillTypeTransferGrid !== 'undefined') MemberBillTypeTransferGrid.loadItems([]);
      resetLedgerPanel();
    }
  }

  function populateMembersDropdown() {
    var sel = document.getElementById('mbtt-form-membercode');
    var members = MemberBillTypeTransferMockData.getMembers();
    sel.innerHTML = '<option value="">— Select Member —</option>';
    members.forEach(function(m) {
      sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
    });
  }

  function onMemberSelect() {
    var code = document.getElementById('mbtt-form-membercode').value;
    if(!code) { resetLedgerPanel(); return; }

    var m = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code; });
    if(m) {
      document.getElementById('mbtt-hdr-name').innerText = m.name;
      document.getElementById('mbtt-hdr-prin').innerText = '₹' + parseFloat(m.principal || 0).toFixed(2);
      document.getElementById('mbtt-hdr-int').innerText = '₹' + parseFloat(m.interest || 0).toFixed(2);
      document.getElementById('mbtt-hdr-tot').innerText = '₹' + parseFloat(m.total || 0).toFixed(2);
      document.getElementById('mbtt-form-person').value = m.name; // Auto-fill person name
      
      // Mock ledger data for the selected member
      var tbody = document.getElementById('mbtt-ledger-tbody');
      if(tbody) {
        tbody.innerHTML = 
          '<tr><td>01-May-25</td><td>Opening Balance</td><td style="text-align:right;">1200.00</td><td></td><td style="text-align:right;">1200.00 Dr</td></tr>' +
          '<tr><td>05-May-25</td><td>Bill #123</td><td style="text-align:right;">5000.00</td><td></td><td style="text-align:right;">6200.00 Dr</td></tr>' +
          '<tr><td>10-May-25</td><td>Receipt #45</td><td></td><td style="text-align:right;">2000.00</td><td style="text-align:right;">4200.00 Dr</td></tr>';
      }
    }
  }

  function resetLedgerPanel() {
    document.getElementById('mbtt-hdr-name').innerText = '-';
    document.getElementById('mbtt-hdr-prin').innerText = '₹0.00';
    document.getElementById('mbtt-hdr-int').innerText = '₹0.00';
    document.getElementById('mbtt-hdr-tot').innerText = '₹0.00';
    var tbody = document.getElementById('mbtt-ledger-tbody');
    if(tbody) tbody.innerHTML = '<tr><td colspan="5" style="text-align:center;color:#9E9E9E;">Select member to view ledger</td></tr>';
  }

  function updateNetBalance() {
    if(typeof MemberBillTypeTransferGrid === 'undefined') return;
    var pT=0, iT=0, dT=0, cT=0;
    var items = MemberBillTypeTransferGrid.getItems();
    items.forEach(function(i) {
      pT += parseFloat(i.principal || 0); iT += parseFloat(i.interest || 0);
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });
    
    document.getElementById('mbtt-net-prin').innerText = pT.toFixed(2);
    document.getElementById('mbtt-net-int').innerText = iT.toFixed(2);
    document.getElementById('mbtt-net-dr').innerText = dT.toFixed(2);
    document.getElementById('mbtt-net-cr').innerText = cT.toFixed(2);
    
    var net = Math.abs(dT - cT);
    var el = document.getElementById('mbtt-net-diff');
    if(dT === cT) { el.innerText = '0.00'; el.style.color = '#2E7D32'; }
    else { el.innerText = net.toFixed(2) + (dT > cT ? ' Dr' : ' Cr'); el.style.color = '#C62828'; }
  }

  function gatherFormData() {
    var code = document.getElementById('mbtt-form-membercode').value;
    if(!code) { alert('Please select a member.'); return null; }

    var m = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code; });
    var items = (typeof MemberBillTypeTransferGrid !== 'undefined') ? MemberBillTypeTransferGrid.getItems() : [];
    
    var dT=0, cT=0;
    items.forEach(function(i) { dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0); });

    return {
      id: document.getElementById('mbtt-form-edit-id').value || null,
      voucherNo: document.getElementById('mbtt-form-vno').value,
      date: document.getElementById('mbtt-form-date').value,
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      type: document.getElementById('mbtt-form-type').value,
      amount: Math.max(dT, cT),
      chqNo: document.getElementById('mbtt-form-chqno').value,
      chqDate: document.getElementById('mbtt-form-chqdate').value,
      bank: document.getElementById('mbtt-form-bank').value,
      billNo: document.getElementById('mbtt-form-billno').value,
      particular1: document.getElementById('mbtt-form-part1').value,
      particular2: document.getElementById('mbtt-form-part2').value,
      personName: document.getElementById('mbtt-form-person').value,
      clearDate: document.getElementById('mbtt-form-cleardate').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function saveTransfer() {
    var obj = gatherFormData();
    if(obj) {
      MemberBillTypeTransferState.saveTransfer(obj);
      MemberBillTypeTransferRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      MemberBillTypeTransferState.saveTransfer(obj);
      MemberBillTypeTransferRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      MemberBillTypeTransferState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateTransfer() {
    document.getElementById('mbtt-form-edit-id').value = '';
    document.getElementById('mbtt-form-vno').value = MemberBillTypeTransferMockData.getNextVoucherNo();
    document.getElementById('mbtt-form-status-badge').innerText = 'Draft';
    document.getElementById('mbtt-form-status-badge').className = 'mbtt-status-badge mbtt-status-draft';
    alert('Duplicated. Edit and save as new transfer.');
  }

  return {
    initForm: initForm, onMemberSelect: onMemberSelect, updateNetBalance: updateNetBalance,
    saveTransfer: saveTransfer, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateTransfer: duplicateTransfer
  };
})();
