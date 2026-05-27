// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — WORKSPACE ENGINE
// ═══════════════════════════════════════════════════════

const WorkspaceManager = {

  // State
  openTabs: [],       // [{ id, label, moduleFile, active }]
  activeTab: null,     // current active tab id

  // ── Tab Management ───────────────────────────────────

  openTab(moduleId, label) {
    // If already open → just activate it
    const existing = this.openTabs.find(t => t.id === moduleId);
    if (existing) { this.activateTab(moduleId); return; }

    // Add new tab
    this.openTabs.push({ id: moduleId, label: label || this.getLabel(moduleId), active: false });
    this.activateTab(moduleId);
    this.renderTabBar();
  },

  activateTab(moduleId) {
    this.openTabs.forEach(t => t.active = (t.id === moduleId));
    this.activeTab = moduleId;
    this.loadModule(moduleId);
    this.renderTabBar();
    this.highlightSidebarItem(moduleId);
  },

  closeTab(moduleId) {
    const idx = this.openTabs.findIndex(t => t.id === moduleId);
    if (idx === -1) return;
    this.openTabs.splice(idx, 1);
    // Activate adjacent tab
    if (this.activeTab === moduleId) {
      const next = this.openTabs[idx] || this.openTabs[idx - 1];
      if (next) this.activateTab(next.id);
      else { this.activeTab = null; this.showWelcome(); }
    }
    this.renderTabBar();
  },

  closeAllTabs() {
    this.openTabs = [];
    this.activeTab = null;
    this.showWelcome();
    this.renderTabBar();
  },

  closeOtherTabs(keepId) {
    this.openTabs = this.openTabs.filter(t => t.id === keepId);
    this.activateTab(keepId);
    this.renderTabBar();
  },

  // ── Module Loading ────────────────────────────────────

  async loadModule(moduleId) {
    const workspace = document.getElementById('workspace-content');
    if (!workspace) return;

    // Show loading
    workspace.innerHTML = `<div class="workspace-loading">
      <div class="spinner"></div><p>Loading...</p>
    </div>`;

    try {
      // Try to load from components folder
      const res = await fetch(`components/${moduleId}.html`);
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
        const loadScriptsSequentially = (idx) => {
          if (idx >= scripts.length) {
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
      'outstanding-list': 'Outstanding List',
      'member-register': 'Member Register',
      'member-account': 'Member Account',
      'society-account': 'Society Account',
      'balance-confirm-letter': 'Balance Confirmation Letter',
      'data-sheet': 'Data Sheet',
      'bank-deposit-list': 'Bank Deposit List',
      'fund-register': 'Fund Register',
      'cheque-list': 'Cheque List',
      'adjustment-list': 'Adjustment List',
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
      }
    } catch (e) { /* use defaults */ }
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

// Init on load
document.addEventListener('DOMContentLoaded', () => WorkspaceManager.init());
document.addEventListener('DOMContentLoaded', () => WorkspaceManager.init());
