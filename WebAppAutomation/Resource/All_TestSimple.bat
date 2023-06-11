@ECHO OFF
ECHO Web Automation Execution Started.

call "C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\Common7\Tools\VsDevCmd.bat"

vstest.console.exe C:\Users\abdul\source\repos\WebAppAutomation\bin\Debug\WebAppAutomation.dll

PAUSE