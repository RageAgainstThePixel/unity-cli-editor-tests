#!/usr/bin/env bash
set -euo pipefail

UNITY_PROJECT_PATH="${UNITY_PROJECT_PATH:?}"
PROJECT="${PROJECT:?}"
BUILD_TARGET="${BUILD_TARGET:?}"
UNITY_VERSION="${UNITY_VERSION:?}"
BUILD_ARGS="${BUILD_ARGS:-}"

RUN_UNITY() {
  unity-cli run -p "$UNITY_PROJECT_PATH" -u "$UNITY_VERSION" -t "$BUILD_TARGET" -quit -batchmode -nographics "$@"
}

case "$PROJECT" in
  compiler-warnings)
    RUN_UNITY
    ;;
  compiler-errors)
    ec=0; RUN_UNITY || ec=$?
    [[ $ec -eq 0 ]] && { echo "Expected compiler-errors to fail"; exit 1; }
    ;;
  build-warnings|build-errors)
    (cd "$UNITY_PROJECT_PATH" && openupm add com.utilities.buildpipeline)
    RUN_UNITY -executeMethod Utilities.Editor.BuildPipeline.UnityPlayerBuildTools.ValidateProject -importTMProEssentialsAsset
    ec=0; RUN_UNITY -executeMethod Utilities.Editor.BuildPipeline.UnityPlayerBuildTools.StartCommandLineBuild -sceneList Assets/Scenes/Main.unity $BUILD_ARGS || ec=$?
    if [[ "$PROJECT" == "build-errors" ]]; then
      [[ $ec -eq 0 ]] && { echo "Expected build-errors to fail"; exit 1; }
    fi
    ;;
  tests-suite)
    for platform in EditMode PlayMode Player; do
      RUN_UNITY -runTests -testPlatform "$platform" -testResults "$UNITY_PROJECT_PATH/${platform}-Passing-results.xml" -testCategory Passing
      RUN_UNITY -runTests -testPlatform "$platform" -testResults "$UNITY_PROJECT_PATH/${platform}-Failing-results.xml" -testCategory Failing || true
      RUN_UNITY -runTests -testPlatform "$platform" -testResults "$UNITY_PROJECT_PATH/${platform}-Skipped-results.xml" -testCategory Skipped
      RUN_UNITY -runTests -testPlatform "$platform" -testResults "$UNITY_PROJECT_PATH/${platform}-All-results.xml" || true
    done
    ;;
  *)
    echo "Unknown project: $PROJECT"
    exit 1
    ;;
esac
