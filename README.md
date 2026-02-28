# unity-cli-editor-tests

Smoke tests for [unity-cli](https://github.com/RageAgainstThePixel/unity-cli) and CI: compiler/build behavior and Editmode/Playmode test reporting.

## Test projects

### Compiler

- [compiler-warnings](compiler-warnings/): Deliberate CS0618 warning; build succeeds; warning in compiler output.
- [compiler-errors](compiler-errors/): `#error` directive; build fails.

### Build

- [build-warnings](build-warnings/): IPreprocessBuildWithReport logs a warning; build succeeds; warning in log.
- [build-errors](build-errors/): Editor script throws at build time; build fails.

### Editmode

- [editmode-passing](editmode-passing/): Single Editmode test `Assert.Pass`; tests pass.
- [editmode-errors](editmode-errors/): Single Editmode test `Assert.Fail`; tests fail.
- [editmode-skipped](editmode-skipped/): Editmode test with `[Ignore]`; tests pass (no test run).
- [editmode-suite](editmode-suite/): Pass/fail/skip Editmode; run fails (one test fails).

### Playmode

- [playmode-passing](playmode-passing/): Single Playmode `[UnityTest]` passes; tests pass.
- [playmode-errors](playmode-errors/): Single Playmode `[UnityTest]` fails; tests fail.
- [playmode-skipped](playmode-skipped/): Playmode with `[Ignore]`; tests pass.
- [playmode-suite](playmode-suite/): All three Playmode tests; run fails (one test fails).
