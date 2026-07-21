window.makeSearchableSelect = function(selectId, placeholder) {
  var selectEl = document.getElementById(selectId);
  if (!selectEl) return;
  
  // Prevent duplicate initialization
  if (selectEl.dataset.searchableInit) return;
  selectEl.dataset.searchableInit = "true";
  
  // Hide the original select
  selectEl.style.display = 'none';
  
  // Create wrapper
  var wrapper = document.createElement('div');
  wrapper.className = 'searchable-select-wrapper';
  wrapper.style.cssText = 'position: relative; width: 100%;';
  
  // Create input field
  var input = document.createElement('input');
  input.type = 'text';
  input.className = 'classic-erp-input searchable-select-input';
  input.placeholder = placeholder || (selectEl.options[0] ? selectEl.options[0].text : '— Select Option —');
  input.style.cssText = 'width: 100%; height: 30px; padding-right: 24px; box-sizing: border-box; text-overflow: ellipsis;';
  
  // Create arrow indicator
  var arrow = document.createElement('span');
  arrow.innerHTML = '▼';
  arrow.style.cssText = 'position: absolute; right: 8px; top: 50%; transform: translateY(-50%) scaleY(0.6); pointer-events: none; color: #888; font-size: 10px; font-weight: bold;';
  
  // Create dropdown container
  var dropdown = document.createElement('div');
  dropdown.className = 'searchable-select-dropdown';
  dropdown.style.cssText = 'display: none; position: absolute; top: 32px; left: 0; right: 0; max-height: 220px; overflow-y: auto; background: white; border: 1px solid #808080; border-radius: 4px; box-shadow: 0 4px 10px rgba(0,0,0,0.15); z-index: 10000; box-sizing: border-box;';
  
  // Append elements
  wrapper.appendChild(input);
  wrapper.appendChild(arrow);
  wrapper.appendChild(dropdown);
  selectEl.parentNode.insertBefore(wrapper, selectEl);
  
  var highlightedIndex = -1;
  var visibleItems = [];
  
  // Helper to build list items
  function rebuildOptions() {
    dropdown.innerHTML = '';
    var options = Array.from(selectEl.options);
    
    options.forEach(function(opt, index) {
      // Skip empty initial placeholders
      if (opt.value === "" && index === 0) return;
      
      var div = document.createElement('div');
      div.className = 'searchable-select-item';
      div.dataset.value = opt.value;
      div.dataset.code = opt.getAttribute('data-code') || '';
      div.textContent = opt.text;
      div.style.cssText = 'padding: 6px 10px; font-size: 11px; cursor: pointer; color: black; border-bottom: 1px dashed #E0E0E0; font-family: sans-serif; text-align: left;';
      
      // Hover effect
      div.onmouseover = function() {
        setHighlight(visibleItems.indexOf(div));
      };
      
      div.onclick = function() {
        selectItem(opt.value, opt.text);
      };
      
      dropdown.appendChild(div);
    });
    
    // Sync current input value
    var selectedOpt = selectEl.options[selectEl.selectedIndex];
    if (selectedOpt && selectedOpt.value !== "") {
      input.value = selectedOpt.text;
    } else {
      input.value = '';
    }
  }
  
  function setHighlight(index) {
    if (visibleItems.length === 0) return;
    // Remove existing highlights
    visibleItems.forEach(function(item) {
      item.style.background = 'white';
      item.style.color = 'black';
    });
    
    highlightedIndex = index;
    if (highlightedIndex < 0) highlightedIndex = 0;
    if (highlightedIndex >= visibleItems.length) highlightedIndex = visibleItems.length - 1;
    
    var activeItem = visibleItems[highlightedIndex];
    if (activeItem) {
      activeItem.style.background = '#1565C0';
      activeItem.style.color = 'white';
      // Scroll into view if needed
      var dropdownTop = dropdown.scrollTop;
      var dropdownBottom = dropdownTop + dropdown.clientHeight;
      var itemTop = activeItem.offsetTop;
      var itemBottom = itemTop + activeItem.clientHeight;
      
      if (itemBottom > dropdownBottom) {
        dropdown.scrollTop = itemBottom - dropdown.clientHeight;
      } else if (itemTop < dropdownTop) {
        dropdown.scrollTop = itemTop;
      }
    }
  }
  
  function selectItem(value, text) {
    selectEl.value = value;
    input.value = text;
    // Trigger onchange on backing select
    selectEl.dispatchEvent(new Event('change'));
    hideDropdown();
  }
  
  function filterItems() {
    var query = input.value.toLowerCase().trim();
    var items = Array.from(dropdown.getElementsByClassName('searchable-select-item'));
    visibleItems = [];
    
    items.forEach(function(item) {
      var text = item.textContent.toLowerCase();
      var code = item.dataset.code.toLowerCase();
      var value = item.dataset.value.toLowerCase();
      
      if (text.indexOf(query) > -1 || code.indexOf(query) > -1 || value.indexOf(query) > -1) {
        item.style.display = 'block';
        visibleItems.push(item);
      } else {
        item.style.display = 'none';
      }
    });
    
    setHighlight(0);
  }
  
  function showDropdown() {
    dropdown.style.display = 'block';
    input.select();
    // Reset filters on show
    var items = Array.from(dropdown.getElementsByClassName('searchable-select-item'));
    visibleItems = items;
    items.forEach(function(item) { item.style.display = 'block'; });
    
    // Highlight currently selected item if any
    var currentText = input.value;
    var idx = visibleItems.findIndex(function(item) { return item.textContent === currentText; });
    setHighlight(idx >= 0 ? idx : 0);
  }
  
  function hideDropdown() {
    setTimeout(function() {
      dropdown.style.display = 'none';
      // If nothing selected or input was cleared/mismatched, restore active select label
      var selectedOpt = selectEl.options[selectEl.selectedIndex];
      if (selectedOpt && selectedOpt.value !== "") {
        input.value = selectedOpt.text;
      } else {
        input.value = '';
      }
    }, 150);
  }
  
  // Event listeners on input
  input.onfocus = function() {
    showDropdown();
  };
  
  input.oninput = function() {
    dropdown.style.display = 'block';
    filterItems();
  };
  
  input.onkeydown = function(e) {
    if (dropdown.style.display === 'none') {
      if (e.key === 'ArrowDown' || e.key === 'ArrowUp' || e.key === 'Enter') {
        showDropdown();
        e.preventDefault();
      }
      return;
    }
    
    if (e.key === 'ArrowDown') {
      e.preventDefault();
      setHighlight(highlightedIndex + 1);
    } else if (e.key === 'ArrowUp') {
      e.preventDefault();
      setHighlight(highlightedIndex - 1);
    } else if (e.key === 'Enter') {
      e.preventDefault();
      if (visibleItems[highlightedIndex]) {
        var val = visibleItems[highlightedIndex].dataset.value;
        var txt = visibleItems[highlightedIndex].textContent;
        selectItem(val, txt);
      }
    } else if (e.key === 'Escape') {
      e.preventDefault();
      hideDropdown();
    }
  };
  
  // Close when user clicks outside
  document.addEventListener('click', function(e) {
    if (!wrapper.contains(e.target)) {
      dropdown.style.display = 'none';
      var selectedOpt = selectEl.options[selectEl.selectedIndex];
      if (selectedOpt && selectedOpt.value !== "") {
        input.value = selectedOpt.text;
      } else {
        input.value = '';
      }
    }
  }, true);
  
  // Observe changes to the underlying select options
  var observer = new MutationObserver(function() {
    rebuildOptions();
  });
  observer.observe(selectEl, { childList: true, subtree: true });
  
  // Initial build
  rebuildOptions();
};
