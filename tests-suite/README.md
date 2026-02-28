# Tests (suite)

All six tests: three Editmode (pass, fail, skip) and three Playmode (pass, fail, skip). Run editmode and playmode with separate commands. **Expected (full run):** Editmode run fails (one failure); Playmode run fails (one failure).

## Run by category

Tests are tagged with NUnit `[Category]` so you can run by outcome:

- **Passing**: Editmode and Playmode tests that pass. Filter by category `Passing` for a green run.
- **Failing**: Editmode and Playmode tests that fail. Filter by category `Failing` for a red run.
- **Skipped**: Editmode and Playmode tests with `[Ignore]`. Filter by category `Skipped`; run passes, skipped tests appear in the report.

Use your test runner’s or unity-cli’s category filter (e.g. `--filter "Category=Passing"` or equivalent) to run tests per category when needed.
