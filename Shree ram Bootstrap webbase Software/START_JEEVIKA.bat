@echo off
title JEEVIKA ERP - Build and Start
color 0B
echo.
echo  =============================================
echo   JEEVIKA ERP - Build and Start
echo  =============================================
echo.

echo [1/4] Stopping old servers...
taskkill /F /IM "dotnet.exe" >nul 2>&1
timeout /t 2 /nobreak >nul

echo [2/4] Building Backend...
cd /d "H:\Jai Shree ram\Shree ram Bootstrap webbase Software\Backend"
dotnet build
if %errorlevel% neq 0 (
    echo.
    echo  BUILD FAILED!
    pause
    exit /b 1
)
echo  BUILD SUCCESS!
echo.

echo [2.5] Cleaning old database for fresh schema...
if exist "bin\Debug\net8.0\Data\ShreeRam.sqlite" del /f "bin\Debug\net8.0\Data\ShreeRam.sqlite"

echo [3/4] Starting Backend on port 5002...
start "Jeevika Backend" dotnet run --urls http://localhost:5002
echo  Waiting 12 seconds...
timeout /t 12 /nobreak >nul

echo [4/4] Opening browser...
start "" "http://localhost:3000/workspace.html"

echo.
echo  =============================================
echo   Backend: http://localhost:5002
echo   Swagger: http://localhost:5002/swagger
echo   Frontend: http://localhost:3000
echo  =============================================
pause
