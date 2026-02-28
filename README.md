# unity-cli-editor-tests

Smoke tests for [unity-cli](https://github.com/RageAgainstThePixel/unity-cli) and CI: compiler/build behavior and Editmode/Playmode test reporting.

## Test projects

### Compiler

- [compiler-warnings](compiler-warnings/): Deliberate CS0618 warning; build succeeds; warning in compiler output.
- [compiler-errors](compiler-errors/): `#error` directive; build fails.

### Build

- [build-warnings](build-warnings/): IPreprocessBuildWithReport logs a warning; build succeeds; warning in log.
- [build-errors](build-errors/): Editor script throws at build time; build fails.

### Tests (Editmode + Playmode)

- [tests-suite](tests-suite/): All six tests (pass, fail, skip). Run editmode and playmode with separate commands; full run fails (one failure per mode). Tests are tagged with NUnit categories **Passing**, **Failing**, and **Skipped** so you can run by category (e.g. filter by `Passing` for a green run, or `Failing` for a red run).
