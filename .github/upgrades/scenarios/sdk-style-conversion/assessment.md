# Assessment: SDK-style Conversion

## Projects to Convert
| Project | Path | packages.config | Custom Imports | Special Type | Risk |
|---------|------|----------------|----------------|-------------|------|
| AHORROS | AHORROS\AHORROS.vbproj | No (uses PackageReference) | $(MSBuildToolsPath)\Microsoft.VisualBasic.targets | WinForms (VB.NET) | Medium |

## Already SDK-style (no action needed)
- None

## Baseline
- Solution build: not executed as part of assessment
- Warning count: unknown

## Key Findings
- AHORROS.vbproj is a legacy (non-SDK) Visual Basic project file: it uses explicit <Compile Include="..."> entries and imports Microsoft.VisualBasic targets instead of using an SDK attribute on the <Project> element.
- The project targets .NET Framework v4.8 (TargetFrameworkVersion v4.8) and is a Windows Forms application (MyType=WindowsForms). Converting to SDK-style will not change the target framework but will require switching project style and possibly using the Microsoft.NET.Sdk.WindowsDesktop SDK when/if a TFM change is later performed.
- There is no packages.config present; the project already uses PackageReference elements for NuGet packages.
- Risk indicators:
  - WinForms desktop app: requires desktop SDK awareness when migrating build tooling and designer support may need attention.
  - Custom imports and explicit Compile includes: conversion must preserve file ordering and any custom build logic.
  - AssemblyInfo and My Project files are present and must be reconciled with SDK-style auto-generation of assembly attributes.

## Recommended next steps
1. Convert AHORROS.vbproj to SDK-style (single-project conversion). Create a per-project subtask in the conversion phase to handle file globs, preserve embedded resources, and ensure designer compatibility.
2. After conversion, build solution and verify designer files and resource generation work as before.

