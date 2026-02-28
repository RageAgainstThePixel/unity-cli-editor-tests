using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UtilSceneSetup
{
    /// <summary>
    /// Ensures an empty build scene exists and is in EditorBuildSettings when the project is opened.
    /// The scene is created/serialized by the current Unity version so it stays version-appropriate.
    /// </summary>
    public static class EnsureBuildScene
    {
        private const string ScenePath = "Assets/Scenes/Main.unity";

        [InitializeOnLoadMethod]
        private static void OnEditorLoad()
        {
            if (AssetDatabase.LoadAssetAtPath<SceneAsset>(ScenePath) != null)
            {
                EnsureInBuildSettings();
                return;
            }

            if (!AssetDatabase.IsValidFolder("Assets/Scenes"))
            {
                AssetDatabase.CreateFolder("Assets", "Scenes");
            }

            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            EditorSceneManager.SaveScene(scene, ScenePath);
            AssetDatabase.Refresh();
            EnsureInBuildSettings();
        }

        private static void EnsureInBuildSettings()
        {
            var list = EditorBuildSettings.scenes.ToList();
            var existing = list.FindIndex(s => s.path == ScenePath);

            if (existing >= 0 && list[existing].enabled)
            {
                return;
            }

            if (existing >= 0)
            {
                list[existing] = new EditorBuildSettingsScene(ScenePath, true);
            }
            else
            {
                list.Add(new EditorBuildSettingsScene(ScenePath, true));
            }

            EditorBuildSettings.scenes = list.ToArray();
        }
    }
}
