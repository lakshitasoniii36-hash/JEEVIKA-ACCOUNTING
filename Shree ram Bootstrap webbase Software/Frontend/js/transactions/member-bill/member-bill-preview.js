// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: PREVIEW / INVOICE
// A4 print-ready accounting invoice layout
// ═══════════════════════════════════════════════════════

var MemberBillPreview = (function () {

  var currentBillNo = null;

  function render(billNo) {
    currentBillNo = billNo;
    var container = document.getElementById('mb-preview-content');
    if (!container) return;

    var bill = TransactionState.getBill(billNo);
    if (!bill) {
      container.innerHTML = '<div style="padding:40px;text-align:center;color:#9E9E9E;">Bill not found</div>';
      return;
    }

    var m = MemberBillMockData.getMember(bill.memberCode);
    var soc = MemberBillMockData.society;
    var t = MemberBillMockData.calcBillTotals(bill);

    var itemsHTML = '';
    var sr = 0;
    (bill.items || []).forEach(function (item) {
      sr++;
      var amt = (item.qty || 1) * (item.rate || 0);
      var cgstAmt = amt * (item.cgst || 0) / 100;
      var sgstAmt = amt * (item.sgst || 0) / 100;
      var gstAmt = cgstAmt + sgstAmt;
      var finalAmt = amt + gstAmt;

      itemsHTML += '<tr>' +
        '<td style="text-align:center;padding:4px 8px;border:1px solid #dee2e6;">' + sr + '</td>' +
        '<td style="padding:4px 8px;border:1px solid #dee2e6;">' + item.head + '</td>' +
        '<td style="padding:4px 8px;border:1px solid #dee2e6;">' + (item.desc || '') + '</td>' +
        '<td style="text-align:center;padding:4px 8px;border:1px solid #dee2e6;">' + (item.qty || 1) + '</td>' +
        '<td style="text-align:right;padding:4px 8px;border:1px solid #dee2e6;">₹' + (item.rate || 0).toFixed(2) + '</td>' +
        '<td style="text-align:right;padding:4px 8px;border:1px solid #dee2e6;">₹' + amt.toFixed(2) + '</td>' +
        (bill.gstEnabled ? '<td style="text-align:center;padding:4px 8px;border:1px solid #dee2e6;">' + (item.cgst || 0) + '%</td>' +
        '<td style="text-align:center;padding:4px 8px;border:1px solid #dee2e6;">' + (item.sgst || 0) + '%</td>' +
        '<td style="text-align:right;padding:4px 8px;border:1px solid #dee2e6;">₹' + gstAmt.toFixed(2) + '</td>' : '') +
        '<td style="text-align:right;padding:4px 8px;border:1px solid #dee2e6;font-weight:600;">₹' + finalAmt.toFixed(2) + '</td>' +
        '</tr>';
    });

    var gstColSpan = bill.gstEnabled ? 3 : 0;
    var totalCols = bill.gstEnabled ? 10 : 7;

    container.innerHTML =
      '<div class="mb-invoice-page">' +
        // Header
        '<div class="mb-invoice-header">' +
          '<div class="mb-invoice-society-name">' + soc.name + '</div>' +
          '<div class="mb-invoice-society-addr">' + soc.address + '</div>' +
          '<div class="mb-invoice-society-info">' +
            'Reg No: ' + soc.regNo + ' | GSTIN: ' + soc.gstNo + ' | Phone: ' + soc.phone +
          '</div>' +
          '<div class="mb-invoice-title-bar">MEMBER BILL / INVOICE</div>' +
        '</div>' +

        // Bill Info
        '<div class="mb-invoice-info-grid">' +
          '<div class="mb-invoice-info-left">' +
            '<table class="mb-invoice-info-table">' +
              '<tr><td class="mb-info-label">Bill No:</td><td class="mb-info-value">' + bill.billNo + '</td></tr>' +
              '<tr><td class="mb-info-label">Bill Date:</td><td class="mb-info-value">' + formatDate(bill.billDate) + '</td></tr>' +
              '<tr><td class="mb-info-label">Due Date:</td><td class="mb-info-value">' + formatDate(bill.dueDate) + '</td></tr>' +
              '<tr><td class="mb-info-label">Period:</td><td class="mb-info-value">' + bill.period + '</td></tr>' +
            '</table>' +
          '</div>' +
          '<div class="mb-invoice-info-right">' +
            '<table class="mb-invoice-info-table">' +
              '<tr><td class="mb-info-label">Member Code:</td><td class="mb-info-value">' + (m ? m.code : '') + '</td></tr>' +
              '<tr><td class="mb-info-label">Member Name:</td><td class="mb-info-value" style="font-weight:700;">' + (m ? m.name : '') + '</td></tr>' +
              '<tr><td class="mb-info-label">Wing / Flat:</td><td class="mb-info-value">' + (m ? (m.wing + '-' + m.flat) : '') + '</td></tr>' +
              '<tr><td class="mb-info-label">Mobile:</td><td class="mb-info-value">' + (m ? m.mobile : '') + '</td></tr>' +
            '</table>' +
          '</div>' +
        '</div>' +

        // Items Table
        '<table class="mb-invoice-items-table">' +
          '<thead><tr>' +
            '<th style="width:40px;">Sr</th>' +
            '<th>Account Head</th>' +
            '<th>Description</th>' +
            '<th style="width:40px;">Qty</th>' +
            '<th style="width:80px;">Rate</th>' +
            '<th style="width:90px;">Amount</th>' +
            (bill.gstEnabled ? '<th style="width:60px;">CGST%</th><th style="width:60px;">SGST%</th><th style="width:90px;">GST Amt</th>' : '') +
            '<th style="width:100px;">Final Amt</th>' +
          '</tr></thead>' +
          '<tbody>' + itemsHTML + '</tbody>' +
        '</table>' +

        // Totals
        '<div class="mb-invoice-totals">' +
          '<div class="mb-invoice-totals-left">' +
            (bill.gstEnabled ? '<div class="mb-totals-row"><span>Non-GST Total:</span><span>₹' + t.nonGstTotal.toFixed(2) + '</span></div>' +
            '<div class="mb-totals-row"><span>GST Taxable Total:</span><span>₹' + t.gstTotal.toFixed(2) + '</span></div>' +
            '<div class="mb-totals-row"><span>CGST:</span><span>₹' + t.cgst.toFixed(2) + '</span></div>' +
            '<div class="mb-totals-row"><span>SGST:</span><span>₹' + t.sgst.toFixed(2) + '</span></div>' : '') +
          '</div>' +
          '<div class="mb-invoice-totals-right">' +
            '<div class="mb-totals-row"><span>Sub Total:</span><span>₹' + t.principal.toFixed(2) + '</span></div>' +
            (bill.gstEnabled ? '<div class="mb-totals-row"><span>GST Amount:</span><span>₹' + t.gstAmount.toFixed(2) + '</span></div>' : '') +
            (t.interest > 0 ? '<div class="mb-totals-row"><span>Interest:</span><span>₹' + t.interest.toFixed(2) + '</span></div>' : '') +
            (t.arrears > 0 ? '<div class="mb-totals-row"><span>Arrears:</span><span>₹' + t.arrears.toFixed(2) + '</span></div>' : '') +
            '<div class="mb-totals-row mb-totals-final"><span>TOTAL AMOUNT:</span><span>₹' + t.total.toFixed(2) + '</span></div>' +
            '<div class="mb-totals-words">(' + numberToWords(t.total) + ')</div>' +
          '</div>' +
        '</div>' +

        // Footer
        '<div class="mb-invoice-footer">' +
          '<div class="mb-invoice-notes">' +
            '<div class="mb-invoice-notes-title">Notes / Terms:</div>' +
            '<ol>' +
              '<li>Payment is due within 15 days from the date of billing.</li>' +
              '<li>Interest @ 21% p.a. will be charged on delayed payments.</li>' +
              '<li>Cheques to be drawn in favour of "' + soc.name + '".</li>' +
              '<li>This is a computer-generated invoice.</li>' +
            '</ol>' +
          '</div>' +
          '<div class="mb-invoice-signatures">' +
            '<div class="mb-sig-block">' +
              '<div class="mb-sig-line"></div>' +
              '<div class="mb-sig-label">Secretary</div>' +
            '</div>' +
            '<div class="mb-sig-block">' +
              '<div class="mb-sig-line"></div>' +
              '<div class="mb-sig-label">Treasurer</div>' +
            '</div>' +
            '<div class="mb-sig-block">' +
              '<div class="mb-sig-line"></div>' +
              '<div class="mb-sig-label">Chairman</div>' +
            '</div>' +
          '</div>' +
        '</div>' +
      '</div>';
  }

  function formatDate(str) {
    if (!str) return '—';
    var parts = str.split('-');
    return parts[2] + '/' + parts[1] + '/' + parts[0];
  }

  function numberToWords(num) {
    if (num === 0) return 'Zero Only';
    var ones = ['', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine',
      'Ten', 'Eleven', 'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'];
    var tens = ['', '', 'Twenty', 'Thirty', 'Forty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety'];

    var rupees = Math.floor(num);
    var paise = Math.round((num - rupees) * 100);

    function convert(n) {
      if (n < 20) return ones[n];
      if (n < 100) return tens[Math.floor(n / 10)] + (n % 10 ? ' ' + ones[n % 10] : '');
      if (n < 1000) return ones[Math.floor(n / 100)] + ' Hundred' + (n % 100 ? ' ' + convert(n % 100) : '');
      if (n < 100000) return convert(Math.floor(n / 1000)) + ' Thousand' + (n % 1000 ? ' ' + convert(n % 1000) : '');
      if (n < 10000000) return convert(Math.floor(n / 100000)) + ' Lakh' + (n % 100000 ? ' ' + convert(n % 100000) : '');
      return convert(Math.floor(n / 10000000)) + ' Crore' + (n % 10000000 ? ' ' + convert(n % 10000000) : '');
    }

    var result = 'Rupees ' + convert(rupees);
    if (paise > 0) result += ' and ' + convert(paise) + ' Paise';
    return result + ' Only';
  }

  function printInvoice() {
    window.print();
  }

  function exportPDF() {
    TransactionState.toast('PDF Export initiated (mock)', 'success');
  }

  function downloadInvoice() {
    TransactionState.toast('Download initiated (mock)', 'success');
  }

  function goBack() {
    MemberBillRouter.showList();
  }

  function editBill() {
    if (currentBillNo) MemberBillRouter.showForm(currentBillNo);
  }

  return {
    render: render,
    printInvoice: printInvoice,
    exportPDF: exportPDF,
    downloadInvoice: downloadInvoice,
    goBack: goBack,
    editBill: editBill
  };
})();
