// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: FORM
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferForm = (function () {

  var particulars = ['', ''];

  function renderParticulars() {
    var container = document.getElementById('mbtt-particulars-container');
    if (!container) return;
    
    container.innerHTML = '';
    particulars.forEach(function(part, idx) {
      var row = document.createElement('div');
      row.style.display = 'flex';
      row.style.gap = '10px';
      row.style.width = '100%';
      row.style.alignItems = 'center';
      
      var input = document.createElement('input');
      input.type = 'text';
      input.id = 'mbtt-form-part' + (idx === 0 ? '1' : '2');
      input.style.flex = '1';
      input.style.height = '30px';
      input.style.border = '1px solid #CFD8DC';
      input.style.borderRadius = '4px';
      input.style.padding = '4px 8px';
      input.style.fontSize = '12px';
      input.style.outline = 'none';
      input.placeholder = 'Particulars ' + (idx + 1) + '...';
      input.value = part;
      input.oninput = function() {
        particulars[idx] = this.value;
      };
      
      row.appendChild(input);
      
      var btn = document.createElement('div');
      btn.id = 'mbtt-particular' + (idx + 1) + '-shortcut-btn';
      btn.style.width = '100px';
      btn.style.background = '#E0E0E0';
      btn.style.border = '1px solid #BDBDBD';
      btn.style.borderRadius = '4px';
      btn.style.textAlign = 'center';
      btn.style.padding = '4px';
      btn.style.fontSize = '10px';
      btn.style.fontWeight = 'bold';
      btn.style.cursor = 'pointer';
      btn.style.color = '#424242';
      btn.style.userSelect = 'none';
      btn.style.transition = 'background 0.2s';
      btn.style.height = '30px';
      btn.style.lineHeight = '20px';
      btn.style.flexShrink = '0';
      btn.innerText = 'Ctrl + L';
      btn.title = 'Click to repeat last Particular ' + (idx + 1);
      btn.onmouseover = function() { this.style.background = '#D5D5D5'; };
      btn.onmouseout = function() { this.style.background = '#E0E0E0'; };
      btn.onclick = function() {
        if (idx === 0) {
          repeatLastParticular1();
        } else {
          repeatLastParticular2();
        }
      };
      row.appendChild(btn);
      
      container.appendChild(row);
    });
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
    
    var code1 = (document.getElementById('mbtt-form-membercode') || {}).value || '';
    var code2 = (document.getElementById('mbtt-form-membercode2') || {}).value || '';
    var isSameMember = (code1 && code2 && code1 === code2);

    // Re-populate Left: exclude valRight only if they are the same member
    var leftHtml = '';
    types.forEach(function(t) {
      if (!isSameMember || t !== valRight) {
        leftHtml += '<option value="' + t + '">' + t + '</option>';
      }
    });
    leftSel.innerHTML = leftHtml;
    leftSel.value = valLeft;

    // Re-populate Right: exclude valLeft only if they are the same member
    var rightHtml = '';
    types.forEach(function(t) {
      if (!isSameMember || t !== valLeft) {
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

    var code1 = document.getElementById('mbtt-form-membercode').value || '—';
    var code2 = document.getElementById('mbtt-form-membercode2').value || '—';

    var tbody = document.getElementById('mbtt-grid-tbody');
    if (!tbody) return;

    var leftDr = (leftTy === 'Debit') ? leftTot : 0;
    var leftCr = (leftTy === 'Credit') ? leftTot : 0;
    var rightDr = (rightTy === 'Debit') ? rightTot : 0;
    var rightCr = (rightTy === 'Credit') ? rightTot : 0;

    var html = '';
    // Row 1: Left (1st Member)
    html += '<tr>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:center; background:#F5F5F5; color:#9E9E9E; font-weight:bold;">1</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; background:#FAFAFA; color:#0D47A1; font-weight:bold;">' + code1 + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; font-weight:bold; color:#1565C0;">' + leftBill + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold;">' + leftPrin.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold;">' + leftInt.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:right; font-family:monospace; font-weight:bold; color:#C62828;">' + leftDr.toFixed(2) + '</td>';
    html += '<td style="padding:6px 8px; text-align:right; font-family:monospace; font-weight:bold; color:#2E7D32;">' + leftCr.toFixed(2) + '</td>';
    html += '</tr>';

    // Row 2: Right (2nd Member)
    html += '<tr>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; text-align:center; background:#F5F5F5; color:#9E9E9E; font-weight:bold;">2</td>';
    html += '<td style="padding:6px 8px; border-right:1px solid #CFD8DC; background:#FAFAFA; color:#2E7D32; font-weight:bold;">' + code2 + '</td>';
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

      // --- Restore metadata from narration ---
      var rawNarr = t.narration || '';
      var code2 = '';
      var transType = 'Cash';
      var chqNo = '';
      var chqDate = '';
      var bank = '';
      var refNo = '';
      var part1 = t.particular1 || '';
      var part2 = t.particular2 || '';

      if (rawNarr.indexOf('|| METADATA:') > -1) {
        var nParts = rawNarr.split('|| METADATA:');
        try {
          var meta = JSON.parse(nParts[1]);
          code2 = meta.memberCode2 || '';
          transType = meta.transType || 'Cash';
          chqNo = meta.chqNo || '';
          chqDate = meta.chqDate || '';
          bank = meta.bank || '';
          refNo = meta.refNo || '';
          part1 = meta.part1 || part1;
          part2 = meta.part2 || part2;
        } catch (e) { console.error('Meta parse error', e); }
      }

      // Populate 2nd member
      document.getElementById('mbtt-form-membercode2').value = code2;
      document.getElementById('mbtt-form-membername2').value = code2;

      // Populate bank fields
      document.getElementById('mbtt-form-transtype').value = transType;
      document.getElementById('mbtt-form-chqno').value = chqNo;
      document.getElementById('mbtt-form-chqdate').value = chqDate;
      document.getElementById('mbtt-form-bank').value = bank;
      document.getElementById('mbtt-form-refno').value = refNo;

      // Populate narration fields
      document.getElementById('mbtt-form-part1').value = part1;
      document.getElementById('mbtt-form-part2').value = part2;
      
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

      // Legacy particulars array (kept for backward compat but we use part1/part2 now)
      particulars = [part1, part2];
      while (particulars.length < 2) particulars.push('');
      particulars = particulars.slice(0, 2);
      renderParticulars();

      document.getElementById('mbtt-form-status-badge').innerText = 'Posted';
      document.getElementById('mbtt-form-status-badge').className = 'mbtt-status-badge mbtt-status-posted';

      onMember1Select();
      onMember2Select();

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
      document.getElementById('mbtt-form-membercode2').value = '';
      document.getElementById('mbtt-form-membername2').value = '';

      // Reset bank fields
      document.getElementById('mbtt-form-transtype').value = 'Cash';
      document.getElementById('mbtt-form-chqno').value = '';
      document.getElementById('mbtt-form-chqdate').value = '';
      document.getElementById('mbtt-form-bank').value = '';
      document.getElementById('mbtt-form-refno').value = '';

      // Reset narration fields
      document.getElementById('mbtt-form-part1').value = '';
      document.getElementById('mbtt-form-part2').value = '';
      
      document.getElementById('mbtt-left-type').value = 'Debit';
      document.getElementById('mbtt-left-principal').value = '0.00';
      document.getElementById('mbtt-left-interest').value = '0.00';
      calculateLeftTotal();

      document.getElementById('mbtt-right-type').value = 'Credit';
      document.getElementById('mbtt-right-principal').value = '0.00';
      document.getElementById('mbtt-right-interest').value = '0.00';
      calculateRightTotal();

      particulars = ['', ''];
      renderParticulars();

      document.getElementById('mbtt-form-status-badge').innerText = 'Draft';
      document.getElementById('mbtt-form-status-badge').className = 'mbtt-status-badge mbtt-status-draft';

      resetLedgerPanel();
    }
  }

  function populateMembersDropdown() {
    var members = MemberBillTypeTransferMockData.getMembers();
    var defaultOpt = '<option value="">— Select —</option>';
    var codeOpts = '';
    var nameOpts = '';
    members.forEach(function(m) {
      codeOpts += '<option value="' + m.code + '">' + m.code + '</option>';
      nameOpts += '<option value="' + m.code + '">' + m.name + '</option>';
    });

    // 1st Member
    document.getElementById('mbtt-form-membercode').innerHTML = defaultOpt + codeOpts;
    document.getElementById('mbtt-form-membername').innerHTML = defaultOpt + nameOpts;
    // 2nd Member
    document.getElementById('mbtt-form-membercode2').innerHTML = defaultOpt + codeOpts;
    document.getElementById('mbtt-form-membername2').innerHTML = defaultOpt + nameOpts;
  }

  // --- 1st Member Selection ---
  function onMember1CodeSelect() {
    var code = document.getElementById('mbtt-form-membercode').value;
    document.getElementById('mbtt-form-membername').value = code;
    onMember1Select();
  }
  function onMember1NameSelect() {
    var code = document.getElementById('mbtt-form-membername').value;
    document.getElementById('mbtt-form-membercode').value = code;
    onMember1Select();
  }
  function onMember1Select() {
    var code = document.getElementById('mbtt-form-membercode').value;
    var nameEl = document.getElementById('mbtt-m1-name');
    var flatEl = document.getElementById('mbtt-m1-flat');
    var mobEl = document.getElementById('mbtt-m1-mob');
    var tbody = document.getElementById('mbtt-m1-balances-tbody');
    if (!code) {
      if (nameEl) nameEl.innerText = '—';
      if (flatEl) flatEl.innerText = '—';
      if (mobEl) mobEl.innerText = '—';
      if (tbody) tbody.innerHTML = '<tr><td colspan="4" style="text-align:center;padding:6px;color:#9E9E9E;">No member selected</td></tr>';
      updateGridFromPartition();
      return;
    }
    var m = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code; });
    if (m) {
      if (nameEl) nameEl.innerText = m.name;
      if (flatEl) flatEl.innerText = m.wingFlat || '—';
      if (mobEl) mobEl.innerText = (m.mobile1 || '—') + (m.mobile2 ? ', ' + m.mobile2 : '');
      if (tbody) {
        var bHtml = '';
        var billTypes = getBillTypes();
        billTypes.forEach(function(bt) {
          var prin = parseFloat(m.principal || 0) / billTypes.length;
          var int_ = parseFloat(m.interest || 0) / billTypes.length;
          bHtml += '<tr>';
          bHtml += '<td style="padding:3px 4px;border-bottom:1px solid #E0E0E0;">' + bt + '</td>';
          bHtml += '<td style="padding:3px 4px;text-align:right;border-bottom:1px solid #E0E0E0;font-family:monospace;">' + prin.toFixed(2) + '</td>';
          bHtml += '<td style="padding:3px 4px;text-align:right;border-bottom:1px solid #E0E0E0;font-family:monospace;">' + int_.toFixed(2) + '</td>';
          bHtml += '<td style="padding:3px 4px;text-align:right;border-bottom:1px solid #E0E0E0;font-family:monospace;font-weight:bold;">' + (prin + int_).toFixed(2) + '</td>';
          bHtml += '</tr>';
        });
        tbody.innerHTML = bHtml;
      }
    }
    var leftSel = document.getElementById('mbtt-left-billtype');
    var rightSel = document.getElementById('mbtt-right-billtype');
    if (leftSel && rightSel) {
      applyBillTypeFilters(leftSel.value, rightSel.value);
    }
    updateGridFromPartition();
  }

  // --- 2nd Member Selection ---
  function onMember2CodeSelect() {
    var code = document.getElementById('mbtt-form-membercode2').value;
    document.getElementById('mbtt-form-membername2').value = code;
    onMember2Select();
  }
  function onMember2NameSelect() {
    var code = document.getElementById('mbtt-form-membername2').value;
    document.getElementById('mbtt-form-membercode2').value = code;
    onMember2Select();
  }
  function onMember2Select() {
    var code = document.getElementById('mbtt-form-membercode2').value;
    var nameEl = document.getElementById('mbtt-m2-name');
    var flatEl = document.getElementById('mbtt-m2-flat');
    var mobEl = document.getElementById('mbtt-m2-mob');
    var tbody = document.getElementById('mbtt-m2-balances-tbody');
    if (!code) {
      if (nameEl) nameEl.innerText = '—';
      if (flatEl) flatEl.innerText = '—';
      if (mobEl) mobEl.innerText = '—';
      if (tbody) tbody.innerHTML = '<tr><td colspan="4" style="text-align:center;padding:6px;color:#9E9E9E;">No member selected</td></tr>';
      updateGridFromPartition();
      return;
    }
    var m = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code; });
    if (m) {
      if (nameEl) nameEl.innerText = m.name;
      if (flatEl) flatEl.innerText = m.wingFlat || '—';
      if (mobEl) mobEl.innerText = (m.mobile1 || '—') + (m.mobile2 ? ', ' + m.mobile2 : '');
      if (tbody) {
        var bHtml = '';
        var billTypes = getBillTypes();
        billTypes.forEach(function(bt) {
          var prin = parseFloat(m.principal || 0) / billTypes.length;
          var int_ = parseFloat(m.interest || 0) / billTypes.length;
          bHtml += '<tr>';
          bHtml += '<td style="padding:3px 4px;border-bottom:1px solid #E0E0E0;">' + bt + '</td>';
          bHtml += '<td style="padding:3px 4px;text-align:right;border-bottom:1px solid #E0E0E0;font-family:monospace;">' + prin.toFixed(2) + '</td>';
          bHtml += '<td style="padding:3px 4px;text-align:right;border-bottom:1px solid #E0E0E0;font-family:monospace;">' + int_.toFixed(2) + '</td>';
          bHtml += '<td style="padding:3px 4px;text-align:right;border-bottom:1px solid #E0E0E0;font-family:monospace;font-weight:bold;">' + (prin + int_).toFixed(2) + '</td>';
          bHtml += '</tr>';
        });
        tbody.innerHTML = bHtml;
      }
    }
    var leftSel = document.getElementById('mbtt-left-billtype');
    var rightSel = document.getElementById('mbtt-right-billtype');
    if (leftSel && rightSel) {
      applyBillTypeFilters(leftSel.value, rightSel.value);
    }
    updateGridFromPartition();
  }

  // Legacy compat wrappers
  function onMemberSelect() { onMember1Select(); }
  function onMemberNameSelect() { onMember1NameSelect(); }

  function resetLedgerPanel() {
    // Reset 1st member sidebar
    var m1Name = document.getElementById('mbtt-m1-name');
    var m1Flat = document.getElementById('mbtt-m1-flat');
    var m1Mob = document.getElementById('mbtt-m1-mob');
    var m1Tbody = document.getElementById('mbtt-m1-balances-tbody');
    if (m1Name) m1Name.innerText = '—';
    if (m1Flat) m1Flat.innerText = '—';
    if (m1Mob) m1Mob.innerText = '—';
    if (m1Tbody) m1Tbody.innerHTML = '<tr><td colspan="4" style="text-align:center;padding:6px;color:#9E9E9E;">No member selected</td></tr>';

    // Reset 2nd member sidebar
    var m2Name = document.getElementById('mbtt-m2-name');
    var m2Flat = document.getElementById('mbtt-m2-flat');
    var m2Mob = document.getElementById('mbtt-m2-mob');
    var m2Tbody = document.getElementById('mbtt-m2-balances-tbody');
    if (m2Name) m2Name.innerText = '—';
    if (m2Flat) m2Flat.innerText = '—';
    if (m2Mob) m2Mob.innerText = '—';
    if (m2Tbody) m2Tbody.innerHTML = '<tr><td colspan="4" style="text-align:center;padding:6px;color:#9E9E9E;">No member selected</td></tr>';
  }

  function updateNetBalance() {
    // Legacy support: not needed in partition layout
  }

  function gatherFormData() {
    var code = document.getElementById('mbtt-form-membercode').value;
    if(!code) { JeevikaDialog.alert('Please select Member (Debit Voucher).', 'Validation'); return null; }

    var code2 = document.getElementById('mbtt-form-membercode2').value;
    if(!code2) { JeevikaDialog.alert('Please select Member (Credit Voucher).', 'Validation'); return null; }

    var m = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code; });
    var m2 = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === code2; });
    
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

    // Collect narration fields
    var part1 = (document.getElementById('mbtt-form-part1').value || '').trim();
    var part2 = (document.getElementById('mbtt-form-part2').value || '').trim();

    // Pack metadata into narration for backend persistence
    var metaObj = {
      memberCode2: code2,
      memberName2: m2 ? m2.name : '',
      transType: document.getElementById('mbtt-form-transtype').value || 'Cash',
      chqNo: (document.getElementById('mbtt-form-chqno').value || '').trim(),
      chqDate: document.getElementById('mbtt-form-chqdate').value || '',
      bank: (document.getElementById('mbtt-form-bank').value || '').trim(),
      refNo: (document.getElementById('mbtt-form-refno').value || '').trim(),
      part1: part1,
      part2: part2
    };
    var narration = (part1 || '') + ' || METADATA:' + JSON.stringify(metaObj);

    // Construct lineItems array for general compatibility with the backend/persistence
    var lineItems = [
      { sr: 1, code: code, accountName: leftBill, principal: leftPrin, interest: leftInt, debit: (leftTy==='Debit')?leftTot:0, credit: (leftTy==='Credit')?leftTot:0 },
      { sr: 2, code: code2, accountName: rightBill, principal: rightPrin, interest: rightInt, debit: (rightTy==='Debit')?rightTot:0, credit: (rightTy==='Credit')?rightTot:0 }
    ];

    return {
      id: document.getElementById('mbtt-form-edit-id').value || null,
      voucherNo: document.getElementById('mbtt-form-vno').value,
      date: document.getElementById('mbtt-form-date').value,
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      amount: leftTot,
      narration: narration,
      particular1: part1,
      particular2: part2,
      particulars: [part1, part2].filter(function(p) { return p.length > 0; }),
      
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

  function repeatLastParticular1() {
    var code = document.getElementById('mbtt-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var transfers = MemberBillTypeTransferMockData.getTransfers() || [];
    var currentNo = document.getElementById('mbtt-form-vno').value;

    var memberTransfers = transfers.filter(function(t) {
      return t.memberCode === code && t.voucherNo !== currentNo && t.particular1;
    });

    if (memberTransfers.length > 0) {
      memberTransfers.sort(function(a, b) {
        return new Date(b.date) - new Date(a.date);
      });
      var lastVal = memberTransfers[0].particular1;
      particulars[0] = lastVal;
      var el = document.getElementById('mbtt-form-part1');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 1 found for this member.");
    }
  }

  function repeatLastParticular2() {
    var code = document.getElementById('mbtt-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var transfers = MemberBillTypeTransferMockData.getTransfers() || [];
    var currentNo = document.getElementById('mbtt-form-vno').value;

    var memberTransfers = transfers.filter(function(t) {
      return t.memberCode === code && t.voucherNo !== currentNo && t.particular2;
    });

    if (memberTransfers.length > 0) {
      memberTransfers.sort(function(a, b) {
        return new Date(b.date) - new Date(a.date);
      });
      var lastVal = memberTransfers[0].particular2;
      particulars[1] = lastVal;
      var el = document.getElementById('mbtt-form-part2');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 2 found for this member.");
    }
  }

  return {
    initForm: initForm, onMemberSelect: onMemberSelect, onMemberNameSelect: onMemberNameSelect, updateNetBalance: updateNetBalance,
    onMember1CodeSelect: onMember1CodeSelect, onMember1NameSelect: onMember1NameSelect,
    onMember2CodeSelect: onMember2CodeSelect, onMember2NameSelect: onMember2NameSelect,
    saveTransfer: saveTransfer, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateTransfer: duplicateTransfer,
    onLeftTypeChange: onLeftTypeChange, onRightTypeChange: onRightTypeChange,
    calculateLeftTotal: calculateLeftTotal, calculateRightTotal: calculateRightTotal,
    repeatLastParticular1: repeatLastParticular1, repeatLastParticular2: repeatLastParticular2
  };
})();
