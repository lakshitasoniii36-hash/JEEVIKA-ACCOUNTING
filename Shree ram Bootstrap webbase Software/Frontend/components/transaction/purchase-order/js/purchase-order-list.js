// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: LIST / REGISTER
// ═══════════════════════════════════════════════════════

var PurchaseOrderList = (function () {

  var selectedPONo = null;
  var sortColumn = 'poNo';
  var sortDirection = 'asc';

  function refresh() {
    var list = PurchaseOrderState.getPOs() || [];
    
    // Sort
    list.sort(function(a, b) {
      var valA = a[sortColumn] || '';
      var valB = b[sortColumn] || '';
      if(typeof valA === 'string') valA = valA.toLowerCase();
      if(typeof valB === 'string') valB = valB.toLowerCase();
      if(valA < valB) return sortDirection === 'asc' ? -1 : 1;
      if(valA > valB) return sortDirection === 'asc' ? 1 : -1;
      return 0;
    });

    // Filters
    var fNo = (document.getElementById('po-filter-no') || {}).value || '';
    var fPerson = (document.getElementById('po-filter-person') || {}).value || '';
    var search = (document.getElementById('po-list-search') || {}).value || '';

    var filtered = list.filter(function(item) {
      if(fNo && (item.poNo || '').toLowerCase().indexOf(fNo.toLowerCase()) === -1) return false;
      if(fPerson && (item.personName || '').toLowerCase().indexOf(fPerson.toLowerCase()) === -1) return false;
      if(search) {
        var term = search.toLowerCase();
        return (item.poNo || '').toLowerCase().indexOf(term) > -1 ||
               (item.personName || '').toLowerCase().indexOf(term) > -1 ||
               (item.remark || '').toLowerCase().indexOf(term) > -1 ||
               (item.invoiceNo || '').toLowerCase().indexOf(term) > -1;
      }
      return true;
    });

    var tbody = document.getElementById('po-list-tbody');
    if(!tbody) return;

    var html = '';
    filtered.forEach(function(item) {
      var isSel = (item.poNo === selectedPONo);
      html += '<tr class="' + (isSel ? 'po-row-active' : '') + '" onclick="PurchaseOrderList.selectRow(\'' + item.poNo + '\')" ondblclick="PurchaseOrderRouter.showForm(\'' + item.poNo + '\')">';
      html += '<td>' + (item.poNo || '') + '</td>';
      html += '<td class="po-td-center">' + window.formatDateToDDMMYYYY(item.poDate) + '</td>';
      html += '<td>' + (item.personName || '') + '</td>';
      html += '<td class="po-td-right">' + parseFloat(item.amount || 0).toFixed(2) + '</td>';
      html += '<td>' + (item.invoiceNo || '—') + '</td>';
      html += '<td class="po-td-center">' + (item.invoiceDate ? window.formatDateToDDMMYYYY(item.invoiceDate) : '—') + '</td>';
      html += '<td>' + (item.period || '—') + '</td>';
      html += '<td class="po-td-narration">' + (item.particular1 || '') + '</td>';
      html += '<td class="po-td-center"><span class="po-status-badge po-status-posted">' + (item.status || 'Posted') + '</span></td>';
      html += '</tr>';
    });

    tbody.innerHTML = html;
    
    var countEl = document.getElementById('po-list-count');
    if(countEl) countEl.innerText = filtered.length + ' entries';
  }

  function selectRow(poNo) {
    selectedPONo = poNo;
    refresh();
  }

  function editSelected() {
    if(!selectedPONo) { alert("Please select a purchase order to edit."); return; }
    PurchaseOrderRouter.showForm(selectedPONo);
  }

  function deleteSelected() {
    if(!selectedPONo) {
      if (window.JeevikaDialog) JeevikaDialog.alert("Please select a purchase order to delete.", "Delete Purchase Order");
      else alert("Please select a purchase order to delete.");
      return;
    }
    var doDelete = function() {
      if (window.JeevikaDialog) {
        JeevikaDialog.confirm("Are you sure you want to delete purchase order: " + selectedPONo + "?", async function() {
          await PurchaseOrderState.deletePO(selectedPONo);
          selectedPONo = null;
          refresh();
        }, "Delete Purchase Order");
      } else if (confirm("Are you sure you want to delete purchase order: " + selectedPONo + "?")) {
        (async function() {
          await PurchaseOrderState.deletePO(selectedPONo);
          selectedPONo = null;
          refresh();
        })();
      }
    };
    doDelete();
  }

  function previewSelected() {
    if(!selectedPONo) { alert("Please select a purchase order to preview."); return; }
    PurchaseOrderRouter.showPreview(selectedPONo);
  }

  function toggleFilterBar() {
    var bar = document.getElementById('po-filter-bar');
    if(bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var fNo = document.getElementById('po-filter-no');
    if(fNo) fNo.value = '';
    var fPerson = document.getElementById('po-filter-person');
    if(fPerson) fPerson.value = '';
    refresh();
  }

  function setSortColumn(col) {
    if(sortColumn === col) {
      sortDirection = (sortDirection === 'asc') ? 'desc' : 'asc';
    } else {
      sortColumn = col;
      sortDirection = 'asc';
    }
    refresh();
  }

  return {
    refresh: refresh, selectRow: selectRow, editSelected: editSelected,
    deleteSelected: deleteSelected, previewSelected: previewSelected,
    toggleFilterBar: toggleFilterBar, clearFilters: clearFilters, setSortColumn: setSortColumn
  };
})();
