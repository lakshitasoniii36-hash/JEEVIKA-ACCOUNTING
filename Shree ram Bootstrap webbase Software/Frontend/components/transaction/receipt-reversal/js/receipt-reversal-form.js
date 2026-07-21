// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: FORM LOGIC
// ═══════════════════════════════════════════════════════

var ReceiptReversalForm = (function () {

  var fetchedReceiptData = null;
  var particulars = ['', ''];
  var currentFormBillType = 'Maintenance';

  function renderParticulars() {
    var container = document.getElementById('rr-particulars-container');
    if (!container) return;
    
    container.innerHTML = '';
    particulars.forEach(function(part, idx) {
      var row = document.createElement('div');
      row.style.display = 'flex';
      row.style.gap = '10px';
      row.style.width = '100%';
      row.style.alignItems = 'center';
      
      var input = document.createElement('input');
      input.type = 'text';
      input.id = 'rr-form-particular' + (idx === 0 ? '' : '2');
      input.style.flex = '1';
      input.style.height = '30px';
      input.style.border = '1px solid #CFD8DC';
      input.style.borderRadius = '4px';
      input.style.padding = '4px 8px';
      input.style.fontSize = '12px';
      input.style.outline = 'none';
      input.placeholder = 'Particulars ' + (idx + 1) + '...';
      input.value = part;
      input.oninput = function() {
        particulars[idx] = this.value;
      };
      
      row.appendChild(input);
      
      var btn = document.createElement('div');
      btn.id = 'rr-particular' + (idx + 1) + '-shortcut-btn';
      btn.style.width = '100px';
      btn.style.background = '#E0E0E0';
      btn.style.border = '1px solid #BDBDBD';
      btn.style.borderRadius = '4px';
      btn.style.textAlign = 'center';
      btn.style.padding = '4px';
      btn.style.fontSize = '10px';
      btn.style.fontWeight = 'bold';
      btn.style.cursor = 'pointer';
      btn.style.color = '#424242';
      btn.style.userSelect = 'none';
      btn.style.transition = 'background 0.2s';
      btn.style.height = '30px';
      btn.style.lineHeight = '20px';
      btn.style.flexShrink = '0';
      btn.innerText = 'Ctrl + L';
      btn.title = 'Click to repeat last Particular ' + (idx + 1);
      btn.onmouseover = function() { this.style.background = '#D5D5D5'; };
      btn.onmouseout = function() { this.style.background = '#E0E0E0'; };
      btn.onclick = function() {
        if (idx === 0) {
          repeatLastParticular1();
        } else {
          repeatLastParticular2();
        }
      };
      row.appendChild(btn);
      
      container.appendChild(row);
    });
  }

  function todayDMY() {
    var d = new Date();
    var dd = String(d.getDate()).padStart(2,'0');
    var mm = String(d.getMonth()+1).padStart(2,'0');
    var yyyy = d.getFullYear();
    return dd + '-' + mm + '-' + yyyy;
  }

  function updateMemberDisplay(memberCode) {
    var displayEl = document.getElementById('rr-form-member-display');
    var codeEl = document.getElementById('rr-form-member-code');
    var nameEl = document.getElementById('rr-form-member-name');
    var memSel = document.getElementById('rr-form-member');

    if (codeEl && codeEl.value !== (memberCode || '')) {
      codeEl.value = memberCode || '';
    }
    
    var m = ReceiptReversalMockData.getMembers().find(function(x) { return x.code === memberCode; });
    if (m) {
      if (displayEl) displayEl.value = m.code + ' - ' + m.name + ' (' + m.wingFlat + ')';
      if (nameEl) nameEl.value = m.name;
      if (memSel && memSel.value !== m.code) {
        memSel.value = m.code;
        var searchableWrapper = memSel.closest('.searchable-select-wrapper');
        if (searchableWrapper) {
          var sInput = searchableWrapper.querySelector('.searchable-select-input');
          if (sInput) sInput.value = m.code + ' - ' + m.name + ' (' + m.wingFlat + ')';
        }
      }
    } else {
      if (displayEl) displayEl.value = memberCode || '';
      if (nameEl) nameEl.value = memberCode ? '' : '';
    }

    // Populate the sidebar details
    var flatNo = '—';
    var area = '—';
    var mobile1 = '—';
    var mobile2 = '—';
    var nocFrom = '—';
    var nocTo = '—';

    if (m) {
      // Find the detailed member object from the cached list or fallback
      var memberList = [];
      if (typeof MemberReceiptState !== 'undefined' && typeof MemberReceiptState.getMembersList === 'function') {
        memberList = MemberReceiptState.getMembersList();
      }
      var detailedMember = memberList.find(function(x) { return (x.MemCode || x.code) === memberCode; }) || m;

      var w = detailedMember.Wing || detailedMember.wing || '';
      var f = detailedMember.FlatNo || detailedMember.flatNo || '';
      flatNo = w && f ? w + '-' + f : (f || w || detailedMember.wingFlat || '—');
      
      if (detailedMember.Sqft || detailedMember.sqft) {
        area = (detailedMember.Sqft || detailedMember.sqft) + ' Sq.Ft';
      }
      
      mobile1 = detailedMember.ContactNo || detailedMember.contactNo || detailedMember.MemMobile || detailedMember.memMobile || detailedMember.mobile || '—';
      mobile2 = detailedMember.MemMobile2 || detailedMember.memMobile2 || '—';
      
      var nocDetail = detailedMember.NocDetail || detailedMember.nocDetail || '';
      if (nocDetail) {
        var sh = nocDetail.split('|');
        nocFrom = sh[2] || '—';
        nocTo = sh[3] || '—';
      }
    }

    if (document.getElementById('rr-preview-flat')) document.getElementById('rr-preview-flat').innerText = flatNo;
    if (document.getElementById('rr-preview-area')) document.getElementById('rr-preview-area').innerText = area;
    if (document.getElementById('rr-preview-mobile1')) document.getElementById('rr-preview-mobile1').innerText = mobile1;
    if (document.getElementById('rr-preview-mobile2')) document.getElementById('rr-preview-mobile2').innerText = mobile2;
    if (document.getElementById('rr-preview-noc-from')) document.getElementById('rr-preview-noc-from').value = nocFrom;
    if (document.getElementById('rr-preview-noc-to')) document.getElementById('rr-preview-noc-to').value = nocTo;
  }
  function getAccountsByBillType(billType) {
    if (!billType) billType = 'Maintenance';
    var accounts = [];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        var typeData = parsed[billType];
        if (typeData && typeData.heads) {
          typeData.heads.forEach(function(head, idx) {
            if (head.accName && head.accCode && idx < 30) {
              accounts.push({ code: head.accCode, name: head.accName });
            }
          });
        }
      }
    } catch(e) {}
    
    if (accounts.length === 0) {
      if (billType === 'Clubhouse') {
        accounts = [
          { code: 'A008', name: 'Welfare Fund' },
          { code: 'A005', name: 'Electricity Charges' }
        ];
      } else if (billType === 'Major Repair') {
        accounts = [
          { code: 'A004', name: 'Repairs & Maintenance' },
          { code: 'A003', name: 'Sinking Fund' }
        ];
      } else {
        accounts = [
          { code: 'A004', name: 'Repairs & Maintenance' },
          { code: 'A002', name: 'Water Charges' },
          { code: 'A007', name: 'Parking Charges' },
          { code: 'A003', name: 'Sinking Fund' },
          { code: 'A006', name: 'Non-Occupancy Charges' },
          { code: 'A001', name: 'Property Tax' }
        ];
      }
    }
    return accounts;
  }

  function initForm(billType) {
    populateMembersDropdown();
    populateReturnReasonsDropdown();
    
    var radios = document.getElementsByName('rr_pay_mode');
    for (var i = 0; i < radios.length; i++) {
      radios[i].onchange = toggleAccountType;
      radios[i].setAttribute('disabled', 'true');
    }
    var payLabels = document.querySelectorAll('.rr-paymode-label');
    payLabels.forEach(function(l) { l.style.cursor = 'not-allowed'; });

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('rr-form-account');
      makeSearchableSelect('rr-form-ledger-account');
      makeSearchableSelect('rr-form-member', '— Select Member —');
    }
    
    var revNo = ReceiptReversalState.getActiveReversal();
    var r = ReceiptReversalState.getReversal(revNo);
 
    if (r) {
      currentFormBillType = r.billType || 'Maintenance';
    } else {
      currentFormBillType = billType || (typeof ReceiptReversalList !== 'undefined' ? ReceiptReversalList.getActiveBillType() : 'Maintenance');
      if (currentFormBillType === 'All') currentFormBillType = 'Maintenance';
    }

    var emptyLedger = document.getElementById('rr-ledger-empty');
    var contentLedger = document.getElementById('rr-ledger-content');

    // Disable principal, interest, and amount adjusted inputs by default on load
    var amtInput = document.getElementById('rr-form-amount');
    var prinInput = document.getElementById('rr-form-principal');
    var intrInput = document.getElementById('rr-form-interest');
    if (amtInput) amtInput.setAttribute('disabled', 'true');
    if (prinInput) prinInput.setAttribute('disabled', 'true');
    if (intrInput) intrInput.setAttribute('disabled', 'true');

    // Bind real-time inputs to update ledger preview dynamically using oninput/onchange
    if (amtInput) {
      amtInput.oninput = function() {
        // Always sync amount → principal when principal hasn't been manually set
        var pVal = prinInput ? prinInput.value : '';
        if (!pVal || pVal === '0') {
          if (prinInput) prinInput.value = this.value;
        }
        updateLedgerPreview();
      };
    }
    if (prinInput) prinInput.oninput = updateLedgerPreview;
    if (intrInput) intrInput.oninput = updateLedgerPreview;

    var memSel = document.getElementById('rr-form-member');
    if (memSel) {
      memSel.onchange = function() {
        if (this.value) {
          if (!fetchedReceiptData) {
            fetchedReceiptData = {
              receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
              billNo: document.getElementById('rr-form-against').value || ''
            };
          }
          if (emptyLedger) emptyLedger.style.display = 'none';
          if (contentLedger) contentLedger.style.display = 'block';
          updateLedgerPreview();
        } else {
          if (emptyLedger) emptyLedger.style.display = 'flex';
          if (contentLedger) contentLedger.style.display = 'none';
        }
      };
    }

    if (r) {
      document.getElementById('rr-form-edit-id').value = r.id;
      document.getElementById('rr-form-revno').value = r.reversalNo;
      document.getElementById('rr-form-revdate').value = r.reversalDate;
      document.getElementById('rr-form-receiptno').value = r.receiptNo;
      
      document.getElementById('rr-form-member').value = r.memberCode;
      updateMemberDisplay(r.memberCode);
      
      var radios = document.getElementsByName('rr_pay_mode');
      if (r.payMode === 'Other Ledger') {
        radios[1].checked = true;
      } else {
        radios[0].checked = true;
      }

      toggleAccountType();

      if (r.payMode === 'Other Ledger') {
        var ledSel = document.getElementById('rr-form-ledger-account');
        if (ledSel) ledSel.value = r.cashBank || '';
      } else {
        var depSel = document.getElementById('rr-form-account');
        if (depSel) depSel.value = r.cashBank || '';
        var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
        if (ledFetched) ledFetched.value = r.ledgerAccount || '';
      }
      
      if (document.getElementById('rr-form-transtype')) {
        document.getElementById('rr-form-transtype').value = r.transType || r.payMode || '';
      }
      document.getElementById('rr-form-chequeno').value = r.chqNo || '';
      document.getElementById('rr-form-chequedate').value = r.chqDate || '';
      if (document.getElementById('rr-form-refno')) {
        document.getElementById('rr-form-refno').value = r.refNo || '';
      }
      document.getElementById('rr-form-bank').value = r.bank || '';
      document.getElementById('rr-form-against').value = r.billNo || '';

      if (r.particulars && Array.isArray(r.particulars)) {
        particulars = r.particulars.slice();
      } else {
        particulars = [];
        if (r.particular1) particulars.push(r.particular1);
        if (r.particular2) particulars.push(r.particular2);
        if (r.particular3) particulars.push(r.particular3);
      }
      while (particulars.length < 2) particulars.push('');
      particulars = particulars.slice(0, 2);
      renderParticulars();
      
      document.getElementById('rr-form-amount').value = r.amount;
      document.getElementById('rr-form-principal').value = r.principalRestored;
      document.getElementById('rr-form-interest').value = r.interestRestored;
      document.getElementById('rr-form-reason').value = r.returnReason || '';

      document.getElementById('rr-form-status-badge').innerText = 'Reversed';
      document.getElementById('rr-form-status-badge').className = 'rr-status-badge rr-status-posted';

      fetchedReceiptData = r;
      if (emptyLedger) emptyLedger.style.display = 'none';
      if (contentLedger) contentLedger.style.display = 'block';
      updateLedgerPreview();

    } else {
      document.getElementById('rr-form-edit-id').value = '';
      document.getElementById('rr-form-revno').value = 'Loading...';
      fetch('http://localhost:5002/api/vouchers/next-no?type=Reversal')
        .then(function(res) { return res.json(); })
        .then(function(res) {
          if (res.success) {
            document.getElementById('rr-form-revno').value = res.voucherNo;
          } else {
            document.getElementById('rr-form-revno').value = ReceiptReversalMockData.getNextRevNo();
          }
        })
        .catch(function(err) {
          console.error(err);
          document.getElementById('rr-form-revno').value = ReceiptReversalMockData.getNextRevNo();
        });
      document.getElementById('rr-form-revdate').value = todayDMY();
      document.getElementById('rr-form-receiptno').value = '';
      
      document.getElementById('rr-form-member').value = '';
      updateMemberDisplay('');
      document.getElementsByName('rr_pay_mode')[0].checked = true;

      toggleAccountType();

      var depSel = document.getElementById('rr-form-account');
      if (depSel) depSel.value = '';
      var ledSel = document.getElementById('rr-form-ledger-account');
      if (ledSel) ledSel.value = '';
      var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
      if (ledFetched) ledFetched.value = '';

      if (document.getElementById('rr-form-transtype')) {
        document.getElementById('rr-form-transtype').value = '';
      }
      document.getElementById('rr-form-chequeno').value = '';
      document.getElementById('rr-form-chequedate').value = '';
      if (document.getElementById('rr-form-refno')) {
        document.getElementById('rr-form-refno').value = '';
      }
      document.getElementById('rr-form-bank').value = '';
      document.getElementById('rr-form-against').value = '';

      particulars = ['Reversal of Receipt', ''];
      renderParticulars();
      
      document.getElementById('rr-form-amount').value = '';
      document.getElementById('rr-form-principal').value = '';
      document.getElementById('rr-form-interest').value = '';
      document.getElementById('rr-form-reason').value = '';

      // Re-disable principal/interest/amount on clear
      if (amtInput) amtInput.setAttribute('disabled', 'true');
      if (prinInput) prinInput.setAttribute('disabled', 'true');
      if (intrInput) intrInput.setAttribute('disabled', 'true');

      document.getElementById('rr-form-status-badge').innerText = 'Draft';
      document.getElementById('rr-form-status-badge').className = 'rr-status-badge rr-status-pending';

      fetchedReceiptData = null;
      if (emptyLedger) emptyLedger.style.display = 'flex';
      if (contentLedger) contentLedger.style.display = 'none';
    }

    var manualToggle = document.getElementById('rr-manual-toggle');
    if (manualToggle) {
      manualToggle.checked = false;
    }
    
    var codeInput = document.getElementById('rr-form-member-code');
    if (codeInput) {
      codeInput.oninput = function() {
        var toggle = document.getElementById('rr-manual-toggle');
        if (toggle && toggle.checked) {
          updateMemberDisplay(this.value);
          var memSel = document.getElementById('rr-form-member');
          if (memSel) memSel.value = this.value;
          updateLedgerPreview();
        }
      };
    }

    if (typeof ReceiptReversalRouter !== 'undefined' && ReceiptReversalRouter.updateWorkspaceTitleAndTab) {
      ReceiptReversalRouter.updateWorkspaceTitleAndTab(currentFormBillType);
    }
  }

  function populateMembersDropdown() {
    var sel = document.getElementById('rr-form-member');
    var members = ReceiptReversalMockData.getMembers();
    sel.innerHTML = '<option value="">— Select Member —</option>';
    members.forEach(function(m) {
      sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
    });
  }

  function populateReturnReasonsDropdown() {
    var sel = document.getElementById('rr-form-reason');
    if (!sel) return;
    var reasons = ReceiptReversalMockData.getReturnReasons();
    sel.innerHTML = '<option value="">— Select Return Reason —</option>';
    reasons.forEach(function(r) {
      sel.innerHTML += '<option value="' + r + '">' + r + '</option>';
    });
  }

  function toggleAccountType() {
    var radios = document.getElementsByName('rr_pay_mode');
    var type = 'Cash/Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) type = radios[i].value; }

    var depGroup = document.getElementById('rr-deposit-account-group');
    var ledSelGroup = document.getElementById('rr-ledger-account-select-group');
    var ledFtcGroup = document.getElementById('rr-ledger-account-fetched-group');
    var chqGroup = document.getElementById('rr-cheque-details-group');

    var sel = document.getElementById('rr-form-account');
    var ledSel = document.getElementById('rr-form-ledger-account');

    if(type === 'Cash/Bank') {
      if(depGroup) depGroup.style.display = 'block';
      if(ledSelGroup) ledSelGroup.style.display = 'none';
      if(ledFtcGroup) ledFtcGroup.style.display = 'block';
      if(chqGroup) chqGroup.style.display = 'flex';
      
      // Populate Cash/Bank accounts
      if (sel) {
        var accountsVal = localStorage.getItem('jeevika_master_account');
        var groupsVal = localStorage.getItem('jeevika_master_group');
        var accountsList = [];
        var groupsList = [];
        try { accountsList = JSON.parse(accountsVal || '[]'); } catch(e) {}
        try { groupsList = JSON.parse(groupsVal || '[]'); } catch(e) {}
        
        var targetGroupIds = groupsList.filter(function(g) {
          return g.GrpName === 'Cash & Bank Balance' || g.GrpPrimaryName === 'Cash & Bank Balance';
        }).map(function(g) { return g.SocGroupId; });

        if (targetGroupIds.length === 0) targetGroupIds = [2];

        var cbAccounts = accountsList.filter(function(a) {
          return targetGroupIds.indexOf(a.SocSubGroupId) !== -1;
        }).map(function(a) {
          return {
            code: a.accCode || a.AccCode || ('AC-' + a.socAccId),
            name: a.accName || a.AccName || ''
          };
        });

        if (cbAccounts.length === 0) {
          cbAccounts = [
            { code: 'CASH', name: 'Cash in Hand' },
            { code: 'B001', name: 'The Saraswat Bank A/C No.' }
          ];
        }

        sel.innerHTML = '<option value="">— Select Account —</option>';
        cbAccounts.forEach(function(a) {
          var labelText = a.code + ' - ' + a.name;
          sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + labelText + '</option>';
        });
      }
    } else {
      if(depGroup) depGroup.style.display = 'none';
      if(ledSelGroup) ledSelGroup.style.display = 'block';
      if(ledFtcGroup) ledFtcGroup.style.display = 'none';
      if(chqGroup) {
        chqGroup.style.display = 'none';
        if (document.getElementById('rr-form-transtype')) {
          document.getElementById('rr-form-transtype').value = '';
        }
        document.getElementById('rr-form-chequeno').value = '';
        document.getElementById('rr-form-chequedate').value = '';
        if (document.getElementById('rr-form-refno')) {
          document.getElementById('rr-form-refno').value = '';
        }
        document.getElementById('rr-form-bank').value = '';
      }

      // Populate Maintenance Ledger accounts
      if (ledSel) {
        var accountsVal = localStorage.getItem('jeevika_master_account');
        var groupsVal = localStorage.getItem('jeevika_master_group');
        var accountsList = [];
        var groupsList = [];
        try { accountsList = JSON.parse(accountsVal || '[]'); } catch(e) {}
        try { groupsList = JSON.parse(groupsVal || '[]'); } catch(e) {}
        
        var targetGroupIds = groupsList.filter(function(g) {
          return g.GrpName === 'Cash & Bank Balance' || g.GrpPrimaryName === 'Cash & Bank Balance';
        }).map(function(g) { return g.SocGroupId; });

        if (targetGroupIds.length === 0) targetGroupIds = [2];

        var otherAccounts = accountsList.filter(function(a) {
          return targetGroupIds.indexOf(a.SocSubGroupId) === -1;
        }).map(function(a) {
          return {
            code: a.accCode || a.AccCode || ('AC-' + a.socAccId),
            name: a.accName || a.AccName || ''
          };
        });

        if (otherAccounts.length === 0) {
          otherAccounts = [
            { code: 'A001', name: 'Dues From Members' },
            { code: 'A002', name: 'One Share of Housing Federation' }
          ];
        }

        ledSel.innerHTML = '<option value="">— Select Ledger Account —</option>';
        otherAccounts.forEach(function(a) {
          var labelText = a.code + ' - ' + a.name;
          ledSel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + labelText + '</option>';
        });
      }
    }
  }

  function fetchReceipt() {
    var rcptNo = document.getElementById('rr-form-receiptno').value;
    if(!rcptNo) { JeevikaDialog.alert("Please enter Receipt No.", "Fetch Receipt"); return; }

    ReceiptReversalRouter.showLoading('Fetching Receipt...');

    setTimeout(function() {
      var data = ReceiptReversalMockData.mockFetchReceiptDetails(rcptNo);
      ReceiptReversalRouter.hideLoading();

      if(!data) {
        JeevikaDialog.alert("Receipt not found or already reversed.", "Fetch Receipt");
        return;
      }

      fetchedReceiptData = data;
      currentFormBillType = data.billType || 'Maintenance';
      
      document.getElementById('rr-form-member').value = data.memberCode;
      updateMemberDisplay(data.memberCode);
      var radios = document.getElementsByName('rr_pay_mode');
      
      var bankAccs = ReceiptReversalMockData.getBankAccounts();
      var isOtherLedger = data.cashBank ? !bankAccs.includes(data.cashBank) : false;

      if (isOtherLedger) {
        radios[1].checked = true;
      } else {
        radios[0].checked = true;
      }

      toggleAccountType();

      // Ensure Debit Account Type radios remain disabled in Fetch mode
      var toggle = document.getElementById('rr-manual-toggle');
      if (!toggle || !toggle.checked) {
        for (var r = 0; r < radios.length; r++) {
          radios[r].setAttribute('disabled', 'true');
        }
        var payLabels = document.querySelectorAll('.rr-paymode-label');
        payLabels.forEach(function(l) { l.style.cursor = 'not-allowed'; });
      }

      if (radios[1].checked) {
        var ledSel = document.getElementById('rr-form-ledger-account');
        if (ledSel) ledSel.value = data.cashBank || '';
      } else {
        var depSel = document.getElementById('rr-form-account');
        if (depSel) depSel.value = data.cashBank || '';
        var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
        if (ledFetched) ledFetched.value = data.ledgerAccount || '';
      }

      if (document.getElementById('rr-form-transtype')) {
        document.getElementById('rr-form-transtype').value = data.transType || data.payMode || '';
      }
      document.getElementById('rr-form-chequeno').value = data.chqNo || '';
      document.getElementById('rr-form-chequedate').value = data.chqDate || '';
      if (document.getElementById('rr-form-refno')) {
        document.getElementById('rr-form-refno').value = data.refNo || '';
      }
      document.getElementById('rr-form-bank').value = data.bank || '';
      document.getElementById('rr-form-against').value = data.billNo || '';

      document.getElementById('rr-form-amount').value = data.amount;
      document.getElementById('rr-form-principal').value = data.principalCleared || data.amount;
      document.getElementById('rr-form-interest').value = data.interestCleared || 0;

      particulars = ['Reversal of Receipt ' + rcptNo];
      renderParticulars();
      
      document.getElementById('rr-ledger-empty').style.display = 'none';
      document.getElementById('rr-ledger-content').style.display = 'block';

      updateLedgerPreview();

    }, 600);
  }

  function updateLedgerPreview() {
    // Works for both fetched AND manual-entry modes — no early bail
    if(!fetchedReceiptData) {
      fetchedReceiptData = {
        receiptNo: (document.getElementById('rr-form-receiptno') || {}).value || 'MANUAL',
        billNo: (document.getElementById('rr-form-against') || {}).value || ''
      };
    }

    var amt = parseFloat(document.getElementById('rr-form-amount').value) || 0;
    var prin = parseFloat(document.getElementById('rr-form-principal').value) || 0;
    var int = parseFloat(document.getElementById('rr-form-interest').value) || 0;

    // Current Outstanding (Before Reversal)
    var curPrin = 5000;
    var curInt = 1200;
    
    document.getElementById('rr-led-prin').innerText = curPrin.toFixed(2);
    document.getElementById('rr-led-int').innerText = curInt.toFixed(2);
    document.getElementById('rr-led-tot').innerText = (curPrin + curInt).toFixed(2);

    // Reversal Adjustment
    document.getElementById('rr-adj-prin').innerText = prin.toFixed(2);
    document.getElementById('rr-adj-int').innerText = int.toFixed(2);

    // New Outstanding
    var newPrin = curPrin + prin;
    var newInt = curInt + int;
    document.getElementById('rr-new-prin').innerText = newPrin.toFixed(2);
    document.getElementById('rr-new-int').innerText = newInt.toFixed(2);
    document.getElementById('rr-new-tot').innerText = (newPrin + newInt).toFixed(2);

    var tbody = document.getElementById('rr-ledger-tbody');
    tbody.innerHTML = 
      '<tr><td>01/05/2025</td><td>' + (fetchedReceiptData.billNo || 'BILL/01') + '</td><td style="text-align:right;">2500.00</td><td style="text-align:right;">0.00</td></tr>' +
      '<tr><td>10/05/2025</td><td>' + fetchedReceiptData.receiptNo + '</td><td style="text-align:right;">0.00</td><td style="text-align:right;">' + amt.toFixed(2) + '</td></tr>' +
      '<tr style="font-weight:bold;color:#C62828;"><td>Now</td><td>Reversal</td><td style="text-align:right;">' + amt.toFixed(2) + '</td><td style="text-align:right;">0.00</td></tr>';
  }

  function gatherFormData() {
    var code = document.getElementById('rr-form-member').value;
    if(!code) { JeevikaDialog.alert("Please select a Member.", "Save Reversal"); return null; }

    var amtInput = document.getElementById('rr-form-amount');
    var amt = parseFloat(amtInput ? amtInput.value : 0) || 0;
    if(amt <= 0) { JeevikaDialog.alert("Please enter a valid Reversal Amount.", "Save Reversal"); return null; }

    if(!fetchedReceiptData) {
      fetchedReceiptData = {
        receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
        billNo: document.getElementById('rr-form-against').value || ''
      };
    }

    var radios = document.getElementsByName('rr_pay_mode');
    var mode = 'Cash/Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) mode = radios[i].value; }

    var acc = '';
    var ledgerAcc = '';
    if (mode === 'Other Ledger') {
      var ledSel = document.getElementById('rr-form-ledger-account');
      acc = ledSel ? ledSel.value : '';
      ledgerAcc = acc;
      if (!acc) { JeevikaDialog.alert("Please select a Ledger Account.", "Save Reversal"); return null; }
    } else {
      var depSel = document.getElementById('rr-form-account');
      acc = depSel ? depSel.value : '';
      var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
      ledgerAcc = ledFetched ? ledFetched.value : '';
      if (!acc) { JeevikaDialog.alert("Please select a Deposit Account.", "Save Reversal"); return null; }
    }

    var m = ReceiptReversalMockData.getMembers().find(function(x) { return x.code === code; });

    var filteredParts = particulars.map(function(p) { return p.trim(); }).filter(function(p) { return p.length > 0; });

    return {
      id: document.getElementById('rr-form-edit-id').value || null,
      reversalNo: document.getElementById('rr-form-revno').value,
      reversalDate: document.getElementById('rr-form-revdate').value,
      receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
      billType: currentFormBillType,
      
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      returnReason: document.getElementById('rr-form-reason').value || '',
      
      payMode: mode,
      cashBank: acc,
      ledgerAccount: ledgerAcc,
      amount: amt,
      
      principalRestored: parseFloat(document.getElementById('rr-form-principal').value) || 0,
      interestRestored: parseFloat(document.getElementById('rr-form-interest').value) || 0,
      
      chqNo: document.getElementById('rr-form-chequeno').value,
      chqDate: document.getElementById('rr-form-chequedate').value,
      bank: document.getElementById('rr-form-bank').value,
      transType: document.getElementById('rr-form-transtype') ? document.getElementById('rr-form-transtype').value : '',
      refNo: document.getElementById('rr-form-refno') ? document.getElementById('rr-form-refno').value : '',
      clearDate: '',
      
      billNo: document.getElementById('rr-form-against').value,
      particular1: filteredParts[0] || '',
      particular2: filteredParts[1] || '',
      particular3: filteredParts[2] || '',
      particulars: filteredParts,
      
      status: 'Reversed'
    };
  }

  async function saveReversal() {
    var obj = gatherFormData();
    if(obj) {
      await ReceiptReversalState.saveReversal(obj);
      ReceiptReversalRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      await ReceiptReversalState.saveReversal(obj);
      ReceiptReversalRouter.showPreview(obj.reversalNo);
    }
  }

  function clearForm() {
    JeevikaDialog.confirm("Are you sure you want to clear the form?", function() {
      initForm();
    }, "Clear Form");
  }

  function enableManualEdit() {
    var prin = document.getElementById('rr-form-principal');
    var intr = document.getElementById('rr-form-interest');
    if (prin) {
      prin.removeAttribute('disabled');
      prin.removeAttribute('readonly');
      prin.focus();
    }
    if (intr) {
      intr.removeAttribute('disabled');
      intr.removeAttribute('readonly');
    }

    // Ensure fetchedReceiptData is set so updateLedgerPreview works
    if (!fetchedReceiptData) {
      fetchedReceiptData = {
        receiptNo: (document.getElementById('rr-form-receiptno') || {}).value || 'MANUAL',
        billNo: (document.getElementById('rr-form-against') || {}).value || ''
      };
    }

    // Show the ledger preview panel
    var emptyLedger = document.getElementById('rr-ledger-empty');
    var contentLedger = document.getElementById('rr-ledger-content');
    if (emptyLedger) emptyLedger.style.display = 'none';
    if (contentLedger) contentLedger.style.display = 'block';

    updateLedgerPreview();
  }

  function toggleManualMode() {
    var toggle = document.getElementById('rr-manual-toggle');
    var isManual = toggle && toggle.checked;

    var rcptNoInput = document.getElementById('rr-form-receiptno');
    var fetchBtn = document.querySelector('.rr-fetch-btn');

    var radios = document.getElementsByName('rr_pay_mode');
    var payLabels = document.querySelectorAll('.rr-paymode-label');

    var memberNameInput = document.getElementById('rr-form-member-name');
    var memberSelectContainer = document.getElementById('rr-member-select-container');

    var fields = [
      { id: 'rr-form-member-code', isSelectOrDate: false },
      { id: 'rr-form-against', isSelectOrDate: false },
      { id: 'rr-form-transtype', isSelectOrDate: true },
      { id: 'rr-form-chequeno', isSelectOrDate: false },
      { id: 'rr-form-chequedate', isSelectOrDate: true },
      { id: 'rr-form-refno', isSelectOrDate: false },
      { id: 'rr-form-bank', isSelectOrDate: false },
      { id: 'rr-form-amount', isSelectOrDate: false },
      { id: 'rr-form-principal', isSelectOrDate: false },
      { id: 'rr-form-interest', isSelectOrDate: false }
    ];

    if (isManual) {
      // Disable receipt no & fetch btn
      if (rcptNoInput) {
        rcptNoInput.setAttribute('disabled', 'true');
        rcptNoInput.style.background = '#ECEFF1';
      }
      if (fetchBtn) {
        fetchBtn.setAttribute('disabled', 'true');
        fetchBtn.style.opacity = '0.5';
        fetchBtn.style.cursor = 'not-allowed';
      }

      // Enable Debit Account Type radios in Manual Mode
      for (var r = 0; r < radios.length; r++) {
        radios[r].removeAttribute('disabled');
      }
      payLabels.forEach(function(l) { l.style.cursor = 'pointer'; });

      // Show Searchable Member Select under Member Name, hide static read-only Member Name input
      if (memberNameInput) memberNameInput.style.display = 'none';
      if (memberSelectContainer) memberSelectContainer.style.display = 'block';

      // Enable the read-only / disabled fields
      fields.forEach(function(field) {
        var el = document.getElementById(field.id);
        if (!el) return;
        el.removeAttribute('readonly');
        el.removeAttribute('disabled');
        el.style.background = '#FFFFFF';
      });

      // Ensure fetchedReceiptData is set so updateLedgerPreview works
      if (!fetchedReceiptData) {
        fetchedReceiptData = {
          receiptNo: (document.getElementById('rr-form-receiptno') || {}).value || 'MANUAL',
          billNo: (document.getElementById('rr-form-against') || {}).value || ''
        };
      }

      // Show the ledger preview panel
      var emptyLedger = document.getElementById('rr-ledger-empty');
      var contentLedger = document.getElementById('rr-ledger-content');
      if (emptyLedger) emptyLedger.style.display = 'none';
      if (contentLedger) contentLedger.style.display = 'block';

      updateLedgerPreview();
    } else {
      // Disable Debit Account Type radios in Fetch Mode
      for (var r = 0; r < radios.length; r++) {
        radios[r].setAttribute('disabled', 'true');
      }
      payLabels.forEach(function(l) { l.style.cursor = 'not-allowed'; });

      // Hide Searchable Member Select, show static read-only Member Name input
      if (memberNameInput) memberNameInput.style.display = 'block';
      if (memberSelectContainer) memberSelectContainer.style.display = 'none';

      // Enable receipt no & fetch btn
      if (rcptNoInput) {
        rcptNoInput.removeAttribute('disabled');
        rcptNoInput.style.background = '';
      }
      if (fetchBtn) {
        fetchBtn.removeAttribute('disabled');
        fetchBtn.style.opacity = '';
        fetchBtn.style.cursor = '';
      }

      // Make fields read-only / disabled again
      fields.forEach(function(field) {
        var el = document.getElementById(field.id);
        if (!el) return;
        if (field.isSelectOrDate) {
          el.setAttribute('disabled', 'true');
        } else {
          el.setAttribute('readonly', 'true');
        }
        el.style.background = '#ECEFF1';
      });

      // Reset values back to default
      initForm();
    }
  }

  function repeatLastParticular1() {
    var code = document.getElementById('rr-form-member').value;
    if (!code) { alert("Please select a Member first."); return; }

    var reversals = ReceiptReversalState.getReversals() || [];
    var currentNo = document.getElementById('rr-form-revno').value;

    var memberReversals = reversals.filter(function(r) {
      return r.memberCode === code && r.reversalNo !== currentNo && (r.particular1 || r.particular);
    });

    if (memberReversals.length > 0) {
      memberReversals.sort(function(a, b) {
        return new Date(b.reversalDate) - new Date(a.reversalDate);
      });
      var lastVal = memberReversals[0].particular1 || memberReversals[0].particular;
      particulars[0] = lastVal;
      var el = document.getElementById('rr-form-particular');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 1 found for this member.");
    }
  }

  function repeatLastParticular2() {
    var code = document.getElementById('rr-form-member').value;
    if (!code) { alert("Please select a Member first."); return; }

    var reversals = ReceiptReversalState.getReversals() || [];
    var currentNo = document.getElementById('rr-form-revno').value;

    var memberReversals = reversals.filter(function(r) {
      return r.memberCode === code && r.reversalNo !== currentNo && r.particular2;
    });

    if (memberReversals.length > 0) {
      memberReversals.sort(function(a, b) {
        return new Date(b.reversalDate) - new Date(a.reversalDate);
      });
      var lastVal = memberReversals[0].particular2;
      particulars[1] = lastVal;
      var el = document.getElementById('rr-form-particular2');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 2 found for this member.");
    }
  }

  return {
    initForm: initForm,
    fetchReceipt: fetchReceipt,
    updateLedgerPreview: updateLedgerPreview,
    saveReversal: saveReversal,
    saveAndPreview: saveAndPreview,
    clearForm: clearForm,
    enableManualEdit: enableManualEdit,
    toggleAccountType: toggleAccountType,
    toggleManualMode: toggleManualMode,
    repeatLastParticular1: repeatLastParticular1,
    repeatLastParticular2: repeatLastParticular2
  };
})();
