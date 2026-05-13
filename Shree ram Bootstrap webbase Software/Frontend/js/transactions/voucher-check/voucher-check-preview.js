// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: PREVIEW
// ═══════════════════════════════════════════════════════

var VoucherCheckPreview = (function () {

  function render() {
    var data = VoucherCheckState.getAllVouchers();
    if (data.length === 0) return;

    var fStatus = (document.getElementById('vc-filter-status') || {}).value || '';
    if (fStatus) data = data.filter(function(v) { return v.status === fStatus; });

    var approved = data.filter(function(v) { return v.status === 'Approved'; });
    var pending = data.filter(function(v) { return v.status === 'Pending'; });
    var rejected = data.filter(function(v) { return v.status === 'Rejected'; });
    var totalAmt = 0;
    data.forEach(function(v) { totalAmt += parseFloat(v.amount || 0); });

    var html = '<div class="vc-invoice-page">';

    html += '<div class="vc-invoice-header">';
    html += '<div class="vc-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="vc-invoice-title-bar">VOUCHER AUDIT SUMMARY</div>';
    html += '<div style="margin-top:10px;font-weight:bold;">Report Date: ' + new Date().toLocaleDateString() + '</div>';
    html += '</div>';

    // Summary
    html += '<div class="vc-invoice-info-grid">';
    html += '<div class="vc-invoice-info-left"><table class="vc-invoice-info-table">';
    html += '<tr><td class="vc-info-label">Total Vouchers</td><td class="vc-info-value"><strong>' + data.length + '</strong></td></tr>';
    html += '<tr><td class="vc-info-label">Total Amount</td><td class="vc-info-value" style="font-weight:bold;color:#1565C0;">₹ ' + totalAmt.toLocaleString('en-IN', { minimumFractionDigits: 2 }) + '</td></tr>';
    html += '</table></div>';
    html += '<div class="vc-invoice-info-right"><table class="vc-invoice-info-table">';
    html += '<tr><td class="vc-info-label" style="color:#2E7D32;">Approved</td><td class="vc-info-value" style="color:#2E7D32;">' + approved.length + '</td></tr>';
    html += '<tr><td class="vc-info-label" style="color:#E65100;">Pending</td><td class="vc-info-value" style="color:#E65100;">' + pending.length + '</td></tr>';
    html += '<tr><td class="vc-info-label" style="color:#C62828;">Rejected</td><td class="vc-info-value" style="color:#C62828;">' + rejected.length + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Pending section
    if (pending.length > 0) {
      html += '<h3 style="color:#E65100;margin:16px 0 8px;font-size:13px;">PENDING VERIFICATION (' + pending.length + ')</h3>';
      html += buildVoucherTable(pending);
    }

    // Rejected section
    if (rejected.length > 0) {
      html += '<h3 style="color:#C62828;margin:16px 0 8px;font-size:13px;">REJECTED VOUCHERS (' + rejected.length + ')</h3>';
      html += buildVoucherTable(rejected);
    }

    // Approved section
    if (approved.length > 0) {
      html += '<h3 style="color:#2E7D32;margin:16px 0 8px;font-size:13px;">APPROVED VOUCHERS (' + approved.length + ')</h3>';
      html += buildVoucherTable(approved);
    }

    html += '<div class="vc-invoice-signatures">';
    html += '<div class="vc-sig-block"><div class="vc-sig-line"></div><div class="vc-sig-label">Auditor</div></div>';
    html += '<div class="vc-sig-block"><div class="vc-sig-line"></div><div class="vc-sig-label">Committee Member</div></div>';
    html += '<div class="vc-sig-block"><div class="vc-sig-line"></div><div class="vc-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('vc-preview-content').innerHTML = html;
  }

  function buildVoucherTable(list) {
    var html = '<table class="vc-invoice-items-table"><thead><tr>';
    html += '<th>Vou No</th><th>Date</th><th>Type</th><th>Person</th><th style="text-align:right;">Amount</th><th>Status</th><th>Remark</th>';
    html += '</tr></thead><tbody>';
    list.forEach(function(v) {
      html += '<tr>';
      html += '<td style="font-weight:bold;">' + v.voucherNo + '</td>';
      html += '<td>' + v.voucherDate + '</td>';
      html += '<td>' + v.voucherType + '</td>';
      html += '<td>' + (v.personName || '') + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(v.amount).toFixed(2) + '</td>';
      html += '<td>' + v.status + '</td>';
      html += '<td>' + (v.remark || v.rejectionReason || '') + '</td>';
      html += '</tr>';
    });
    html += '</tbody></table>';
    return html;
  }

  function printStatement() { window.print(); }

  return { render: render, printStatement: printStatement };
})();
