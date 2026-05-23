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

      if (editIndex === index) {
        html += '<tr class="mb-grid-row mb-grid-editing">';
        html += '<td class="mb-grid-sr">' + (index + 1) + '</td>';
        
        // Account Head
        html += '<td><select id="grid-ah" class="mb-grid-input mb-grid-select" onchange="MemberBillGrid.calcRow()">';
        html += '<option value="">--Select--</option>';
        heads.forEach(function(h) {
          html += '<option value="'+h+'" '+(item.accountHead===h?'selected':'')+'>'+h+'</option>';
        });
        html += '</select></td>';
        
        // Particular 1
        html += '<td><input type="text" id="grid-p1" class="mb-grid-input" value="'+(item.particular1||'')+'"></td>';
        // Particular 2
        html += '<td><input type="text" id="grid-p2" class="mb-grid-input" value="'+(item.particular2||'')+'"></td>';
        
        // Qty
        html += '<td><input type="number" id="grid-qty" class="mb-grid-input" style="text-align:right;" value="'+(item.qty||1)+'" min="1" oninput="MemberBillGrid.calcRow()"></td>';
        // Rate
        html += '<td><input type="number" id="grid-rate" class="mb-grid-input" style="text-align:right;" value="'+(item.rate||0)+'" min="0" oninput="MemberBillGrid.calcRow()"></td>';
        
        // Principal
        html += '<td><input type="number" id="grid-prin" class="mb-grid-input" style="text-align:right;" value="'+(item.principal||0)+'" min="0" oninput="MemberBillGrid.calcRowManual()"></td>';
        // Interest
        html += '<td><input type="number" id="grid-int" class="mb-grid-input" style="text-align:right;" value="'+(item.interest||0)+'" min="0" oninput="MemberBillGrid.calcRowManual()"></td>';
        
        // Total (Readonly)
        html += '<td class="mb-grid-readonly" style="text-align:right;font-weight:bold;" id="grid-tot">' + (item.total||0).toFixed(2) + '</td>';
        
        html += '<td><button class="mb-action-btn mb-action-primary" style="padding:2px 6px;width:100%;" onclick="MemberBillGrid.saveRow()">OK</button></td>';
        
        html += '</tr>';
      } else {
        html += '<tr class="mb-grid-row" ondblclick="MemberBillGrid.editRow(' + index + ')">';
        html += '<td class="mb-grid-sr">' + (index + 1) + '</td>';
        html += '<td class="mb-grid-cell" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.accountHead || '') + '</td>';
        html += '<td class="mb-grid-cell" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.particular1 || '') + '</td>';
        html += '<td class="mb-grid-cell" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.particular2 || '') + '</td>';
        html += '<td class="mb-grid-num" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.qty || 1) + '</td>';
        html += '<td class="mb-grid-num" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.rate || 0).toFixed(2) + '</td>';
        html += '<td class="mb-grid-num" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.principal || 0).toFixed(2) + '</td>';
        html += '<td class="mb-grid-num" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.interest || 0).toFixed(2) + '</td>';
        html += '<td class="mb-grid-num" style="font-weight:bold;" onclick="MemberBillGrid.editRow(' + index + ')">' + (item.total || 0).toFixed(2) + '</td>';
        
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
                        '<td colspan="6" style="text-align:right;">TOTAL:</td>' +
                        '<td class="mb-grid-total">₹' + prinTot.toFixed(2) + '</td>' +
                        '<td class="mb-grid-total">₹' + intTot.toFixed(2) + '</td>' +
                        '<td class="mb-grid-total">₹' + finalTot.toFixed(2) + '</td>' +
                        '<td></td></tr>';
    }

    if(typeof MemberBillForm !== 'undefined') MemberBillForm.updateGridTotals(prinTot, intTot);
  }

  function calcRow() {
    var qty = parseFloat(document.getElementById('grid-qty').value) || 0;
    var rate = parseFloat(document.getElementById('grid-rate').value) || 0;
    
    var head = document.getElementById('grid-ah').value;
    var isInterest = (head === 'Penalty / Interest');

    var amt = qty * rate;
    
    if(isInterest) {
      document.getElementById('grid-prin').value = 0;
      document.getElementById('grid-int').value = amt.toFixed(2);
    } else {
      document.getElementById('grid-prin').value = amt.toFixed(2);
      document.getElementById('grid-int').value = 0;
    }
    
    document.getElementById('grid-tot').innerText = amt.toFixed(2);
  }

  function calcRowManual() {
    var prin = parseFloat(document.getElementById('grid-prin').value) || 0;
    var int = parseFloat(document.getElementById('grid-int').value) || 0;
    var tot = prin + int;
    document.getElementById('grid-tot').innerText = tot.toFixed(2);
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
    item.particular1 = document.getElementById('grid-p1').value;
    item.particular2 = document.getElementById('grid-p2').value;
    item.qty = parseFloat(document.getElementById('grid-qty').value) || 0;
    item.rate = parseFloat(document.getElementById('grid-rate').value) || 0;
    item.principal = parseFloat(document.getElementById('grid-prin').value) || 0;
    item.interest = parseFloat(document.getElementById('grid-int').value) || 0;
    item.total = item.principal + item.interest;

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
    calcRowManual: calcRowManual
  };
})();
