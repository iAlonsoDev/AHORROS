# Plan: SDK-style Conversion

## Overview
Convert legacy non-SDK-style projects to SDK-style project format. Work in-place on the current branch (DESARROLLO_AHORROS) and commit after each task.

## Top-level Tasks

- 01-assessment: Assessment — Scan the solution and identify projects that need SDK-style conversion.
  Done when:
  - `assessment.md` exists in the scenario folder.
  - A table of projects with `packages.config` and explicit file includes has been produced.
  - Risk indicators (ASP.NET, custom imports, shared projects) are listed per project.

- 02-conversion: Convert projects — (created after assessment) Convert identified projects to SDK-style format. (Will be broken into per-project subtasks.)

