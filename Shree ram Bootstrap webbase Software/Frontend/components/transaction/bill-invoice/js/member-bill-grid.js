// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: FORM GRID CONTROLLER
// ═══════════════════════════════════════════════════════

var MemberBillGrid = (function () {

  var gridItems = [];
  var editIndex = -1;

  function loadItems(items) {
    gridItems = JSON.parse(JSON.stringify(items || []));
    editIndex = -1;
    renderGrid();
  }

  function getItems() {
    return gridItems.filter(function(i) { return i.accountHead || i.principal > 0; });
  }

  function renderGrid() {
    var tbody = document.getElementById('mb-grid-tbody');
    if (!tbody) return;

    var html = '';
    var prinTot = 0, intTot = 0, finalTot = 0;

    gridItems.forEach(function (item, index) {
      prinTot += (item.principal || 0);
      intTot += (item.interest || 0);
      finalTot += (item.total || 0);

      var code = item.accountCode || MemberBillMockData.getAccountCode(item.accountHead);

      if (editIndex === index) {
        html += '<tr class="mb-grid-row mb-grid-editing">';
        html += '<td class="mb-grid-sr">' + (index + 1) + '</td>';
        
        // Account Code (Static text)
        html += '<td style="font-family:monospace;font-size:11px;vertical-align:middle;padding:4px 8px;">' + code + '</td>';
        
        // Acc Head (Static text)
        html += '<td style="vertical-align:middle;padding:4px 8px;">' + (item.accountHead || '') + '</td>';
        
        // Amount (Editable Input)
        html += '<td><input type="number" id="grid-amount" class="mb-grid-input" style="text-align:right;" value="'+(item.total||0)+'" min="0" oninput="MemberBillGrid.calcRowManual()" onkeydown="if(event.key===\'Enter\') MemberBillGrid.saveRow(true)"></td>';
        
        html += '</tr>';
      } else {
        html += '<tr class="mb-grid-row" ondblclick="MemberBillGrid.editRow(' + index + ')">';
        html += '<td class="mb-grid-sr">' + (index + 1) + '</td>';
        html += '<td class="mb-grid-cell" style="font-family:monospace;font-size:11px;" onclick="MemberBillGrid.editRow(' + index + ')">' + code + '</td>';
        html += '<td class="mb-grid-cell" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.accountHead || '') + '</td>';
        html += '<td class="mb-grid-num" style="font-weight:bold;text-align:right;" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.total || 0).toFixed(2) + '</td>';
        
        html += '</tr>';
      }
    });

    tbody.innerHTML = html;

    // Render Tfoot
    var tfoot = document.getElementById('mb-grid-tfoot');
    if(tfoot) {
      tfoot.innerHTML = '<tr class="mb-grid-totals-row">' +
                        '<td colspan="3" style="text-align:right;">TOTAL:</td>' +
                        '<td class="mb-grid-total" style="text-align:right;font-weight:bold;">₹' + finalTot.toFixed(2) + '</td>' +
                        '</tr>';
    }

    if(typeof MemberBillForm !== 'undefined') MemberBillForm.updateGridTotals(prinTot, intTot);
  }

  function onCodeChange() {
  }

  function calcRow() {
  }

  function calcRowManual() {
  }

  function getEmptyRow() {
    return { sr: gridItems.length+1, accountCode: '', accountHead: '', particular1: '', particular2: '', qty: 1, rate: 0, principal: 0, interest: 0, total: 0 };
  }

  function addRow() {
  }

  function editRow(index) {
    if(editIndex > -1) saveRow();
    editIndex = index;
    renderGrid();
    setTimeout(function(){ 
      var amtInput = document.getElementById('grid-amount');
      if (amtInput) {
        amtInput.focus(); 
        amtInput.select();
      }
    }, 50);
  }

  function saveRow(goToNext) {
    if(editIndex === -1) return;
    var item = gridItems[editIndex];
    var amt = parseFloat(document.getElementById('grid-amount').value) || 0;
    
    var isInterest = (item.accountHead === 'Penalty / Interest' || item.accountHead === 'Interest');
    if (isInterest) {
      item.principal = 0;
      item.interest = amt;
    } else {
      item.principal = amt;
      item.interest = 0;
    }
    item.total = amt;
    
    // Maintain placeholders for rate/qty just in case
    item.qty = 1;
    item.rate = amt;

    // Recalculate CGST & SGST if auto-calculated GST is enabled
    var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'AUTO' || localStorage.getItem('jeevika_bm_gst_calc') === 'YES';
    if (gstEnabled) {
      var subtotal = 0;
      gridItems.forEach(function (it) {
        if (it.accountHead !== 'CGST' && it.accountHead !== 'SGST' && it.accountHead !== 'Penalty / Interest' && it.accountHead !== 'Interest') {
          subtotal += (it.total || 0);
        }
      });
      var cgstVal = subtotal * 0.09;
      var sgstVal = subtotal * 0.09;

      gridItems.forEach(function (it) {
        if (it.accountHead === 'CGST') {
          it.total = cgstVal;
          it.rate = cgstVal;
          it.principal = cgstVal;
        } else if (it.accountHead === 'SGST') {
          it.total = sgstVal;
          it.rate = sgstVal;
          it.principal = sgstVal;
        }
      });
    }

    var nextIndex = -1;
    if (goToNext) {
      nextIndex = editIndex + 1;
      if (nextIndex >= gridItems.length) {
        nextIndex = -1;
      }
    }

    editIndex = nextIndex;
    renderGrid();

    if (editIndex > -1) {
      setTimeout(function(){ 
        var amtInput = document.getElementById('grid-amount');
        if (amtInput) {
          amtInput.focus(); 
          amtInput.select();
        }
      }, 50);
    }
  }

  function deleteRow(index) {
  }

  return {
    loadItems: loadItems,
    getItems: getItems,
    addRow: addRow,
    editRow: editRow,
    saveRow: saveRow,
    deleteRow: deleteRow,
    calcRow: calcRow,
    calcRowManual: calcRowManual,
    onCodeChange: onCodeChange
  };
})();
