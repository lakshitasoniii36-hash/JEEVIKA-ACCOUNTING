// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — FIXED DEPOSIT: MOCK DATA & STORAGE
// ═══════════════════════════════════════════════════════

var FixedDepositMockData = (function () {
  var STORAGE_KEY = 'jeevika_tx_fd';

  var defaultBanks = [
    'State Bank of India',
    'HDFC Bank',
    'ICICI Bank',
    'Bank of Baroda',
    'Saraswat Co-Operative Bank',
    'Punjab National Bank',
    'Axis Bank',
    'Canara Bank',
    'Union Bank of India'
  ];

  var records = (function () {
    var stored = localStorage.getItem(STORAGE_KEY);
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed) && parsed.length > 0) return parsed;
      } catch (e) {
        console.error('Error parsing fixed deposit records:', e);
      }
    }
    return generateInitialRecords();
  })();

  function generateInitialRecords() {
    var initial = [
      {
        id: 'FD-ID-1',
        srNo: 1,
        fdrNo: 'FDR/SBI/2025/101',
        fdrRecNo: 'REC-994821',
        fdrDate: '2025-04-10',
        amount: 500000,
        maturityDate: '2026-04-10',
        maturityAmount: 537500,
        rateOfInterest: 7.50,
        earmarked: 'Sinking Fund',
        bankName: 'State Bank of India',
        status: 'Live',
        status1: 'New',
        showReminder: 'Yes',
        accruedInterest: 37500,
        earnedInterest: 0,
        remark: '1 Year FD against Sinking Fund investments'
      },
      {
        id: 'FD-ID-2',
        srNo: 2,
        fdrNo: 'FDR/HDFC/2025/204',
        fdrRecNo: 'REC-443912',
        fdrDate: '2025-06-15',
        amount: 250000,
        maturityDate: '2026-06-15',
        maturityAmount: 268125,
        rateOfInterest: 7.25,
        earmarked: 'Repair Fund',
        bankName: 'HDFC Bank',
        status: 'Live',
        status1: 'Existing',
        showReminder: 'Yes',
        accruedInterest: 18125,
        earnedInterest: 0,
        remark: 'Annual Fixed Deposit for Major Repairs reserve'
      },
      {
        id: 'FD-ID-3',
        srNo: 3,
        fdrNo: 'FDR/BOB/2024/089',
        fdrRecNo: 'REC-112049',
        fdrDate: '2024-03-01',
        amount: 1000000,
        maturityDate: '2025-03-01',
        maturityAmount: 1070000,
        rateOfInterest: 7.00,
        earmarked: 'General Reserve',
        bankName: 'Bank of Baroda',
        status: 'Closed',
        status1: 'Existing',
        showReminder: 'No',
        accruedInterest: 0,
        earnedInterest: 70000,
        remark: 'Matured and proceeds credited to Bank Savings A/c'
      }
    ];
    localStorage.setItem(STORAGE_KEY, JSON.stringify(initial));
    return initial;
  }

  function persist() {
    localStorage.setItem(STORAGE_KEY, JSON.stringify(records));
  }

  return {
    getBanks: function () {
      return defaultBanks;
    },

    getAll: function () {
      return records;
    },

    getById: function (id) {
      for (var i = 0; i < records.length; i++) {
        if (records[i].id === id) return records[i];
      }
      return null;
    },

    save: function (data) {
      if (!data.id) {
        data.id = 'FD-ID-' + (records.length ? Math.max.apply(null, records.map(function (r) {
          var n = parseInt((r.id || '').replace('FD-ID-', ''));
          return isNaN(n) ? 0 : n;
        })) + 1 : 1);
        if (!data.srNo) {
          data.srNo = records.length ? Math.max.apply(null, records.map(function (r) {
            return parseInt(r.srNo) || 0;
          })) + 1 : 1;
        }
        records.push(data);
      } else {
        var idx = records.findIndex(function (r) { return r.id === data.id; });
        if (idx !== -1) {
          records[idx] = data;
        } else {
          records.push(data);
        }
      }
      persist();
      return data;
    },

    delete: function (id) {
      records = records.filter(function (r) { return r.id !== id; });
      persist();
    },

    getNextSrNo: function () {
      return records.length ? Math.max.apply(null, records.map(function (r) {
        return parseInt(r.srNo) || 0;
      })) + 1 : 1;
    },

    getNextFDRNo: function () {
      var nextNo = this.getNextSrNo();
      var year = new Date().getFullYear();
      return 'FDR/' + year + '/' + String(nextNo).padStart(3, '0');
    }
  };
})();
