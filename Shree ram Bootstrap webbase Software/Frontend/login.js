document.getElementById('loginForm').addEventListener('submit', async function(e) {
  e.preventDefault();
  const username = document.getElementById('username').value;
  const password = document.getElementById('password').value;
  const btn = this.querySelector('button[type="submit"]');
  btn.disabled = true;
  btn.innerHTML = '<span class="spinner-border spinner-border-sm me-2"></span>Authenticating...';
  try {
    const res = await fetch('http://localhost:5002/api/auth/login', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ username, password })
    });
    const data = await res.json();
    if (data.success) {
      localStorage.setItem('UserName', data.userName || username);
      localStorage.setItem('authToken', data.token);
      localStorage.setItem('userType', data.userType || 'USER');
      localStorage.setItem('userLevel', data.userLevel || '1');
      // Clear previous setup context so user must re-select
      localStorage.removeItem('setupComplete');
      localStorage.removeItem('activeSocietyId');
      localStorage.removeItem('activeSocietyName');
      localStorage.removeItem('activeSocietyCode');
      localStorage.removeItem('activeFYStart');
      localStorage.removeItem('activeFYEnd');
      showToast('Login successful! Redirecting...', 'success');
      setTimeout(() => {
        // Always go to setup first after login
        window.location.href = 'setup.html';
      }, 800);
    } else {
      showToast(data.message || 'Login failed', 'danger');
      btn.disabled = false;
      btn.innerHTML = 'Login';
    }
  } catch (err) {
    showToast('Network error — is the backend running?', 'danger');
    btn.disabled = false;
    btn.innerHTML = 'Login';
  }
});

function showToast(message, type) {
  const toastContainer = document.getElementById('toastContainer');
  toastContainer.innerHTML = `
    <div class="toast align-items-center text-bg-${type} border-0 show" role="alert" aria-live="assertive" aria-atomic="true">
      <div class="d-flex">
        <div class="toast-body">${message}</div>
        <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
      </div>
    </div>
  `;
  const toastEl = toastContainer.querySelector('.toast');
  if (toastEl) new bootstrap.Toast(toastEl).show();
}
