// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: ROUTER
// ═══════════════════════════════════════════════════════

var VoucherCheckRouter = (function () {

  var sections = ['vc-section-list', 'vc-section-form', 'vc-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'vc-section-list': 'list',
      'vc-section-form': 'form',
      'vc-section-preview': 'preview'
    };
    VoucherCheckState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('vc-section-list');
    if (typeof VoucherCheckList !== 'undefined' && VoucherCheckList.refresh) {
      VoucherCheckList.refresh();
    }
  }

  function showForm(voucherId) {
    if(voucherId) VoucherCheckState.setActiveVoucher(voucherId);
    showSection('vc-section-form');
    if (typeof VoucherCheckForm !== 'undefined' && VoucherCheckForm.initVoucher) {
      VoucherCheckForm.initVoucher();
    }
  }

  function showPreview() {
    showSection('vc-section-preview');
    if (typeof VoucherCheckPreview !== 'undefined' && VoucherCheckPreview.render) {
      VoucherCheckPreview.render();
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview
  };
})();
