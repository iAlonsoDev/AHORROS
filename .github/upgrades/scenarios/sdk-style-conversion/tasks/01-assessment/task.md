# 01-assessment: Assessment

Assessment — Scan the solution and identify projects that need SDK-style conversion.

## Research Findings

### Projects Affected
- AHORROS\AHORROS.vbproj — Legacy Visual Basic WinForms project targeting .NET Framework v4.8. Uses explicit <Compile Include="..."> entries and imports Microsoft.VisualBasic.targets.

### Files to Modify
- None for assessment phase. This task only produces the assessment artifact.

### Packages to Update
| Package | Current | Target | Notes |
|---------|---------|--------|-------|
| N/A | N/A | N/A | No package updates during assessment.

### Dependencies & Risks
- Desktop WinForms: designer and generated code must remain compatible after conversion.
- AssemblyInfo and My Project auto-generated code may duplicate attributes with SDK-style projects; reconcile during conversion.

## Decisions Made
- Scope: Single-project assessment. No decomposition required — conversion can be handled as a single per-project subtask in the next phase.

## Done when
- `assessment.md` exists in the scenario folder.
- Project table produced and risk indicators listed (this file and the scenario assessment.md).
