// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: FORM
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferForm = (function () {

  var particulars = [''];

  function renderParticulars() {
    var container = document.getElementById('mbtt-particulars-container');
    if (!container) return;
    
    container.innerHTML = '';
    particulars.forEach(function(part, idx) {
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
      input.placeholder = 'Enter particular...';
      input.value = part;
      input.oninput = function() {
        particulars[idx] = this.value;
      };
      
      row.appendChild(input);
      
      if (idx === 0) {
        var addBtn = document.createElement('button');
        addBtn.type = 'button';
        addBtn.className = 'mbtt-action-btn mbtt-action-primary';
        addBtn.style.whiteSpace = 'nowrap';
        addBtn.style.padding = '0 16px';
        addBtn.style.height = '30px';
        addBtn.style.display = 'flex';
        addBtn.style.alignItems = 'center';
        addBtn.style.gap = '4px';
        addBtn.innerHTML = '<i class="bi bi-plus-lg"></i> Add';
        addBtn.onclick = function() {
          addParticularRow();
        };
        row.appendChild(addBtn);
      } else {
        var deleteBtn = document.createElement('button');
        deleteBtn.type = 'button';
        deleteBtn.className = 'mbtt-action-btn mbtt-action-danger';
        deleteBtn.style.whiteSpace = 'nowrap';
        deleteBtn.style.padding = '0 12px';
        deleteBtn.style.height = '30px';
        deleteBtn.style.display = 'flex';
        deleteBtn.style.alignItems = 'center';
        deleteBtn.style.justifyContent = 'center';
        deleteBtn.innerHTML = '<i class="bi bi-trash"></i>';
        deleteBtn.onclick = function() {
          removeParticularRow(idx);
        };
        row.appendChild(deleteBtn);
      }
      
      container.appendChild(row);
    });
  }

  function addParticularRow() {
    particulars.push('');
    renderParticulars();
    var container = document.getElementById('mbtt-particulars-container');
    if (container && container.lastChild) {
      var input = container.lastChild.querySelector('input');
      if (input) input.focus();
    }
  }

  function removeParticularRow(idx) {
    if (idx > 0) {
      particulars.splice(idx, 1);
      renderParticulars();
    }
  }

  function getBillTypes() {
    var types = ['Maintenance', 'Clubhouse', 'Major Repair'];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        var keys = Object.keys(parsed);
        if (keys.length > 0) types = keys;
      }
    } catch(e) {}
    return types;
  }

  function applyBillTypeFilters(valLeft, valRight) {
    var leftSel = document.getElementById('mbtt-left-billtype');
    var rightSel = document.getElementById('mbtt-right-billtype');
    if (!leftSel || !rightSel) return;

    var types = getBillTypes();

    // Re-populate Left excluding valRight
    var leftHtml = '';
    types.forEach(function(t) {
      if (t !== valRight) {
        leftHtml += '<option value="' + t + '">' + t + '</option>';
      }
    });
    leftSel.innerHTML = leftHtml;
    leftSel.value = valLeft;

    // Re-populate Right excluding valLeft
    var rightHtml = '';
    types.forEach(function(t) {
      if (t !== valLeft) {
        rightHtml += '<option value="' + t + '">' + t + '</option>';
      }
    });
    rightSel.innerHTML = rightHtml;
    rightSel.value = valRight;
  }

  function populateBillTypesDropdowns() {
    var leftSel = document.getElementById('mbtt-left-billtype');
    var rightSel = document.getElementById('mbtt-right-billtype');
    if (!leftSel || !rightSel) return;
    
    var types = getBillTypes();
    var html = '';
    types.forEach(function(t) {
      html += '<option value="' + t + '">' + t + '</option>';
    });
    
    leftSel.innerHTML = html;
    rightSel.innerHTML = html;
    
    if (types.length > 1) {
      rightSel.value = types[1];
    } else if (types.length > 0) {
      rightSel.value = types[0];
    }

    applyBillTypeFilters(leftSel.value, rightSel.value);

    leftSel.onchange = function() {
      applyBillTypeFilters(this.value, rightSel.value);
      updateGridFromPartition();
    };
    rightSel.onchange = function() {
      applyBillTypeFilters(leftSel.value, this.value);
      updateGridFromPartition();
    };
  }

  function updateGridFromPartition() {
    var leftBill = document.getElementById('mbtt-left-billtype').value || '';
    var leftTy = document.getElementById('mbtt-left-type').value || 'Debit';
    var leftPrin = parseFloat(document.getElementById('mbtt-left-principal').value) || 0;
    var leftInt = parseFloat(document.getElementById('mbtt-left-interest').value) || 0;
    var leftTot = leftPrin + leftInt;

    var rightBill = document.getElementById('mbtt-right-billtype').value || '';
    var rightTy = document.getElementById('mbtt-right-type').value || 'Credit';
    var rightPrin = parseFloat(document.getElementById('mbtt-right-principal').value) || 0;
    var rightInt = parseFloat(document.getElementById('mbtt-right-interest').value) || 0;
    var rightTot = rightPrin + rightInt;

    var tbody = document.getElementById('mbtt-grid-tbody');
    if (!tbody) return;

    var leftDr = (leftTy === 'Debit') ? leftTot : 0;
    var leftCr = (leftTy === 'Credit') ? leftTot : 0;
    var rightDr = (rightTy === 'Debit') ? rightTot : 0;
    var rightCr = (rightTy === 'Credit') ? rightTot : 0;

    var html = '';
    // Row 1: Left
    html += '<tr>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:center; background:#F5F5F5; color:#9E9E9E; font-weight:bold;">1</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; background:#FAFAFA; color:#616161;">A01</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; font-weight:bold; color:#1565C0;">' + leftBill + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold;">' + leftPrin.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold;">' + leftInt.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold; color:#C62828;">' + leftDr.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; text-align:right; font-family:monospace; font-weight:bold; color:#2E7D32;">' + leftCr.toFixed(2) + '</td>';
    html += '</tr>';

    // Row 2: Right
    html += '<tr>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:center; background:#F5F5F5; color:#9E9E9E; font-weight:bold;">2</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; background:#FAFAFA; color:#616161;">A02</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; font-weight:bold; color:#1565C0;">' + rightBill + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold;">' + rightPrin.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold;">' + rightInt.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold; color:#C62828;">' + rightDr.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; text-align:right; font-family:monospace; font-weight:bold; color:#2E7D32;">' + rightCr.toFixed(2) + '</td>';
    html += '</tr>';

    tbody.innerHTML = html;

    // Update footer totals
    document.getElementById('mbtt-net-prin').innerText = (leftPrin + rightPrin).toFixed(2);
    document.getElementById('mbtt-net-int').innerText = (leftInt + rightInt).toFixed(2);
    document.getElementById('mbtt-net-dr').innerText = (leftDr + rightDr).toFixed(2);
    document.getElementById('mbtt-net-cr').innerText = (leftCr + rightCr).toFixed(2);

    var diff = Math.abs(leftTot - rightTot);
    document.getElementById('mbtt-net-diff').innerText = diff.toFixed(2);
    if (diff !== 0) {
      document.getElementById('mbtt-net-diff').style.color = '#D32F2F';
    } else {
      document.getElementById('mbtt-net-diff').style.color = '#2E7D32';
    }
  }

  function calculateLeftTotal() {
    var prin = parseFloat(document.getElementById('mbtt-left-principal').value) || 0;
    var inter = parseFloat(document.getElementById('mbtt-left-interest').value) || 0;
    document.getElementById('mbtt-left-total').value = (prin + inter).toFixed(2);
    updateGridFromPartition();
  }

  function calculateRightTotal() {
    var prin = parseFloat(document.getElementById('mbtt-right-principal').value) || 0;
    var inter = parseFloat(document.getElementById('mbtt-right-interest').value) || 0;
    document.getElementById('mbtt-right-total').value = (prin + inter).toFixed(2);
    updateGridFromPartition();
  }

  function onLeftTypeChange() {
    var leftVal = document.getElementById('mbtt-left-type').value;
    document.getElementById('mbtt-right-type').value = (leftVal === 'Debit') ? 'Credit' : 'Debit';
    updateGridFromPartition();
  }

  function onRightTypeChange() {
    var rightVal = document.getElementById('mbtt-right-type').value;
    document.getElementById('mbtt-left-type').value = (rightVal === 'Debit') ? 'Credit' : 'Debit';
    updateGridFromPartition();
  }

  function initForm() {
    populateMembersDropdown();
    populateBillTypesDropdowns();
    
    var vNo = MemberBillTypeTransferState.getActiveVoucher();
    var t = MemberBillTypeTransferState.getTransfer(vNo);

    if (t) {
      document.getElementById('mbtt-form-edit-id').value = t.id;
      document.getElementById('mbtt-form-vno').value = t.voucherNo;
      document.getElementById('mbtt-form-date').value = t.date;
      document.getElementById('mbtt-form-membercode').value = t.memberCode;
      document.getElementById('mbtt-form-membername').value = t.memberCode;
      
      // Legacy translation & loading Left/Right partition values
      var leftBill = t.leftBillType || (t.lineItems && t.lineItems[0] ? t.lineItems[0].accountName : 'Maintenance');
      var leftTy = t.leftType || t.type || 'Debit';
      var leftPrin = t.leftPrincipal !== undefined ? t.leftPrincipal : (t.lineItems && t.lineItems[0] ? (t.lineItems[0].principal || t.amount) : t.amount);
      var leftInt = t.leftInterest !== undefined ? t.leftInterest : (t.lineItems && t.lineItems[0] ? (t.lineItems[0].interest || 0) : 0);
      
      var rightBill = t.rightBillType || (t.lineItems && t.lineItems[1] ? t.lineItems[1].accountName : 'Clubhouse');
      var rightTy = t.rightType || (leftTy === 'Debit' ? 'Credit' : 'Debit');
      var rightPrin = t.rightPrincipal !== undefined ? t.rightPrincipal : leftPrin;
      var rightInt = t.rightInterest !== undefined ? t.rightInterest : leftInt;

      // Re-populate all options temporarily to allow setting the selected values correctly on load
      var types = getBillTypes();
      var html = '';
      types.forEach(function(typeOpt) { html += '<option value="' + typeOpt + '">' + typeOpt + '</option>'; });
      document.getElementById('mbtt-left-billtype').innerHTML = html;
      document.getElementById('mbtt-right-billtype').innerHTML = html;

      document.getElementById('mbtt-left-billtype').value = leftBill;
      document.getElementById('mbtt-left-type').value = leftTy;
      document.getElementById('mbtt-left-principal').value = parseFloat(leftPrin).toFixed(2);
      document.getElementById('mbtt-left-interest').value = parseFloat(leftInt).toFixed(2);
      calculateLeftTotal();

      document.getElementById('mbtt-right-billtype').value = rightBill;
      document.getElementById('mbtt-right-type').value = rightTy;
      document.getElementById('mbtt-right-principal').value = parseFloat(rightPrin).toFixed(2);
      document.getElementById('mbtt-right-interest').value = parseFloat(rightInt).toFixed(2);
      calculateRightTotal();

      // Now apply the correct filters
      applyBillTypeFilters(leftBill, rightBill);

      if (t.particulars && Array.isArray(t.particulars)) {
        particulars = t.particulars.slice();
      } else {
        particulars = [];
        if (t.particular1) particulars.push(t.particular1);
        if (t.particular2) particulars.push(t.particular2);
      }
      if (particulars.length === 0) particulars = [''];
      renderParticulars();

      document.getElementById('mbtt-form-status-badge').innerText = 'Posted';
      document.getElementById('mbtt-form-status-badge').className = 'mbtt-status-badge mbtt-status-posted';

      onMemberSelect();

    } else {
      document.getElementById('mbtt-form-edit-id').value = '';
      document.getElementById('mbtt-form-vno').value = 'Loading...';
      fetch('http://localhost:5002/api/bill-transfers/next-no')
        .then(function(res) { return res.json(); })
        .then(function(res) {
          if (res.success) {
            document.getElementById('mbtt-form-vno').value = res.transferNo;
          } else {
            document.getElementById('mbtt-form-vno').value = MemberBillTypeTransferMockData.getNextVoucherNo();
          }
        })
        .catch(function(err) {
          console.error(err);
          document.getElementById('mbtt-form-vno').value = MemberBillTypeTransferMockData.getNextVoucherNo();
        });
      document.getElementById('mbtt-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('mbtt-form-membercode').value = '';
      document.getElementById('mbtt-form-membername').value = '';
      
      document.getElementById('mbtt-left-type').value = 'Debit';
      document.getElementById('mbtt-left-principal').value = '0.00';
      document.getElementById('mbtt-left-interest').value = '0.00';
      calculateLeftTotal();

      document.getElementById('mbtt-right-type').value = 'Credit';
      document.getElementById('mbtt-right-principal').value = '0.00';
      document.getElementById('mbtt-right-interest').value = '0.00';
      calculateRightTotal();

      particulars = [''];
      renderParticulars();

      document.getElementById('mbtt-form-status-badge').innerText = 'Draft';
      document.getElementById('mbtt-form-status-badge').className = 'mbtt-status-badge mbtt-status-draft';

      resetLedgerPanel();
    }
  }

  function populateMembersDropdown() {
    var selCode = document.getElementById('mbtt-form-membercode');
    var selName = document.getElementById('mbtt-form-membername');
    var members = MemberBillTypeTransferMockData.getMembers();
    
    selCode.innerHTML = '<option value="">— Select —</option>';
    selName.innerHTML = '<option value="">— Select —</option>';
    
    members.forEach(function(m) {
      selCode.innerHTML += '<option value="' + m.code + '">' + m.code + '</option>';
      selName.innerHTML += '<option value="' + m.code + '">' + m.name + '</option>';
    });
  }

  function onMemberSelect() {
    var code = document.getElementById('mbtt-form-membercode').value;
    if(!code) { resetLedgerPanel(); return; }

    var m = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code; });
    if(m) {
      document.getElementById('mbtt-form-membername').value = code;
      document.getElementById('mbtt-hdr-name').innerText = m.name;
      document.getElementById('mbtt-hdr-prin').innerText = '₹' + parseFloat(m.principal || 0).toFixed(2);
      document.getElementById('mbtt-hdr-int').innerText = '₹' + parseFloat(m.interest || 0).toFixed(2);
      document.getElementById('mbtt-hdr-tot').innerText = '₹' + parseFloat(m.total || 0).toFixed(2);
      
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

  function onMemberNameSelect() {
    var code = document.getElementById('mbtt-form-membername').value;
    document.getElementById('mbtt-form-membercode').value = code;
    onMemberSelect();
  }

  function resetLedgerPanel() {
    document.getElementById('mbtt-form-membercode').value = '';
    document.getElementById('mbtt-form-membername').value = '';
    document.getElementById('mbtt-hdr-name').innerText = '-';
    document.getElementById('mbtt-hdr-prin').innerText = '₹0.00';
    document.getElementById('mbtt-hdr-int').innerText = '₹0.00';
    document.getElementById('mbtt-hdr-tot').innerText = '₹0.00';
    var tbody = document.getElementById('mbtt-ledger-tbody');
    if(tbody) tbody.innerHTML = '<tr><td colspan="5" style="text-align:center;color:#9E9E9E;">Select member to view ledger</td></tr>';
  }

  function updateNetBalance() {
    // Legacy support: not needed in partition layout
  }

  function gatherFormData() {
    var code = document.getElementById('mbtt-form-membercode').value;
    if(!code) { JeevikaDialog.alert('Please select a member.', 'Validation'); return null; }

    var m = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code; });
    
    var leftBill = document.getElementById('mbtt-left-billtype').value;
    var rightBill = document.getElementById('mbtt-right-billtype').value;
    if (leftBill === rightBill) {
      JeevikaDialog.alert("Source and Destination Bill Types cannot be the same.", "Validation");
      return null;
    }

    var leftTy = document.getElementById('mbtt-left-type').value;
    var rightTy = document.getElementById('mbtt-right-type').value;
    if (leftTy === rightTy) {
      JeevikaDialog.alert("One side must be Debit and the other side must be Credit.", "Validation");
      return null;
    }

    var leftPrin = parseFloat(document.getElementById('mbtt-left-principal').value) || 0;
    var leftInt = parseFloat(document.getElementById('mbtt-left-interest').value) || 0;
    var leftTot = parseFloat(document.getElementById('mbtt-left-total').value) || 0;

    var rightPrin = parseFloat(document.getElementById('mbtt-right-principal').value) || 0;
    var rightInt = parseFloat(document.getElementById('mbtt-right-interest').value) || 0;
    var rightTot = parseFloat(document.getElementById('mbtt-right-total').value) || 0;

    if (leftTot <= 0) {
      JeevikaDialog.alert("Amount must be greater than zero.", "Validation");
      return null;
    }

    if (leftTot !== rightTot) {
      JeevikaDialog.alert("Left Side Total must equal Right Side Total.", "Validation");
      return null;
    }

    var filteredParts = particulars.map(function(p) { return p.trim(); }).filter(function(p) { return p.length > 0; });

    // Construct lineItems array for general compatibility with the backend/persistence
    var lineItems = [
      { sr: 1, code: 'A01', accountName: leftBill, principal: leftPrin, interest: leftInt, debit: (leftTy==='Debit')?leftTot:0, credit: (leftTy==='Credit')?leftTot:0 },
      { sr: 2, code: 'A02', accountName: rightBill, principal: rightPrin, interest: rightInt, debit: (rightTy==='Debit')?rightTot:0, credit: (rightTy==='Credit')?rightTot:0 }
    ];

    return {
      id: document.getElementById('mbtt-form-edit-id').value || null,
      voucherNo: document.getElementById('mbtt-form-vno').value,
      date: document.getElementById('mbtt-form-date').value,
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      amount: leftTot,
      particular1: filteredParts[0] || '',
      particular2: filteredParts[1] || '',
      particulars: filteredParts,
      
      // Left side
      leftBillType: leftBill,
      leftType: leftTy,
      leftPrincipal: leftPrin,
      leftInterest: leftInt,
      leftTotal: leftTot,

      // Right side
      rightBillType: rightBill,
      rightType: rightTy,
      rightPrincipal: rightPrin,
      rightInterest: rightInt,
      rightTotal: rightTot,

      lineItems: lineItems,
      status: 'Posted'
    };
  }

  async function saveTransfer() {
    var obj = gatherFormData();
    if(obj) {
      await MemberBillTypeTransferState.saveTransfer(obj);
      MemberBillTypeTransferRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      await MemberBillTypeTransferState.saveTransfer(obj);
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
    initForm: initForm, onMemberSelect: onMemberSelect, onMemberNameSelect: onMemberNameSelect, updateNetBalance: updateNetBalance,
    saveTransfer: saveTransfer, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateTransfer: duplicateTransfer,
    onLeftTypeChange: onLeftTypeChange, onRightTypeChange: onRightTypeChange,
    calculateLeftTotal: calculateLeftTotal, calculateRightTotal: calculateRightTotal
  };
})();
