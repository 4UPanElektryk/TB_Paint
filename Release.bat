@echo off

start msbuild .\TB_Paint\TB_Paint.csproj /t:Build /verbosity:detailed /p:Configuration=Release /p:Platform="AnyCPU"
start msbuild .\TB_Paint\TB_Paint.csproj /t:Build /verbosity:detailed /p:Configuration=Release /p:Platform="AnyCPU"
start msbuild .\TB_Paint\TB_Paint.csproj /t:Build /verbosity:detailed /p:Configuration=Release /p:Platform="AnyCPU"

start msbuild .\TB_Paint\TB_Paint.csproj /t:Build /verbosity:detailed /p:Configuration=Release /p:Platform="AnyCPU"
start msbuild .\TB_Paint\TB_Paint.csproj /t:Build /verbosity:detailed /p:Configuration=Release /p:Platform="AnyCPU"
start msbuild .\TB_Paint\TB_Paint.csproj /t:Build /verbosity:detailed /p:Configuration=Release /p:Platform="AnyCPU"

COPY ".\TB_Paint\bin\Release\TB_Paint.exe" ".\ToRelease\TB_Paint.exe"
COPY ".\TB_Paint\bin\x64\Release\TB_Paint.exe" ".\ToRelease\TB_Paint_x64.exe"

COPY ".\TB_PaintCompactor\bin\Release\TB_PaintCompactor.exe" ".\ToRelease\TB_PaintCompactor.exe"
COPY ".\TB_PaintCompactor\bin\x64\Release\TB_PaintCompactor.exe" ".\ToRelease\TB_PaintCompactor_x64.exe"

COPY ".\TB_PaintRuntime\bin\Release\TB_PaintRuntime.exe" ".\ToRelease\TB_PaintRuntime.exe"
COPY ".\TB_PaintRuntime\bin\x64\Release\TB_PaintRuntime.exe" ".\ToRelease\TB_PaintRuntime_x64.exe"

for /f "tokens=2 delims==" %%a in ('wmic OS Get localdatetime /value') do set "dt=%%a"
set "YY=%dt:~2,2%" & set "YYYY=%dt:~0,4%" & set "MM=%dt:~4,2%" & set "DD=%dt:~6,2%"
set "HH=%dt:~8,2%" & set "Min=%dt:~10,2%" & set "Sec=%dt:~12,2%"

set "fullstamp=%YYYY%-%MM%-%DD%_%HH%-%Min%-%Sec%"
echo %fullstamp% > ".\ToRelease\PackedOn.txt"