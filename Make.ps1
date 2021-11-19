<#
.SYNOPSIS
    Invokes various build commands.

.DESCRIPTION
    This script is similar to a makefile.
#>
[CmdletBinding(DefaultParameterSetName="Build")]
param (
    # Build.
    [Parameter(Mandatory, ParameterSetName="Build")]
    [Parameter(ParameterSetName="Run")]
    [Parameter(ParameterSetName="RunCheckout")]
    [Parameter(ParameterSetName="RunFooter")]
    [Parameter(ParameterSetName="RunHeader")]
    [Parameter(ParameterSetName="RunLanding")]
    [Parameter(ParameterSetName="RunProductDetail")]
    [Parameter(ParameterSetName="RunSearch")]
    [Parameter(ParameterSetName="RunShell")]
    [Parameter(ParameterSetName="RunMicroService")]
    [switch] $Build,

    # Run All.
    [Parameter(Mandatory, ParameterSetName="RunAll")]
    [switch] $RunAll,

    # Run Checkout MFE.
    [Parameter(Mandatory, ParameterSetName="RunCheckout")]
    [switch] $RunCheckout,

    # Run Footer MFE.
    [Parameter(Mandatory, ParameterSetName="RunFooter")]
    [switch] $RunFooter,

    # Run Header MFE.
    [Parameter(Mandatory, ParameterSetName="RunHeader")]
    [switch] $RunHeader,

    # Run Landing MFE.
    [Parameter(Mandatory, ParameterSetName="RunLanding")]
    [switch] $RunLanding,

    # Run ProductDetail MFE.
    [Parameter(Mandatory, ParameterSetName="RunProductDetail")]
    [switch] $RunProductDetail,

    # Run Search MFE.
    [Parameter(Mandatory, ParameterSetName="RunSearch")]
    [switch] $RunSearch,

    # Run Shell MFE.
    [Parameter(Mandatory, ParameterSetName="RunShell")]
    [switch] $RunShell,

    # Run MicroService.
    [Parameter(Mandatory, ParameterSetName="RunMicroService")]
    [switch] $RunMicroService,

    # The configuration to build: Debug or Release.  The default is Debug.
    [Parameter(ParameterSetName="Build")]
    [ValidateSet("Debug", "Release")]
    [string] $Configuration = "Debug"
)

#Requires -Version 7
$ErrorActionPreference = "Stop"
Set-StrictMode -Version Latest

$Command = $PSCmdlet.ParameterSetName
if ($Command -eq "Build") { $Build = $true }

# http://patorjk.com/software/taag/#p=display&f=Slant
Write-Host -ForegroundColor Cyan @'
    __  __           __         __  __                   ___   ____ ___  ___
   / / / /___ ______/ /______ _/ /_/ /_  ____  ____     |__ \ / __ \__ \<  /
  / /_/ / __ `/ ___/ //_/ __ `/ __/ __ \/ __ \/ __ \    __/ // / / /_/ // /
 / __  / /_/ / /__/ ,< / /_/ / /_/ / / / /_/ / / / /   / __// /_/ / __// /
/_/ /_/\__,_/\___/_/|_|\__,_/\__/_/ /_/\____/_/ /_/   /____/\____/____/_/
    ____  __           __      __    _
   / __ )/ /___ ______/ /__   / /   (_)___  ____
  / __  / / __ `/ ___/ //_/  / /   / / __ \/ __ \
 / /_/ / / /_/ / /__/ ,<    / /___/ / /_/ / / / /
/_____/_/\__,_/\___/_/|_|  /_____/_/\____/_/ /_/

'@

function Main {
    if ($Build) {
        Invoke-Build
    }

    # Invoke the individual run commands
    if ($RunCheckout -or $RunAll) {
        Invoke-Run -ProjName "Checkout" -IsMfe $true
    }
    if ($RunFooter -or $RunAll) {
        Invoke-Run -ProjName "Footer" -IsMfe $true
    }
    if ($RunHeader -or $RunAll) {
        Invoke-Run -ProjName "Header" -IsMfe $true
    }
    if ($RunLanding -or $RunAll) {
        Invoke-Run -ProjName "Landing" -IsMfe $true
    }
    if ($RunProductDetail -or $RunAll) {
        Invoke-Run -ProjName "ProductDetail" -IsMfe $true
    }
    if ($RunSearch -or $RunAll) {
        Invoke-Run -ProjName "Search" -IsMfe $true
    }
    if ($RunShell -or $RunAll) {
        Invoke-Run -ProjName "Shell" -IsMfe $true
    }
    if ($RunMicroService -or $RunAll) {
        Invoke-Run -ProjName "MicroService" -IsMfe $false
    }
}

function Invoke-Build {
    Write-Phase "Build"
    Invoke-DotNetExe build ./src/Hack2021BlackLion.sln --configuration $Configuration
}

function Invoke-Run($ProjName, $IsMfe) {
    Write-Phase "Run $ProjName"
    Invoke-DotNetExeInNewWindow -Arguments @(
        "run"
        "--project ./src/$ProjName/$ProjName.csproj"
    )
    if ($IsMfe) {
        Invoke-WebpackInNewWindow -Directory "$PSScriptRoot/src/$ProjName/app"
    }    
}

function Invoke-DotNetExeInNewWindow {
    param (
        [Parameter(Mandatory, ValueFromRemainingArguments)]
        [string[]] $Arguments
    )
    Start-Process pwsh -ArgumentList "-noexit", "-command & dotnet.exe $Arguments"
}

function Invoke-WebpackInNewWindow {
    param (
        [Parameter(Mandatory)]
        [string] $Directory
    )
    $cmds = { "-noexit", "& Set-Location $Directory", "& npm run watch" }
    Start-Process pwsh -ArgumentList "-noexit", "-command & Set-Location $Directory; & npm run watch"
}

function Write-Phase {
    param (
        [Parameter(Mandatory)]
        [string] $Name
    )
    Write-Host "`n===== $Name =====`n" -ForegroundColor Cyan
}

# Invoke Main
try {
    Push-Location $PSScriptRoot
    Main
}
finally {
    Pop-Location
}
