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
    var heads = MemberBillMockData.getAccountHeads();

    if (gridItems.length === 0) {
      for (var i = 0; i < 4; i++) {
        gridItems.push(getEmptyRow());
      }
    }

    gridItems.forEach(function (item, index) {
      prinTot += (item.principal || 0);
      intTot += (item.interest || 0);
      finalTot += (item.total || 0);

      var code = MemberBillMockData.getAccountCode(item.accountHead);

      if (editIndex === index) {
        html += '<tr class="mb-grid-row mb-grid-editing">';
        html += '<td class="mb-grid-sr">' + (index + 1) + '</td>';
        
        // Account Code (Dropdown select)
        html += '<td><select id="grid-ac" class="mb-grid-input mb-grid-select" onchange="MemberBillGrid.onCodeChange()">';
        html += '<option value="">--Select--</option>';
        var codes = ['MNT-001', 'SNK-002', 'PRK-003', 'WTR-004', 'NOC-005', 'PEN-006'];
        codes.forEach(function(c) {
          html += '<option value="'+c+'" '+(code===c?'selected':'')+'>'+c+'</option>';
        });
        html += '</select></td>';
        
        // Acc Head
        html += '<td><select id="grid-ah" class="mb-grid-input mb-grid-select" onchange="MemberBillGrid.calcRow()">';
        html += '<option value="">--Select--</option>';
        heads.forEach(function(h) {
          html += '<option value="'+h+'" '+(item.accountHead===h?'selected':'')+'>'+h+'</option>';
        });
        html += '</select></td>';
        
        // Amount
        html += '<td><input type="number" id="grid-amount" class="mb-grid-input" style="text-align:right;" value="'+(item.total||0)+'" min="0" oninput="MemberBillGrid.calcRowManual()"></td>';
        
        html += '<td><button class="mb-action-btn mb-action-primary" style="padding:2px 6px;width:100%;" onclick="MemberBillGrid.saveRow()">OK</button></td>';
        
        html += '</tr>';
      } else {
        html += '<tr class="mb-grid-row" ondblclick="MemberBillGrid.editRow(' + index + ')">';
        html += '<td class="mb-grid-sr">' + (index + 1) + '</td>';
        html += '<td class="mb-grid-cell" style="font-family:monospace;font-size:11px;" onclick="MemberBillGrid.editRow(' + index + ')">' + code + '</td>';
        html += '<td class="mb-grid-cell" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.accountHead || '') + '</td>';
        html += '<td class="mb-grid-num" style="font-weight:bold;text-align:right;" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.total || 0).toFixed(2) + '</td>';
        
        html += '<td class="mb-grid-action">';
        html += '<button class="mb-grid-del-btn" onclick="MemberBillGrid.deleteRow(' + index + ')" title="Delete Row"><i class="bi bi-x-circle-fill"></i></button>';
        html += '</td>';
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
                        '<td></td></tr>';
    }

    if(typeof MemberBillForm !== 'undefined') MemberBillForm.updateGridTotals(prinTot, intTot);
  }

  function onCodeChange() {
    var code = document.getElementById('grid-ac').value;
    var head = '';
    switch (code) {
      case 'MNT-001': head = 'Maintenance Charges'; break;
      case 'SNK-002': head = 'Sinking Fund'; break;
      case 'PRK-003': head = 'Parking Charges'; break;
      case 'WTR-004': head = 'Water Charges'; break;
      case 'NOC-005': head = 'Non-Occupancy Charges'; break;
      case 'PEN-006': head = 'Penalty / Interest'; break;
    }
    document.getElementById('grid-ah').value = head;
  }

  function calcRow() {
    var head = document.getElementById('grid-ah').value;
    var code = MemberBillMockData.getAccountCode(head);
    var codeSelect = document.getElementById('grid-ac');
    if (codeSelect) codeSelect.value = code;
  }

  function calcRowManual() {
    // Amount updates totals directly, so no manual calculations are needed.
  }

  function getEmptyRow() {
    return { sr: gridItems.length+1, accountHead: '', particular1: '', particular2: '', qty: 1, rate: 0, principal: 0, interest: 0, total: 0 };
  }

  function addRow() {
    if(editIndex > -1) saveRow();
    gridItems.push(getEmptyRow());
    editIndex = gridItems.length - 1;
    renderGrid();
    setTimeout(function(){ document.getElementById('grid-ah').focus(); }, 50);
  }

  function editRow(index) {
    if(editIndex > -1) saveRow();
    editIndex = index;
    renderGrid();
    setTimeout(function(){ document.getElementById('grid-ah').focus(); }, 50);
  }

  function saveRow() {
    if(editIndex === -1) return;
    var item = gridItems[editIndex];
    item.accountHead = document.getElementById('grid-ah').value;
    var amt = parseFloat(document.getElementById('grid-amount').value) || 0;
    
    var isInterest = (item.accountHead === 'Penalty / Interest');
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

    if(!item.accountHead && item.total === 0) {
      gridItems.splice(editIndex, 1);
    }

    editIndex = -1;
    renderGrid();
  }

  function deleteRow(index) {
    gridItems.splice(index, 1);
    if(gridItems.length === 0) gridItems.push(getEmptyRow());
    renderGrid();
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
