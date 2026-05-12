/* ===== JEEVIKA MDI WINDOW MANAGER ===== */
const JeevikaMDI = (function() {
    let windows = [];
    let windowIdCounter = 0;
    let zIndexCounter = 1000;
    let activeWindow = null;

    // API Configuration
    const API_BASE = 'http://localhost:5002/api';

    const ctx = {
        societyId: localStorage.getItem('activeSocietyId') || '',
        societyName: localStorage.getItem('activeSocietyName') || '',
        societyCode: localStorage.getItem('activeSocietyCode') || '',
        fyStart: localStorage.getItem('activeFYStart') || '',
        fyEnd: localStorage.getItem('activeFYEnd') || '',
        user: localStorage.getItem('UserName') || '',
        token: localStorage.getItem('authToken') || ''
    };

    // Fetch helper
    async function fetchAPI(path, options = {}) {
        options = options || {};
        options.headers = Object.assign({
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + ctx.token
        }, options.headers || {});
        return fetch(API_BASE + path, options).then(r => r.json());
    }

    // Open a new window
    function openWindow(url, title, width = 900, height = 600) {
        const windowId = 'mdi-window-' + (++windowIdCounter);
        const container = document.querySelector('.mdi-container');
        
        // Calculate default position (cascade)
        const offsetX = (windows.length * 30) % 200;
        const offsetY = (windows.length * 30) % 150;
        
        const windowEl = document.createElement('div');
        windowEl.className = 'mdi-window';
        windowEl.id = windowId;
        windowEl.style.cssText = `
            left: ${50 + offsetX}px;
            top: ${20 + offsetY}px;
            width: ${width}px;
            height: ${height}px;
            z-index: ${++zIndexCounter};
        `;
        
        windowEl.innerHTML = `
            <div class="mdi-window-header">
                <span class="mdi-window-title">${title}</span>
                <div class="mdi-window-controls">
                    <button class="mdi-window-btn minimize" title="Minimize">_</button>
                    <button class="mdi-window-btn maximize" title="Maximize">□</button>
                    <button class="mdi-window-btn close" title="Close">×</button>
                </div>
            </div>
            <div class="mdi-window-content">
                <div class="loading-overlay"><div class="spinner"></div></div>
            </div>
            <div class="mdi-resize-handle"></div>
        `;
        
        container.appendChild(windowEl);
        
        const windowObj = {
            id: windowId,
            element: windowEl,
            title: title,
            url: url,
            minimized: false,
            maximized: false
        };
        
        windows.push(windowObj);
        
        // Setup window events
        setupWindowEvents(windowObj);
        
        // Load content
        loadWindowContent(windowObj);
        
        // Focus window
        focusWindow(windowId);
        
        // Update taskbar
        updateTaskbar();
        
        return windowId;
    }

    // Load window content from URL
    async function loadWindowContent(windowObj) {
        const contentEl = windowObj.element.querySelector('.mdi-window-content');
        
        try {
            const response = await fetch(windowObj.url, { cache: 'no-cache' });
            if (!response.ok) {
                contentEl.innerHTML = `
                    <div style="padding: 40px; text-align: center; color: #666;">
                        <div style="font-size: 48px; margin-bottom: 16px;">⚠️</div>
                        <div style="font-weight: 700; margin-bottom: 8px;">Content Not Found</div>
                        <div style="font-size: 11px;">Could not load: ${windowObj.url}</div>
                    </div>
                `;
                return;
            }
            
            const html = await response.text();
            contentEl.innerHTML = html;
            
            // Execute scripts
            contentEl.querySelectorAll('script').forEach(oldScript => {
                const newScript = document.createElement('script');
                if (oldScript.src) {
                    newScript.src = oldScript.src;
                    document.head.appendChild(newScript);
                } else {
                    newScript.textContent = oldScript.textContent;
                    document.body.appendChild(newScript);
                    document.body.removeChild(newScript);
                }
                oldScript.remove();
            });
            
        } catch (error) {
            console.error('Failed to load window content:', error);
            contentEl.innerHTML = `
                <div style="padding: 40px; text-align: center; color: #dc3545;">
                    <div style="font-size: 48px; margin-bottom: 16px;">❌</div>
                    <div style="font-weight: 700; margin-bottom: 8px;">Load Error</div>
                    <div style="font-size: 11px;">${error.message}</div>
                </div>
            `;
        }
    }

    // Setup window event handlers
    function setupWindowEvents(windowObj) {
        const header = windowObj.element.querySelector('.mdi-window-header');
        const closeBtn = windowObj.element.querySelector('.mdi-window-btn.close');
        const minimizeBtn = windowObj.element.querySelector('.mdi-window-btn.minimize');
        const maximizeBtn = windowObj.element.querySelector('.mdi-window-btn.maximize');
        
        // Focus on click
        windowObj.element.addEventListener('mousedown', () => focusWindow(windowObj.id));
        
        // Close button
        closeBtn.addEventListener('click', () => closeWindow(windowObj.id));
        
        // Minimize button
        minimizeBtn.addEventListener('click', () => minimizeWindow(windowObj.id));
        
        // Maximize button
        maximizeBtn.addEventListener('click', () => toggleMaximize(windowObj.id));
        
        // Drag functionality
        let isDragging = false;
        let dragOffsetX = 0;
        let dragOffsetY = 0;
        
        header.addEventListener('mousedown', (e) => {
            if (windowObj.maximized) return;
            if (e.target.closest('.mdi-window-controls')) return;
            
            isDragging = true;
            dragOffsetX = e.clientX - windowObj.element.offsetLeft;
            dragOffsetY = e.clientY - windowObj.element.offsetTop;
            
            document.addEventListener('mousemove', onDrag);
            document.addEventListener('mouseup', stopDrag);
        });
        
        function onDrag(e) {
            if (!isDragging) return;
            
            let newX = e.clientX - dragOffsetX;
            let newY = e.clientY - dragOffsetY;
            
            // Constrain to container
            const container = document.querySelector('.mdi-container');
            const maxX = container.clientWidth - 50;
            const maxY = container.clientHeight - 32;
            
            newX = Math.max(0, Math.min(newX, maxX));
            newY = Math.max(0, Math.min(newY, maxY));
            
            windowObj.element.style.left = newX + 'px';
            windowObj.element.style.top = newY + 'px';
        }
        
        function stopDrag() {
            isDragging = false;
            document.removeEventListener('mousemove', onDrag);
            document.removeEventListener('mouseup', stopDrag);
        }
        
        // Resize functionality
        const resizeHandle = windowObj.element.querySelector('.mdi-resize-handle');
        let isResizing = false;
        let resizeStartX = 0;
        let resizeStartY = 0;
        let resizeStartWidth = 0;
        let resizeStartHeight = 0;
        
        resizeHandle.addEventListener('mousedown', (e) => {
            if (windowObj.maximized) return;
            
            isResizing = true;
            resizeStartX = e.clientX;
            resizeStartY = e.clientY;
            resizeStartWidth = windowObj.element.offsetWidth;
            resizeStartHeight = windowObj.element.offsetHeight;
            
            document.addEventListener('mousemove', onResize);
            document.addEventListener('mouseup', stopResize);
        });
        
        function onResize(e) {
            if (!isResizing) return;
            
            const newWidth = resizeStartWidth + (e.clientX - resizeStartX);
            const newHeight = resizeStartHeight + (e.clientY - resizeStartY);
            
            windowObj.element.style.width = Math.max(400, newWidth) + 'px';
            windowObj.element.style.height = Math.max(300, newHeight) + 'px';
        }
        
        function stopResize() {
            isResizing = false;
            document.removeEventListener('mousemove', onResize);
            document.removeEventListener('mouseup', stopResize);
        }
    }

    // Focus a window
    function focusWindow(windowId) {
        windows.forEach(w => {
            if (w.id === windowId) {
                w.element.classList.add('focused');
                w.element.style.zIndex = ++zIndexCounter;
                activeWindow = w;
            } else {
                w.element.classList.remove('focused');
            }
        });
        updateTaskbar();
    }

    // Close a window
    function closeWindow(windowId) {
        const index = windows.findIndex(w => w.id === windowId);
        if (index === -1) return;
        
        windows[index].element.remove();
        windows.splice(index, 1);
        
        if (activeWindow && activeWindow.id === windowId) {
            activeWindow = windows.length > 0 ? windows[windows.length - 1] : null;
            if (activeWindow) focusWindow(activeWindow.id);
        }
        
        updateTaskbar();
    }

    // Minimize a window
    function minimizeWindow(windowId) {
        const windowObj = windows.find(w => w.id === windowId);
        if (!windowObj) return;
        
        windowObj.minimized = true;
        windowObj.element.classList.add('minimized');
        
        if (activeWindow && activeWindow.id === windowId) {
            activeWindow = windows.find(w => !w.minimized) || null;
            if (activeWindow) focusWindow(activeWindow.id);
        }
        
        updateTaskbar();
    }

    // Restore a minimized window
    function restoreWindow(windowId) {
        const windowObj = windows.find(w => w.id === windowId);
        if (!windowObj) return;
        
        windowObj.minimized = false;
        windowObj.element.classList.remove('minimized');
        focusWindow(windowId);
    }

    // Toggle maximize
    function toggleMaximize(windowId) {
        const windowObj = windows.find(w => w.id === windowId);
        if (!windowObj) return;
        
        windowObj.maximized = !windowObj.maximized;
        windowObj.element.classList.toggle('maximized', windowObj.maximized);
    }

    // Update taskbar
    function updateTaskbar() {
        const taskbar = document.querySelector('.mdi-taskbar');
        if (!taskbar) return;
        
        taskbar.innerHTML = windows.map(w => `
            <div class="mdi-taskbar-item ${activeWindow && activeWindow.id === w.id ? 'active' : ''} ${w.minimized ? '' : ''}"
                 onclick="JeevikaMDI.restoreWindow('${w.id}')">
                ${w.title}
            </div>
        `).join('');
    }

    // Toggle dropdown menu
    function toggleMenu(element) {
        // Close all other dropdowns
        document.querySelectorAll('.mdi-nav-item').forEach(item => {
            if (item !== element) item.classList.remove('active');
        });
        
        element.classList.toggle('active');
    }

    // Close dropdowns when clicking outside
    document.addEventListener('click', (e) => {
        if (!e.target.closest('.mdi-nav-item')) {
            document.querySelectorAll('.mdi-nav-item').forEach(item => {
                item.classList.remove('active');
            });
        }
    });

    // Society Master specific workflow
    function openSocietyMaster() {
        openWindow('components/society-list.html', 'Society Selection & Management', 1100, 700);
    }

    function switchToSociety(societyId, societyName) {
        // Update global workspace context
        localStorage.setItem('activeSocietyId', societyId);
        localStorage.setItem('activeSocietyName', societyName);
        
        // Update header UI
        const ctxSociety = document.getElementById('ctxSociety');
        if (ctxSociety) {
            ctxSociety.innerHTML = '<strong>' + societyName + '</strong>';
        }
        
        // Show toast notification
        showToast(`Workplace switched to: ${societyName}`, 'success');
        
        // Close all society master windows
        windows.filter(w => w.title.includes('Society')).forEach(w => closeWindow(w.id));
    }

    function openSocietyEditor(societyId) {
        openWindow('components/society-editor.html?id=' + societyId, 'Society Master — Edit Configuration', 1200, 800);
    }

    // Toast notification
    function showToast(message, type = 'info') {
        const toast = document.createElement('div');
        toast.style.cssText = `
            position: fixed;
            bottom: 50px;
            right: 20px;
            padding: 10px 16px;
            background: ${type === 'success' ? '#1B5E20' : type === 'error' ? '#dc3545' : '#000'};
            color: #fff;
            font-size: 11px;
            font-weight: 600;
            border-radius: 4px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.2);
            z-index: 99999;
            animation: slideIn 0.3s ease;
        `;
        toast.textContent = message;
        document.body.appendChild(toast);
        
        setTimeout(() => {
            toast.style.opacity = '0';
            toast.style.transition = 'opacity 0.3s';
            setTimeout(() => toast.remove(), 300);
        }, 3000);
    }

    // Keyboard shortcuts
    document.addEventListener('keydown', (e) => {
        // Ctrl+G: Group Master
        if (e.ctrlKey && e.key === 'g') {
            e.preventDefault();
            openWindow('components/groupMaster.html', 'Group Master', 900, 600);
        }
        // Ctrl+A: Account Master
        if (e.ctrlKey && e.key === 'a') {
            e.preventDefault();
            openWindow('components/accountMaster.html', 'Account Master', 900, 600);
        }
        // Ctrl+M: Member Master
        if (e.ctrlKey && e.key === 'm') {
            e.preventDefault();
            openWindow('components/memberMaster.html', 'Member Master', 900, 600);
        }
    });

    // Public API
    return {
        openWindow,
        closeWindow,
        minimizeWindow,
        restoreWindow,
        toggleMaximize,
        focusWindow,
        toggleMenu,
        openSocietyMaster,
        switchToSociety,
        openSocietyEditor,
        fetch: fetchAPI,
        ctx: ctx,
        toast: showToast
    };
})();
