
[string[]]$ItemsToCompile = @(
	"TB_Paint",
	"TB_PaintCompactor",
	"TB_PaintRuntime"
)
$MSBuild = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
$ReleaseDirectory = ".\Release\"
foreach ($item in $ItemsToCompile)
{
	$Proj = ".\" + $item + "\" + $item + ".csproj"
	$Args = "/p:Configuration=Release /p:Platform=AnyCPU"

	& $MSBuild $Proj $Args
	$MSBuild + " .\" + $item + "\" + $item + ".csproj /t:Build /verbosity:detailed /p:Configuration=Release /p:Platform=""x64"""
	Copy-Item (".\" + $item + "\bin\Release\" + $item + ".exe") -Destination $ReleaseDirectory + $item + ".exe"
	Copy-Item (".\" + $item + "\bin\x64\Release\" + $item + ".exe") -Destination $ReleaseDirectory + $item + "_x64.exe"
}
$timestamp = Get-Date -Format "dd-MM-yyyy_HH-mm"
New-Item -Path ($ReleaseDirectory + $timestamp + ".txt")