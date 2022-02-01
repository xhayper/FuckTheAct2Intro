@echo off
dotnet build
RMDIR /s /q production >nul 2>&1
XCOPY bin\Debug\netstandard2.1\FuckTheAct2Intro.dll production\ /v /y >nul
XCOPY manifest.json production\ /v /y >nul
XCOPY icon.png production\ /v /y >nul
XCOPY README.md production\ /v /y >nul