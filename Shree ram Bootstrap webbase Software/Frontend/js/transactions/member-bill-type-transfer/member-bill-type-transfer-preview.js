// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: PREVIEW
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferPreview = (function () {

  function render() {
    var vNo = MemberBillTypeTransferState.getActiveVoucher();
    var t = MemberBillTypeTransferState.getTransfer(vNo);
    if(!t) return;

    // Legacy translation & loading Left/Right partition values
    var leftBill = t.leftBillType || (t.lineItems && t.lineItems[0] ? t.lineItems[0].accountName : 'Maintenance');
    var leftTy = t.leftType || t.type || 'Debit';
    var leftPrin = t.leftPrincipal !== undefined ? t.leftPrincipal : (t.lineItems && t.lineItems[0] ? (t.lineItems[0].principal || t.amount) : t.amount);
    var leftInt = t.leftInterest !== undefined ? t.leftInterest : (t.lineItems && t.lineItems[0] ? (t.lineItems[0].interest || 0) : 0);
    var leftTotal = t.leftTotal !== undefined ? t.leftTotal : (parseFloat(leftPrin) + parseFloat(leftInt));

    var rightBill = t.rightBillType || (t.lineItems && t.lineItems[1] ? t.lineItems[1].accountName : 'Clubhouse');
    var rightTy = t.rightType || (leftTy === 'Debit' ? 'Credit' : 'Debit');
    var rightPrin = t.rightPrincipal !== undefined ? t.rightPrincipal : leftPrin;
    var rightInt = t.rightInterest !== undefined ? t.rightInterest : leftInt;
    var rightTotal = t.rightTotal !== undefined ? t.rightTotal : (parseFloat(rightPrin) + parseFloat(rightInt));

    var leftDeb = (leftTy === 'Debit') ? leftTotal : 0;
    var leftCred = (leftTy === 'Credit') ? leftTotal : 0;
    var rightDeb = (rightTy === 'Debit') ? rightTotal : 0;
    var rightCred = (rightTy === 'Credit') ? rightTotal : 0;

    var dT = leftDeb + rightDeb;
    var cT = leftCred + rightCred;

    var html = '<div class="mbtt-invoice-page">';
    
    html += '<div class="mbtt-invoice-header">';
    html += '<div class="mbtt-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="mbtt-invoice-title-bar">MEMBER TRANSFER VOUCHER</div>';
    html += '</div>';

    html += '<div class="mbtt-invoice-info-grid">';
    html += '<div class="mbtt-invoice-info-left"><table class="mbtt-invoice-info-table">';
    html += '<tr><td class="mbtt-info-label">Member Name</td><td class="mbtt-info-value"><strong>' + t.memberName + '</strong></td></tr>';
    html += '<tr><td class="mbtt-info-label">Flat / Wing</td><td class="mbtt-info-value">' + t.wingFlat + '</td></tr>';
    html += '<tr><td class="mbtt-info-label">Member Code</td><td class="mbtt-info-value">' + t.memberCode + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mbtt-invoice-info-right"><table class="mbtt-invoice-info-table">';
    html += '<tr><td class="mbtt-info-label">Voucher No</td><td class="mbtt-info-value"><strong>' + t.voucherNo + '</strong></td></tr>';
    html += '<tr><td class="mbtt-info-label">Date</td><td class="mbtt-info-value">' + window.formatDateToDDMMYYYY(t.date) + '</td></tr>';
    html += '<tr><td class="mbtt-info-label">Type</td><td class="mbtt-info-value">' + leftTy + ' / ' + rightTy + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items
    html += '<table class="mbtt-invoice-items-table"><thead><tr>';
    html += '<th style="width:40px;text-align:center;">Sr</th><th>Account Name</th><th style="width:100px;text-align:right;">Debit (₹)</th><th style="width:100px;text-align:right;">Credit (₹)</th>';
    html += '</tr></thead><tbody>';

    // Left Side Row
    html += '<tr><td style="text-align:center;">1</td>';
    html += '<td>' + leftBill + ' (Principal: ₹' + parseFloat(leftPrin).toFixed(2) + ', Interest: ₹' + parseFloat(leftInt).toFixed(2) + ')</td>';
    html += '<td style="text-align:right;font-family:monospace;">' + leftDeb.toFixed(2) + '</td>';
    html += '<td style="text-align:right;font-family:monospace;">' + leftCred.toFixed(2) + '</td></tr>';

    // Right Side Row
    html += '<tr><td style="text-align:center;">2</td>';
    html += '<td>' + rightBill + ' (Principal: ₹' + parseFloat(rightPrin).toFixed(2) + ', Interest: ₹' + parseFloat(rightInt).toFixed(2) + ')</td>';
    html += '<td style="text-align:right;font-family:monospace;">' + rightDeb.toFixed(2) + '</td>';
    html += '<td style="text-align:right;font-family:monospace;">' + rightCred.toFixed(2) + '</td></tr>';
    
    html += '<tr style="font-weight:bold;background:#F5F5F5;">';
    html += '<td colspan="2" style="text-align:right;">TOTAL</td>';
    html += '<td style="text-align:right;color:#0D47A1;font-family:monospace;">' + dT.toFixed(2) + '</td>';
    html += '<td style="text-align:right;color:#0D47A1;font-family:monospace;">' + cT.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table>';

    // Second Table: Member Ledger Balances by Bill Type
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

    var allTypes = getBillTypes();
    if (allTypes.indexOf(leftBill) === -1) allTypes.push(leftBill);
    if (allTypes.indexOf(rightBill) === -1) allTypes.push(rightBill);

    var member = MemberBillTypeTransferMockData.getMembers().find(function(x) { return x.code === t.memberCode; });
    var memPrin = member ? parseFloat(member.principal || 0) : 0;
    var memInt = member ? parseFloat(member.interest || 0) : 0;

    html += '<h3 style="margin-top:24px; font-size:12px; font-weight:700; color:#0D47A1; border-bottom:2px solid #0D47A1; padding-bottom:4px; margin-bottom:12px; text-transform:uppercase;">Member Ledger Balances by Bill Type</h3>';

    var orderedTypes = [];
    orderedTypes.push(leftBill);
    if (rightBill !== leftBill) {
      orderedTypes.push(rightBill);
    }
    allTypes.forEach(function(bt) {
      if (bt !== leftBill && bt !== rightBill) {
        orderedTypes.push(bt);
      }
    });

    orderedTypes.forEach(function(bt) {
      var beforePrin = 0;
      var beforeInt = 0;
      if (bt.toLowerCase() === 'maintenance') {
        beforePrin = memPrin * 0.6;
        beforeInt = memInt * 0.6;
      } else if (bt.toLowerCase().replace(' ', '') === 'clubhouse') {
        beforePrin = memPrin * 0.3;
        beforeInt = memInt * 0.3;
      } else if (bt.toLowerCase().replace(' ', '') === 'majorrepair') {
        beforePrin = memPrin * 0.1;
        beforeInt = memInt * 0.1;
      }

      var effPrin = 0;
      var effInt = 0;
      var effSign = '';

      if (bt === leftBill) {
        effPrin = leftPrin;
        effInt = leftInt;
        effSign = (leftTy === 'Debit') ? '+' : '-';
      }
      if (bt === rightBill) {
        effPrin = rightPrin;
        effInt = rightInt;
        effSign = (rightTy === 'Debit') ? '+' : '-';
      }

      var afterPrin = beforePrin;
      var afterInt = beforeInt;
      if (effSign === '+') {
        afterPrin = beforePrin + effPrin;
        afterInt = beforeInt + effInt;
      } else if (effSign === '-') {
        afterPrin = beforePrin - effPrin;
        afterInt = beforeInt - effInt;
      }

      var beforeTot = beforePrin + beforeInt;
      var afterTot = afterPrin + afterInt;
      
      var labelSuffix = '';
      if (bt === leftBill) {
        labelSuffix = ' <span style="font-size:10px; color:#D32F2F; font-weight:bold; background:#FFEBEE; padding:2px 6px; border-radius:3px; margin-left:8px; border:1px solid #FFCDD2;">[Current One - Converting From]</span>';
      } else if (bt === rightBill) {
        labelSuffix = ' <span style="font-size:10px; color:#2E7D32; font-weight:bold; background:#E8F5E9; padding:2px 6px; border-radius:3px; margin-left:8px; border:1px solid #C8E6C9;">[Transferring Into]</span>';
      } else {
        labelSuffix = ' <span style="font-size:10px; color:#616161; font-weight:bold; background:#F5F5F5; padding:2px 6px; border-radius:3px; margin-left:8px; border:1px solid #E0E0E0;">[Other Bill Type]</span>';
      }

      var effPrinText = '—';
      var effIntText = '—';
      var effTotText = '—';
      var effStyle = 'color:#757575;';
      if (effSign !== '') {
        effPrinText = effSign + ' ' + effPrin.toFixed(2);
        effIntText = effSign + ' ' + effInt.toFixed(2);
        var effTotVal = effPrin + effInt;
        effTotText = effSign + ' ' + effTotVal.toFixed(2);
        effStyle = (effSign === '+') ? 'color:#C62828; font-weight:bold;' : 'color:#2E7D32; font-weight:bold;';
      }

      html += '<div style="margin-bottom:18px; border:1px solid #E0E0E0; border-radius:4px; overflow:hidden; background:white; box-shadow:0 1px 3px rgba(0,0,0,0.05);">';
      html += '  <div style="background:#F5F5F5; padding:6px 12px; border-bottom:1px solid #E0E0E0; font-size:12px; font-weight:bold; color:#37474F; display:flex; align-items:center;">';
      html += '    <i class="bi bi-tag-fill" style="color:#0D47A1; margin-right:6px;"></i>' + bt + labelSuffix;
      html += '  </div>';
      html += '  <table class="mbtt-invoice-items-table" style="margin-bottom:0; width:100%; border-collapse:collapse;">';
      html += '    <thead>';
      html += '      <tr style="background:#ECEFF1;">';
      html += '        <th style="background:#ECEFF1; color:#37474F; border:1px solid #CFD8DC; font-size:9px; width:25%;">Balance Component</th>';
      html += '        <th style="background:#ECEFF1; color:#37474F; border:1px solid #CFD8DC; font-size:9px; text-align:right; width:25%;">Before (₹)</th>';
      html += '        <th style="background:#ECEFF1; color:#37474F; border:1px solid #CFD8DC; font-size:9px; text-align:right; width:25%;">Effect (₹)</th>';
      html += '        <th style="background:#ECEFF1; color:#37474F; border:1px solid #CFD8DC; font-size:9px; text-align:right; width:25%;">After (₹)</th>';
      html += '      </tr>';
      html += '    </thead>';
      html += '    <tbody>';
      // Row 1: Principal
      html += '      <tr>';
      html += '        <td style="font-weight:600; color:#546E7A; padding:4px 8px;">Principal</td>';
      html += '        <td style="text-align:right; font-family:monospace; padding:4px 8px;">' + beforePrin.toFixed(2) + '</td>';
      html += '        <td style="text-align:right; font-family:monospace; padding:4px 8px; ' + effStyle + '">' + effPrinText + '</td>';
      html += '        <td style="text-align:right; font-family:monospace; padding:4px 8px; font-weight:600;">' + afterPrin.toFixed(2) + '</td>';
      html += '      </tr>';
      // Row 2: Interest
      html += '      <tr>';
      html += '        <td style="font-weight:600; color:#546E7A; padding:4px 8px;">Interest</td>';
      html += '        <td style="text-align:right; font-family:monospace; padding:4px 8px;">' + beforeInt.toFixed(2) + '</td>';
      html += '        <td style="text-align:right; font-family:monospace; padding:4px 8px; ' + effStyle + '">' + effIntText + '</td>';
      html += '        <td style="text-align:right; font-family:monospace; padding:4px 8px; font-weight:600;">' + afterInt.toFixed(2) + '</td>';
      html += '      </tr>';
      // Row 3: Total
      html += '      <tr style="background:#ECEFF1; font-weight:bold; border-top:1px solid #CFD8DC;">';
      html += '        <td style="color:#263238; padding:5px 8px;">Total</td>';
      html += '        <td style="text-align:right; font-family:monospace; color:#263238; padding:5px 8px;">' + beforeTot.toFixed(2) + '</td>';
      html += '        <td style="text-align:right; font-family:monospace; padding:5px 8px; ' + effStyle + '">' + effTotText + '</td>';
      html += '        <td style="text-align:right; font-family:monospace; color:#0D47A1; padding:5px 8px; font-size:12px;">' + afterTot.toFixed(2) + '</td>';
      html += '      </tr>';
      html += '    </tbody>';
      html += '  </table>';
      html += '</div>';
    });

    var particulars = [];
    if (t.particulars && Array.isArray(t.particulars)) {
      particulars = t.particulars.filter(function(p) { return p.trim().length > 0; });
    } else {
      if (t.particular1) particulars.push(t.particular1);
      if (t.particular2) particulars.push(t.particular2);
    }

    if(particulars.length > 0 || t.chqNo || t.bank) {
      html += '<div style="margin-bottom:16px;font-size:11px;color:#424242;padding:8px;border:1px solid #E0E0E0;background:#FAFAFA;">';
      if (particulars.length > 0) {
        html += '<div style="margin-bottom:4px;"><strong>Remarks:</strong> ' + particulars.join(' | ') + '</div>';
      }
      if(t.chqNo) html += '<div><strong>Cheque Details:</strong> Chq No: ' + t.chqNo + ' | Date: ' + (t.chqDate ? window.formatDateToDDMMYYYY(t.chqDate) : '-') + ' | Bank: ' + (t.bank||'-') + '</div>';
      if(t.billNo) html += '<div style="margin-top:4px;"><strong>Bill Ref:</strong> ' + t.billNo + '</div>';
      html += '</div>';
    }

    // Amount in words
    html += '<div style="margin-bottom:20px;">';
    html += '<div style="font-size:11px;font-weight:700;">Amount in words:</div>';
    html += '<div style="font-style:italic;">Rupees ' + numberToWords(dT) + ' Only</div>';
    html += '</div>';

    html += '<div class="mbtt-invoice-signatures">';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Prepared By</div></div>';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Checked By</div></div>';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('mbtt-preview-content').innerHTML = html;
  }

  function numberToWords(num) {
    if(num === 0) return 'Zero';
    var a = ['','One ','Two ','Three ','Four ','Five ','Six ','Seven ','Eight ','Nine ','Ten ','Eleven ','Twelve ','Thirteen ','Fourteen ','Fifteen ','Sixteen ','Seventeen ','Eighteen ','Nineteen '];
    var b = ['','','Twenty','Thirty','Forty','Fifty','Sixty','Seventy','Eighty','Ninety'];
    var n = Math.floor(num);
    if (n.toString().length > 9) return 'overflow';
    var str = ('000000000' + n).substr(-9);
    var result = '';
    result += (str[0]!=='0'||str[1]!=='0') ? (a[Number(str[0])]||b[str[0]]+' '+a[str[1]])+'Crore ' : '';
    result += (str[2]!=='0'||str[3]!=='0') ? (a[Number(str[2])]||b[str[2]]+' '+a[str[3]])+'Lakh ' : '';
    result += (str[4]!=='0'||str[5]!=='0') ? (a[Number(str[4])]||b[str[4]]+' '+a[str[5]])+'Thousand ' : '';
    result += (str[6]!=='0') ? (a[Number(str[6])]||b[str[6]]+' '+a[str[7]])+'Hundred ' : '';
    result += (str[7]!=='0'||str[8]!=='0') ? ((str[6]!=='0')?'and ':'')+(a[Number(str[7]*10)+Number(str[8])]||b[str[7]]+' '+a[str[8]]) : '';
    return result.trim();
  }

  function goBack() { MemberBillTypeTransferRouter.showList(); }
  function editTransfer() { MemberBillTypeTransferRouter.showForm(MemberBillTypeTransferState.getActiveVoucher()); }
  function printVoucher() { window.print(); }

  return { render: render, goBack: goBack, editTransfer: editTransfer, printVoucher: printVoucher };
})();
