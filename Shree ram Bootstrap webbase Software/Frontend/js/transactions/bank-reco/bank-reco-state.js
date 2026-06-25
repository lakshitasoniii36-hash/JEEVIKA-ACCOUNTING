// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: STATE MANAGER
// ═══════════════════════════════════════════════════════

var BankRecoState = (function () {

  var entries = [];
  var activeView = 'list';
  var selectedEntryId = null;
  var activeBankCode = 'B001';
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/bankreco');
      var list = [];
      if (res.ok) {
        var result = await res.json();
        list = result.success ? result.data : [];
      }
      
      var banks = BankRecoMockData.getBanks();

      entries = list.map(function(e) {
        var isReceipt = e.tranType === 'Receipt' || e.amountFrom > 0;
        var b = banks.find(function(x) { return x.name === e.cashBankName; });
        return {
          id: e.id,
          bankCode: b ? b.code : '',
          bankName: e.cashBankName,
          voucherDate: e.tranDate ? e.tranDate.split('T')[0] : '',
          clearingDate: e.clearType === 'Cleared' ? (e.chqDate || '') : '',
          debit: isReceipt ? e.amountFrom : 0,
          credit: isReceipt ? 0 : e.amountTo,
          type: e.tranType || (isReceipt ? 'Receipt' : 'Payment'),
          no: e.id,
          memberCode: '',
          person: e.person,
          chequeNo: e.chqNo,
          chequeDate: e.chqDate,
          voucherType: isReceipt ? 'RV' : 'PV',
          voucherNo: e.particular2,
          particular1: e.particular3,
          particular2: e.particular4,
          particular3: '',
          voucherNarration: '',
          recoRemark: '',
          status: e.clearType === 'Cleared' ? 'Cleared' : 'Uncleared'
        };
      });
    } catch(e) {
      console.error("Error loading bank reco entries:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllEntries() { return entries; }
  
  function getEntry(id) {
    if(!id) return null;
    return entries.find(function(e) { return e.id === id; });
  }

  function getByAccount(bankCode) {
    var bank = BankRecoMockData.getBanks().find(function(b) { return b.code === bankCode; });
    var name = bank ? bank.name : bankCode;
    return entries.filter(function(e) {
      return e.bankName === name || e.bankCode === bankCode;
    });
  }

  function getActiveBank() { return activeBankCode; }
  function setActiveBank(code) { activeBankCode = code; }

  async function saveEntry(obj) {
    try {
      var isUpdate = obj.id ? true : false;
      var url = 'http://localhost:5002/api/bankreco';
      var method = 'POST';
      if (isUpdate) {
        url = 'http://localhost:5002/api/bankreco/' + encodeURIComponent(obj.id);
        method = 'PUT';
      }

      var payload = {
        cashBankName: obj.bankName,
        tranDate: obj.voucherDate,
        tranType: obj.type,
        amountFrom: obj.debit,
        amountTo: obj.credit,
        chqNo: obj.chequeNo,
        chqDate: obj.chequeDate,
        bankName: obj.bankName,
        person: obj.person,
        particular2: obj.voucherNo,
        particular3: obj.particular1,
        particular4: obj.particular2,
        clearType: obj.status === 'Cleared' ? 'Cleared' : 'Uncleared'
      };

      var res = await fetch(url, {
        method: method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to save bank reco entry');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function updateEntriesStatus(ids, clearingDate, remark) {
    for (var i = 0; i < entries.length; i++) {
      var e = entries[i];
      if (ids.includes(e.id)) {
        var isCleared = !!clearingDate;
        var reqPayload = {
          cashBankName: e.bankName,
          tranDate: e.voucherDate,
          tranType: e.type,
          amountFrom: e.debit,
          amountTo: e.credit,
          chqNo: e.chequeNo,
          chqDate: clearingDate || e.chequeDate,
          bankName: e.bankName,
          person: e.person,
          particular2: e.voucherNo,
          particular3: e.particular1,
          particular4: e.particular2,
          clearType: isCleared ? 'Cleared' : 'Uncleared'
        };
        
        try {
          await fetch('http://localhost:5002/api/bankreco/' + encodeURIComponent(e.id), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(reqPayload)
          });
        } catch(err) {
          console.error(err);
        }
      }
    }
    await init();
  }

  async function batchUpdate(updates) {
    for (var i = 0; i < updates.length; i++) {
      var up = updates[i];
      var entry = entries.find(function(e) { return e.id === up.id; });
      if (entry) {
        var reqPayload = {
          cashBankName: entry.bankName,
          tranDate: entry.voucherDate,
          tranType: entry.type,
          amountFrom: entry.debit,
          amountTo: entry.credit,
          chqNo: entry.chequeNo,
          chqDate: up.clearingDate || entry.chequeDate,
          bankName: entry.bankName,
          person: entry.person,
          particular2: entry.voucherNo,
          particular3: entry.particular1,
          particular4: up.bankRef || entry.particular2,
          clearType: up.status === 'Cleared' ? 'Cleared' : 'Uncleared'
        };
        try {
          await fetch('http://localhost:5002/api/bankreco/' + encodeURIComponent(entry.id), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(reqPayload)
          });
        } catch(e) {
          console.error(e);
        }
      }
    }
    await init();
  }

  function selectEntry(id) {
    selectedEntryId = id;
    notify();
  }

  function clearSelection() { selectedEntryId = null; notify(); }
  function getSelected() { return selectedEntryId; }

  function setView(view) { activeView = view; notify(); }
  function getView() { return activeView; }

  return {
    init: init, subscribe: subscribe,
    getAllEntries: getAllEntries, getEntry: getEntry,
    getByAccount: getByAccount, getActiveBank: getActiveBank, setActiveBank: setActiveBank,
    saveEntry: saveEntry, updateEntriesStatus: updateEntriesStatus, batchUpdate: batchUpdate,
    selectEntry: selectEntry, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView
  };
})();
