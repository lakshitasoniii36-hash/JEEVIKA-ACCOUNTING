// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: PREVIEW
// ═══════════════════════════════════════════════════════

var VoucherCheckPreview = (function () {

  function render() {
    var id = VoucherCheckState.getActiveVoucher();
    var v = VoucherCheckState.getVoucher(id);
    if(!v) return;

    var html = '<div class="vc-invoice-page">';
    
    // Header
    html += '<div class="vc-invoice-header">';
    html += '<div class="vc-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="vc-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="vc-invoice-title-bar">VOUCHER AUDIT SUMMARY</div>';
    html += '</div>';

    // Details
    html += '<div class="vc-invoice-info-grid">';
    html += '<div class="vc-invoice-info-left">';
    html += '<table class="vc-invoice-info-table">';
    html += '<tr><td class="vc-info-label">Voucher No</td><td class="vc-info-value"><strong>' + v.vchNo + '</strong></td></tr>';
    html += '<tr><td class="vc-info-label">Type</td><td class="vc-info-value">' + v.vchType + '</td></tr>';
    html += '<tr><td class="vc-info-label">Prepared By</td><td class="vc-info-value">' + v.entryUser + '</td></tr>';
    html += '</table></div>';
    html += '<div class="vc-invoice-info-right">';
    html += '<table class="vc-invoice-info-table">';
    html += '<tr><td class="vc-info-label">Date</td><td class="vc-info-value"><strong>' + v.vchDate + '</strong></td></tr>';
    html += '<tr><td class="vc-info-label">Check Status</td><td class="vc-info-value">' + v.status + '</td></tr>';
    html += '<tr><td class="vc-info-label">Approval</td><td class="vc-info-value"><strong>' + v.approval + '</strong></td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Grid
    html += '<table class="vc-invoice-items-table" style="margin-bottom:15px;">';
    html += '<thead><tr><th>Ledger Account</th><th>Remarks</th><th style="text-align:right;">Debit (₹)</th><th style="text-align:right;">Credit (₹)</th></tr></thead>';
    html += '<tbody>';
    
    v.details.forEach(function(d) {
      html += '<tr>';
      html += '<td>' + d.ledger + '</td>';
      html += '<td>' + d.remarks + '</td>';
      html += '<td style="text-align:right;">' + (d.dr ? d.dr.toFixed(2) : '') + '</td>';
      html += '<td style="text-align:right;">' + (d.cr ? d.cr.toFixed(2) : '') + '</td>';
      html += '</tr>';
    });

    html += '<tr style="font-weight:bold;background:#F5F5F5;">';
    html += '<td colspan="2" style="text-align:right;">TOTAL</td>';
    html += '<td style="text-align:right;">' + v.debitTot.toFixed(2) + '</td>';
    html += '<td style="text-align:right;">' + v.creditTot.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table>';

    // Narration
    html += '<div style="margin-bottom:20px;border:1px solid #E0E0E0;padding:10px;border-radius:4px;">';
    html += '<div style="font-size:10px;font-weight:bold;color:#616161;text-transform:uppercase;margin-bottom:4px;">Narration</div>';
    html += '<div style="font-size:12px;">' + v.narration + '</div>';
    html += '</div>';

    // Audit Remarks
    if(v.auditRem) {
      html += '<div style="margin-bottom:30px;border:1px solid #EF9A9A;background:#FFEBEE;padding:10px;border-radius:4px;">';
      html += '<div style="font-size:10px;font-weight:bold;color:#C62828;text-transform:uppercase;margin-bottom:4px;">Audit / Reviewer Remarks</div>';
      html += '<div style="font-size:12px;color:#C62828;">' + v.auditRem + '</div>';
      html += '</div>';
    }

    // Signatures
    html += '<div class="vc-invoice-signatures">';
    html += '<div class="vc-sig-block"><div class="vc-sig-line"></div><div class="vc-sig-label">Prepared By</div></div>';
    html += '<div class="vc-sig-block"><div class="vc-sig-line"></div><div class="vc-sig-label">Checked By (Audit)</div></div>';
    html += '<div class="vc-sig-block"><div class="vc-sig-line"></div><div class="vc-sig-label">Approved By</div></div>';
    html += '</div>';

    html += '</div>'; 
    
    document.getElementById('vc-preview-content').innerHTML = html;
  }

  function goBack() { VoucherCheckRouter.showForm(); }
  function printPreview() { window.print(); }

  return { render: render, goBack: goBack, printPreview: printPreview };
})();
