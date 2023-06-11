@ECHO OFF
ECHO AUTOMATION OF ADACTIN HOTEL APP STARTED.

call "C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\Common7\Tools\VsDevCmd.bat"

vstest.console.exe C:\Users\abdul\source\repos\WebAppAutomation\bin\Debug\WebAppAutomation.dll /TestCaseFilter:"TestCategory=BookHotel" /Logger:"trx;LogFileName=C:\Users\abdul\source\repos\WebAppAutomation\TestSummaryReport\BookHotel.trx"

cd C:\Users\abdul\source\repos\WebAppAutomation\bin\Debug\

TrxToHTML.exe C:\Users\abdul\source\repos\WebAppAutomation\TestSummaryReport\

PAUSE