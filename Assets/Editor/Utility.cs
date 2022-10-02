using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;

public static class Utility
{

    //[InitializeOnLoadMethod]
    private static void Run()
    {
        //var pattern = new Regex("^Assets/VitDeck/Templates/JQuesta_.+");
        //foreach (var path in AssetDatabase.GetAllAssetPaths())
        //{
        //    if (!pattern.IsMatch(path))
        //    {
        //        continue;
        //    }

        //    var importer = AssetImporter.GetAtPath(path) as TextureImporter;
        //    if (importer == null)
        //    {
        //        continue;
        //    }

        //    Debug.Log(path);

        //    var settings = importer.GetPlatformTextureSettings("Android");
        //    settings.overridden = true;
        //    settings.format = TextureImporterFormat.ASTC_6x6;
        //    importer.SetPlatformTextureSettings(settings);
        //    EditorUtility.SetDirty(importer);
        //    importer.SaveAndReimport();
        //}



        //var pattern = new Regex("^Assets/VitDeck/Templates/JQuesta_Event_Booth_[^/]+/TemplateAssets/{ID}/Interior_[^/]+/Interior_[^/]+.prefab");
        //foreach (var path in AssetDatabase.GetAllAssetPaths())
        //{
        //    if (!pattern.IsMatch(path))
        //    {
        //        continue;
        //    }

        //    Debug.Log(path);

        //    var prefab = PrefabUtility.LoadPrefabContents(path);

        //    foreach (var transform in prefab.GetComponentsInChildren<Transform>())
        //    {
        //        GameObjectUtility.SetStaticEditorFlags(
        //            transform.gameObject,
        //            StaticEditorFlags.OccludeeStatic | StaticEditorFlags.BatchingStatic | StaticEditorFlags.ReflectionProbeStatic
        //        );
        //    }

        //    PrefabUtility.SaveAsPrefabAsset(prefab, path);
        //    PrefabUtility.UnloadPrefabContents(prefab);
        //}
    }
}
