// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: PRINT REGISTER
// ═══════════════════════════════════════════════════════

var MemberBillPrint = (function () {

  function renderRegisterPreview() {
    var data = MemberBillState.getAllBills();
    
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">BILL REGISTER</h2>';
    var todayStr = new Date().toISOString().split('T')[0];
    html += '<h4 style="text-align:center;">As on ' + window.formatDateToDDMMYYYY(todayStr) + '</h4>';
    
    html += '<table style="width:100%;border-collapse:collapse;margin-top:20px;border:1px solid #000;">';
    html += '<thead><tr style="border-bottom:2px solid #000;">';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Bill No</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Date</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Member</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Period</th>';
    html += '<th style="text-align:right;padding:4px;border-right:1px solid #000;">Principal</th>';
    html += '<th style="text-align:right;padding:4px;border-right:1px solid #000;">Interest</th>';
    html += '<th style="text-align:right;padding:4px;border-right:1px solid #000;">Arrears</th>';
    html += '<th style="text-align:right;padding:4px;">Total</th>';
    html += '</tr></thead><tbody>';

    var prinTot = 0, intTot = 0, arrTot = 0, finalTot = 0;

    data.forEach(function(b) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + b.billNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + window.formatDateToDDMMYYYY(b.billDate) + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + b.memberName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + b.period + '</td>';
      html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + b.principalTotal.toFixed(2) + '</td>';
      html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + b.interestTotal.toFixed(2) + '</td>';
      html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + b.arrears.toFixed(2) + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + b.finalTotal.toFixed(2) + '</td>';
      html += '</tr>';

      prinTot += b.principalTotal;
      intTot += b.interestTotal;
      arrTot += b.arrears;
      finalTot += b.finalTotal;
    });

    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="4" style="padding:4px;text-align:right;border-right:1px solid #000;">GRAND TOTAL:</td>';
    html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + prinTot.toFixed(2) + '</td>';
    html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + intTot.toFixed(2) + '</td>';
    html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + arrTot.toFixed(2) + '</td>';
    html += '<td style="padding:4px;text-align:right;">' + finalTot.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table></div>';
    
    document.getElementById('print-register-content').innerHTML = html;
  }

  function exportPDF() {
    alert("Exporting PDF register...");
  }

  return {
    renderRegisterPreview: renderRegisterPreview,
    exportPDF: exportPDF
  };
})();
