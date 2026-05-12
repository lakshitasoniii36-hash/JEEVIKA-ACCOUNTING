// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: GRID
// ═══════════════════════════════════════════════════════

var VoucherCheckGrid = (function () {

  function init(voucher) {
    var tbody = document.getElementById('vc-grid-tbody');
    if (!tbody) return;

    var html = '';
    var totDr = 0;
    var totCr = 0;

    voucher.details.forEach(function(d, idx) {
      totDr += d.dr;
      totCr += d.cr;

      html += '<tr>';
      html += '<td class="vc-grid-cell" style="text-align:center;">'+(idx+1)+'</td>';
      html += '<td class="vc-grid-cell" style="font-weight:600;">' + d.ledger + '</td>';
      html += '<td class="vc-grid-cell vc-grid-num" style="color:#C62828;">' + (d.dr ? d.dr.toFixed(2) : '') + '</td>';
      html += '<td class="vc-grid-cell vc-grid-num" style="color:#2E7D32;">' + (d.cr ? d.cr.toFixed(2) : '') + '</td>';
      html += '<td class="vc-grid-cell" style="color:#616161;font-size:11px;">' + d.remarks + '</td>';
      html += '<td class="vc-grid-cell" style="text-align:center;"><i class="bi bi-check2-circle" style="color:#BDBDBD;"></i></td>';
      html += '</tr>';
    });

    tbody.innerHTML = html;

    // Update Totals
    var tfDr = document.getElementById('vc-grid-tot-dr');
    var tfCr = document.getElementById('vc-grid-tot-cr');
    
    if(tfDr) tfDr.innerText = totDr.toFixed(2);
    if(tfCr) tfCr.innerText = totCr.toFixed(2);

    // Validation
    var validationPanel = document.getElementById('vc-validation-panel');
    var valMsg = document.getElementById('vc-validation-msg');
    
    if(totDr !== totCr) {
      validationPanel.className = 'vc-audit-panel vc-panel-error';
      valMsg.innerHTML = '<i class="bi bi-exclamation-triangle"></i> <strong>CRITICAL MISMATCH:</strong> Debit ('+totDr.toFixed(2)+') does not match Credit ('+totCr.toFixed(2)+'). Difference: ' + Math.abs(totDr - totCr).toFixed(2);
    } else {
      validationPanel.className = 'vc-audit-panel vc-panel-success';
      valMsg.innerHTML = '<i class="bi bi-check-circle"></i> <strong>ACCOUNTING VERIFIED:</strong> Debit and Credit perfectly match.';
    }
  }

  return { init: init };
})();
