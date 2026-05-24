// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: LIST VIEW
// ═══════════════════════════════════════════════════════

var VoucherCheckList = (function () {

  var sortCol = 'entryNo';
  var sortDesc = true;

  function refresh() {
    var data = VoucherCheckState.getAllVouchers();

    // Filters
    var fType = (document.getElementById('vc-filter-type') || {}).value || '';
    if (fType) data = data.filter(function(v) { return v.voucherType === fType; });

    var fStatus = (document.getElementById('vc-filter-status') || {}).value || '';
    if (fStatus) data = data.filter(function(v) { return v.status === fStatus; });

    var search = (document.getElementById('vc-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (v) {
        return (v.voucherNo.toLowerCase().includes(search) ||
                (v.personName && v.personName.toLowerCase().includes(search)) ||
                (v.chqNo && v.chqNo.toLowerCase().includes(search)) ||
                (v.billNo && v.billNo.toLowerCase().includes(search)));
      });
    }

    data.sort(function (a, b) {
      var valA = a[sortCol]; var valB = b[sortCol];
      if (typeof valA === 'string') valA = valA.toLowerCase();
      if (typeof valB === 'string') valB = valB.toLowerCase();
      if (valA < valB) return sortDesc ? 1 : -1;
      if (valA > valB) return sortDesc ? -1 : 1;
      return 0;
    });

    renderTable(data);
    updateSummary(data);

    var selId = VoucherCheckState.getSelected();
    if (selId && !data.find(function(v) { return v.id === selId; })) {
      VoucherCheckState.clearSelection();
    } else {
      updateDetailPanel();
    }
  }

  function chkIcon(val) {
    return val ? '<i class="bi bi-check-square-fill" style="color:#C62828;"></i>' : '<i class="bi bi-square" style="color:#BDBDBD;"></i>';
  }

  function statusBadge(s) {
    if (s === 'Approved') return '<span class="vc-badge vc-badge-approved">Approved</span>';
    if (s === 'Rejected') return '<span class="vc-badge vc-badge-error">Rejected</span>';
    return '<span class="vc-badge vc-badge-pending">Pending</span>';
  }

  function renderTable(data) {
    var tbody = document.getElementById('vc-list-tbody');
    if (!tbody) return;

    document.getElementById('vc-list-count').innerText = data.length + ' vouchers';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="22" style="text-align:center;padding:20px;color:#9E9E9E;">No Vouchers Found</td></tr>';
      return;
    }

    var html = '';
    var selectedId = VoucherCheckState.getSelected();

    data.forEach(function (v) {
      var isSelected = (selectedId === v.id);
      var rowClass = isSelected ? 'vc-row-active ' : '';
      if (v.status === 'Approved') rowClass += 'vc-row-success';
      else if (v.status === 'Rejected') rowClass += 'vc-row-danger';

      html += '<tr class="' + rowClass + '" onclick="VoucherCheckList.onRowClick(\'' + v.id + '\')">';

      html += '<td>' + v.voucherType + '</td>';
      html += '<td style="font-weight:bold;color:#1565C0;">' + v.voucherNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(v.voucherDate) + '</td>';
      html += '<td class="vc-td-right" style="color:#0D47A1;">' + parseFloat(v.amount || 0).toFixed(2) + '</td>';

      // Checkbox columns
      html += '<td class="vc-td-center">' + (v.checks.check ? '<i class="bi bi-check-circle-fill" style="color:#2E7D32;"></i>' : '<i class="bi bi-circle" style="color:#BDBDBD;"></i>') + '</td>';
      html += '<td class="vc-td-center">' + chkIcon(v.checks.noCommitteeSign) + '</td>';
      html += '<td class="vc-td-center">' + chkIcon(v.checks.noReceiverSign) + '</td>';
      html += '<td class="vc-td-center">' + chkIcon(v.checks.noSupporting) + '</td>';
      html += '<td class="vc-td-center">' + chkIcon(v.checks.noMeetingApproval) + '</td>';
      html += '<td class="vc-td-center">' + chkIcon(v.checks.noTDSDeducted) + '</td>';
      html += '<td class="vc-td-center">' + chkIcon(v.checks.noVoucher) + '</td>';
      html += '<td class="vc-td-center">' + chkIcon(v.checks.excessCash) + '</td>';

      html += '<td>' + (v.remark || '') + '</td>';
      html += '<td>' + (v.remark1 || '') + '</td>';
      html += '<td>' + (v.chqNo || '') + '</td>';
      html += '<td>' + (v.billNo || '') + '</td>';
      html += '<td>' + (v.personName || '') + '</td>';
      html += '<td>' + (v.particular || '') + '</td>';
      html += '<td>' + (v.particular1 || '') + '</td>';
      html += '<td>' + (v.cashBank || '') + '</td>';
      html += '<td>' + statusBadge(v.status) + '</td>';
      html += '<td>' + v.entryNo + '</td>';

      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function onRowClick(id) {
    VoucherCheckState.selectEntry ? VoucherCheckState.selectEntry(id) : VoucherCheckState.selectVoucher(id);
    refresh();
  }

  function updateDetailPanel() {
    var id = VoucherCheckState.getSelected();
    var v = VoucherCheckState.getVoucher(id);

    // Line items sub-grid
    var subTbody = document.getElementById('vc-detail-grid-tbody');
    if (subTbody) {
      if (v && v.lineItems) {
        var html = '';
        v.lineItems.forEach(function(li) {
          html += '<tr>';
          html += '<td>' + (li.code || '') + '</td>';
          html += '<td>' + (li.accountName || '') + '</td>';
          html += '<td class="vc-grid-num">' + parseFloat(li.debit || 0).toFixed(2) + '</td>';
          html += '<td class="vc-grid-num">' + parseFloat(li.credit || 0).toFixed(2) + '</td>';
          html += '<td>' + (li.gst || '0') + '%</td>';
          html += '<td>' + (li.ledgerType || '') + '</td>';
          html += '</tr>';
        });
        subTbody.innerHTML = html;
      } else {
        subTbody.innerHTML = '<tr><td colspan="6" style="text-align:center;color:#9E9E9E;">Select a voucher</td></tr>';
      }
    }

    // Right detail form
    if (!v) {
      setDetailField('vc-det-chqno', '');
      setDetailField('vc-det-chqdate', '');
      setDetailField('vc-det-billno', '');
      setDetailField('vc-det-particular', '');
      setDetailField('vc-det-person', '');
      setDetailField('vc-det-narration', '');
      setDetailField('vc-det-approval-remark', '');
      setDetailField('vc-det-auditor-remark', '');
      setDetailField('vc-det-rejection-reason', '');
      setSpanText('vc-det-updated-by', '-');
      setSpanText('vc-det-updated-time', '-');

      // Checkboxes
      setChk('vc-chk-check', false);
      setChk('vc-chk-noCommitteeSign', false);
      setChk('vc-chk-noReceiverSign', false);
      setChk('vc-chk-noSupporting', false);
      setChk('vc-chk-noMeetingApproval', false);
      setChk('vc-chk-noTDSDeducted', false);
      setChk('vc-chk-noVoucher', false);
      setChk('vc-chk-excessCash', false);
      setDetailField('vc-det-remark', '');
      setDetailField('vc-det-remark1', '');
      return;
    }

    setDetailField('vc-det-chqno', v.chqNo || '');
    setDetailField('vc-det-chqdate', window.formatDateToDDMMYYYY(v.voucherDate) || '');
    setDetailField('vc-det-billno', v.billNo || '');
    setDetailField('vc-det-particular', v.particular || '');
    setDetailField('vc-det-person', v.personName || '');
    setDetailField('vc-det-narration', v.particular1 || '');
    setDetailField('vc-det-approval-remark', '');
    setDetailField('vc-det-auditor-remark', '');
    setDetailField('vc-det-rejection-reason', v.rejectionReason || '');
    setSpanText('vc-det-updated-by', v.approvedBy || v.createdBy || '-');
    setSpanText('vc-det-updated-time', v.lastUpdatedTime || '-');

    setChk('vc-chk-check', v.checks.check);
    setChk('vc-chk-noCommitteeSign', v.checks.noCommitteeSign);
    setChk('vc-chk-noReceiverSign', v.checks.noReceiverSign);
    setChk('vc-chk-noSupporting', v.checks.noSupporting);
    setChk('vc-chk-noMeetingApproval', v.checks.noMeetingApproval);
    setChk('vc-chk-noTDSDeducted', v.checks.noTDSDeducted);
    setChk('vc-chk-noVoucher', v.checks.noVoucher);
    setChk('vc-chk-excessCash', v.checks.excessCash);
    setDetailField('vc-det-remark', v.remark || '');
    setDetailField('vc-det-remark1', v.remark1 || '');
  }

  function setDetailField(id, val) { var el = document.getElementById(id); if (el) el.value = val; }
  function setSpanText(id, val) { var el = document.getElementById(id); if (el) el.innerText = val; }
  function setChk(id, val) { var el = document.getElementById(id); if (el) el.checked = !!val; }

  function gatherChecks() {
    return {
      check: document.getElementById('vc-chk-check').checked,
      noCommitteeSign: document.getElementById('vc-chk-noCommitteeSign').checked,
      noReceiverSign: document.getElementById('vc-chk-noReceiverSign').checked,
      noSupporting: document.getElementById('vc-chk-noSupporting').checked,
      noMeetingApproval: document.getElementById('vc-chk-noMeetingApproval').checked,
      noTDSDeducted: document.getElementById('vc-chk-noTDSDeducted').checked,
      noVoucher: document.getElementById('vc-chk-noVoucher').checked,
      excessCash: document.getElementById('vc-chk-excessCash').checked
    };
  }

  function processUpdate() {
    var id = VoucherCheckState.getSelected();
    if (!id) { alert('Please select a voucher first.'); return; }
    var checksObj = gatherChecks();
    var remarks = {
      remark: document.getElementById('vc-det-remark').value,
      remark1: document.getElementById('vc-det-remark1').value
    };
    VoucherCheckState.updateVoucherChecks(id, checksObj, remarks);
    refresh();
  }

  function processApprove() {
    var id = VoucherCheckState.getSelected();
    if (!id) { alert('Please select a voucher first.'); return; }
    if (confirm('Approve this voucher?')) {
      VoucherCheckRouter.showLoading('Approving...');
      setTimeout(function () {
        VoucherCheckState.updateVoucherStatus([id], 'Approved');
        VoucherCheckRouter.hideLoading();
        refresh();
      }, 400);
    }
  }

  function processReject() {
    var id = VoucherCheckState.getSelected();
    if (!id) { alert('Please select a voucher first.'); return; }
    VoucherCheckRouter.showRejectModal();
  }

  function confirmReject() {
    var id = VoucherCheckState.getSelected();
    var reason = document.getElementById('vc-reject-reason').value;
    if (!reason) { alert('Please provide a rejection reason.'); return; }
    VoucherCheckRouter.closeModal('vc-modal-reject');
    VoucherCheckRouter.showLoading('Rejecting...');
    setTimeout(function () {
      VoucherCheckState.updateVoucherStatus([id], 'Rejected', reason);
      VoucherCheckRouter.hideLoading();
      refresh();
    }, 400);
  }

  function runMultiApprove() {
    var status = document.getElementById('vc-ma-status').value;
    var all = VoucherCheckState.getAllVouchers();
    var toApprove = all.filter(function(v) { return v.status === 'Pending'; }).map(function(v) { return v.id; });
    if (toApprove.length === 0) { alert('No pending vouchers to approve.'); return; }
    VoucherCheckRouter.closeModal('vc-modal-multi-approve');
    VoucherCheckRouter.showLoading('Processing ' + toApprove.length + ' vouchers...');
    setTimeout(function () {
      VoucherCheckState.updateVoucherStatus(toApprove, status);
      VoucherCheckRouter.hideLoading();
      refresh();
      alert(toApprove.length + ' vouchers updated successfully.');
    }, 800);
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('vc-list-summary');
    if (!summaryEl) return;

    var total = data.length;
    var approved = data.filter(function(v) { return v.status === 'Approved'; }).length;
    var pending = data.filter(function(v) { return v.status === 'Pending'; }).length;
    var rejected = data.filter(function(v) { return v.status === 'Rejected'; }).length;
    var totalAmt = 0;
    data.forEach(function(v) { totalAmt += parseFloat(v.amount || 0); });

    summaryEl.innerHTML =
      '<span class="vc-summary-item"><strong>Total:</strong> ' + total + '</span>' +
      '<span class="vc-summary-item" style="color:#2E7D32;"><strong>Approved:</strong> ' + approved + '</span>' +
      '<span class="vc-summary-item" style="color:#E65100;"><strong>Pending:</strong> ' + pending + '</span>' +
      '<span class="vc-summary-item" style="color:#C62828;"><strong>Rejected:</strong> ' + rejected + '</span>' +
      '<span class="vc-summary-item" style="color:#0D47A1;"><strong>Total Amt:</strong> ₹' + totalAmt.toLocaleString('en-IN', { minimumFractionDigits: 2 }) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function renderAuditTrail() {
    var id = VoucherCheckState.getSelected();
    var v = VoucherCheckState.getVoucher(id);
    var el = document.getElementById('vc-audit-trail-content');
    if (!el) return;
    if (!v) { el.innerHTML = '<p style="color:#9E9E9E;">No voucher selected.</p>'; return; }

    var html = '<table style="width:100%;border-collapse:collapse;font-size:12px;">';
    html += '<tr style="background:#1565C0;color:white;"><th style="padding:6px;">Field</th><th style="padding:6px;">Value</th></tr>';
    html += '<tr><td style="padding:4px;border:1px solid #E0E0E0;font-weight:bold;">Created By</td><td style="padding:4px;border:1px solid #E0E0E0;">' + (v.createdBy || '-') + '</td></tr>';
    html += '<tr><td style="padding:4px;border:1px solid #E0E0E0;font-weight:bold;">Approved By</td><td style="padding:4px;border:1px solid #E0E0E0;">' + (v.approvedBy || '-') + '</td></tr>';
    html += '<tr><td style="padding:4px;border:1px solid #E0E0E0;font-weight:bold;">Status</td><td style="padding:4px;border:1px solid #E0E0E0;">' + v.status + '</td></tr>';
    html += '<tr><td style="padding:4px;border:1px solid #E0E0E0;font-weight:bold;">Last Updated</td><td style="padding:4px;border:1px solid #E0E0E0;">' + (v.lastUpdatedTime || '-') + '</td></tr>';
    if (v.rejectionReason) {
      html += '<tr style="background:#FFEBEE;"><td style="padding:4px;border:1px solid #E0E0E0;font-weight:bold;color:#C62828;">Rejection Reason</td><td style="padding:4px;border:1px solid #E0E0E0;color:#C62828;">' + v.rejectionReason + '</td></tr>';
    }
    html += '</table>';
    el.innerHTML = html;
  }

  VoucherCheckState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn,
    onRowClick: onRowClick,
    processUpdate: processUpdate, processApprove: processApprove, processReject: processReject,
    confirmReject: confirmReject, runMultiApprove: runMultiApprove,
    renderAuditTrail: renderAuditTrail
  };
})();
