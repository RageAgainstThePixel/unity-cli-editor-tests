using UnityEngine;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

/// <summary>
/// Emits a build-time warning via the build pipeline (no custom UTP JSON logging).
/// Place under an Editor folder when copying into a project.
/// </summary>
public class BuildWarnings : IPreprocessBuildWithReport
{
    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildReport report)
    {
        Debug.LogWarning("Intentional build warning.");
    }
}
