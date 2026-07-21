// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — FIXED DEPOSIT: PREVIEW
// ═══════════════════════════════════════════════════════

var FixedDepositPreview = (function () {

  function formatCurrency(val) {
    var num = parseFloat(val) || 0;
    return num.toLocaleString('en-IN', { minimumFractionDigits: 2, maximumFractionDigits: 2 });
  }

  function formatDate(dStr) {
    if (!dStr) return '-';
    var parts = dStr.split('-');
    if (parts.length === 3) {
      return parts[2] + '/' + parts[1] + '/' + parts[0];
    }
    return dStr;
  }

  return {
    render: function (id) {
      var record = FixedDepositMockData.getById(id);
      var container = document.getElementById('fd-preview-card-body');
      if (!container) return;

      if (!record) {
        container.innerHTML = '<div style="text-align:center; padding:30px; color:#9E9E9E;">Fixed Deposit record not found.</div>';
        return;
      }

      var societyName = window.currentSociety ? (window.currentSociety.name || window.currentSociety.SocietyName) : 'SHREE RAM HOUSING SOCIETY';

      var html = '';
      html += '<div style="border:2px solid #1565C0; padding:24px; border-radius:6px; background:white;">';
      
      // Title bar
      html += '<div style="text-align:center; margin-bottom:20px; border-bottom:2px double #1565C0; padding-bottom:12px;">';
      html += '<h2 style="margin:0; font-size:20px; font-weight:800; color:#1565C0; text-transform:uppercase;">' + societyName + '</h2>';
      html += '<div style="font-size:13px; font-weight:700; color:#424242; margin-top:4px; text-transform:uppercase; letter-spacing:1px;">FIXED DEPOSIT RECORD CERTIFICATE</div>';
      html += '</div>';

      // Grid details
      html += '<table style="width:100%; border-collapse:collapse; font-size:13px; margin-bottom:20px;">';
      
      html += '<tr>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; width:20%; border:1px solid #E0E0E0;">Sr No:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; width:30%; font-weight:bold;">' + record.srNo + '</td>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; width:20%; border:1px solid #E0E0E0;">Status:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; width:30%; font-weight:bold; color:#1565C0;">' + (record.status || 'Live') + ' (' + (record.status1 || 'New') + ')</td>';
      html += '</tr>';

      html += '<tr>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">FDR No:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; font-weight:700; color:#1565C0;">' + (record.fdrNo || '-') + '</td>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">FDR Rec No:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0;">' + (record.fdrRecNo || '-') + '</td>';
      html += '</tr>';

      html += '<tr>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">FDR Issue Date:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0;">' + formatDate(record.fdrDate) + '</td>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Bank Name:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; font-weight:600;">' + (record.bankName || '-') + '</td>';
      html += '</tr>';

      html += '<tr>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Principal Amount:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; font-weight:800; font-size:15px; color:#2E7D32;">₹ ' + formatCurrency(record.amount) + '</td>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Rate of Interest:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; font-weight:700;">' + (record.rateOfInterest ? record.rateOfInterest + ' % p.a.' : '0%') + '</td>';
      html += '</tr>';

      html += '<tr>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Maturity Date:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0;">' + formatDate(record.maturityDate) + '</td>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Maturity Amount:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; font-weight:800; font-size:15px; color:#0D47A1;">₹ ' + formatCurrency(record.maturityAmount) + '</td>';
      html += '</tr>';

      html += '<tr>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Accrued Interest:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; font-weight:600;">₹ ' + formatCurrency(record.accruedInterest) + '</td>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Earned Interest:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0; font-weight:600;">₹ ' + formatCurrency(record.earnedInterest) + '</td>';
      html += '</tr>';

      html += '<tr>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Earmarked Fund:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0;">' + (record.earmarked || '-') + '</td>';
      html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Show Reminder:</td>';
      html += '<td style="padding:8px; border:1px solid #E0E0E0;">' + (record.showReminder || 'Yes') + '</td>';
      html += '</tr>';

      if (record.remark) {
        html += '<tr>';
        html += '<td style="padding:8px; font-weight:bold; background:#F5F5F5; border:1px solid #E0E0E0;">Remarks / Notes:</td>';
        html += '<td colspan="3" style="padding:8px; border:1px solid #E0E0E0; font-style:italic;">' + record.remark + '</td>';
        html += '</tr>';
      }

      html += '</table>';

      // Signatures
      html += '<div style="display:flex; justify-content:space-between; margin-top:50px; padding-top:20px;">';
      html += '<div style="text-align:center; width:200px; border-top:1px dashed #757575; padding-top:6px; font-size:11px; font-weight:bold; color:#616161;">PREPARED BY</div>';
      html += '<div style="text-align:center; width:200px; border-top:1px dashed #757575; padding-top:6px; font-size:11px; font-weight:bold; color:#616161;">HON. TREASURER</div>';
      html += '<div style="text-align:center; width:200px; border-top:1px dashed #757575; padding-top:6px; font-size:11px; font-weight:bold; color:#616161;">HON. SECRETARY</div>';
      html += '</div>';

      html += '</div>';

      container.innerHTML = html;
    }
  };
})();
