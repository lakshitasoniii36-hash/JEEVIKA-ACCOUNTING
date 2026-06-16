/**
 * MAULI ERP Dashboard Controller
 * Professional Zoho-style Workspace Router
 */

// Global API Helper (Mirroring workspace.html logic)
const API_BASE = 'http://localhost:5002/api';
window.JEEVIKA = {
    api: API_BASE,
    ctx: {
        societyId: localStorage.getItem('activeSocietyId') || '',
        societyName: localStorage.getItem('activeSocietyName') || '',
        societyCode: localStorage.getItem('activeSocietyCode') || '',
        fyStart: localStorage.getItem('activeFYStart') || '',
        fyEnd: localStorage.getItem('activeFYEnd') || '',
        user: localStorage.getItem('UserName') || '',
        token: localStorage.getItem('authToken') || ''
    },
    fetch: function(path, options) {
        options = options || {};
        options.headers = Object.assign({
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + this.ctx.token
        }, options.headers || {});
        return fetch(this.api + path, options).then(r => r.json());
    },
    toast: showNotification,
    navigate: handlePageNavigation
};

document.addEventListener('DOMContentLoaded', () => {
    // Auth Check
    const userName = localStorage.getItem('UserName');
    const authToken = localStorage.getItem('authToken');
    if (!userName || !authToken) {
        window.location.href = 'login.html';
        return;
    }

    initializeWorkspace();
});

function initializeWorkspace() {
    setupSidebar();
    updateContext();
    startTimeUpdate();
    
    // Load default page (Dashboard)
    const lastPage = localStorage.getItem('lastActivePage') || 'dashboard';
    handlePageNavigation(lastPage);

    // Logout handler
    document.getElementById('logoutBtn')?.addEventListener('click', handleLogout);
}

function setupSidebar() {
    const toggleBtn = document.getElementById('toggleSidebar');
    const appContainer = document.getElementById('appContainer');
    
    // Toggle Sidebar ON/OFF
    toggleBtn?.addEventListener('click', () => {
        appContainer.classList.toggle('collapsed');
        localStorage.setItem('sidebarCollapsed', appContainer.classList.contains('collapsed'));
    });

    if (localStorage.getItem('sidebarCollapsed') === 'true') {
        appContainer.classList.add('collapsed');
    }

    // --- Omni-Sidebar Dropdown Logic ---
    document.querySelectorAll('.nav-dropdown-toggle').forEach(toggle => {
        toggle.addEventListener('click', function() {
            const dropdown = this.closest('.nav-dropdown');
            const items = dropdown.querySelector('.nav-dropdown-items');
            const isOpen = items.classList.contains('show');
            
            // Close others if desired (Accordion style)
            document.querySelectorAll('.nav-dropdown-items').forEach(el => el.classList.remove('show'));
            
            if (!isOpen) {
                items.classList.add('show');
                localStorage.setItem('activeDropdown', dropdown.dataset.target);
            } else {
                localStorage.removeItem('activeDropdown');
            }
        });
    });

    // Restore active dropdown
    const activeDrop = localStorage.getItem('activeDropdown');
    if (activeDrop) {
        document.querySelector(`.nav-dropdown[data-target="${activeDrop}"] .nav-dropdown-items`)?.classList.add('show');
    }

    // Navigation Click Handlers
    document.querySelectorAll('.nav-item').forEach(item => {
        item.addEventListener('click', function(e) {
            e.preventDefault();
            const page = this.getAttribute('data-page');
            if (!page) return;

            document.querySelectorAll('.nav-item').forEach(n => n.classList.remove('active'));
            this.classList.add('active');

            handlePageNavigation(page);
        });
    });
}

/**
 * Global Command Bar (7-Button Protocol)
 * Injects the standard buttons into the module workspace
 */
function renderCommandBar(container) {
    const bar = document.createElement('div');
    bar.className = 'command-bar';
    bar.innerHTML = `
        <button class="btn btn-command btn-primary-bw" id="btnGlobalNew" title="Add New Record">
            <i class="fa-solid fa-plus"></i> NEW
        </button>
        <button class="btn btn-command" id="btnGlobalSave" title="Save / Update Record">
            <i class="fa-solid fa-floppy-disk"></i> 💾 SAVE
        </button>
        <button class="btn btn-command text-danger" id="btnGlobalDelete" title="Delete Selected Record">
            <i class="fa-solid fa-trash"></i> 🗑️ DELETE
        </button>
        <button class="btn btn-command" id="btnGlobalMultiDelete" title="Bulk Delete">
            <i class="fa-solid fa-xmark"></i> ❌ MULTI DELETE
        </button>
        <div class="ms-auto d-flex gap-2">
            <button class="btn btn-command" id="btnGlobalPrint" title="Print Current View">
                <i class="fa-solid fa-print"></i> 🖨️ PRINT
            </button>
            <button class="btn btn-command" id="btnGlobalDetails" title="Show Audit Details">
                <i class="fa-solid fa-magnifying-glass"></i> 🔍 DETAILS
            </button>
            <button class="btn btn-command" id="btnGlobalExit" title="Close Module">
                <i class="fa-solid fa-door-open"></i> 🚪 EXIT
            </button>
        </div>
    `;
    container.prepend(bar);

    // Default event for EXIT
    document.getElementById('btnGlobalExit')?.addEventListener('click', () => handlePageNavigation('dashboard'));
}

/**
 * Minimalist Toast Notification
 */
const JEEVIKA = {
    fetch: async (url, options = {}) => {
        const fullUrl = url.startsWith('http') ? url : `http://localhost:5002/api${url}`;
        const defaultOptions = {
            headers: { 'Content-Type': 'application/json' }
        };
        const response = await fetch(fullUrl, { ...defaultOptions, ...options });
        return await response.json();
    },
    toast: (message, type = 'success') => {
        const toast = document.createElement('div');
        toast.style.cssText = `
            position: fixed; top: 20px; right: 20px; padding: 8px 16px;
            background: ${type === 'success' ? '#000' : '#d9534f'};
            color: #fff; font-size: 11px; font-weight: 600; text-transform: uppercase;
            z-index: 9999; border: 1px solid rgba(255,255,255,0.1);
            box-shadow: 0 4px 12px rgba(0,0,0,0.2); transition: all 0.3s ease;
        `;
        toast.textContent = message;
        document.body.appendChild(toast);
        setTimeout(() => {
            toast.style.opacity = '0';
            setTimeout(() => toast.remove(), 300);
        }, 3000);
    }
};

async function handlePageNavigation(pageName) {
    const contentArea = document.getElementById('dashboardContent');
    if (!contentArea) return;

    localStorage.setItem('lastActivePage', pageName);

    // Dynamic Main Content Overflow control to prevent double scrollbars in sub-modules
    const mainContent = document.querySelector('.main-content');
    if (mainContent) {
        mainContent.style.overflowY = (pageName === 'dashboard') ? 'auto' : 'hidden';
    }

    // Show loader
    contentArea.innerHTML = `
        <div class="d-flex align-items-center justify-content-center" style="height: 400px;">
            <div class="spinner-border text-dark" role="status">
                <span class="visually-hidden">Loading...</span>
            </div>
        </div>`;

    if (pageName === 'dashboard') {
        renderDashboardHome(contentArea);
        return;
    }

    try {
        const fileMap = {
            'society-master': 'societyMaster.html',
            'group-master': 'groupMaster.html',
            'account-master': 'accountMaster.html',
            'member-master': 'memberMaster.html',
            'society-config': 'societyConfig.html',
            'trial-balance': 'trial-balance.html',
            'receipt-entry': 'receipt-entry.html'
        };

        const fileName = fileMap[pageName] || `${pageName}.html`;
        const response = await fetch(`components/${fileName}`, { cache: 'no-cache' });
        
        if (!response.ok) throw new Error(`Could not load ${fileName}`);

        const html = await response.text();
        contentArea.innerHTML = `<div class="component-wrapper h-100 d-flex flex-column">${html}</div>`;

        // Inject 7-Button Command Bar
        const wrapper = contentArea.querySelector('.component-wrapper');
        renderCommandBar(wrapper);

        // Execute scripts and initialize component
        await executeComponentScripts(contentArea, pageName);
        
    } catch (error) {
        console.error('Navigation Error:', error);
        contentArea.innerHTML = `
            <div class="p-5 text-center">
                <i class="fa-solid fa-triangle-exclamation text-muted mb-3" style="font-size: 48px;"></i>
                <h4 class="text-muted">Module Not Found</h4>
                <p class="text-muted">The module <b>${pageName}</b> is under development or the file is missing.</p>
                <button class="btn btn-sm btn-black mt-3" onclick="handlePageNavigation('dashboard')">Back to Dashboard</button>
            </div>`;
    }
}

async function executeComponentScripts(container, pageName) {
    const scripts = container.querySelectorAll('script');
    
    // 1. Execute all scripts
    for (const oldScript of scripts) {
        const newScript = document.createElement('script');
        if (oldScript.src) {
            newScript.src = oldScript.src;
            await new Promise((resolve) => {
                newScript.onload = resolve;
                newScript.onerror = resolve;
                document.body.appendChild(newScript);
            });
        } else {
            newScript.textContent = oldScript.textContent;
            document.body.appendChild(newScript);
            document.body.removeChild(newScript); // Clean up inline
        }
        oldScript.parentNode?.removeChild(oldScript);
    }

    // 2. Call initialization hook (e.g., init_society_master)
    const initFnName = 'init_' + pageName.replace(/-/g, '_');
    if (typeof window[initFnName] === 'function') {
        try {
            window[initFnName]();
        } catch (e) {
            console.error(`Error in ${initFnName}:`, e);
        }
    }
}

function updateContext() {
    const socName = localStorage.getItem('activeSocietyName') || 'Select Society';
    const fyStart = localStorage.getItem('activeFYStart');
    const fyEnd = localStorage.getItem('activeFYEnd');
    
    let fyText = '---';
    if (fyStart && fyEnd) {
        const start = new Date(fyStart).getFullYear();
        const end = new Date(fyEnd).getFullYear();
        fyText = `${start}-${end}`;
    }

    const socEl = document.getElementById('headerSociety');
    const fyEl = document.getElementById('headerFY');
    
    if (socEl) socEl.textContent = socName;
    if (fyEl) fyEl.textContent = fyText;
}

function startTimeUpdate() {
    const timeEl = document.getElementById('currentTime');
    const updateTime = () => {
        if (timeEl) {
            timeEl.textContent = new Date().toLocaleString('en-IN', { 
                day: '2-digit', month: 'short', 
                hour: '2-digit', minute: '2-digit', second: '2-digit'
            });
        }
    };
    updateTime();
    setInterval(updateTime, 1000);
}

function renderDashboardHome(container) {
    const socName = localStorage.getItem('activeSocietyName') || 'Guest';
    container.innerHTML = `
        <div class="p-4">
            <div class="mb-4">
                <h4 class="fw-bold text-uppercase" style="letter-spacing: 1px;">Command Center</h4>
                <p class="text-muted small">Welcome, ${socName}. Your ERP system is ready.</p>
            </div>
            
            <div class="row g-3">
                <div class="col-md-3"><div class="border p-3 bg-light"><div class="text-muted small mb-1">MEMBERS</div><div class="h4 fw-bold mb-0">---</div></div></div>
                <div class="col-md-3"><div class="border p-3 bg-light"><div class="text-muted small mb-1">DUE AMOUNT</div><div class="h4 fw-bold mb-0">₹ 0.00</div></div></div>
                <div class="col-md-3"><div class="border p-3 bg-light"><div class="text-muted small mb-1">PENDING VOUCHERS</div><div class="h4 fw-bold mb-0">0</div></div></div>
                <div class="col-md-3"><div class="border p-3 bg-light"><div class="text-muted small mb-1">SYSTEM STATUS</div><div class="h4 fw-bold mb-0 text-success">ONLINE</div></div></div>
            </div>

            <div class="mt-5 border p-5 text-center bg-light">
                <i class="fa-solid fa-building-circle-check text-muted mb-3" style="font-size: 48px;"></i>
                <h5>Professional Society Management</h5>
                <p class="text-muted small">Navigate using the sidebar to access Masters, Transactions, and Reports.</p>
                <div class="mt-3">
                    <button class="btn btn-sm btn-black px-4" onclick="JEEVIKA.navigate('society-master')">Open Society Master</button>
                </div>
            </div>
        </div>`;
}

function handleLogout() {
    if (confirm('Are you sure you want to logout?')) {
        localStorage.clear();
        window.location.href = 'login.html';
    }
}

function showNotification(message, type = 'info') {
    const toast = document.createElement('div');
    toast.className = `alert alert-${type === 'error' ? 'danger' : type} position-fixed shadow-sm`;
    toast.style.cssText = 'top:20px;right:20px;z-index:9999;min-width:280px;font-size:12px;';
    toast.innerHTML = `<div class="d-flex justify-content-between align-items-center">${message}<button class="btn-close" onclick="this.parentElement.parentElement.remove()"></button></div>`;
    document.body.appendChild(toast);
    setTimeout(() => { if (toast.parentNode) toast.remove(); }, 4000);
}

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
