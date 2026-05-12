Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "  JEEVIKA ERP - Build & Start" -ForegroundColor Cyan
Write-Host "==========================================" -ForegroundColor Cyan
Write-Host ""

# Kill any old dotnet processes
Write-Host "[1/4] Stopping old servers..." -ForegroundColor Yellow
Get-Process -Name "dotnet" -ErrorAction SilentlyContinue | Stop-Process -Force -ErrorAction SilentlyContinue
Start-Sleep -Seconds 2

# Build
Write-Host "[2/4] Building Backend..." -ForegroundColor Yellow
Set-Location "H:\Jai Shree ram\Shree ram Bootstrap webbase Software\Backend"
$buildResult = dotnet build 2>&1
$buildResult | ForEach-Object { Write-Host $_ }

if ($LASTEXITCODE -ne 0) {
    Write-Host "`nBUILD FAILED! Fix errors and try again." -ForegroundColor Red
    Read-Host "Press Enter to exit"
    exit 1
}
Write-Host "BUILD SUCCESSFUL!" -ForegroundColor Green
Write-Host ""

# Delete old database so fresh schema is created
$dbPath = Join-Path (Get-Location) "bin\Debug\net8.0\Data\ShreeRam.sqlite"
if (Test-Path $dbPath) {
    Remove-Item $dbPath -Force
    Write-Host "[INFO] Old database deleted for clean schema." -ForegroundColor Yellow
}

# Start backend
Write-Host "[3/4] Starting Backend on port 5002..." -ForegroundColor Yellow
Start-Process -FilePath "dotnet" -ArgumentList "run --urls http://localhost:5002" -WorkingDirectory "H:\Jai Shree ram\Shree ram Bootstrap webbase Software\Backend"
Write-Host "Waiting 12 seconds for server to initialize..." -ForegroundColor Gray
Start-Sleep -Seconds 12

# Test backend
Write-Host "[4/4] Testing API..." -ForegroundColor Yellow
try {
    $response = Invoke-RestMethod -Uri "http://localhost:5002/api/group" -TimeoutSec 5
    Write-Host "API is LIVE! Groups found: $($response.data.Count)" -ForegroundColor Green
} catch {
    Write-Host "API test failed: $_" -ForegroundColor Red
    Write-Host "The server may still be starting. Try opening http://localhost:5002/swagger in browser." -ForegroundColor Yellow
}

# Open browser
Write-Host ""
Write-Host "Opening workspace in browser..." -ForegroundColor Cyan
Start-Process "http://localhost:3000/workspace.html"

Write-Host ""
Write-Host "==========================================" -ForegroundColor Green
Write-Host "  Backend : http://localhost:5002" -ForegroundColor Green
Write-Host "  Swagger : http://localhost:5002/swagger" -ForegroundColor Green
Write-Host "  Frontend: http://localhost:3000" -ForegroundColor Green
Write-Host "==========================================" -ForegroundColor Green
Write-Host ""
Read-Host "Press Enter to close (servers keep running)"
