@echo off
echo ============================================
echo   JEEVIKA ACCOUNTING ERP
echo   Startup Script
echo ============================================
echo.

echo [1/4] Checking .NET installation...
where dotnet >nul 2>nul
if %errorlevel% neq 0 (
    echo ERROR: .NET is not installed or not in PATH
    echo Please install .NET 8.0 SDK from https://dotnet.microsoft.com/download
    pause
    exit /b 1
)

echo [2/4] Verifying database...
if exist "%~dp0Backend\Data\ShreeRam.sqlite" (
    echo   Database found.
    rem del /f /q "%~dp0Backend\Data\ShreeRam.sqlite" >nul 2>nul
) else (
    echo   No old database found. Fresh one will be created.
)

echo [3/4] Starting Backend API Server (port 5001)...
cd /d "%~dp0Backend"
start "JEEVIKA Backend" cmd /k "dotnet run --urls http://localhost:5001"

echo Waiting for backend to initialize (10 seconds)...
timeout /t 10 /nobreak >nul

echo [4/4] Starting Frontend Server (port 3000)...
cd /d "%~dp0Frontend"
start "JEEVIKA Frontend" cmd /k "npx -y serve -l 3000 ."

echo Waiting for frontend to start...
timeout /t 5 /nobreak >nul

echo Opening browser...
start "" "http://localhost:3000/login.html"

echo.
echo ============================================
echo   System Running Successfully!
echo   Backend API:  http://localhost:5001
echo   Frontend:     http://localhost:3000
echo   Login:        http://localhost:3000/login.html
echo.
echo   Default Credentials:
echo     Username: ADMIN
echo     Password: ADMIN
echo ============================================
echo.
echo Press any key to exit this window...
pause
