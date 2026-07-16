// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — WORKSPACE ENGINE
// ═══════════════════════════════════════════════════════

const WorkspaceManager = {

  // State
  openTabs: [],       // [{ id, label, moduleFile, active }]
  activeTab: null,     // current active tab id
  isDirty: false,      // Track if changes have been made in active tab

  // ── Helper ───────────────────────────────────────────
  discardBillingMasterChanges() {
    if (window.BM && typeof window.BM.closeConfirm === 'function') {
      window.BM.closeConfirm(false);
    } else {
      delete window.tempBillingMasterMembers;
      delete window.tempBillingMasterOriginalMembers;
      window.tempBillingMasterHasChanges = false;
    }
  },

  hasUnsavedChanges() {
    if (this.activeTab === 'billing-master') {
      return !!window.tempBillingMasterHasChanges;
    }

    const workspace = document.getElementById('workspace-content');
    if (!workspace) return false;

    // Check if there is a visible cancel button in the workspace
    const cancelBtns = Array.from(workspace.querySelectorAll('[id$="-btn-cancel"]'));
    const visibleCancelBtn = cancelBtns.find(btn => btn.style.display !== 'none' && btn.offsetWidth > 0 && btn.offsetHeight > 0);

    if (!visibleCancelBtn) {
      this.isDirty = false; // Auto-reset when out of edit mode
      return false;
    }

    return !!this.isDirty;
  },

  // ── Tab Management ───────────────────────────────────

  async openTab(moduleId, label) {
    if (this.activeTab && this.activeTab !== moduleId && this.hasUnsavedChanges()) {
      const confirmLeave = await window.JeevikaDialog.confirm(
        "Are you sure you want to leave without saving changes?",
        null,
        "Unsaved Changes"
      );
      if (!confirmLeave) return;
      if (this.activeTab === 'billing-master') this.discardBillingMasterChanges();
    }

    const existing = this.openTabs.find(t => t.id === moduleId);
    if (existing) {
      await this.activateTab(moduleId, true);
      return;
    }

    // Add new tab
    this.openTabs.push({ id: moduleId, label: label || this.getLabel(moduleId), active: false });
    await this.activateTab(moduleId, true);
    this.renderTabBar();
  },

  async activateTab(moduleId, bypassConfirm = false) {
    if (!bypassConfirm && this.activeTab && this.activeTab !== moduleId && this.hasUnsavedChanges()) {
      const confirmLeave = await window.JeevikaDialog.confirm(
        "Are you sure you want to leave without saving changes?",
        null,
        "Unsaved Changes"
      );
      if (!confirmLeave) {
        this.highlightSidebarItem(this.activeTab);
        this.renderTabBar();
        return;
      }
      if (this.activeTab === 'billing-master') this.discardBillingMasterChanges();
    }

    this.openTabs.forEach(t => t.active = (t.id === moduleId));
    this.activeTab = moduleId;
    await this.loadModule(moduleId);
    this.renderTabBar();
    this.highlightSidebarItem(moduleId);
  },

  async closeTab(moduleId) {
    const idx = this.openTabs.findIndex(t => t.id === moduleId);
    if (idx === -1) return;

    if (this.activeTab === moduleId && this.hasUnsavedChanges()) {
      const confirmLeave = await window.JeevikaDialog.confirm(
        "Are you sure you want to leave without saving changes?",
        null,
        "Unsaved Changes"
      );
      if (!confirmLeave) return;
      if (moduleId === 'billing-master') this.discardBillingMasterChanges();
    }

    this.openTabs.splice(idx, 1);
    // Activate adjacent tab
    if (this.activeTab === moduleId) {
      const next = this.openTabs[idx] || this.openTabs[idx - 1];
      if (next) await this.activateTab(next.id, true);
      else { this.activeTab = null; this.showWelcome(); }
    }
    this.renderTabBar();
  },

  async closeAllTabs() {
    if (this.hasUnsavedChanges()) {
      const confirmLeave = await window.JeevikaDialog.confirm(
        "Are you sure you want to leave without saving changes?",
        null,
        "Unsaved Changes"
      );
      if (!confirmLeave) return;
      if (this.activeTab === 'billing-master' || this.openTabs.some(t => t.id === 'billing-master')) {
        this.discardBillingMasterChanges();
      }
    }
    this.openTabs = [];
    this.activeTab = null;
    this.showWelcome();
    this.renderTabBar();
  },

  async closeOtherTabs(keepId) {
    if (this.activeTab !== keepId && this.hasUnsavedChanges()) {
      const confirmLeave = await window.JeevikaDialog.confirm(
        "Are you sure you want to leave without saving changes?",
        null,
        "Unsaved Changes"
      );
      if (!confirmLeave) return;
      if (this.activeTab === 'billing-master') this.discardBillingMasterChanges();
    }
    this.openTabs = this.openTabs.filter(t => t.id === keepId);
    await this.activateTab(keepId, true);
    this.renderTabBar();
  },

  // ── Module Loading ────────────────────────────────────

  async loadModule(moduleId) {
    this.isDirty = false; // Reset dirty flag when loading a new module
    const workspace = document.getElementById('workspace-content');
    if (!workspace) return;

    // Show loading
    workspace.innerHTML = `<div class="workspace-loading">
      <div class="spinner"></div><p>Loading...</p>
    </div>`;

    try {
      // Try to load from components folder using its category path
      const category = (typeof ModulesCategoryMap !== 'undefined' && ModulesCategoryMap[moduleId]) ? ModulesCategoryMap[moduleId] : 'master';
      const res = await fetch(`components/${category}/${moduleId}/${moduleId}.html`, { cache: 'no-cache' });
      if (res.ok) {
        const html = await res.text();
        workspace.innerHTML = html;

        // Inject <link> stylesheets into <head>
        workspace.querySelectorAll('link[rel="stylesheet"]').forEach(link => {
          const existing = document.querySelector(`link[href="${link.getAttribute('href')}"]`);
          if (!existing) {
            const nl = document.createElement('link');
            nl.rel = 'stylesheet';
            nl.href = link.getAttribute('href');
            document.head.appendChild(nl);
          }
          link.remove();
        });

        // Execute scripts (supports both inline and external src) in order
        const scripts = Array.from(workspace.querySelectorAll('script'));
        window.isSeedingPhase = true;
        const loadScriptsSequentially = (idx) => {
          if (idx >= scripts.length) {
            window.isSeedingPhase = false;
            // All scripts loaded — call init function
            const initFn = window[`init_${moduleId.replace(/-/g, '_')}`];
            if (typeof initFn === 'function') initFn();
            return;
          }
          const s = scripts[idx];
          const srcAttr = s.getAttribute('src');
          const ns = document.createElement('script');
          s.remove();
          if (srcAttr) {
            // External script — load via src with onload chain
            ns.src = srcAttr;
            ns.onload = () => loadScriptsSequentially(idx + 1);
            ns.onerror = () => {
              console.error('Failed to load script:', srcAttr);
              loadScriptsSequentially(idx + 1);
            };
            document.head.appendChild(ns);
          } else {
            // Inline script — execute immediately, then proceed
            ns.textContent = s.textContent;
            document.head.appendChild(ns);
            loadScriptsSequentially(idx + 1);
          }
        };
        loadScriptsSequentially(0);
      } else {
        workspace.innerHTML = this.buildPlaceholder(moduleId);
      }
    } catch (e) {
      workspace.innerHTML = this.buildPlaceholder(moduleId);
    }
    // Inject society info into module header
    this.injectSocietyInfo();
  },

  buildPlaceholder(moduleId) {
    const label = this.getLabel(moduleId);
    return `
    <div class="module-panel">
      <div class="module-header">
        <div>
          <h2 class="module-title">${label}</h2>
          <div class="module-subtitle">
            <span class="module-society"></span>
            <span class="module-year"></span>
          </div>
        </div>
        <button class="btn-sa-path">⚙ SA PATH</button>
      </div>
      <div class="module-body">
        <div class="empty-state">
          <div class="empty-icon">📋</div>
          <p>No records found.</p>
          <p class="empty-sub">This module is under development.</p>
        </div>
      </div>
    </div>`;
  },

  injectSocietyInfo() {
    const society = window.currentSociety || {};
    document.querySelectorAll('.module-society').forEach(el => {
      el.innerHTML = `<span class="icon-loc">◎</span> ${society.name || 'Society Name'}`;
    });
    document.querySelectorAll('.module-year').forEach(el => {
      el.innerHTML = `<span class="icon-cal">📅</span> ${society.year || '2025-26'}`;
    });
  },

  showWelcome() {
    this.isDirty = false; // Reset dirty flag when going to welcome screen
    const workspace = document.getElementById('workspace-content');
    if (!workspace) return;
    workspace.innerHTML = `
    <div class="welcome-state">
      <div class="welcome-logo">J</div>
      <h2>JEEVIKA ERP</h2>
      <p>Select a module from the menu or sidebar to get started.</p>
      <div class="welcome-shortcuts">
        <p>Quick Access: Use <kbd>Alt+R</kbd> for Receipt, <kbd>Alt+M</kbd> for Member Master</p>
      </div>
    </div>`;
  },

  // ── Tab Bar Rendering ─────────────────────────────────

  renderTabBar() {
    const bar = document.getElementById('tab-bar-inner');
    if (!bar) return;
    bar.innerHTML = this.openTabs.map(t => `
    <div class="tab-item ${t.active ? 'active' : ''}"
         data-tab-id="${t.id}"
         onclick="WorkspaceManager.activateTab('${t.id}')"
         oncontextmenu="WorkspaceManager.showTabContextMenu(event,'${t.id}')">
      <span class="tab-label">${t.label}</span>
      <button class="tab-close" onclick="event.stopPropagation();
              WorkspaceManager.closeTab('${t.id}')">×</button>
    </div>`).join('');
    this.scrollActiveTabIntoView();
  },

  scrollActiveTabIntoView() {
    const bar = document.getElementById('tab-bar-inner');
    const active = bar?.querySelector('.tab-item.active');
    if (active) active.scrollIntoView({ inline: 'nearest', behavior: 'smooth' });
  },

  // ── Context Menu ──────────────────────────────────────

  showTabContextMenu(e, tabId) {
    e.preventDefault();
    const existing = document.getElementById('tab-context-menu');
    if (existing) existing.remove();
    const menu = document.createElement('div');
    menu.id = 'tab-context-menu';
    menu.style.cssText = `
      position:fixed;top:${e.clientY}px;left:${e.clientX}px;
      background:white;border:1px solid #E0E0E0;border-radius:4px;
      box-shadow:0 4px 12px rgba(0,0,0,0.15);z-index:9999;min-width:160px;
    `;
    menu.innerHTML = `
      <div class="ctx-item" onclick="WorkspaceManager.closeTab('${tabId}');document.getElementById('tab-context-menu').remove()">Close</div>
      <div class="ctx-item" onclick="WorkspaceManager.closeOtherTabs('${tabId}');document.getElementById('tab-context-menu').remove()">Close Others</div>
      <div class="ctx-item" onclick="WorkspaceManager.closeAllTabs();document.getElementById('tab-context-menu').remove()">Close All</div>
    `;
    document.body.appendChild(menu);
    setTimeout(() => document.addEventListener('click', () => menu.remove(), { once: true }), 10);
  },

  // ── Sidebar Sync ──────────────────────────────────────

  highlightSidebarItem(moduleId) {
    document.querySelectorAll('.sidebar-sub-item').forEach(el => {
      el.classList.toggle('active', el.dataset.module === moduleId);
    });
  },

  // ── Top Nav Filter ────────────────────────────────────

  filterSidebar(category) {
    document.querySelectorAll('.top-nav-item').forEach(el => {
      el.classList.toggle('active', el.dataset.category === category);
    });
    const allSections = document.querySelectorAll('.sidebar-section');
    allSections.forEach(sec => {
      sec.style.display = (sec.dataset.category === category || category === 'all') ? '' : 'none';
    });
  },

  // ── Label Map ─────────────────────────────────────────

  getLabel(moduleId) {
    const map = {
      'society-master': 'Society Master',
      'group-master': 'Group Master',
      'account-master': 'Account Master',
      'member-master': 'Member Master',
      'billing-master': 'Billing Master',
      'bill-type-master': 'Bill Type & Notes Master',
      'opening-bank-reco': 'Opening Bank Reco',
      'opening-balances': 'Opening Balances',
      'bill-print-setup': 'Bill Print Setup',
      'gst-master': 'GST Master',
      'committee-master': 'Committee Master',
      'staff-master': 'Staff Master',
      'vendor-master': 'Vendor Master',
      'transaction-types-notes-master': 'Transaction Types & Notes Master',
      'bill-invoice': 'Bill / Invoice Generation',
      'member-receipt': 'Member Receipt Entry',
      'receipt-reversal': 'Member Receipt Reversal',
      'debit-note': 'Member Debit Note',
      'credit-note': 'Member Credit Note',
      'bill-type-transfer': 'Member Bill Type Transfer',
      'other-receipt': 'Other Receipt Entry',
      'payment-entry': 'Payment Entry (Voucher)',
      'contra-entry': 'Contra Entry',
      'journal-voucher': 'Journal Voucher (JV)',
      'purchase-order': 'Purchase Order (PO)',
      'outstanding-list': 'Outstanding List',
      'member-register': 'Member Register [Dr/Cr]',
      'member-account': 'Member Account | Head wise',
      'society-account': 'Member Control Account',
      'balance-confirm-letter': 'Balance Confirmation Letter',
      'data-sheet': 'Data Sheet',
      'bank-deposit-list': 'Bank Deposit List',
      'fund-register': 'Fund Register',
      'cheque-list': 'Cheque List',
      'adjustment-list': 'Adjustment List',
      'bill-format': 'Bill Format',
      'receipt-format': 'Receipt Format',
      'debit-note-half': 'Debit Note - Half Page',
      'debit-note-14': 'Debit Note - Full Page 14 Head',
      'debit-note-21': 'Debit Note - Full Page 21 Head',
      'credit-note-half': 'Credit Note - Half Page',
      'credit-note-14': 'Credit Note - Full Page 14 Head',
      'credit-note-21': 'Credit Note - Full Page 21 Head',
      'bill-register-summary': 'Bill Register Summary',
      'bill-register-detailed': 'Bill Register Detailed',
      'receipt-register': 'Receipt Register',
      'debit-note-register': 'Debit Note Register',
      'credit-note-register': 'Credit Note Register',
      'adjustment-register': 'Adjustment Register',
      'member-jv-register': 'Member JV Register',
      'cash-book': 'Cash Book',
      'bank-book': 'Bank Book',
      'account-ledger': 'Account Ledger',
      'trial-balance': 'Trial Balance',
      'balance-sheet': 'Balance Sheet',
      'income-expenditure': 'Income & Expenditure',
      'monthly-report': 'Monthly Report',
      'receipt-register': 'Receipt Register',
      'payment-register': 'Payment Register',
      'contra-entry': 'Contra Entry',
      'bank-reconciliation': 'Bank Reconciliation',
      'ledger': 'Ledger',
    };
    return map[moduleId] || moduleId.replace(/-/g, ' ').replace(/\b\w/g, c => c.toUpperCase());
  },

  // ── Init ─────────────────────────────────────────────

  init() {
    this.showWelcome();
    this.renderTabBar();
    // Load society info from API
    this.loadSocietyInfo();
    // Bind keyboard shortcuts
    this.bindKeyboard();
    // Bind tab bar scroll arrows
    document.getElementById('tab-scroll-left')?.addEventListener('click', () => {
      document.getElementById('tab-bar-inner').scrollBy(-120, 0);
    });
    document.getElementById('tab-scroll-right')?.addEventListener('click', () => {
      document.getElementById('tab-bar-inner').scrollBy(120, 0);
    });

    // Global dirty state tracking for form edits
    const workspace = document.getElementById('workspace-content');
    if (workspace) {
      const markDirty = () => {
        // Only mark dirty if a cancel button is currently visible (i.e. in edit/alter mode)
        const cancelBtns = workspace.querySelectorAll('[id$="-btn-cancel"]');
        const isEditing = Array.from(cancelBtns).some(btn => btn.style.display !== 'none' && btn.offsetWidth > 0 && btn.offsetHeight > 0);
        if (isEditing) {
          this.isDirty = true;
        }
      };

      workspace.addEventListener('input', markDirty);
      workspace.addEventListener('change', markDirty);
      workspace.addEventListener('paste', markDirty);

      workspace.addEventListener('click', (e) => {
        if (e.target && (
          e.target.type === 'checkbox' ||
          e.target.type === 'radio' ||
          e.target.type === 'file' ||
          e.target.closest('.signature-upload') ||
          e.target.closest('[id$="-btn-upload"]') ||
          e.target.closest('.signature-preview-container') ||
          e.target.closest('.delete-sig-btn')
        )) {
          markDirty();
        }

        // If they click any alter, new, or add button, reset dirty flag for the new session
        const editTrigger = e.target.closest('[id$="-btn-alter"], [id$="-btn-new"], [id$="-btn-add"]');
        if (editTrigger) {
          this.isDirty = false;
        }
      });

      workspace.addEventListener('dblclick', (e) => {
        // If they double click a row (typically triggers alter), reset dirty flag for the new session
        const row = e.target.closest('tr');
        if (row) {
          this.isDirty = false;
        }
      });
    }

    // Global intercept for CANCEL button clicks inside modules
    document.addEventListener('click', async (event) => {
      const cancelBtn = event.target.closest('[id$="-btn-cancel"]');
      if (cancelBtn) {
        // Verify cancel button is visible
        if (cancelBtn.style.display === 'none' || cancelBtn.offsetWidth === 0) {
          return;
        }

        // If already confirmed, let it proceed
        if (cancelBtn.dataset.confirmed === 'true') {
          delete cancelBtn.dataset.confirmed;
          return;
        }

        // If form is not dirty, no need to show popup, just let it cancel
        if (!this.isDirty) {
          return;
        }

        // Intercept click
        event.preventDefault();
        event.stopPropagation();

        const confirmed = await window.JeevikaDialog.confirm(
          "Are you sure you want to leave without saving changes?",
          null,
          "Unsaved Changes"
        );

        if (confirmed) {
          this.isDirty = false; // Reset dirty state
          cancelBtn.dataset.confirmed = 'true';
          cancelBtn.click();
        }
      }
    }, true); // Use capture phase to intercept before inline onclick handlers execute

    // Intercept browser page refresh or close
    window.addEventListener('beforeunload', (e) => {
      if (this.hasUnsavedChanges()) {
        e.preventDefault();
        e.returnValue = 'Are you sure you want to leave without saving changes?';
        return e.returnValue;
      }
    });
  },

  async loadSocietyInfo() {
    try {
      const res = await fetch('http://localhost:5002/api/workspace/society/active');

      if (res.ok) {
        const result = await res.json();
        window.currentSociety = result.data || result;
        // Update topbar
        const el = document.getElementById('active-society-name');
        if (el) el.textContent = window.currentSociety.name || window.currentSociety.SocietyName || 'Society Name';

        // Update GST Master visibility in sidebar
        this.updateGstMenuVisibility();
      }
    } catch (e) { /* use defaults */ }
  },

  updateGstMenuVisibility() {
    const isGstEnabled = window.currentSociety && (window.currentSociety.GSTApplicable === 'Y' || window.currentSociety.gstApplicable === 'Y');
    const gstMenuItem = document.querySelector('.sidebar-sub-item[data-module="gst-master"]');
    if (gstMenuItem) {
      gstMenuItem.style.display = isGstEnabled ? '' : 'none';
    }
  },

  // Set active society context (for workspace switching)
  async setActiveSociety(societyCode, societyName) {
    try {
      localStorage.setItem('jeevika_active_society', societyCode);
      localStorage.setItem('jeevika_active_society_name', societyName);

      // Update current society object
      window.currentSociety = {
        code: societyCode,
        name: societyName,
        year: '2025-26'
      };

      // Update module subtitles across all open tabs
      this.injectSocietyInfo();

      // Update topbar
      const el = document.getElementById('active-society-name');
      if (el) el.textContent = societyName;

      // Call backend to set active society
      await fetch('http://localhost:5002/api/workspace/society/switch', {

        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ societyCode, societyName })
      });

      // Clear Billing Master temporary cache
      delete window.tempBillingMasterMembers;
      delete window.tempBillingMasterOriginalMembers;
      window.tempBillingMasterHasChanges = false;

      // Fetch active society info to get GSTApplicable etc.
      await this.loadSocietyInfo();

      // Reload the active tab if there is one
      if (this.activeTab) {
        await this.loadModule(this.activeTab);
      }

      return true;
    } catch (e) {
      console.error('Error setting active society:', e);
      return false;
    }
  },

  bindKeyboard() {
    const map = {
      'a': 'account-master', 'm': 'member-master',
      'r': 'member-receipt', 'c': 'contra-entry',
      'b': 'bank-reconciliation', 'i': 'bill-invoice',
      'p': 'member-receipt', 'l': 'account-ledger',
      't': 'trial-balance', 's': 'balance-sheet',
      'd': 'data-sheet', 'q': 'cheque-list',
      'g': 'group-master'
    };
    document.addEventListener('keydown', e => {
      // Toggle shortcuts panel on Ctrl + Alt + S
      if (e.ctrlKey && e.altKey && e.key.toLowerCase() === 's') {
        e.preventDefault();
        toggleShortcutsPanel();
        return;
      }

      if (e.altKey && map[e.key.toLowerCase()]) {
        e.preventDefault();
        this.openTab(map[e.key.toLowerCase()]);
      }
    });
  }
};

// Sidebar toggle (collapse/expand parent items)
function toggleSidebarSection(parentEl) {
  const sub = parentEl.nextElementSibling;
  if (!sub || !sub.classList.contains('sidebar-sub-list')) return;
  const isOpen = sub.style.display !== 'none';
  sub.style.display = isOpen ? 'none' : 'block';
  parentEl.querySelector('.sidebar-arrow')?.classList.toggle('open', !isOpen);
}

// Nested sidebar subgroup toggle (collapse/expand sub-menus)
function toggleSidebarSubGroup(toggleEl) {
  const subList = toggleEl.nextElementSibling;
  const arrow = toggleEl.querySelector('.sidebar-sub-arrow');
  if (subList && subList.classList.contains('sidebar-sub-group-list')) {
    const isOpen = subList.style.display === 'block';
    subList.style.display = isOpen ? 'none' : 'block';
    if (arrow) {
      arrow.classList.toggle('open', !isOpen);
    }
  }
}

// Shortcuts panel collapse
function toggleShortcutsPanel() {
  const panel = document.getElementById('shortcuts-panel');
  const btn = document.getElementById('shortcuts-toggle');
  const isCollapsed = panel.classList.toggle('collapsed');
  btn.textContent = isCollapsed ? '<' : '>';
}

// Global Date Formatting Utility (dd-mm-yyyy)
window.formatDateToDDMMYYYY = function (dateStr) {
  if (!dateStr || dateStr === '-') return dateStr || '-';
  // If already in dd-mm-yyyy format, return as is
  if (/^\d{2}-\d{2}-\d{4}$/.test(dateStr)) return dateStr;

  // If in yyyy-mm-dd format (e.g. 2025-05-12)
  var parts = dateStr.split('-');
  if (parts.length === 3) {
    if (parts[0].length === 4) {
      return parts[2] + '-' + parts[1] + '-' + parts[0];
    }
  }

  // Fallback to parse standard Date/ISO string
  try {
    var d = new Date(dateStr);
    if (!isNaN(d.getTime())) {
      var day = String(d.getDate()).padStart(2, '0');
      var month = String(d.getMonth() + 1).padStart(2, '0');
      var year = d.getFullYear();
      return day + '-' + month + '-' + year;
    }
  } catch (e) { }

  return dateStr;
};

// Custom Dialog UI Engine (Styled perfectly to match the ERP software theme)
window.JeevikaDialog = {
  alert(message, title) {
    return new Promise((resolve) => {
      const existing = document.getElementById('jeevika-custom-dialog-overlay');
      if (existing) existing.remove();

      const overlay = document.createElement('div');
      overlay.id = 'jeevika-custom-dialog-overlay';
      overlay.className = 'erp-modal-overlay';
      overlay.style.cssText = `
        position: fixed;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: rgba(0, 0, 0, 0.4);
        backdrop-filter: blur(1px);
        z-index: 20000;
        display: flex;
        align-items: center;
        justify-content: center;
      `;

      const dialogTitle = title || 'Notification';
      const html = `
        <div style="width: 380px; min-height: 160px; display: flex; flex-direction: column;">
          <div style="background: #1565C0; color: #FFFFFF; font-family: 'Segoe UI', Inter, sans-serif; font-size: 12px; font-weight: 700; padding: 10px 14px; text-transform: uppercase; letter-spacing: 0.3px; border-bottom: 1px solid #0D47A1; display: flex; justify-content: space-between; align-items: center;">
            <div><i class="bi bi-info-circle-fill" style="margin-right: 6px;"></i> ${dialogTitle}</div>
            <button style="background: transparent; color: #FFFFFF; opacity: 0.8; font-size: 18px; font-weight: 700; border: none; cursor: pointer;" onclick="JeevikaDialog._close(false)">&times;</button>
          </div>
          <div style="padding: 16px; background: #FFFFFF; font-family: 'Segoe UI', Inter, sans-serif; font-size: 13px; color: #333333; line-height: 1.5; flex: 1;">
            ${message}
          </div>
          <div style="background: #F5F5F5; border-top: 1px solid #E0E0E0; padding: 10px 14px; display: flex; justify-content: flex-end; gap: 8px;">
            <button class="classic-erp-btn active" style="padding: 6px 20px !important; min-width: 80px; background: #1565C0 !important; color: white !important; border-color: #1565C0 !important;" onclick="JeevikaDialog._close(true)">OK</button>
          </div>
        </div>
      `;

      overlay.innerHTML = html;
      document.body.appendChild(overlay);

      // Focus OK button
      const okBtn = overlay.querySelector('button.classic-erp-btn');
      if (okBtn) okBtn.focus();

      JeevikaDialog._callback = (result) => {
        overlay.remove();
        resolve(result);
      };
    });
  },

  confirm(message, onConfirm, title) {
    return new Promise((resolve) => {
      const existing = document.getElementById('jeevika-custom-dialog-overlay');
      if (existing) existing.remove();

      const overlay = document.createElement('div');
      overlay.id = 'jeevika-custom-dialog-overlay';
      overlay.className = 'erp-modal-overlay';
      overlay.style.cssText = `
        position: fixed;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: rgba(0, 0, 0, 0.4);
        backdrop-filter: blur(1px);
        z-index: 20000;
        display: flex;
        align-items: center;
        justify-content: center;
      `;

      const dialogTitle = title || 'Confirm Action';
      const html = `
        <div style="width: 400px; min-height: 160px; display: flex; flex-direction: column;">
          <div style="background: #1565C0; color: #FFFFFF; font-family: 'Segoe UI', Inter, sans-serif; font-size: 12px; font-weight: 700; padding: 10px 14px; text-transform: uppercase; letter-spacing: 0.3px; border-bottom: 1px solid #0D47A1; display: flex; justify-content: space-between; align-items: center;">
            <div><i class="bi bi-question-circle-fill" style="margin-right: 6px;"></i> ${dialogTitle}</div>
            <button style="background: transparent; color: #FFFFFF; opacity: 0.8; font-size: 18px; font-weight: 700; border: none; cursor: pointer;" onclick="JeevikaDialog._close(false)">&times;</button>
          </div>
          <div style="padding: 16px; background: #FFFFFF; font-family: 'Segoe UI', Inter, sans-serif; font-size: 13px; color: #333333; line-height: 1.5; flex: 1;">
            ${message}
          </div>
          <div style="background: #F5F5F5; border-top: 1px solid #E0E0E0; padding: 10px 14px; display: flex; justify-content: flex-end; gap: 8px;">
            <button class="classic-erp-btn" style="padding: 6px 16px !important;" onclick="JeevikaDialog._close(false)">Cancel</button>
            <button class="classic-erp-btn active" style="padding: 6px 20px !important; min-width: 80px; background: #1565C0 !important; color: white !important; border-color: #1565C0 !important;" onclick="JeevikaDialog._close(true)">OK</button>
          </div>
        </div>
      `;

      overlay.innerHTML = html;
      document.body.appendChild(overlay);

      // Focus OK button
      const okBtn = overlay.querySelector('button.classic-erp-btn.active');
      if (okBtn) okBtn.focus();

      JeevikaDialog._callback = (result) => {
        overlay.remove();
        if (result && typeof onConfirm === 'function') {
          onConfirm();
        }
        resolve(result);
      };
    });
  },

  manageTds(onUpdate) {
    return new Promise((resolve) => {
      const existing = document.getElementById('jeevika-custom-dialog-overlay');
      if (existing) existing.remove();

      const overlay = document.createElement('div');
      overlay.id = 'jeevika-custom-dialog-overlay';
      overlay.className = 'erp-modal-overlay';
      overlay.style.cssText = `
        position: fixed;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: rgba(0, 0, 0, 0.4);
        backdrop-filter: blur(1px);
        z-index: 20000;
        display: flex;
        align-items: center;
        justify-content: center;
      `;

      const renderList = () => {
        let custom = [];
        try {
          const val = localStorage.getItem('custom_tds_sections');
          if (val) custom = JSON.parse(val);
        } catch (e) { }

        const listContainer = overlay.querySelector('#tds-list-container');
        if (!listContainer) return;

        if (custom.length === 0) {
          listContainer.innerHTML = `<div style="color: #888; font-style: italic; text-align: center; padding: 12px; font-size: 12px; font-family: 'Segoe UI', Inter, sans-serif;">No custom sections added yet.</div>`;
          return;
        }

        listContainer.innerHTML = custom.map((sec) => `
          <div class="tds-manage-item" style="display: flex; justify-content: space-between; align-items: center; padding: 6px 10px; border-bottom: 1px solid #ECEFF1; font-family: 'Segoe UI', Inter, sans-serif; font-size: 13px;">
            <span style="font-weight: 600; color: #37474F;">${sec}</span>
            <button class="tds-del-item-btn" data-sec="${sec}" style="background: transparent; border: none; color: #d32f2f; font-weight: bold; cursor: pointer; font-size: 16px; padding: 2px 8px; line-height: 1; border-radius: 4px; transition: background 0.2s;" title="Delete ${sec}">&times;</button>
          </div>
        `).join('');

        listContainer.querySelectorAll('.tds-del-item-btn').forEach(btn => {
          btn.addEventListener('mouseover', () => { btn.style.background = '#FFEBEE'; });
          btn.addEventListener('mouseout', () => { btn.style.background = 'transparent'; });
          btn.addEventListener('click', (e) => {
            const secToDelete = e.currentTarget.getAttribute('data-sec');
            JeevikaDialog.confirm(`Are you sure you want to delete TDS section "${secToDelete}"?`, () => {
              let updated = custom.filter(s => s !== secToDelete);
              localStorage.setItem('custom_tds_sections', JSON.stringify(updated));
              renderList();
              if (typeof onUpdate === 'function') onUpdate();
            }, 'Confirm Delete');
          });
        });
      };

      const html = `
        <div style="width: 350px; min-height: 250px; display: flex; flex-direction: column; background: #FFFFFF; border: 1px solid #B0BEC5; box-shadow: 0 4px 20px rgba(0,0,0,0.15); border-radius: 4px; overflow: hidden;">
          <div style="background: #1565C0; color: #FFFFFF; font-family: 'Segoe UI', Inter, sans-serif; font-size: 12px; font-weight: 700; padding: 10px 14px; text-transform: uppercase; letter-spacing: 0.3px; border-bottom: 1px solid #0D47A1; display: flex; justify-content: space-between; align-items: center;">
            <div><i class="bi bi-gear-fill" style="margin-right: 6px;"></i> Manage TDS Sections</div>
            <button style="background: transparent; color: #FFFFFF; opacity: 0.8; font-size: 18px; font-weight: 700; border: none; cursor: pointer;" id="tds-close-x">&times;</button>
          </div>
          
          <div style="padding: 14px; flex: 1; display: flex; flex-direction: column; gap: 10px;">
            <div style="font-family: 'Segoe UI', Inter, sans-serif; font-size: 11px; font-weight: bold; color: #546E7A; text-transform: uppercase;">Custom TDS Sections</div>
            
            <div id="tds-list-container" style="flex: 1; min-height: 100px; max-height: 180px; overflow-y: auto; border: 1px solid #CFD8DC; border-radius: 4px; background: #FAFAFA;">
            </div>
            
            <div style="border-top: 1px dashed #CFD8DC; padding-top: 10px; margin-top: 5px;">
              <div style="font-family: 'Segoe UI', Inter, sans-serif; font-size: 11px; font-weight: bold; color: #546E7A; text-transform: uppercase; margin-bottom: 6px;">Add New Section</div>
              <div style="display: flex; gap: 6px;">
                <input type="text" id="tds-new-input" class="classic-erp-input" style="flex: 1; text-transform: uppercase; padding: 5px 8px; font-size: 12px;" placeholder="e.g. 194A">
                <button class="classic-erp-btn active" id="tds-add-submit" style="padding: 5px 14px !important; min-width: 60px; background: #1565C0 !important; color: white !important; border-color: #1565C0 !important; font-size: 12px; cursor: pointer;">Add</button>
              </div>
              <div id="tds-error-msg" style="color: #d32f2f; font-size: 11px; margin-top: 4px; display: none; font-family: 'Segoe UI', Inter, sans-serif;"></div>
            </div>
          </div>

          <div style="background: #F5F5F5; border-top: 1px solid #E0E0E0; padding: 10px 14px; display: flex; justify-content: flex-end;">
            <button class="classic-erp-btn active" style="padding: 6px 20px !important; min-width: 80px; background: #1565C0 !important; color: white !important; border-color: #1565C0 !important; cursor: pointer;" id="tds-done-btn">Close</button>
          </div>
        </div>
      `;

      overlay.innerHTML = html;
      document.body.appendChild(overlay);

      renderList();

      const addInput = overlay.querySelector('#tds-new-input');
      const addSubmit = overlay.querySelector('#tds-add-submit');
      const errorMsg = overlay.querySelector('#tds-error-msg');

      const performAdd = () => {
        let val = addInput.value.trim().toUpperCase();
        if (!val) return;

        let custom = [];
        try {
          const saved = localStorage.getItem('custom_tds_sections');
          if (saved) custom = JSON.parse(saved);
        } catch (e) { }

        if (custom.includes(val)) {
          errorMsg.textContent = `Section "${val}" already exists.`;
          errorMsg.style.display = 'block';
          addInput.focus();
          return;
        }

        custom.push(val);
        localStorage.setItem('custom_tds_sections', JSON.stringify(custom));
        addInput.value = '';
        errorMsg.style.display = 'none';
        renderList();
        if (typeof onUpdate === 'function') onUpdate(val);
      };

      addSubmit.addEventListener('click', performAdd);
      addInput.addEventListener('keydown', (e) => {
        if (e.key === 'Enter') {
          performAdd();
        }
      });

      const closeOverlay = () => {
        overlay.remove();
        resolve(true);
      };

      overlay.querySelector('#tds-close-x').addEventListener('click', closeOverlay);
      overlay.querySelector('#tds-done-btn').addEventListener('click', closeOverlay);
    });
  },

  prompt(message, title, defaultValue = '') {
    return new Promise((resolve) => {
      const existing = document.getElementById('jeevika-custom-dialog-overlay');
      if (existing) existing.remove();

      const overlay = document.createElement('div');
      overlay.id = 'jeevika-custom-dialog-overlay';
      overlay.className = 'erp-modal-overlay';
      overlay.style.cssText = `
        position: fixed;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: rgba(0, 0, 0, 0.4);
        backdrop-filter: blur(1px);
        z-index: 20000;
        display: flex;
        align-items: center;
        justify-content: center;
      `;

      const dialogTitle = title || 'Input Required';
      const html = `
        <div style="width: 400px; min-height: 180px; display: flex; flex-direction: column; background: #FFFFFF; border: 1px solid #B0BEC5; box-shadow: 0 4px 20px rgba(0,0,0,0.15); border-radius: 4px; overflow: hidden;">
          <div style="background: #1565C0; color: #FFFFFF; font-family: 'Segoe UI', Inter, sans-serif; font-size: 12px; font-weight: 700; padding: 10px 14px; text-transform: uppercase; letter-spacing: 0.3px; border-bottom: 1px solid #0D47A1; display: flex; justify-content: space-between; align-items: center;">
            <div><i class="bi bi-pencil-square" style="margin-right: 6px;"></i> ${dialogTitle}</div>
            <button style="background: transparent; color: #FFFFFF; opacity: 0.8; font-size: 18px; font-weight: 700; border: none; cursor: pointer;" onclick="JeevikaDialog._close(null)">&times;</button>
          </div>
          <div style="padding: 16px; background: #FFFFFF; font-family: 'Segoe UI', Inter, sans-serif; font-size: 13px; color: #333333; line-height: 1.5; flex: 1; display: flex; flex-direction: column; gap: 8px;">
            <div style="font-weight: 600; color: #37474F;">${message}</div>
            <input type="text" id="jeevika-prompt-input" class="classic-erp-input" style="width: 100%; box-sizing: border-box; padding: 6px 10px; font-size: 13px; border: 1px solid #CFD8DC; border-radius: 4px;" value="${defaultValue}">
          </div>
          <div style="background: #F5F5F5; border-top: 1px solid #E0E0E0; padding: 10px 14px; display: flex; justify-content: flex-end; gap: 8px;">
            <button class="classic-erp-btn" style="padding: 6px 16px !important;" onclick="JeevikaDialog._close(null)">Cancel</button>
            <button class="classic-erp-btn active" style="padding: 6px 20px !important; min-width: 80px; background: #1565C0 !important; color: white !important; border-color: #1565C0 !important;" id="jeevika-prompt-ok-btn">OK</button>
          </div>
        </div>
      `;

      overlay.innerHTML = html;
      document.body.appendChild(overlay);

      const inputEl = overlay.querySelector('#jeevika-prompt-input');
      const okBtn = overlay.querySelector('#jeevika-prompt-ok-btn');

      if (inputEl) {
        inputEl.focus();
        const valLen = inputEl.value.length;
        inputEl.setSelectionRange(valLen, valLen);
      }

      const handleOk = () => {
        const val = inputEl ? inputEl.value : '';
        JeevikaDialog._close(val);
      };

      if (okBtn) {
        okBtn.addEventListener('click', handleOk);
      }

      if (inputEl) {
        inputEl.addEventListener('keydown', (e) => {
          if (e.key === 'Enter') {
            handleOk();
          } else if (e.key === 'Escape') {
            JeevikaDialog._close(null);
          }
        });
      }

      JeevikaDialog._callback = (result) => {
        overlay.remove();
        resolve(result);
      };
    });
  },

  _close(result) {
    if (typeof JeevikaDialog._callback === 'function') {
      JeevikaDialog._callback(result);
    }
  }
};

// Init on load
document.addEventListener('DOMContentLoaded', () => WorkspaceManager.init());


