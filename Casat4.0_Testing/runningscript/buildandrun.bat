set location="D:\Community\Community\Community"

@echo off
set hh=%time:~0,2%
if "%time:~0,1%"==" " set hh=0%hh:~1,1%   
set dt=%date:~4,2%-%date:~7,2%-%date:~10,4%_%hh:~0,2%_%time:~3,2%_%time:~6,2%

taskkill /F /IM vstest.discoveryengine.x86.exe /FI "MEMUSAGE gt 1"
cd %location%
"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" "E:\Mvv\CASAT 4.0\Casat_4.0\TestAutomation\Casat4.0_Testing\Casat4.0_Testing.sln" /p:configuration=debug

cd "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE"
echo %DATE% %TIME% > E:\Mvv\CASAT 4.0\Casat_4.0\TestAutomation\Casat4.0_Testing\TestResults\Summary.log
"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe" /testcontainer:"E:\Mvv\CASAT 4.0\Casat_4.0\TestAutomation\Casat4.0_Testing\Casat4.0_Testing\bin\Debug\Casat4.0_Testing.dll" /testsettings:"E:\Mvv\CASAT 4.0\Casat_4.0\TestAutomation\Casat4.0_Testing\settings.testsettings" >>"E:\Mvv\CASAT 4.0\Casat_4.0\TestAutomation\Casat4.0_Testing\TestResults\Summary.log"

cmd /k

