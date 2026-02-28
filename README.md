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

Each project contains both Editmode and Playmode tests; run editmode and playmode with separate commands.

- [tests-passing](tests-passing/): Editmode and Playmode tests that pass.
- [tests-errors](tests-errors/): Editmode and Playmode tests that fail.
- [tests-skipped](tests-skipped/): Editmode and Playmode tests with `[Ignore]`; runs pass.
- [tests-suite](tests-suite/): All six tests (pass, fail, skip); both runs fail (one failure each).
