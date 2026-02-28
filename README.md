# unity-cli-editor-tests

Smoke tests for [unity-cli](https://github.com/RageAgainstThePixel/unity-cli) and CI: compiler/build behavior and Editmode/Playmode test reporting.

## Build-scene setup

The **compiler** and **build** projects (compiler-warnings, compiler-errors, build-warnings, build-errors) each include a copy of the same editor script at `Assets/Editor/EnsureBuildScene.cs`. On Editor load it ensures an empty scene (`Assets/Scenes/Main.unity`) exists and is in build settings, so Unity versions that require a scene at build time are satisfied without committing a version-specific scene file.

## Test projects

### Compiler

- [compiler-warnings](compiler-warnings/): Deliberate CS0618 warning; build succeeds; warning in compiler output.
- [compiler-errors](compiler-errors/): `#error` directive; build fails.

### Build

- [build-warnings](build-warnings/): IPreprocessBuildWithReport logs a warning; build succeeds; warning in log.
- [build-errors](build-errors/): Editor script throws at build time; build fails.

### Tests (Editmode + Playmode)

- [tests-suite](tests-suite/): All six tests (pass, fail, skip). Run editmode and playmode with separate commands; full run fails (one failure per mode). Tests are tagged with NUnit categories **Passing**, **Failing**, and **Skipped** so you can run by category (e.g. filter by `Passing` for a green run, or `Failing` for a red run).
