// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — FIXED DEPOSIT: FORM MANAGEMENT
// ═══════════════════════════════════════════════════════

var FixedDepositForm = (function () {

  function getTodayDateStr() {
    var today = new Date();
    var yyyy = today.getFullYear();
    var mm = String(today.getMonth() + 1).padStart(2, '0');
    var dd = String(today.getDate()).padStart(2, '0');
    return yyyy + '-' + mm + '-' + dd;
  }

  function getNextYearDateStr() {
    var today = new Date();
    var yyyy = today.getFullYear() + 1;
    var mm = String(today.getMonth() + 1).padStart(2, '0');
    var dd = String(today.getDate()).padStart(2, '0');
    return yyyy + '-' + mm + '-' + dd;
  }

  return {
    init: function () {
      this.populateBankDropdown();
      this.bindAutoCalc();
    },

    populateBankDropdown: function () {
      var select = document.getElementById('fd-form-bankname');
      if (!select) return;
      var currentVal = select.value;
      select.innerHTML = '<option value="">-- Select Bank --</option>';
      var banks = FixedDepositMockData.getBanks();
      banks.forEach(function (b) {
        select.innerHTML += '<option value="' + b + '">' + b + '</option>';
      });
      if (currentVal) select.value = currentVal;
    },

    bindAutoCalc: function () {
      var amountEl = document.getElementById('fd-form-amount');
      var roiEl = document.getElementById('fd-form-roi');
      var fdrDateEl = document.getElementById('fd-form-fdrdate');
      var matDateEl = document.getElementById('fd-form-maturitydate');

      var self = this;
      var calcHandler = function () { self.calculateInterest(); };

      if (amountEl) amountEl.addEventListener('input', calcHandler);
      if (roiEl) roiEl.addEventListener('input', calcHandler);
      if (fdrDateEl) fdrDateEl.addEventListener('change', calcHandler);
      if (matDateEl) matDateEl.addEventListener('change', calcHandler);
    },

    calculateInterest: function () {
      var amount = parseFloat(document.getElementById('fd-form-amount')?.value) || 0;
      var roi = parseFloat(document.getElementById('fd-form-roi')?.value) || 0;
      var fdrDateStr = document.getElementById('fd-form-fdrdate')?.value;
      var matDateStr = document.getElementById('fd-form-maturitydate')?.value;

      var matAmtEl = document.getElementById('fd-form-maturityamount');
      var accruedEl = document.getElementById('fd-form-accrued');

      if (amount <= 0 || roi <= 0 || !fdrDateStr || !matDateStr) return;

      var d1 = new Date(fdrDateStr);
      var d2 = new Date(matDateStr);
      var diffTime = d2.getTime() - d1.getTime();
      var diffDays = diffTime / (1000 * 3600 * 24);

      if (diffDays > 0) {
        var interest = (amount * roi * (diffDays / 365)) / 100;
        var totalMat = amount + interest;

        if (matAmtEl && (!matAmtEl.value || parseFloat(matAmtEl.value) === 0 || matAmtEl.dataset.auto === 'true')) {
          matAmtEl.value = Math.round(totalMat);
          matAmtEl.dataset.auto = 'true';
        }

        // Estimate accrued interest up to today if FDR Date is past
        var today = new Date();
        if (today > d1 && accruedEl) {
          var accruedDays = Math.min(diffDays, (today.getTime() - d1.getTime()) / (1000 * 3600 * 24));
          if (accruedDays > 0) {
            var accrued = (amount * roi * (accruedDays / 365)) / 100;
            if (!accruedEl.value || parseFloat(accruedEl.value) === 0 || accruedEl.dataset.auto === 'true') {
              accruedEl.value = Math.round(accrued);
              accruedEl.dataset.auto = 'true';
            }
          }
        }
      }
    },

    loadData: function (id) {
      this.populateBankDropdown();
      var formTitle = document.getElementById('fd-form-title');

      if (!id) {
        if (formTitle) formTitle.textContent = 'Fixed Deposit Add';
        this.clearForm();
        
        // Auto assign next SrNo and FDR No
        var srNoInput = document.getElementById('fd-form-srno');
        var fdrNoInput = document.getElementById('fd-form-fdrno');
        if (srNoInput) srNoInput.value = FixedDepositMockData.getNextSrNo();
        if (fdrNoInput) fdrNoInput.value = FixedDepositMockData.getNextFDRNo();
        return;
      }

      if (formTitle) formTitle.textContent = 'Fixed Deposit Edit';

      var record = FixedDepositMockData.getById(id);
      if (!record) return;

      document.getElementById('fd-form-id').value = record.id || '';
      document.getElementById('fd-form-srno').value = record.srNo || '';
      document.getElementById('fd-form-fdrno').value = record.fdrNo || '';
      document.getElementById('fd-form-fdrrecno').value = record.fdrRecNo || '';
      document.getElementById('fd-form-fdrdate').value = record.fdrDate || getTodayDateStr();
      document.getElementById('fd-form-amount').value = record.amount || 0;
      document.getElementById('fd-form-maturitydate').value = record.maturityDate || getNextYearDateStr();
      document.getElementById('fd-form-maturityamount').value = record.maturityAmount || 0;
      document.getElementById('fd-form-roi').value = record.rateOfInterest || 0;
      document.getElementById('fd-form-earmarked').value = record.earmarked || '';
      document.getElementById('fd-form-bankname').value = record.bankName || '';
      document.getElementById('fd-form-status').value = record.status || 'Live';
      document.getElementById('fd-form-status1').value = record.status1 || 'New';
      document.getElementById('fd-form-showreminder').value = record.showReminder || 'Yes';
      document.getElementById('fd-form-accrued').value = record.accruedInterest || 0;
      document.getElementById('fd-form-earned').value = record.earnedInterest || 0;
      document.getElementById('fd-form-remark').value = record.remark || '';
    },

    clearForm: function () {
      document.getElementById('fd-form-id').value = '';
      document.getElementById('fd-form-srno').value = '';
      document.getElementById('fd-form-fdrno').value = '';
      document.getElementById('fd-form-fdrrecno').value = '';
      document.getElementById('fd-form-fdrdate').value = getTodayDateStr();
      document.getElementById('fd-form-amount').value = 0;
      document.getElementById('fd-form-maturitydate').value = getNextYearDateStr();
      document.getElementById('fd-form-maturityamount').value = 0;
      document.getElementById('fd-form-roi').value = 0;
      document.getElementById('fd-form-earmarked').value = '';
      document.getElementById('fd-form-bankname').value = '';
      document.getElementById('fd-form-status').value = 'Live';
      document.getElementById('fd-form-status1').value = 'New';
      document.getElementById('fd-form-showreminder').value = 'Yes';
      document.getElementById('fd-form-accrued').value = 0;
      document.getElementById('fd-form-earned').value = 0;
      document.getElementById('fd-form-remark').value = '';
    },

    save: function () {
      var fdrNo = document.getElementById('fd-form-fdrno')?.value.trim();
      var amount = parseFloat(document.getElementById('fd-form-amount')?.value) || 0;
      var bankName = document.getElementById('fd-form-bankname')?.value;

      if (!fdrNo) {
        if (window.JeevikaDialog) JeevikaDialog.alert('Please enter FDR Number.', 'Validation');
        else alert('Please enter FDR Number.');
        document.getElementById('fd-form-fdrno')?.focus();
        return;
      }

      if (amount <= 0) {
        if (window.JeevikaDialog) JeevikaDialog.alert('Please enter valid Deposit Amount.', 'Validation');
        else alert('Please enter valid Deposit Amount.');
        document.getElementById('fd-form-amount')?.focus();
        return;
      }

      if (!bankName) {
        if (window.JeevikaDialog) JeevikaDialog.alert('Please select or enter Bank Name.', 'Validation');
        else alert('Please select or enter Bank Name.');
        document.getElementById('fd-form-bankname')?.focus();
        return;
      }

      var formData = {
        id: document.getElementById('fd-form-id').value || null,
        srNo: parseInt(document.getElementById('fd-form-srno').value) || FixedDepositMockData.getNextSrNo(),
        fdrNo: fdrNo,
        fdrRecNo: document.getElementById('fd-form-fdrrecno').value.trim(),
        fdrDate: document.getElementById('fd-form-fdrdate').value,
        amount: amount,
        maturityDate: document.getElementById('fd-form-maturitydate').value,
        maturityAmount: parseFloat(document.getElementById('fd-form-maturityamount').value) || 0,
        rateOfInterest: parseFloat(document.getElementById('fd-form-roi').value) || 0,
        earmarked: document.getElementById('fd-form-earmarked').value.trim(),
        bankName: bankName,
        status: document.getElementById('fd-form-status').value,
        status1: document.getElementById('fd-form-status1').value,
        showReminder: document.getElementById('fd-form-showreminder').value,
        accruedInterest: parseFloat(document.getElementById('fd-form-accrued').value) || 0,
        earnedInterest: parseFloat(document.getElementById('fd-form-earned').value) || 0,
        remark: document.getElementById('fd-form-remark').value.trim()
      };

      var saved = FixedDepositMockData.save(formData);

      if (window.JeevikaDialog) {
        JeevikaDialog.alert('Fixed Deposit record saved successfully!', 'Success', function () {
          FixedDepositRouter.showList();
        });
      } else {
        alert('Fixed Deposit record saved successfully!');
        FixedDepositRouter.showList();
      }
    }
  };
})();
