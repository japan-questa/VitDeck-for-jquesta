using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;

public static class Utility
{

    /*[InitializeOnLoadMethod]
    private static void Run()
    {
        var pattern = new Regex("^Assets/VitDeck/Templates/JQuesta_Event_Booth_[^/]+/TemplateAssets/{ID}/Interior_[^/]+/Interior_[^/]+.prefab");
        foreach (var path in AssetDatabase.GetAllAssetPaths())
        {
            if (!pattern.IsMatch(path))
            {
                continue;
            }

            Debug.Log(path);

            var prefab = PrefabUtility.LoadPrefabContents(path);

            foreach (var transform in prefab.GetComponentsInChildren<Transform>())
            {
                GameObjectUtility.SetStaticEditorFlags(
                    transform.gameObject,
                    StaticEditorFlags.OccludeeStatic | StaticEditorFlags.BatchingStatic | StaticEditorFlags.ReflectionProbeStatic
                );
            }

            PrefabUtility.SaveAsPrefabAsset(prefab, path);
            PrefabUtility.UnloadPrefabContents(prefab);
        }
    }*/
}
