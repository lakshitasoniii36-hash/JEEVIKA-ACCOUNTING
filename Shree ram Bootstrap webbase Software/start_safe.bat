@echo off
echo ============================================
echo   JEEVIKA ERP - BUILD AND START
echo ============================================
echo.

echo [1/3] Building Backend...
cd /d "%~dp0Backend"
dotnet build 2>&1
if %errorlevel% neq 0 (
    echo BUILD FAILED! Check errors above.
    pause
    exit /b 1
)
echo BUILD SUCCESSFUL!
echo.

echo [2/3] Starting Backend API on port 5002...
start "JEEVIKA Backend" cmd /k "dotnet run --urls http://localhost:5002"

echo Waiting for backend to initialize (8 seconds)...
timeout /t 8 /nobreak >nul

echo [3/3] Starting Frontend on port 3000...
cd /d "%~dp0Frontend"
start "JEEVIKA Frontend" cmd /k "npx -y serve -l 3000 ."

echo Waiting for frontend (5 seconds)...
timeout /t 5 /nobreak >nul

echo Opening browser...
start "" "http://localhost:3000/workspace.html"

echo.
echo ============================================
echo   System Running!
echo   Backend:  http://localhost:5002
echo   Frontend: http://localhost:3000
echo   Workspace: http://localhost:3000/workspace.html
echo ============================================
echo.
pause
