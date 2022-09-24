namespace VitDeck.Validator
{
    public static class JQuestaAssetData
    {
        /// <summary>
        /// 公式配布されたアセット及び前提となるアセットのGUID
        /// <list type="bullet">
        /// <item>DynamicBone</item>
        /// <item>TextMeshPro</item>
        /// <item>VRCSDK</item>
        /// <item>Udon</item>
        /// <item>VitDeck</item>
        /// <item>VitDeck Template SharesAssets</item>
        /// <item>VketAssets</item>
        /// <item>VketShaderPack</item>
        /// </list>
        /// </summary>
        public static string[] GUIDs = new string[]
        {
            #region DynamicBone

            "bdbe6feeda2a62b45ad9a4e311031478",  // Assets/DynamicBone/ReadMe.txt
            "ba128457d0ea5e3439dbe4a53b9d1273",  // Assets/DynamicBone/Demo/c1.fbx
            "902c84bf971339c459ce4b757e333a55",  // Assets/DynamicBone/Demo/Demo1.unity
            "178320cedf292cb4f8d6c0b737b35953",  // Assets/DynamicBone/Demo/DynamicBoneDemo1.cs
            "19015a5957bbaa745a61cba005220542",  // Assets/DynamicBone/Demo/tail.FBX
            "f9ac8d30c6a0d9642a11e5be4c440740",  // Assets/DynamicBone/Scripts/DynamicBone.cs
            "baedd976e12657241bf7ff2d1c685342",  // Assets/DynamicBone/Scripts/DynamicBoneCollider.cs
            "04878769c08021a41bc2d2375e23ec0b",  // Assets/DynamicBone/Scripts/DynamicBoneColliderBase.cs
            "4e535bdf3689369408cc4d078260ef6a",  // Assets/DynamicBone/Scripts/DynamicBonePlaneCollider.cs

            #endregion

            #region Text Mesh Pro

            "6e59c59b81ab47f9b6ec5781fa725d2c",  // Assets/TextMesh Pro/Fonts/LiberationSans - OFL.txt
            "e3265ab4bf004d28a9537516768c1c75",  // Assets/TextMesh Pro/Fonts/LiberationSans.ttf
            "fade42e8bc714b018fac513c043d323b",  // Assets/TextMesh Pro/Resources/LineBreaking Following Characters.txt
            "d82c1b31c7e74239bff1220585707d2b",  // Assets/TextMesh Pro/Resources/LineBreaking Leading Characters.txt
            "3f5b5dff67a942289a9defa416b206f3",  // Assets/TextMesh Pro/Resources/TMP Settings.asset
            "e73a58f6e2794ae7b1b7e50b7fb811b0",  // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Drop Shadow.mat
            "2e498d1c8094910479dc3e1b768306a4",  // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Fallback.asset
            "79459efec17a4d00a321bdcc27bbc385",  // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Outline.mat
            "8f586378b4e144a9851e7b34d9b748ee",  // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset
            "407bc68d299748449bbf7f48ee690f8d",  // Assets/TextMesh Pro/Resources/Shaders/TMPro.cginc
            "3997e2241185407d80309a82f9148466",  // Assets/TextMesh Pro/Resources/Shaders/TMPro_Properties.cginc
            "d930090c0cd643c7b55f19a38538c162",  // Assets/TextMesh Pro/Resources/Shaders/TMPro_Surface.cginc
            "48bb5f55d8670e349b6e614913f9d910",  // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap-Custom-Atlas.shader
            "1e3b057af24249748ff873be7fafee47",  // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap-Mobile.shader
            "128e987d567d4e2c824d754223b3f3b0",  // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap.shader
            "dd89cf5b9246416f84610a006f916af7",  // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF Overlay.shader
            "bc1ede39bf3643ee8e493720e4259791",  // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile Masking.shader
            "a02a7d8c237544f1962732b55a9aebf1",  // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile Overlay.shader
            "fe393ace9b354375a9cb14cdbbc28be4",  // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile.shader
            "85187c2149c549c5b33f0cdb02836b17",  // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Surface-Mobile.shader
            "f7ada0af4f174f0694ca6a487b8f543d",  // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Surface.shader
            "68e6db2ebdc24f95958faec2be5558d6",  // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF.shader
            "cf81c85f95fe47e1a27f6ae460cf182c",  // Assets/TextMesh Pro/Resources/Shaders/TMP_Sprite.shader
            "c41005c129ba4d66911b75229fd70b45",  // Assets/TextMesh Pro/Resources/Sprite Assets/EmojiOne.asset
            "f952c082cb03451daed3ee968ac6c63e",  // Assets/TextMesh Pro/Resources/Style Sheets/Default Style Sheet.asset
            "381dcb09d5029d14897e55f98031fca5",  // Assets/TextMesh Pro/Sprites/EmojiOne Attribution.txt
            "8f05276190cf498a8153f6cbe761d4e6",  // Assets/TextMesh Pro/Sprites/EmojiOne.json
            "dffef66376be4fa480fb02b19edbe903",  // Assets/TextMesh Pro/Sprites/EmojiOne.png

            #endregion

            #region VRCSDK

            "2cdbe2e71e2c46e48951c13df254e5b1",  // Assets/VRCSDK/version.txt
            "820ee6e459999be418b410c7af108bc3",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll
            "17e2ad8740ce0ab4eb1a95a73e362865",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll.mdb
            "aecaffc7454b52e448fc0ea1aef2dd1d",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll
            "027e8b8acf565544d9050219e1521b7e",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll.mdb
            "d4055bfc0cd67d642a7eceaf547c4901",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll
            "0da239ac72288814a9c4b799c7674b25",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll.mdb
            "625a50dd0dd525a49a41cb3e3117fa15",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll
            "b93a9778ddf074845b1649181fda7e86",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll.mdb
            "34b0990e1522a284b9666d6821cd601c",  // Assets/VRCSDK/Dependencies/DotZLib/DotZLib.dll
            "b609c54f9d3581e4fa22b3e389fd8d33",  // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86/zlibwapi.dll
            "54f59547b5261e64f8256d6daaa01b17",  // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86_64/zlibwapi.dll
            "a2e4b2ce02fa7914895069e5fdbf112d",  // Assets/VRCSDK/Dependencies/librsync/Blake2Sharp.dll
            "912b2ac597cb1ad4c9bdc1a98ec15459",  // Assets/VRCSDK/Dependencies/librsync/librsync.net.dll
            "cb850b86de9091d4db4595959c56f954",  // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Editor/ONSPAudioSourceEditor.cs
            "e503ea6418d27594caa33b93cac1b06a",  // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPAudioSource.cs
            "ad074644ff568a14187a3690cfbd7534",  // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPSettings.cs
            "5a8cc42eaba7a2a41b6ca3be3c40b315",  // Assets/VRCSDK/Dependencies/SharpZipLib/ICSharpCode.SharpZipLib.dll
            "d471b09e7f06a69458457ec63d3532b8",  // Assets/VRCSDK/Dependencies/VRChat/Settings.asset
            "10d9f721d76e07a47bc9e5f61e2fae72",  // Assets/VRCSDK/Dependencies/VRChat/Editor/EnvConfig.cs
            "c3399613f583f3e46b2df27ae87dd5d6",  // Assets/VRCSDK/Dependencies/VRChat/Editor/HDRColorFixerUtility.cs
            "7b8bb626428d0f341b9ed6a68cb5c9cc",  // Assets/VRCSDK/Dependencies/VRChat/Editor/SDKUpdater.cs
            "679ba0056bf110c4db8b550082e73a5f",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderKeywordsUtility.cs
            "4a9696f3dea8a764f9c4bc6d2e652b74",  // Assets/VRCSDK/Dependencies/VRChat/Editor/VRCCachedWWW.cs
            "cb5d1f9882b08564cae97b2b14ad4e8f",  // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_EditorTools.cs
            "f4cf5dd705ab67149afaba40b4a8fa7e",  // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_SdkSplashScreen.cs
            "3d6a1d7b0624f414ba6fb922687a06da",  // Assets/VRCSDK/Dependencies/VRChat/Editor/AWS/S3Manager.cs
            "21332e1f0d937794d916d2402ba1943a",  // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/VRC.SDKBase.Editor.BuildPipeline.asmdef
            "0a1d20f4241085e46bdddc71b691465b",  // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/Samples/VRCSDKBuildRequestedCallbackSample.cs
            "39cdf3092ab81be4b9e623cb5a8819d8",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/ApiCacheEditor.cs
            "0a364ece829b6234888c59987a305a00",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/AutoAddSpatialAudioComponents.cs
            "89005ebc9543e0a4284893c09ca19b1d",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorCoroutine.cs
            "3d6c2e367eaa9564ebf6267ec163cfbd",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorHandling.cs
            "4810e652e8242384c834320970702290",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EventHandlerEditor.cs
            "482185bf29f12074dada194ffef6a682",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/OldTriggerEditors.cs
            "5e83254bb97e84795ac882692ae124ba",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCAvatarDescriptorEditor.cs
            "26a75599848adb449b7aceed5090e35c",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSpawnEditor.cs
            "ed4aad2698d3b62408e69b57c7748791",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSyncEditor.cs
            "8986a640e24a0754ea0aded12234b808",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModEditorWindow.cs
            "792e7964a56e51f4188e1221751642e9",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModsEditor.cs
            "5262a02c32e41e047bdfdfc3b63db8ff",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerStationEditor.cs
            "e9cbc493bbbc443fb92898aa84d221ec",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCSceneDescriptorEditor.cs
            "eeda995d0ceac6443a54716996eab52e",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_AvatarVariationsEditor.cs
            "0ac7998a36f085844847acbc046d4e27",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DataStorageEditor.cs
            "3b63b118c0591b548ba1797e6be4292e",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DestructibleStandardEditor.cs
            "e19a7147a2386554a8e4d6e414f190a2",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_ObjectSyncEditor.cs
            "4aff4e5c0d600c845b29d7b8b7965d68",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PickupEditor.cs
            "5c545625e0bf93045ac1c5864141c5c1",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PlayerAudioOverrideEditor.cs
            "0d2d4cba733f5eb4ba170368e67710d2",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SpatialAudioSourceEditor.cs
            "ae0e74693b7899f47bd98864f94b9311",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoPlayerEditor.cs
            "3f9dccfed0b072f49a307b3f20a7e768",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoStreamEditor.cs
            "3aecd666943878944a811acb9db2ace7",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_TriggerEditor.cs
            "d09b36020f697be4d9a0f5a6a48cfa83",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_WebPanelEditor.cs
            "764e26c1ca28e2e45a30c778c1955a47",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_YouTubeSyncEditor.cs
            "d57b23c04034119448f23c5fdbc57662",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCDestructibleUdonEditor.cs
            "8901d07a685ca424492a3cabff506184",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCPlayerStationEditor3.cs
            "4b2b9ac625bc5b04c887ff9ee9b5fdbe",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCSceneDescriptorEditor3.cs
            "a8cc4c1876b26174fbaeb062178a6bda",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_PickupEditor3.cs
            "3f8f999a8e1ebee4588f94a8a618d7c6",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_SpatialAudioSourceEditor3.cs
            "310a760e312f2984e85eece367bab19a",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/IVRCSdkControlPanelBuilder.cs
            "20b4cdbdda9655947aab6f8f2c90690f",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanel.cs
            "5066cd5c1cc208143a1253cac821714a",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelAccount.cs
            "4c73e735ee0380241b186a8993fa56bf",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilder.cs
            "c768b42ca9a2f2b48afeb1fa03d5e1bf",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilderAttribute.cs
            "c7333cdb3df19724b84b4a1b05093fe0",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelContent.cs
            "f3507a74e4b8cfd469afac127fa5f4e5",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelHelp.cs
            "8357b9b7ef2416946ae86f465a64c0e0",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelSettings.cs
            "f2a720a30f1043247af7742fdfd0b8e5",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelWorldBuilder.cs
            "93710d221addc0243ba90dd20369844b",  // Assets/VRCSDK/Dependencies/VRChat/Editor/SDK3Compatibility/VRCSdk3Analysis.cs
            "c18570190ea21fa4babc80af77d4d766",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/StripPostProcessing.cs
            "b1e8486f7c7c81a4ea45be9776971082",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/VRC.SDKBase.Editor.ShaderStripping.asmdef
            "62d40cc4e8f8494695f0102c58b3ea60",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Validation/Performance/SDKPerformanceDisplay.cs
            "da07ab9b78cb0432e95e11e2cb619ea7",  // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.mat
            "94b649c2bd1ac4cac95049605dc5333d",  // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.renderTexture
            "2166f6bbfce69594fad494087eca58e8",  // Assets/VRCSDK/Dependencies/VRChat/Materials/damageGrey.mat
            "e13e96301b7c8214dac6883be5b82bfa",  // Assets/VRCSDK/Dependencies/VRChat/Models/damageSphere.fbx
            "841c3ce718e8b61408005c1cfce6b7de",  // Assets/VRCSDK/Dependencies/VRChat/Models/Materials/lambert2.mat
            "4acdf7b3eb426480bb5acf58638bd493",  // Assets/VRCSDK/Dependencies/VRChat/Resources/awsconfig.xml
            "dd5614b710e774040ab715161f7dfaca",  // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.customizations.json
            "37b4abef7420c4c7ea71dbe76757498a",  // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.json
            "be98467dc5d3c4eb1aeef22952913b0e",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCCam.prefab
            "dce0dda226bd1f147a34f9b4660f5992",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCProjectSettings.prefab
            "b14e1b78a061f8543b2f4120b5c369fa",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKAvatar.prefab
            "248f850c58993ed43bcaad6b934b7c92",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader.png
            "551946bfd2b165f419f297805d1e1256",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader_Oculus_Quest.png
            "d2244637721b4f3458280ffc1f9dd7cc",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkClDialogNewIcon.png
            "38956f4b67ba0984587b1a913d05beea",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeader.png
            "ff7f4f4963793a340bde459bc9975c07",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeaderWithCommunityLabs.png
            "1d151b29d1d1c704daa27e4921e39129",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon1.png
            "8458230047d35d4498b2de453f2cabda",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon2.png
            "fc887d4eeb5a941ed86bca0135b05e2b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKWorld.prefab
            "e8e780ff40c6a484294bfec8711ced23",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRC_PlayerVisualDamage.prefab
            "43066d8a73c579048891e3c123e252a0",  // Assets/VRCSDK/Dependencies/VRChat/Resources/2FAIcons/SDK_Warning_Triangle_icon.png
            "f310c3dbad3125d4e8fc2e00bdc2acb4",  // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/CL_Lab_Icon_256.png
            "36349feed06587e479724a1a09c0b267",  // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/Icon_New.png
            "4109d4977ddfb6548b458318e220ac70",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Good_32.png
            "644caf5607820c7418cf0d248b12f33b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Great_32.png
            "2886eb1248200a94d9eaec82336fbbad",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Horrible_32.png
            "9296abd40c7c1934cb668aae07b41c69",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Medium_32.png
            "e561d0406779ab948b7f155498d101ee",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Poor_32.png
            "8ae6e7ea5b8982143aa8c2c4e2fe81c6",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AnimatorPerformanceScanner.asset
            "c2ca835e9f95b464b8a2df5c181ba44e",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AudioPerformanceScanner.asset
            "d162a2d08d890e644b79b605f1d1120e",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ClothPerformanceScanner.asset
            "371dfb95b91b4684eb1ad68d37d81ac9",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/DynamicBonePerformanceScanner.asset
            "69c7115984bf82e46af96d6f144fe463",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LightPerformanceScanner.asset
            "07199be0cf1b2a34f8dff60d486129ea",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LineRendererPerformanceScanner.asset
            "e750aae2c41768e4485dfb9a6de00454",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/MeshPerformanceScanner.asset
            "f4004220746a95a4e84a3909a49d844b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ParticlePerformanceScanner.asset
            "18ec5f6f963b6774fa1b84c5bff0246f",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/PhysicsPerformanceScanner.asset
            "986c284df70b4c34dad7e5ef27a86156",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/TrailRendererPerformanceScanner.asset
            "bf50321b92d503d4a823939356ce856d",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Quest.asset
            "b0d7b483809dd6441bb36507c9f64040",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Windows.asset
            "f0f530dea3891c04e8ab37831627e702",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/AvatarPerformanceStatLevels_Quest.asset
            "e750436d0bab192489da0debe67ee879",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Excellent_Quest.asset
            "b25db21b17fba3d49a7248568fdb9870",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Good_Quest.asset
            "31feb7417182a80469408649071d10ac",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Medium_Quest.asset
            "171503e8193e15447967be1e3ca1e714",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Poor_Quest.asset
            "438f83f183e95f740877d4c22ed91af2",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/AvatarPerformanceStatLevels_Windows.asset
            "88c46902276e7624e8adda9020bef28b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Excellent_Windows.asset
            "38957d57ab5a7f145b954d20fc24b1d4",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Good_Windows.asset
            "65edaefdc2f87414594559cb89383b5b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Medium_Windows.asset
            "595049d4e162571489f2437524d98a31",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Poor_Windows.asset
            "36c0d886a26373c46be857f2fc441071",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/ApiFileHelper.cs
            "acadc6659c5ab3446ad0d5de2563f95f",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/AudioManagerSettings.cs
            "8d047eaa3325d654aa62ccad6f73eb93",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/CommunityLabsConstants.cs
            "e1c693656bf5d584b87df969efeb5536",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/ContentUploadedDialog.cs
            "a3132e0ab7e16494a9d492087a1ca447",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeAPICreation.cs
            "1e5ebf65c5dceeb4c909aa7812bd2999",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeBlueprintCreation.cs
            "2bd5ee5d69ee0f3449bf2f81fcb7f4e3",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeWorldCreation.cs
            "0d49300ad532d4ae6b569b28de5b7dac",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/SceneSaver.cs
            "10121679f780956408f9a434a526f553",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/MaterialFallback/FallbackMaterialCache.cs
            "bef0a8d1d2c547119a62b7d7a5c512ea",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ShaderValidation.cs
            "8a90ec11b51863c4cb2d8a8cee31c2fb",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ValidationUtils.cs
            "9b03724cd556cb047b2da80492ea28a5",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/WorldValidation.cs
            "15ecac6f7fdc1bc4fb723fee6f4635dd",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformance.cs
            "f1ce994297384ff1bc330196df61b7ca",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformanceCategory.cs
            "f28c978154794266b38d686139c6b872",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/MeshUtils.cs
            "8cdca9d06d1b4732b9ccb82a38bb8d9c",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceFilterSet.cs
            "a5ed7498cb1a46c78eab031f5f32448c",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceInfoDisplayLevel.cs
            "5019a55ee9e2404c81bc61a39a010d8d",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceRating.cs
            "4afb61f36d144fc381114cd7f78d13e7",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceScannerSet.cs
            "abda65e062e44213aa3e1f4c82b400a8",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Filters/AbstractPerformanceFilter.cs
            "0bd0691a021844f49444a04a959d6328",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AbstractPerformanceScanner.cs
            "08c8e931d0544866a0f626855d9c1841",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AnimatorPerformanceScanner.cs
            "b3a8bba736414d1aaa9e766da27b56b5",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AudioPerformanceScanner.cs
            "0cec88b5a46f459195f10a2f11fddb2f",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ClothPerformanceScanner.cs
            "a226df494ef04404a9a47c714822ab9f",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/DynamicBonePerformanceScanner.cs
            "405778fdc32c44c1bb9fdd0476fb0007",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LightPerformanceScanner.cs
            "ec87392b85844f7bb526a48ec866a8f0",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LineRendererPerformanceScanner.cs
            "38bca10261df4ddfa10cff3b3bbb9428",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/MeshPerformanceScanner.cs
            "10723e354ff14f98a49ab797b3f005e6",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ParticlePerformanceScanner.cs
            "6a94ecdeecd04f85824cc3244be5712a",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/PhysicsPerformanceScanner.cs
            "2efd714b564547b4be1ebd1f2700668b",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/TrailRendererPerformanceScanner.cs
            "1bf4fb79a49d4b109c4dce6b38e5548e",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStats.cs
            "f742c36dce5730f4d96e37d82c330584",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevel.cs
            "468554b1bfc447f41a20a2f5bae65d16",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevelSet.cs
            "9ae7399f0cf902a41a20f3487af8322a",  // Assets/VRCSDK/Dependencies/VRChat/SdkGraphics/SDK_Panel_Banner.png
            "13d3efffb839ced4c8426a88a0c3e98c",  // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGreyNoAlpha.png
            "8d95767408d35544c98f92ef7279b8db",  // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGRNoAlpha.png
            "861bc2dd35aa1534d89330ffa4434b61",  // Assets/VRCSDK/Dependencies/VRChat/Textures/VRChatBanner.png
            "3bb6d22e89000724b90fb830af69384b",  // Assets/VRCSDK/Plugins/sqlite3.dll
            "4ecd63eff847044b68db9453ce219299",  // Assets/VRCSDK/Plugins/VRCCore-Editor.dll
            "b0e1c0f72d838fe49bfe88b987a471bd",  // Assets/VRCSDK/Plugins/VRCCore-Standalone.dll
            "215be632cb025bd429dd50a3fa942168",  // Assets/VRCSDK/Plugins/VRCSDK3-Editor.dll
            "661092b4961be7145bfbe56e1e62337b",  // Assets/VRCSDK/Plugins/VRCSDK3.dll
            "d09383607271b19468447945fda29e86",  // Assets/VRCSDK/Plugins/VRCSDK3Base-Editor.dll
            "bdccfb093344e7545a49b72a64499682",  // Assets/VRCSDK/Plugins/VRCSDK3Base.dll
            "dc5cab6c932db3247aab9f50c5f3bd5f",  // Assets/VRCSDK/Plugins/VRCSDKBase-Editor.dll
            "db48663b319a020429e3b1265f97aff1",  // Assets/VRCSDK/Plugins/VRCSDKBase.dll

            #endregion

            #region Udon

            "45115577ef41a5b4ca741ed302693907",  // Assets/Udon/UdonBehaviour.cs
            "530bdb25a3862ff4c8be42f678c53527",  // Assets/Udon/UdonManager.cs
            "473737f63e15e204aa3a3df7a3a173e3",  // Assets/Udon/version.txt
            "3c1bc1267eab5884ebe7f232c09ee0d9",  // Assets/Udon/VRC.Udon.asmdef
            "84de2da7fe8ad8e439c084731189bc12",  // Assets/Udon/Editor/UdonBehaviourEditor.cs
            "66ebdaa27f6d2d54cbb62abddc493674",  // Assets/Udon/Editor/UdonEditorManager.cs
            "627c4d5cd580ddf41bd320e784fe8b9d",  // Assets/Udon/Editor/VRC.Udon.Editor.asmdef
            "8b6535096cfa29340897276abbdd015f",  // Assets/Udon/Editor/External/VRC.Udon.Compiler.dll
            "585dd63e377866248b16bdba915820ed",  // Assets/Udon/Editor/External/VRC.Udon.EditorBindings.dll
            "b335798a4f28bec40ba9b3d4a15acee7",  // Assets/Udon/Editor/External/VRC.Udon.Graph.dll
            "21dcba1a47cc8c84381629950b692129",  // Assets/Udon/Editor/External/VRC.Udon.UAssembly.dll
            "161140ecae894b84ba7bdd6e44ff4371",  // Assets/Udon/Editor/External/VRC.Udon.VRCGraphModules.dll
            "19cff77330d183441a69ff6c69e07629",  // Assets/Udon/Editor/External/VRC.Udon.VRCTypeResolverModules.dll
            "cac80b40f57c41d4b941dc5059271583",  // Assets/Udon/Editor/GraphModules/VRCInstantiateNodeRegistry.cs
            "e1b5b45f24b268b42826fc5c5497dc15",  // Assets/Udon/Editor/ProgramSources/SerializedUdonProgramAssetEditor.cs
            "0e5ced9511d591140b191bbd9e948e61",  // Assets/Udon/Editor/ProgramSources/Attributes/UdonProgramSourceNewMenuAttribute.cs
            "22203902d63dec94194fefc3e155c43b",  // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAsset.cs
            "3df823f3ab561fc43bcb81286e14b91d",  // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetEditor.cs
            "3c0638314c289c24193b47d1c53c9fca",  // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetImporter.cs
            "4f11136daadff0b44ac2278a314682ab",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAsset.cs
            "31d6811854f59254aa1a263a8d566eb2",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAssetEditor.cs
            "57422d3fdb0cc124189c68f87b7157cd",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/UdonGraphExtensions.cs
            "e2f2300f99ce0ea4a8d9a20b464384df",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/TypeExtension.cs
            "9214873dab0ea8a4b91861cd5a04dae3",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraph.cs
            "f166d8f1c152ef34899019ab9a4fd0f2",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphElementData.cs
            "54dd824c6c614b94183d92710efe4f5f",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphStatus.cs
            "87e2044d3bcb715499ac68cc7380a9ed",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphViewSettings.cs
            "c6f017dc2674fec4da54a57b2655a948",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphWindow.cs
            "5dcd92112af21784ba5bf6383abab768",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterField.cs
            "70616b8b964e3664780fc03f65f27f4f",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterProperty.cs
            "fddc146e8502d7b49a294b6264d66dfd",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonProgramSourceView.cs
            "e5786fc577943ae45953c6f54c97116b",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonWelcomeView.cs
            "aabdd863f82551d40bd3a1b0835d2fc3",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/VideoPlayerElement.cs
            "469db50616185d04e8a46dcd75db12d2",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/GraphElementExtension.cs
            "f4f0ade55ae13b6468a765826f1f2540",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonArrayInspector.cs
            "7e5916b8dd19e4445a9156a457b82ee4",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonComment.cs
            "ba3ecc4c46929404d8c2ec920743b823",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGraphElement.cs
            "1b8045222a10ce04b815642b9cd5ca17",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGroup.cs
            "b006d67642298f04e895b6709ef12429",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonMinimap.cs
            "dcd657bc1dcf357448d27bcfa8c5dc36",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonNode.cs
            "8f83d1d3578dd28498c71a980bca86dd",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonPort.cs
            "c5cfbbfcd7bb5ad4487f1f9388a3a168",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonStackNode.cs
            "2d0a4730c5f61b247b27b54f280300b5",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonVariablesBlackboard.cs
            "6581176c97993bb40976acff208bd0b1",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFocusedSearchWindow.cs
            "b721120e6c1d320448a55fe87a7de824",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFullSearchWindow.cs
            "e94c084f399869b42a21244fd07778c4",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonPortSearchWindow.cs
            "6a6c453fae11b5349a33399e258d1578",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonRegistrySearchWindow.cs
            "e5a10bb1987c27944bd08a88119b2844",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchManager.cs
            "d825ed3ba6aa7f14294e73efefc217d0",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchWindowBase.cs
            "16fc7a7a059deeb458fdcdf719b467a4",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonVariableTypeWindow.cs
            "264ec3c8a1d423f42a144da0df6c5ebe",  // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAsset.cs
            "41d70977fa7936441afe41442f1862b2",  // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAssetEditor.cs
            "9e84f8ee45862f04ca6b9f8d5c7f5897",  // Assets/Udon/Editor/Resources/CornerResize.png
            "632470b93f35ec64ab6e3efd639c986c",  // Assets/Udon/Editor/Resources/DarkButtonBG.png
            "d4ca7f47895ab36408e28f4f742fba99",  // Assets/Udon/Editor/Resources/DropdownBG.png
            "f43fd332539599c47b3bb05ea38d5d0d",  // Assets/Udon/Editor/Resources/ToolbarBG.png
            "5cbfe49b858635b44844a178cb934b68",  // Assets/Udon/Editor/Resources/ToolbarButtonBG.png
            "7dade49b2f58f734f8db0983d8e7fb60",  // Assets/Udon/Editor/Resources/UdonChangelog.uxml
            "927841c571a405846b3442bc0aa56220",  // Assets/Udon/Editor/Resources/UdonFlowSlot.png
            "3803fec4c7b065042891595e749524cc",  // Assets/Udon/Editor/Resources/UdonFlowSlotFilled.png
            "7c75c00422f12124faed19bfb8dd96df",  // Assets/Udon/Editor/Resources/UdonFlowSlotFilledLight.png
            "610088fc92e5fc64b8c7f9e9c51f2939",  // Assets/Udon/Editor/Resources/UdonFlowSlotLight.png
            "d47fd176596dfbe4e9e78964b40c93ee",  // Assets/Udon/Editor/Resources/UdonGraphNeonStyle.uss
            "815baa9989198624aa5fec5ecdb42bd0",  // Assets/Udon/Editor/Resources/UdonGraphStyle.uss
            "0e2cfcbd717e75441b108d3ad9de2d29",  // Assets/Udon/Editor/Resources/UdonLogo.png
            "8cf68553c5a4bb140a6341072891aa88",  // Assets/Udon/Editor/Resources/UdonLogoAlpha.png
            "d0608d33a4043b2499adb1fee18f2a64",  // Assets/Udon/Editor/Resources/UdonLogoAlphaWhite.png
            "17102758d03099542afc7a1808745eaf",  // Assets/Udon/Editor/Resources/UdonNodeAccent.png
            "c0230adfeb2abe242b8d64c7e3bd2adc",  // Assets/Udon/Editor/Resources/UdonNodeActiveBackground.png
            "8289cc16393cd3040a9920e71bfe10bc",  // Assets/Udon/Editor/Resources/UdonNodeActiveBackgroundLight.png
            "f47842ead2f80fa46ab6e5bbde409193",  // Assets/Udon/Editor/Resources/UdonNodeBackground.png
            "c9235631e37566447ae4567624755326",  // Assets/Udon/Editor/Resources/UdonNodeBackgroundLight.png
            "2d2675a75fea1d2438859bdb320d544d",  // Assets/Udon/Editor/Resources/UdonNodeInlay.png
            "12f29a8be9fc52640b40f6ffa59336c6",  // Assets/Udon/Editor/Resources/UdonNodeInlayLight.png
            "1ed47570201e1854d9e455e38eecbcf7",  // Assets/Udon/Editor/Resources/UdonSettings.uxml
            "91b7c8d7d899ec04e9568e9385aba34d",  // Assets/Udon/Editor/Resources/UdonSlot.png
            "3a1ab76e09365f14cab0665b40da8843",  // Assets/Udon/Editor/Resources/UdonSlotFilled.png
            "add07ab72e2fc3d4d81143ab77d121f5",  // Assets/Udon/Editor/Resources/UdonSlotFilledLight.png
            "1badb339ed4f23541b6db8a9420aeea9",  // Assets/Udon/Editor/Resources/UdonSlotLight.png
            "37bd184e5e9b13945840f70329f2e0f6",  // Assets/Udon/Editor/Resources/videoStill.png
            "c041fa712f66a5d4f8525cd447dc8b29",  // Assets/Udon/Editor/TypeResolvers/UdonBehaviourTypeResolver.cs
            "02e7e7f5f9fc2c24ab3af0b8780f3623",  // Assets/Udon/Editor/UnityEditorTests/UICompilerTests.cs
            "3c3c5a3876474c648a47177c1875f447",  // Assets/Udon/Editor/UnityEditorTests/UnityEditorTests.asmdef
            "80455fb15755bfd47b1803c8fe84e16e",  // Assets/Udon/External/VRC.Udon.ClientBindings.dll
            "a5e7b2f5005f10e44b082e7c18871cc6",  // Assets/Udon/External/VRC.Udon.Common.dll
            "9d86dc4a513809149af3856eab191a3d",  // Assets/Udon/External/VRC.Udon.Security.dll
            "ecb1eec40b5e47047891ee46e739186a",  // Assets/Udon/External/VRC.Udon.VM.dll
            "92886df353bf1f14489cf2c4578e58af",  // Assets/Udon/External/VRC.Udon.VRCWrapperModules.dll
            "a3a3dda899277cc4ea6aebe18c6b5736",  // Assets/Udon/External/VRC.Udon.Wrapper.dll
            "bf61d954ecb803046953c666facfb904",  // Assets/Udon/ProgramSources/SerializedUdonProgramAsset.cs
            "2fad63ba312d5f44a8ab215c3f5b18f1",  // Assets/Udon/ProgramSources/Abstract/AbstractSerializedUdonProgramAsset.cs
            "7fa64b2d7df72fb4cbf7898a400e86ef",  // Assets/Udon/ProgramSources/Abstract/AbstractUdonProgramSource.cs
            "b1d0b8aa8084bcd44a572d524d7a31bb",  // Assets/Udon/Serialization/Formatters/UdonGameObjectComponentReferenceFormatter.cs
            "f2626352b2a60eb41adc3580ae44c750",  // Assets/Udon/Serialization/Formatters/UdonProgramFormatter.cs
            "ec4e6da38017fe7df076afceb30fa17c",  // Assets/Udon/Serialization/OdinSerializer/LICENSE
            "2105a6c0e5c0955d2d4a704c5e9c9b8f",  // Assets/Udon/Serialization/OdinSerializer/Version.txt
            "f70a94b0bedfa8ec50ed757f72032810",  // Assets/Udon/Serialization/OdinSerializer/VRC.Udon.Serialization.OdinSerializer.asmdef
            "bfaf18dca1f68cc99ebeb0b862179265",  // Assets/Udon/Serialization/OdinSerializer/Config/GlobalSerializationConfig.cs
            "4ac1e1612275111bd50db8a3de8ba9c4",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReader.cs
            "501a7e1356f5fdc8e9bbefcd61a56490",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReaderWriter.cs
            "9638b18c6b6b6532b3b3cd3a73fefc2a",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataWriter.cs
            "dc1fe25e670cf981ed66b3e85c3e4249",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataReader.cs
            "af6696e41807b3c3f9a1d73667f76701",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataWriter.cs
            "ee0465a1838833eb878447b34339d4f4",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataReader.cs
            "1bc9e2503afdd0290574ebc14cf4a16d",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataWriter.cs
            "1361420bc2b384389a065fd2fe59fb22",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryEntryType.cs
            "7a3a6dce9e0b8317b3804b35f48f6a97",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonConfig.cs
            "2ecc39ef0dc55ec10f83bb7eefd4f1db",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataReader.cs
            "3e05b98a26be61fa9203d4a45bfc1e95",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataWriter.cs
            "aad0a34e801ae645b359e4800ef7f636",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonTextReader.cs
            "6a0f5e01b82ae0763f6f907157a2c9c8",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNode.cs
            "eab5938e837a8de93ce64c25399edde6",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReader.cs
            "9321fb650525f4bed18119d187111569",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReaderWriterConfig.cs
            "dd54f07c359d141095a031192c5ca084",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataWriter.cs
            "0bdecd79f568c8a3252bb5a9f3e2acdc",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ArrayFormatterLocator.cs
            "c4228cdbba89e2a5d52357b998c3387d",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/DelegateFormatterLocator.cs
            "cf715e98fa96d74c81b4d3f4491d2592",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/FormatterLocator.cs
            "d35d0d1eb290f5d00e273d65e5db09d7",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/GenericCollectionFormatterLocator.cs
            "f2a9beaeecdd6eb929ddb049d7846a14",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/IFormatterLocator.cs
            "cdd12b278851bfdc68ca0d9e1e4f2d28",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ISerializableFormatterLocator.cs
            "876ae9a404abe412e663fd9bc03d3525",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/SelfFormatterLocator.cs
            "00e10f526d476731ebc596ceb66271a6",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/TypeFormatterLocator.cs
            "9aaf14140a26e04b861b027d5ddb8fb6",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayFormatter.cs
            "3f5dc00eb17e568de42119a7f0f30ee8",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayListFormatter.cs
            "9598679c29f3e3696941746c26f1ccf8",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/BaseFormatter.cs
            "dff51bfb9b4d71aa78b3e5c8fec8c924",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeFormatter.cs
            "3480954e7eecdc9745c1d08721b2f8b3",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeOffsetFormatter.cs
            "4f17b17e986ae6f3be6a2ea1b716fcaf",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DelegateFormatter.cs
            "4402da708267c579874c808a813bfe62",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DerivedDictionaryFormatter.cs
            "b80567603fe814a8b4341584f8c3b4a6",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DictionaryFormatter.cs
            "5c21ee7e54dff531da57563e2f81fff5",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DoubleLookupDictionaryFormatter.cs
            "54578488936f8484c97ba7c52bfb0563",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EasyBaseFormatter.cs
            "e226537cbfa910681132da3718f41c34",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmittedFormatterAttribute.cs
            "149c482b2ab9c601b8bc2ecc20bbd8d9",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmptyTypeFormatter.cs
            "b7da6bf97199e0bb743f7639c17112ac",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/FormatterEmitter.cs
            "06ccb8250c692f2695d28bfd6bcd4273",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/GenericCollectionFormatter.cs
            "f1eaa1b43658215b6d81013928eac19e",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/HashSetFormatter.cs
            "0fcb040f1c493dc2a5224e446be8b3c9",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/IFormatter.cs
            "5cae1c5d1116a090d70b6d0289061d21",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/KeyValuePairFormatter.cs
            "ba4ee6777a44f6e9a8e2e0a222c0f7db",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ListFormatter.cs
            "21078ce134ce87231526dee77088e7ab",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MethodInfoFormatter.cs
            "ae604bc0ef4ef9938100804f05decb21",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MinimalBaseFormatter.cs
            "dc1b5b3148988d0d4fc2dab60a5c146c",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MultiDimensionalArrayFormatter.cs
            "f9ea00de8051ca957d994e11630671d9",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/NullableFormatter.cs
            "6b6a62ea2fe943a4b261f832e8a1f3dd",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/PrimitiveArrayFormatter.cs
            "8045e4edca7c27f5b16bd90d7101c935",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/QueueFormatter.cs
            "15fa864c9e3363220ceac4ec93c7f5b8",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionFormatter.cs
            "dde0095df6bea6624dfa72a31127bc48",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionOrEmittedBaseFormatter.cs
            "12a47dd574302b77ba3c5ac05cd04541",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SelfFormatterFormatter.cs
            "0f59404c810d015ed87c7e1557188435",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SerializableFormatter.cs
            "087303d0d43cf7ce5af060a0cc0b5d38",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/StackFormatter.cs
            "4b0676b49f03cc50a1e532cf23e3988e",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TimeSpanFormatter.cs
            "c6529471b992ba4080a123aa504ef9ea",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TypeFormatter.cs
            "4a7c8e71a3ef1124db10e72af34e1724",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/VersionFormatter.cs
            "23fa5d3fed3b4b9de502257a594b00de",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AllowDeserializeInvalidDataAttribute.cs
            "92726834b08002d525b86fbb012e184f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AlwaysFormatsSelfAttribute.cs
            "72783638708ea644ba5c3e1b91f827f6",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ArchitectureInfo.cs
            "ad4e17831e9503c1f11149997c609477",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/Buffer.cs
            "e7e73146f1e861c27c5608bff4142402",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CachedMemoryStream.cs
            "4fd6ff4077bbbef9b366d8ffd9236173",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomFormatterAttribute.cs
            "e02123fad495d06f2a89e5335f00126c",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomGenericFormatterAttribute.cs
            "97e9e01eb36fd43879b166b6b3c2469b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomLogger.cs
            "95bb5531b6c1d1a5eab8400ea1bd6167",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomSerializationPolicy.cs
            "c2a40a3e6a114e5a50c0af209b8ae35e",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DataFormat.cs
            "0bd9ab6cf3bd913588b6652279b7a6ba",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultLoggers.cs
            "996e793dcc0920d2590cb61f0761d498",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultSerializationBinder.cs
            "c79df97337d89089be40beb2e272df0b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DeserializationContext.cs
            "ae849a3e6d277006f3b4dd58a5765955",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EmittedAssemblyAttribute.cs
            "3b06b106636f38afbb25ddd11e0c597c",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EntryType.cs
            "c73435dff291e72c0d9ce55b59c39145",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ErrorHandlingPolicy.cs
            "df06475ac5299f402ca1bdee3cf7e702",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ExcludeDataFromInspectorAttribute.cs
            "08528593c8dd764b6d928dcee6daca9f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterLocationStep.cs
            "30194d27b77855bf09b9af809a761ca5",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterUtilities.cs
            "32f94aca65b8d09ddd7b3db72e08db3f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IAskIfCanFormatTypes.cs
            "7ef6b6dd5e3be66c3a66753cc7e799de",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalGuidReferenceResolver.cs
            "d1eaa1a505a876bebb9cad40d01989e9",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalIndexReferenceResolver.cs
            "9414cf6a3ea9a51afcf648fe9ea02bed",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalStringReferenceResolver.cs
            "8bab352682356b8a2b02842520a68a11",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ILogger.cs
            "106ca47adfa52732b129015337a1c8cd",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISelfFormatter.cs
            "90bcbfdc0286ca48d51fc578a1e15b8f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISerializationPolicy.cs
            "7de3f23805ad9d4b3d033eef45e3b59b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/LoggingPolicy.cs
            "10eb7be2b7c363367c46bc5699a361a8",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/NodeInfo.cs
            "766bbafe64ad16f63af4b81eb430e380",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/OdinSerializeAttribute.cs
            "3db8c00661ec222984427ab12295940f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModification.cs
            "23ceed712f987034deb8e92c561a1d3b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModificationType.cs
            "96fec6c04f13e378def42ea5ad5dc940",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PreviouslySerializedAsAttribute.cs
            "989e99cd5b8f922edc1b13bbc22f4289",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ProperBitConverter.cs
            "82702718797409c332f9174bdad57bbc",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterAttribute.cs
            "a000ffc63858a974eb63d9ef6f91adac",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterLocatorAttribute.cs
            "dca124a461001ad1494664ed95539612",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationAbortException.cs
            "eba33c8e77e2084c660af46be1b547dd",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationConfig.cs
            "1e93880e733f9a6a084cf4061634e7fb",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationContext.cs
            "67a19021ff9e6b27d8e9257ad075055a",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationPolicies.cs
            "08607b6e9c39ec19c1b61341583c2f3e",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationUtility.cs
            "bc69d8fd9d15913a491a45d1e040faf6",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/TwoWaySerializationBinder.cs
            "0e8d8c5a97fdc322a8b8471aaf02f469",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/BooleanSerializer.cs
            "8aa9f52771b0e4e6f8f0c438a4f0430b",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ByteSerializer.cs
            "d44d1ae83013328d7b855275fa1cfad7",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/CharSerializer.cs
            "5a2a43b51cef79fd0e85028650394b55",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ComplexTypeSerializer.cs
            "50c67937d611e4749188b838e4cff5dc",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DecimalSerializer.cs
            "9fc4716f683bc313c24bfa537cdd97f6",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DoubleSerializer.cs
            "7a5d23b139cd8e692702aa431b071d07",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/EnumSerializer.cs
            "19dcfa9f6a40979fc2b6c3ae0f24b67c",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/GuidSerializer.cs
            "d280b44f7c75a9a18484a84745998130",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int16Serializer.cs
            "eafebb70813195e03b1ba467931eb686",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int32Serializer.cs
            "afe45c48508431a62aba886d943d8501",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int64Serializer.cs
            "6ccaffe3090611c2ada67d49cf834771",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/IntPtrSerializer.cs
            "88f3ec418fdfdd7eabd6134f1de91991",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SByteSerializer.cs
            "29261eaea99f2d34c42cdc0b04f95daa",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Serializer.cs
            "7aa356971fd0b66eb59875b278fa7f03",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SingleSerializer.cs
            "85996580a8691185d06ec342c5c43747",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/StringSerializer.cs
            "3936194ea64890e11a7db8474eb0bbcf",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt16Serializer.cs
            "f30e426f88b471e498dd1853b7bbaee6",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt32Serializer.cs
            "f55c085325e12800428d01e3535cb297",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt64Serializer.cs
            "0ee9dd19c234e4b16c835b9188459e36",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UIntPtrSerializer.cs
            "94a6cc2044fcd2cb317b1cdb1e8fcdaf",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportScanner.cs
            "f5fe153775edbadfa2b659e0e35dc881",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportUtilities.cs
            "aaf2f90207414827b53b85dae0eae82e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/OdinPrefabSerializationEditorUtility.cs
            "de5584f66ccc5e072681a310c5987b8c",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnityReferenceResolver.cs
            "f670c1f9aa9ab0c5988e81802c005767",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationInitializer.cs
            "9eb15f2339819bb651c7872d73c89776",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationUtility.cs
            "864fb1c011715f9df2998d71ac8716f6",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/BaseDictionaryKeyPathProvider.cs
            "ef6f699f176c2dfdea788982526f989a",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/DictionaryKeyUtility.cs
            "b513c156933d8b833ccd40d717bf7e2b",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/IDictionaryKeyPathProvider.cs
            "54f653ed4a4e15c07057283c11dce4d9",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/RegisterDictionaryKeyPathProviderAttribute.cs
            "0405ef103432161dff609e75f71f3f55",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector2DictionaryKeyPathProvider.cs
            "1d61e235c606c1c9d7269f7e68471e38",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector3DictionaryKeyPathProvider.cs
            "51bb2cf369b5ea90948a20e4f2ebae48",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector4DictionaryKeyPathProvider.cs
            "3d2976bd61cccf62b11b4d3f02762465",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/AnimationCurveFormatter.cs
            "6ff1b29d64402a15d020739becd8661e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/BoundsFormatter.cs
            "0878ec68b6ab3c9ebc365b6d139e4840",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Color32Formatter.cs
            "25e35581ce6d1febd9ac41864a76ecdb",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorBlockFormatter.cs
            "484768ba343a6a05522c29d81a4ce61d",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorFormatter.cs
            "c3968bef792c5668478ac01be7645b30",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/CoroutineFormatter.cs
            "b5b415c00da8157ac50b8f5543f0b1d9",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientAlphaKeyFormatter.cs
            "8936a3e43078251682f18923139f7aee",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientColorKeyFormatter.cs
            "d5b54660d5342fd45e2e43775538879d",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientFormatter.cs
            "68ac0b27f571616d3ed26c23eef40c8c",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/KeyframeFormatter.cs
            "afc596cd95a1ac316024d16f6fec6536",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/LayerMaskFormatter.cs
            "558323987bf9b75943382a5faa093ee3",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/QuaternionFormatter.cs
            "196809b991e565a48e3d4ad08cb30b5e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/RectFormatter.cs
            "c934302874ac3315ed322feefefa1f9c",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/UnityEventFormatter.cs
            "70c675a7b4c71c685ee39d745ccb058b",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector2Formatter.cs
            "da2644647af1368176103aa87de1dbaf",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector3Formatter.cs
            "60afa8ede3981c383782a01ddc55e943",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector4Formatter.cs
            "ff1ca109149d83b03b39644f8045275e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationFormat.cs
            "8942002e9ac41c2bfd27c4fbedf93f09",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationPolicy.cs
            "7279ec8ad7837f13ec833193ab4282cc",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/ISupportsPrefabSerialization.cs
            "ea095023abd05a7af0da4166dcefdee8",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializationData.cs
            "c3cecb461cebbc940ede3b5ddb72382e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedBehaviour.cs
            "56b88cfe9935184fe250bda018144f26",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedComponent.cs
            "d1b9fa6342beb9fdfc2c4bc1d8e5e971",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedMonoBehaviour.cs
            "6cb9325ffffee5d6ed94d71590b4049a",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedScriptableObject.cs
            "eefcd68a84ee7903b08c6254c17fafe3",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedStateMachineBehaviour.cs
            "d62f7ab4e5aa075b819d6c71e929686b",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedUnityObject.cs
            "78ce67c0b3c1975c520a08d1ff9fd24e",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/FieldInfoExtensions.cs
            "068f5645a5c3f9ce36a580ec57e775d1",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/GarbageFreeIterators.cs
            "0f84614827ff91701149564447a3932b",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/LinqExtensions.cs
            "62088a9c188c943eb4035de16eb6ec32",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MemberInfoExtensions.cs
            "63a9a0384a6fe66fb04f82f325895b30",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MethodInfoExtensions.cs
            "1df9513f03131466eecad22d1b19c4d8",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/Operator.cs
            "da8aea12015a2df5402c9e2d4f1cec5c",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PathUtilities.cs
            "7f13450d6fd82372ffa7ee075a8eb4c9",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PropertyInfoExtensions.cs
            "b554cbd9469011b544a2d92ae85a3b60",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/StringExtensions.cs
            "a6a172cef14a88c7fb714df37bbecedb",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/TypeExtensions.cs
            "eb77f5278e425e91b71e186df29a5f16",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/UnityExtensions.cs
            "787c97af872124f748a4a9b366f325d3",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/AssemblyImportSettingsUtilities.cs
            "146b6bd1e3b0f0926205abf839ec9e6f",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Cache.cs
            "1bd625694c606aab0cb7895da4911c6a",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/DoubleLookupDictionary.cs
            "bda92ec6156282448e883bf8f6a781fd",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/EmitUtilities.cs
            "570028979953bd2c60b7e89ff7cef92e",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/FastTypeComparer.cs
            "42e5d977e21c7a6524213a8a7dbee24a",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Flags.cs
            "783316da32d87acfae14953e341732a3",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ICacheNotificationReceiver.cs
            "1bc635f3755c60fe69f1895dd53974e2",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ImmutableList.cs
            "000592e93b119574207ea3bf59f659e4",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasFieldInfo.cs
            "c1e85c1ef449ccb40e05f0afd3dd717f",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasMethodInfo.cs
            "00bf47593f2a330c1bb41552bdc1233f",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasPropertyInfo.cs
            "5ad884ed6013d621a310ceb4c954f62a",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ReferenceEqualityComparer.cs
            "0fe3820fb4651e200f17905245ec8be2",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnityVersion.cs
            "93b4d01199b118896c756b09a9206fc0",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnsafeUtilities.cs
            "f6cfa3d8ec4f885468d17f5b023d2529",  // Assets/Udon/WrapperModules/ExternVRCInstantiate.cs

            #endregion

            #region UdonSharp

            "c333ccfdd0cbdbc4ca30cef2dd6e6b9b",  // Assets/UdonSharp/Editor/UdonSharpProgramAsset.cs

            #endregion

            #region VitDeck

            "6ca6388f2eb7b124c9822f0ec18507ee",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/BoothRangeIndicator.cs
            "61a91fd6b14a4c74d8def021d6ac569b",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/BoundsRangeOutIndicator.cs
            "087a446a9975ddb46a8258b730da5b4a",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ColliderBoundsSource.cs
            "ff83b2b8a00549b44917c8d655d8d986",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/IBoothBoundsProvider.cs
            "fd2ce3eee33700a41882b61a9f0ab570",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/IBoundsSource.cs
            "d94df5fc33543984b847883374ecd8f6",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/LightProbeBoundsSource.cs
            "934a5f28e95c42347b819e98e4da1030",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/RectTransformRangeOutIndicator.cs
            "98a472ef355204d4bb8ea4843d56ca71",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/RendererBoundsSource.cs
            "ed421118c3b307d45a120e16c922b98a",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ResetToken.cs
            "1aa83c466a8ea1e4ba2e7f307c221a3f",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ResetTokenSource.cs
            "4919afe7ffcff8544bc0a71dc7451fc5",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/TransformMemory.cs
            "af1597e2617a95e4a9d30a3020a864ee",  // Assets/VitDeck/Validator/Runtime/BoundsIndicators/TransformRangeOutIndicator.cs

            #endregion

            #region VitDeck Templates
            "9cc74956ce0789345b947a4210714572", // Assets/VitDeck/Templates
            "b942f5c156abbd94b90136d8987565fc", // Assets/VitDeck/Templates/JQuesta_Avatar_template
            "b1d64992f791b2b4d8400949893a3ea2", // Assets/VitDeck/Templates/JQuesta_Avatar_template/LICENSE.txt
            "34361b8394c457b4eb5e3a710f37bdb1", // Assets/VitDeck/Templates/JQuesta_Avatar_template/Property.asset
            "39a8dae1ab7baf341b5bad06b705be1c", // Assets/VitDeck/Templates/JQuesta_Avatar_template/SharedAssets
            "9222f26c552ba5f4b94ccc5f0294dca2", // Assets/VitDeck/Templates/JQuesta_Avatar_template/TemplateAssets
            "400d799a0500d084c85626b107e4c217", // Assets/VitDeck/Templates/JQuesta_Avatar_template/TemplateAssets/{ID}
            "5902c622efd86b649b76ef2d6567c0ff", // Assets/VitDeck/Templates/JQuesta_Avatar_template/TemplateAssets/{ID}/{ID}.unity
            "789762393b3d40b2adb00b4bfe085168", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template
            "4cfb028c6a344c08b7b2c2b83d36d16d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/LICENSE.txt
            "b15f0f372d2e4e38a916243de740d266", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/Property.asset
            "0190b0d8472b4be7a9eba9a59fd0dff8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets
            "158c307bcbb547b0861e75f218fa9226", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}
            "956dc0a6f4cb4c1a86b1669ec45e61c8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "f03b7748b55b41e39820dae0fb1187f8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined
            "16ff37766fb640f2a21fc5d40a1a7894", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Interior_Japanese_1FOnly_Combined.prefab
            "ba4650262bbe4547bf8b470a6e964d62", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Materials
            "647e2f29bae045fbba7a996fec1f3599", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Materials/Kakejiku.mat
            "d7d0727be1754fe98228815273d2d16d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Models
            "d122efc015fc446bb993546c24669b5f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Models/Kakejiku.fbx
            "0a788e3f8a52441684d0da256556a455", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources
            "f649c7b246a14d99bf9ee350ad79e273", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly
            "64629c57c40f4e8787a99845ee547493", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "000cf0d2474841d1a34335893ebe197b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/BakedMaterial-mat-_MainTex-atlas-0.png
            "a9331dcea8a84dcca3b3c3ac87c309e9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/BakedMaterial-mat.mat
            "9d36f28a1c884f3a95fab33f633c8b93", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/Booth_Wafuu_Merged_Mesh0-mesh.asset
            "eebb0c6c7f5c48e7b37bc415cd65a571", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/Booth_Wafuu_Merged_Mesh0.prefab
            "673a37f24de44ebe9685188a28f63b8a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Textures
            "8ef54c89a0054e98b0d7c02550c62e36", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "ca662b3ad8104c559015b751eb86aa61", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Textures/dummyposter.png
            "b936d69b700b45afbd2ba34c72f90b03", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template
            "1a016d6db4d441ca955ec53194d1c9fe", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/LICENSE.txt
            "49546f84c593447687b006569c2514b4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/Property.asset
            "d969a11c3e8b4df386fbe19e541971a8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets
            "db08dadff06f405ba3a0bf598164932e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}
            "f34d84c7ef3144eeb15ddadb3fa4aa41", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/{ID}.unity
            "c3ee3d157b1f4cefb0b431547fa2c6fe", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly
            "09efc51c27b64f09b0d11184c79ba881", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Interior_Japanese_1FOnly.prefab
            "5294f23b74324ec4bfdfa51057fae4f1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials
            "ad0bdd8106d94d5bb0ac945c4a700a1c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Andon.mat
            "8033c8085326410e848d80ebb8d8280f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Booth.mat
            "85f565e51c6943cfbade4db63af8e2a6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Kakejiku.mat
            "9c196489c749450bbdee5965df240b61", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Koagari.mat
            "dbf1453a14b54c3a9c4192c626f6246b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Shoji.mat
            "e3fb08d009cd41fc9061928806204e7a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Zabuton.mat
            "e90c779a45814f9087ecb2d6642fe440", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Zataku.mat
            "a728e8a162874bc888311d7fca8d93bf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models
            "03ea9e8ed40946a3a81eddc8d9b53fcf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Andon.fbx
            "08581aa8524f43318c4746a2b8421491", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Booth.fbx
            "0c4ec6474eeb452f82e415934b8e839a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Kakejiku.fbx
            "17c6a9f23bd24eaa88122f1ec30bb21a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Koagari.fbx
            "3ef3a0cde94f43bfa004100c4ca0bad6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Shoji.fbx
            "4ab09a4ded8f4002ad275f3bd0689003", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Zabuton.fbx
            "64bbdbfa2059486391a6ef3688c1e6f1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Zataku.fbx
            "1d656eb982dd46d1ac71b445b7e5e467", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures
            "2cec6f7a1e7f4060afb914e64288b526", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Andon_BaseMap.png
            "1f585bf89b774dd28cc0eb4b4c25b95e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Andon_Emissive.png
            "c866a510005e4474a23a6148586ffac8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Booth_BaseMap.png
            "ad02a9671d07486a9bc2c70e94ac1dd4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "955a03b844e2450e9b036197f358aca8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Koagari_BaseMap.png
            "d507ff47836a4396a2da4b8c77fabde2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Shoji_BaseMap.png
            "052a3ef9dea04b2a82e5ae7f03f94069", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Zabuton_BaseMap.png
            "104c411d874f41a993c9d06a1adf2512", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Zataku_BaseMap.png
            "d79ed23d92364583bbae5a2e8c74d50f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/dummyposter.png
            "88163c60c7934e5cb70e0af3c6a29f58", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template
            "f4d9d2583a2a49d382d4f5305249bc6e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/LICENSE.txt
            "4038b1720e824d939d7eba10972dc067", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/Property.asset
            "e8fc23ef37334b7dbd82ed75fb491250", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets
            "b2cda6f2726a490da33a010035976554", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}
            "a4cd73834ab04f9fbd929303b243d42c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "4e87d6dab2a3482f849a50052793eb8b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined
            "2ab04a2068e74857826b008604e33312", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Interior_Japanese_2F_Combined.prefab
            "18b3064886dc49f1bcbe9116ec3c924a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Materials
            "a97b3cc37ca748c3af1d6c07e4f8c2b0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Materials/Kakejiku.mat
            "baa4ef4a1e694b3ebaa3895cdd5f7b80", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Models
            "f2af65189a7b4a2f8f5e078385b0d0e7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Models/Kakejiku.fbx
            "0f77f219eade4ed59a967700553d6bd2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources
            "f60721d47e1441d198a7951e26ab76ac", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors
            "e56d90948c7043f78aed2b5db1a78546", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "02db080f32bf42de80ed3d7c57a4f4da", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/BakedMaterial-mat-_MainTex-atlas-0.png
            "adf3c336b77c4ce796ebb77c82d319f6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/BakedMaterial-mat.mat
            "8abf426d4a324d8384f71c0986fd6359", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/Booth_Wafuu_Merged_Mesh-mesh.prefab
            "bfcac01acbeba284ba77c4151437a2c4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/Booth_Wafuu_Merged_Mesh.asset
            "9b576879a0ff46b3b75ae19c5144e78a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Textures
            "87ec413c036a44e19924fbb4891f7244", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "2f4c69766b774ef7b7d8ea7d4a9c5964", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Textures/dummyposter.png
            "fccfbf98a12e4a2a90222953fb841ce2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template
            "e698af42128248a8928f732f12668ba9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/LICENSE.txt
            "7f590a1a03a54b88b1a630028aa03f6a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/Property.asset
            "06d7c9917b74410aa23731fa584a8248", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets
            "453fcdbaf4e448a1a7c41342eebca37b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}
            "6c155dbcac014630960a732c3cfd2f47", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/{ID}.unity
            "d83fa5f3aea34615989e22cc9a396663", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F
            "764c6163dfca4f37ac7eeaf0a0477efd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Interior_Japanese_2F.prefab
            "b181c2f6940242eb9333ec148bd793ce", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials
            "90e35b91d73142f49469cca29e2f38f5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/2ndFloor.mat
            "5c845af09d8b49fda01d363905f1a388", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Andon.mat
            "f49eceefc9e94d06b7ac0b3737fa4aaf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Booth.mat
            "7c6aa668c3314271adc1dc90249a8cc8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Irori.mat
            "cec602661cfd4a3e81020af07818267b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Kaidan.mat
            "d430de5b671a4107a19da746ade00d85", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Kakejiku.mat
            "16331f96dabf413dadf70359313ec44c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Koagari.mat
            "88b464571bdb45bab01d91a2fdb9640e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Shoji.mat
            "9df8954a96fb4fa2aa384f351956dd63", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Zabuton.mat
            "73d7ae6fe45a43b2ad42a5f2e6e32ad6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Zataku.mat
            "86b56ea5fada443dbcb14c7f29ed27fc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models
            "afac067b167f441b830ae33b4261ba28", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/2ndFloor.fbx
            "8e52e08696bc415ca43504286419d0f4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Andon.fbx
            "28bc7e0a29e94f368eeb29f9ff45ce4b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Booth.fbx
            "ff3c7df5e1db498c9e8bb2a3971874e9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Irori.fbx
            "117a68aba3e148f48a73617a6a210e5c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Kaidan.fbx
            "8a8025e424db479d9ec5c0c34f75105d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Kakejiku.fbx
            "1cae40c9a2324d579d0d93bef0d42104", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Koagari.fbx
            "81ee31e61c4d4d628218c9276b9158f9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Shoji.fbx
            "50cdc70fdfcb48cda02452135cac9993", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Zabuton.fbx
            "0d17174c632e46c78f0f86fa7a84e5b1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Zataku.fbx
            "18401f2baf564809b50e34fad0b0ef02", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures
            "b628f69858ae4c92885de6753c23af00", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_2ndFloor_BaseMap.png
            "f03f3ee3800f4f3f87fced23e12980d9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Andon_BaseMap.png
            "42380e2eabaa4da0b3fd9fe3d5d0673b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Andon_Emissive.png
            "8e31fa4319fb4d79af0c75da86a65148", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Booth_BaseMap.png
            "fe21c6258d214d49ac61ca19b58591f5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Irori_BaseMap.png
            "6964ca6abdeb45daabe622f56a7ec324", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Kaidan_BaseMap.png
            "c85c2fd8b7924431a727ce48656643d5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "7d2104440020491badbb3137e5c880a3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Koagari_BaseMap.png
            "e5e7165f958a45908de8bddbfae4e8c4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Shoji_BaseMap.png
            "b6fae0181d384a23a16b7b90ae5e163c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Zabuton_BaseMap.png
            "cbc352e6d29c448180c5aadb31efd4eb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Zataku_BaseMap.png
            "498c4841f9a24ce3b00f36c480b004b4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/dummyposter.png
            "ce75efaa08e54c04a3b52acadaa54643", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template
            "3c9dc7edc3f646cebf282d56116646b4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/LICENSE.txt
            "0d275bc5dece4ebfa29db74dd5bc20b5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/Property.asset
            "1cb8746ab97a0284899af371948fbb14", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets
            "b5a05a8661426bf45994ba5873d87fc1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Mat_Floor.mat
            "c0ff2b5050b8e2f479b2e7974d22e5bd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior
            "26752797b165dfe42accd28ea499f6cb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/FBX
            "4dcc85979f301c24494d085e9242f424", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/FBX/Wafu_A.fbx
            "028b723399f2adb41bcb4d514962e10e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/FBX/Wafu_B.fbx
            "968895c7768ef134ea14ba7d09044c18", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/FBX/Youfu_A.fbx
            "ef65f0d52ed49b642b9aab1e6a5292ca", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/FBX/Youfu_B.fbx
            "876547d81580c894888e6ac5bc3f1fc0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Material
            "e905fe2cddcd6ab41b3fa396c89aef46", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Material/Mat_Wafu.mat
            "180bc6778ceeea5468fb33c32e2ff43d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Material/Mat_YoufuA.mat
            "17926b4ac3eb53147aa3997471a35c2f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Material/Mat_YoufuA_Emm.mat
            "7819223660d271042aa06450f47b47fd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Material/Mat_YoufuB.mat
            "dde4efd29ac856c4f9e11cd381329c70", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Material/Mat_YoufuB_Emm.mat
            "8430c67373fac6c48883be2de17755f9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Prefab
            "576963bf5e99dc844b9531eebc90b4ec", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Prefab/Wafu_A.prefab
            "1a03f7888a9c3ac45bad951e2e3170f3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Prefab/Wafu_B.prefab
            "ff5f9cbe7fdaf86468812e77c7f934b0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Prefab/Youfu_A.prefab
            "3fa51b028a8cb01489e0b0383d08e97f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Prefab/Youfu_A_Emm.prefab
            "14d4a4b2616b60c44b625a6ffa0df753", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Prefab/Youfu_B.prefab
            "6cea175d9156e6d4ba8e98c3b3a2b2e0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Prefab/Youfu_B_Emm.prefab
            "f870f247da39e61478408f3f9ca93b83", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Texture
            "7d88d628f0e78f645b7b78eb845d9432", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Texture/Tex_Wafu.png
            "63b514c81f63f23498413af2bde2aee0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Texture/Tex_YoufuA.png
            "577dc1710def0c7429af8ed51224b9d4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Texture/Tex_YoufuA_Emm.png
            "00665f7e2d1145749b7b0733308e9539", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Texture/Tex_YoufuB.png
            "6f32df9aa7f43fa49ae8c0b0537e42ad", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/SharedAssets/Exterior/Texture/Tex_YoufuB_Emm.png
            "54bf0119a1574bd5954529faed7a58d2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/TemplateAssets
            "2143897af50a4939b2ed62525436e18c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/TemplateAssets/{ID}
            "5c4af1daf46e4e5d9409a0c6f44179b8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_A_Empty_template/TemplateAssets/{ID}/{ID}.unity
            "8d0bbd2f734c94549aa1e68bbff7d40f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template
            "e0a0e1fece7c1904eaa19feaf1466e5e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/LICENSE.txt
            "81a590d2b74ac5841b3139f31fc47af9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/Property.asset
            "45878a73bcd5eea4294c901a74393039", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/SharedAssets
            "6880ad26dfa34034f948064bef3987cc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets
            "db2a824329212524583539ccdcd1ff67", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}
            "367464d90db249745959124b12d7d404", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "b365b43a98cc19e41b4ea4e17cc72b3d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined
            "50acd81316c344cfac99b3190d9a93e0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Interior_Japanese_1FOnly_Combined.prefab
            "66b8c36db93a77442808f13f37ecf26b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Materials
            "0c9f2d15b2a94a2ea07e602540e02ba8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Materials/Kakejiku.mat
            "8660c6d0cdc5b0b4084eb4502f3ae3f3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Models
            "bb2e9340f68e40d38d0b9feeb4ad51be", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Models/Kakejiku.fbx
            "df1d074950b36d34888d16656b2edc4c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources
            "e24e24771e236f448916d09d2692bf92", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly
            "49820f324a9d4d168f9b6eb59c88acfe", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "0a23fe95475a41fd85a8e4a9df4bd26b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/BakedMaterial-mat-_MainTex-atlas-0.png
            "35c4ee1b8d6840508b652e1b76d6c78f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/BakedMaterial-mat.mat
            "89fb03b6691e4b9f86e9e1b2d63ebd42", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/Booth_Wafuu_Merged_Mesh0-mesh.asset
            "187a382729a24562abdc72f8f50045c2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Resources/1stFloorsOnly/Booth_Wafuu_Merged_Mesh0.prefab
            "eee6f044a0c9f194ebdfa023704b4370", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Textures
            "6c58bf6f77ab47308f1ffc932773b832", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "e8e4c24ed5d546e09a160555048c05c3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_Combined_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly_Combined/Textures/dummyposter.png
            "f9853bf94e0941e4a9b6f849f79263cd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template
            "b285ebe2ae9171c408fc4c211b0799dc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/LICENSE.txt
            "7f64e40cb1e5f29439f33e4866fe1a93", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/Property.asset
            "9db69889be1f2414b8420fbc35c52b0d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/SharedAssets
            "12ca8da8ccf46644bb4df0853cdd1de1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets
            "ad1361b83a52f254fbcb343ea84b510f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}
            "c32d47f1b5fd47541b716bd5eabc2358", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/{ID}.unity
            "3ebdb72b773adb94da7562e87dafe2e6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly
            "b0bd72f5e7ca42f9bb07c3a882721419", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Interior_Japanese_1FOnly.prefab
            "47664934950afe841aa064c6e7f82592", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials
            "ce75d1bdac3047a79be8b27871e41534", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Andon.mat
            "cbf3458faa43406e9e36777472321c41", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Booth.mat
            "90440d05ceb54256adadc2d1e445a5eb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Kakejiku.mat
            "5bab45405879488d82af2597fe6c1977", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Koagari.mat
            "9318fee268014c99a3ec1972a9d00e40", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Shoji.mat
            "9c213dd2786f465681490a25e24d4a21", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Zabuton.mat
            "30d7a50ae157460fa30ca686a491a53f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Materials/Zataku.mat
            "1332b863a7724fc40b8ab93f7d00852a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models
            "fd136a03bd2a44b3950b08c5b5d6e4f1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Andon.fbx
            "6f32509485de417d81ec3ffe6371a4e7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Booth.fbx
            "ad72dad58fd44c2b81a3fb2711d242d2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Kakejiku.fbx
            "9051d25969b04e92b12c8b35ab8d7d99", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Koagari.fbx
            "35565bb0a3484bbe867ae124a36f6195", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Shoji.fbx
            "3d9bdc4cbfce464db978fd1da8b60da9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Zabuton.fbx
            "643db2b37ecc4920ae5451614b86015c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Models/Zataku.fbx
            "d55ee9a8d6e60ee459e8df3608edb009", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures
            "4938884592784c299bafe0c07ec1f1dd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Andon_BaseMap.png
            "df4fee0750a04801b0f23a4bd0b4c371", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Andon_Emissive.png
            "7715c9c961e14be3b93f78b8ca228107", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Booth_BaseMap.png
            "0ec40f7f4a07494db07fd1c8068231f7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "502d0690130a4cdeba7ca3ca5caaceba", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Koagari_BaseMap.png
            "690ec6842316433bb75cab5396e090d0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Shoji_BaseMap.png
            "75d4dc801441418c8a8c722ef377c9cb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Zabuton_BaseMap.png
            "cc82a7ba6fed4d779af0d0f91449ae4d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/Booth_Wafuu_Zataku_BaseMap.png
            "1479e3c8c7a944caa560157e5d897432", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_1FOnly_template/TemplateAssets/{ID}/Interior_Japanese_1FOnly/Textures/dummyposter.png
            "f3b11e2d5fdae714381bf258665e5641", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template
            "a7c3fbe2ddd0fda4b96e6a13545e1a5c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/LICENSE.txt
            "a6180cb8f7981db45951f91f3d02281b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/Property.asset
            "536d13772cc3de14e927cd906129fe69", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/SharedAssets
            "b96326fb1a683b342ac92be82db7bb27", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets
            "e35968fc71146ea41b639cc973d4c740", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}
            "9cb21509b246d8b428779614e203c0bb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "68de3e874b521994e8f3c412ffaa7dba", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined
            "8492b70f718342f580705a594083641d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Interior_Japanese_2F_Combined.prefab
            "956e4cfdffd3e28468c2191b0a98c109", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Materials
            "9b99e62eba9e4129be6dc350f49781aa", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Materials/Kakejiku.mat
            "7a8d85bee58c5424bb3191f9ef388730", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Models
            "687691e118c34706a89afc38ddf8f9bc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Models/Kakejiku.fbx
            "ddf0f41759319f349a1c6fd97dfc112e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources
            "2c808e67749c284429b5210b7aff24cb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors
            "d9c8bab88ef84c59b632f39023df8144", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "217b77c160ba45a6bbd59526633ef483", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/BakedMaterial-mat-_MainTex-atlas-0.png
            "bf25e8e7d97849739af7b75876eb0284", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/BakedMaterial-mat.mat
            "35fbc1580655440fa273b81c2eb92763", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/Booth_Wafuu_Merged_Mesh-mesh.asset
            "15c70a0b442043318e4cf1426ec8a0bc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Resources/2Floors/Booth_Wafuu_Merged_Mesh.prefab
            "0930fd4b0b8378242a233c0c32763b9f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Textures
            "4013d49dc0e84f15b4cf8de52456bd76", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "b26ba7af191d4a9fab631173c8fd5dfc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Japanese_2F_Combined/Textures/dummyposter.png
            "70e639853c7da6f45a1bbaf266cb7f2c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template
            "dbc6a9612d1610745b4f680b354595e1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/LICENSE.txt
            "8af248aae05320a4ca92ecfa66c215ab", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/Property.asset
            "437b2573da36a7e45a9422d9f51952f6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/SharedAssets
            "7f0adb31c18a0b447ba395bdeab718a4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets
            "f3e81a45d72defe40940d13c624a8d6e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}
            "76f02c36821a43d45b4eb34ea7ebdfd0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/{ID}.unity
            "50a442653e64474459065b87e69ced7c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F
            "710a717544fd4afa85065beee849b601", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Interior_Japanese_2F.prefab
            "59416884b4b889a498cbfa93c4443933", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials
            "d9dbee07a8944549a8103412a7bdaff2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/2ndFloor.mat
            "8062b2cc0c324f21966dd8bf6979ba6a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Andon.mat
            "763ca1ea4cc343d59e351c6c713505a9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Booth.mat
            "8214e339b49348e4936397e282bea4ee", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Irori.mat
            "9616e76b65104a6dab8053c13c36176c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Kaidan.mat
            "e0ebd2209f334e9ca27b4bd28cd325a7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Kakejiku.mat
            "9c86bfd4198b439dacd5e5d098a2d9ca", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Koagari.mat
            "470e2cf57d194b3f929d61bcd0edd48a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Shoji.mat
            "d3da6eb0605449108d604471467a205a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Zabuton.mat
            "095061eda29742c2aec50b092e962368", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Materials/Zataku.mat
            "c73f3149168647441a6cbf0817b1f017", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models
            "90674fa08e54422a9e6f492d244b9e68", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/2ndFloor.fbx
            "764a810940494e7f8995c4c92164d708", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Andon.fbx
            "1c1ad3673f204a83ad77d3c69b2e0608", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Booth.fbx
            "5e21d9a8bc144befa247e78708b184a4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Irori.fbx
            "ff623c19391e46f1a3854f57f9ea6890", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Kaidan.fbx
            "bb8f35259e5148d99af217063fe7bb6d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Kakejiku.fbx
            "6917a14db0d54aa0bd3bb21730b1c44e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Koagari.fbx
            "518a180e488642fbafa95c3ba064a9db", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Shoji.fbx
            "0d8d3109041b4129ba3b72a94b18ee19", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Zabuton.fbx
            "850213faa55547f0a4d389133d6a4d71", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Models/Zataku.fbx
            "436321f3cfb4fff4f904cbcc34fa4f5f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures
            "7c958755465743f0962593553b972c7d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_2ndFloor_BaseMap.png
            "f6465686057e46f2944cd2fe0efc4afc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Andon_BaseMap.png
            "361ed02061cc48f891d3d07ac6e1eb27", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Andon_Emissive.png
            "7fa51f237ff04afa877f0370dedcf237", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Booth_BaseMap.png
            "d0c8a722f69846f98c0b31ee5e8cef05", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Irori_BaseMap.png
            "5dc95fbf8879455e9bd9647ffa676929", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Kaidan_BaseMap.png
            "22949b2055b24e518a2f18f896326400", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Kakejiku_BaseMap.png
            "78bf4e9a426d49c69812d9646057eace", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Koagari_BaseMap.png
            "1a7100b9c72a471092a7551a69fe5408", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Shoji_BaseMap.png
            "37d8b52659f446ce916ffd33f59d6c45", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Zabuton_BaseMap.png
            "3c9b82b3ab284bf1af3ec96d6bc0273c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/Booth_Wafuu_Zataku_BaseMap.png
            "a8e084142a644dd8b1835ea1612a3075", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_2F_template/TemplateAssets/{ID}/Interior_Japanese_2F/Textures/dummyposter.png
            "f299422c8372ca642af728fdd40e7ab7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_Empty_template
            "e254a42dd1b983f4dbce77ffeddbfb50", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_Empty_template/LICENSE.txt
            "1333b62b60b009b48844e8e284ba73f6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_Empty_template/Property.asset
            "61530375c05e6ee479a48df8e29e3368", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_Empty_template/SharedAssets
            "060766554b7b5474eb2332b5c165bacb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_Empty_template/TemplateAssets
            "68c4ee4e27379f44598e6902b1bece12", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_Empty_template/TemplateAssets/{ID}
            "9270df63a4ccb3849ae2949db813d619", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Japanese_B_Empty_template/TemplateAssets/{ID}/{ID}.unity
            "fc0ceab4676941fbbed598307647765c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template
            "9efd998a97c3430db4b9d870efce4599", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/LICENSE.txt
            "cf3846b1fe1741cdb6cf0a8bf40d8d3c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/Property.asset
            "13794147d8884884b60fc640e669d818", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets
            "ae5d4ea48bd54d0f9108a76b7d3fbb5b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}
            "f5d73320bfc744b39df569f6cd75d1ec", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "4a546bc1a594405c8b42457dde36fe06", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined
            "fddfcc6cc0de40bea583c0a874b68b95", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Interior_Western_1FOnly_WithCounter_Combined.prefab
            "20be85ac9f6e482b80e09996a446431a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Materials
            "0af4e2c1c28f4a2eb01a1446682a4043", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Materials/PictureFrame.mat
            "4f5c84b7dd6f4408809c7a7dad67fcb3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Models
            "105cc1a9b5144dd9bda0d735a76861ab", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Models/PictureFrame.fbx
            "f229bce9bfa240158a2c91a588b965f9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources
            "a29764ba09664f7f8668a70d7ca3dc6d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly
            "c6d61a711dc244e293168f3a44f818c1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "61035d7174ee476d8c0190466db6d80b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/BakedMaterial-mat-_MainTex-atlas-0.png
            "f4dea430d01c4d8fa31a3f78844b46ca", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/BakedMaterial-mat.mat
            "bb639222159f4859b1a8cc811bb4ef15", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/Booth_Youfuu_Merged_Mesh0-mesh.asset
            "4fe7be00517047429db321fc781e2e64", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/Booth_Youfuu_Merged_Mesh0.prefab
            "c8cd5159a62a41f7a0a925a7ea7cfba6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Textures
            "7ce8907c849247a788acc31b175226c4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Textures/dummyposter.png
            "77648fe632c94299b2a97427dc0f0627", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Textures/PictureFrame_AlbedoTransparency.png
            "93f2668e90c94a6bb93974853edb87f1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template
            "d103b225c64e415b8378afc926b9f920", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/LICENSE.txt
            "dae8767f20924344b9a2690126af3339", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/Property.asset
            "546b4b3bd2ca4dbc96afc0382b5f9153", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets
            "f7a3b2ed767b47959a3bbf685984f895", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}
            "16c7d536e01145d09ab1a75b8f005f35", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/{ID}.unity
            "41ed4f95ba1b42b7bf090e556d2ff41b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter
            "71e464b922694098aeb5b9207f1fd3d8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Interior_Western_1FOnly_WithCounter.prefab
            "40a2f316655144bdbd04fbf6ba93d3e2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials
            "c7287ec28dad4bd1a09beee65c492568", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Booth.mat
            "ed22896a17fd4ee39878532c5011b085", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Chair.mat
            "e7059e7eb9d445fc8c89279132d6425b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Chandelier.mat
            "2f8c7f6af2fc44e0bcf6507bcf27a5ed", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Chest.mat
            "ae0c9cf3ccbb4c7197f908fb66f6431f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Lantern.mat
            "4d36aefc850e4493bed0414796502f15", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/MenuBook.mat
            "140954b695e74bb28d47d3fdae7d10ac", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/PictureFrame.mat
            "106f2a78ef4447479a48ec721381f53b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Sofa.mat
            "6fe0434b243f48c0aa9893edcabccd1d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Stool.mat
            "092e8b56630d401bb63e175e8a49b0db", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Table.mat
            "810e26ea45be453fb6f7470efdb7a7de", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models
            "09474e3e58cd489ba035227f8b7e580f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/1stFloor_Only(Counter_Roof).fbx
            "844dcc8c867b4d67a1b02afe07365b18", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/1stFloor_Only.fbx
            "66a4a0dfaf93434e9a8c9654a121b611", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Booth.fbx
            "ff9feb54d0f34615a0abbf0aaf204cbd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chair_A.fbx
            "5b8ac7ff28ed4f4a8b5801d7cd977965", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chair_B.fbx
            "2cb9ccd69bbe435dae69c08408dc6bbe", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chandelier.fbx
            "9115c30217a140de82192dfa506e81c9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chest.fbx
            "05f48c30762b4e00852ac6859b8384e8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Counter.fbx
            "064507d876044902816375bd954a2bf2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Lantern_A.fbx
            "c7ca3171fc8e4e68b419105fe5ba1044", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Lantern_B.fbx
            "0896e3eebed14aab95e1a87c3809943d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/MenuBook.fbx
            "d5a9591e829f412785030cfd4dc49fe7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/MenuStand.fbx
            "643fb0f9c8ec447ba4e6a9cd95f93fa3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/PictureFrame.fbx
            "db683c63db944bfb97613987ea849ee6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Sofa.fbx
            "f689a17589b64f0f84a5356971eaf864", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Stool.fbx
            "1faeb67686e24ad9b27794552dec0f86", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Table.fbx
            "e447d652b0264feead789cec64d9f966", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures
            "0a706b400a9244639717d62178ff458f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Booth_AlbedoTransparency.png
            "f3df2f80b26a4ea5891baec4eb487f2a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chair_AlbedoTransparency.png
            "27c2af7d76c14ed095f684a3561b5244", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chandelier_AlbedoTransparency.png
            "7b5fd4efff4f476c93647ac0d0db2426", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chandelier_Mask.png
            "7039f31d1e264a73accd5fa8b7ab3343", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chest_AlbedoTransparency.png
            "a8f402d3cc3b4c889d61bc6e6a2c8a31", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/dummyposter.png
            "c9a9e200c89f45fe8a84b799ccb304a3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Lantern_AlbedoTransparency.png
            "0c1ca415b34b4a0b898b319014b0df25", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Lantern_Mask.png
            "fc0083afb1784fccac6785124421e24c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/MenuBook_AlbedoTransparency.png
            "0ee4f07b327d4f63b2221bda15e8ce05", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/PictureFrame_AlbedoTransparency.png
            "2f492fde554b47b192a85a48a6fb324d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Sofa_AlbedoTransparency.png
            "5346761fb5cf47c18e8060a8a2b6190f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Stool_AlbedoTransparency.png
            "cb29ad10923b4b579b153237e6d16396", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Table_AlbedoTransparency.png
            "4c11e3fb96fd4a40bf6781d4ec44bbb7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template
            "56009324b876411eb84558a87ab90dce", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/LICENSE.txt
            "d6d98a5e966442f4942eda4830f2d020", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/Property.asset
            "cd76c4376b574e798c18799ec0821050", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets
            "aba64a01b49a49dbb40ab7e2de3cbfb6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}
            "7a14daf6884f499783cf1ada9b3434fa", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "c5fbabacf8244a62bacbc831a260ee1d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined
            "c4a04848430a4953897904eba45ed441", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Interior_Western_1FOnly_WithoutCounter_Combined.prefab
            "c7871aa745a24edbb47a2a84b7165264", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Materials
            "90a9627abb714aae8758b7f21833ecbb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Materials/PictureFrame.mat
            "56048b86816549a2bf2010c10b899107", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Models
            "56634683ec044f1d985f012be6eba6ed", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Models/PictureFrame.fbx
            "4a402d82473644b4b5401c728f7c485e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources
            "713e8a21ff2e47828f642e2e9e666a23", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2
            "adf300703cef43a286ea3953f066c9c8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "8d1a2d35bc6e4c2dba59cb31e9fdc620", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/BakedMaterial-mat-_MainTex-atlas-0.png
            "11e20f95844d42ea89400152aef16f0a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/BakedMaterial-mat.mat
            "d0983a8db7b848e7b71555beeaf7254a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/Booth_Youfuu_Merged_Mesh0-mesh.asset
            "17685cfde99a4dedaefed24f718c862c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/Booth_Youfuu_Merged_Mesh0.prefab
            "28dfc153ff5f471291db732703c725ea", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Textures
            "19afb6a908a74d05b6a1398a3cf58953", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Textures/dummyposter.png
            "92c3b4d83001434e8b552024a2e03656", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Textures/PictureFrame_AlbedoTransparency.png
            "b98996c2731d4a00af0c08666b66b037", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template
            "341c199193054af1aa7125aedc4de7c4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/LICENSE.txt
            "255efb355c3348579e7a41c280997ae7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/Property.asset
            "6a88f88bc2a44bafb271786b7439fd78", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets
            "648ec2dadfb24e76b7bfb1bb95bd0c1c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}
            "d9486b93f61b4a049911998fc0ef96cf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/{ID}.unity
            "534921ed5731457fb2582ed270917691", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter
            "856da720d4a84185889386065b8b3f2e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Interior_Western_1FOnly_WithoutCounter.prefab
            "608b768905934606ba7c38e84d93af9a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials
            "d4f27b0839a64ab78af92975ec755f47", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Booth.mat
            "609e36526cc34bf4a3521fa0ee1cf89f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Chair.mat
            "ac086d3ee3d94aada22a1f434c1eea14", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Chandelier.mat
            "6d6c630e69974afea8299475d6d9d4b4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Chest.mat
            "46c1885f3aee4046af54f76756d9a0b7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Lantern.mat
            "d8607c6fc23b430ea98d4aac1a437ec5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/MenuBook.mat
            "e9ec0f6793d942de92cf6b4d4beecf61", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/PictureFrame.mat
            "be89eb6dd322478693316cd3e3c2a900", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Sofa.mat
            "b4abc1b056db46ed9fb0a28be27d7b33", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Table.mat
            "860dbcb693744f4c8c883ddcc1138571", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models
            "e660a9cd58524985925b98f7ad961304", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/1stFloor_Only.fbx
            "cc995458d4c647848477181a28a62198", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Booth.fbx
            "aff5733b700543b4b07842075a156f0a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chair_A.fbx
            "60f5a96d60ef44f2bbfa0e6eb2588b6c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chair_B.fbx
            "ce9ce4a82aca47de8c69a6bc17b286b0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chandelier.fbx
            "038695b42cff441987a4e0d52c19296f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chest.fbx
            "7048b8a2a05b4a129c0d2ba0d16eca79", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Lantern_B.fbx
            "a7700728604547c68f028ce08c104c46", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/MenuBook.fbx
            "233dc961b1ea4830834b1acadcece2c0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/MenuStand.fbx
            "e9da5de8b1cc46fb837d48a125f64eab", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/PictureFrame.fbx
            "6b2d0b2b67f04611ab617975d3a3087e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Sofa.fbx
            "d2eb4974967d452b9232347f3e924d7c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Table.fbx
            "2ed7997a40f24951be8b4db7a930026f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures
            "bd76066ceb0d4693a7c3452ee12d7d17", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Booth_AlbedoTransparency.png
            "704bcbb90cd347edaf73ca1658c3321c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chair_AlbedoTransparency.png
            "b076cfe94e72406c804ce6bd54aca148", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chandelier_AlbedoTransparency.png
            "83f60778e11f4ea790d6c1c4ae23fae6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chandelier_Mask.png
            "05146a4e1dd34691939dc1ba751e9961", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chest_AlbedoTransparency.png
            "70613ddec8ca496d8d3361a4d4e3fd41", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/dummyposter.png
            "e52866bee98f417da4ef0a59e982f0d2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Lantern_AlbedoTransparency.png
            "2eb545df3c8c4664ba205009e8a262e1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Lantern_Mask.png
            "62ca77b705a344058a38e9f4efb798a4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/MenuBook_AlbedoTransparency.png
            "f9a79148712e41cda9a29e7314d51100", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/PictureFrame_AlbedoTransparency.png
            "8a68ebf23d6549049dc8a4de786b131f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Sofa_AlbedoTransparency.png
            "986c1af30e0546a395f589ac7667aaa1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Table_AlbedoTransparency.png
            "8655f58dcbe54f298a42b7a2e1c97757", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template
            "ec321d610a884b15a30bd61e5450f744", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/LICENSE.txt
            "67f8ca4581ac4e09a5980c2f4672dc17", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/Property.asset
            "b536e2c317284f4c88cf2940e952c12b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets
            "c02cb07ec205408699c0637967810711", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}
            "7cf23fc66ae74e36b15dfae3cabc7d51", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "cbdd51add307469ea202bd4cbc8fd193", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined
            "d0bb3e522631493eb5d98cb126c288b6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Interior_Western_2F_Combined.prefab
            "081261f49676443b85d1a491b9298fab", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Materials
            "f9f1d8b39b1144d99f69c26be305dfed", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Materials/PictureFrame.mat
            "1158461e119c48c0804ff30e7660663f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Models
            "f43d8f5157484d868b96e4ea2d92e025", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Models/PictureFrame.fbx
            "f7c722315df04255ab898f07ee7fa894", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources
            "316c55df58be4ce482b894effe6e9cce", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors
            "26584ff616aa12144a3f69190b891973", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "e65a35cc51b28b8468e56bcc2b23c915", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/BakedMaterial-mat-_MainTex-atlas-0.png
            "3d2a5476c56ca134887b5a7e45b9d0fc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/BakedMaterial-mat.mat
            "c0187e75e6ec6e942ad7009361bd821b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/Booth_Youfuu_Merged_Mesh0-mesh.asset
            "d2424e0b13d881049b6cda9e0c85f1f1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/Booth_Youfuu_Merged_Mesh0.prefab
            "50c13c9044e145d780c1c4d53cef00d7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Textures
            "0385b945d32249c0b7873b8d8c470d20", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Textures/dummyposter.png
            "09b15a3a887f4d709f6adbc012c048ad", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Textures/PictureFrame_AlbedoTransparency.png
            "9276b03986134d858b350c5c5071016e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template
            "329215fcb05d438cb227bba7164570b2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/LICENSE.txt
            "640d4cb6b9674655ab4d0f3a1d810cb5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/Property.asset
            "d6ea96d629ac4a4b957d3af3d9aabbea", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets
            "26a32702dd9f47e1b01ddd1f8af4de8a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}
            "9cca4096b70442798eaf6bb8db21ad69", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/{ID}.unity
            "9da2639d5af84602add1f504b47e40f2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F
            "d31709f2c4b6491fb5d3978e2384d1b7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Interior_Western_2F.prefab
            "e37678a6e9784a03826c51a502533e4d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials
            "f556e0ae66ca45328fab417ce90b079c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Booth.mat
            "84d9bf62ef0440a8a8f88799364f0a80", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Chair.mat
            "cd323f932dd04d0d87817f9a02758b21", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Chandelier.mat
            "983e313f8cde4ecea1fe9e64abb197ec", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Chest.mat
            "07e5579170f94aa799da14d81655ba14", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Lantern.mat
            "89758528790d41d9b6feb482a23ae6e8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/MenuBook.mat
            "1f03ce3dde964240b229cbf6d4abaf7e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/PictureFrame.mat
            "70b6ae028ea3438aaeaa66da250eb604", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Sofa.mat
            "d5a8a12a3df6454cb4012739395d530c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Stool.mat
            "234e0023932e4cc08e3767f11e108ef7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Table.mat
            "2d484aed33694c508cc73acc060fadee", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models
            "4f221b9aa295429e95d7f52b0be789c9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/2ndFloor.fbx
            "a3be09b58cbf4778a81cedc6a76b2da5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Booth.fbx
            "f33f46d0edf542f085c3b357faa13124", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chair_A.fbx
            "92579e5194744a7e9370149c209dcf6e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chair_B.fbx
            "a97fb5295aff432a92f7702fecd06430", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chandelier.fbx
            "df7d41f93c4c41e8be3d26274619e0d7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chest.fbx
            "55f6a283b4de43029442129001cebc4b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Counter.fbx
            "aee9d7ac70fe4b75a3aaef90e78cefb2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Lantern_A.fbx
            "6f55a2fc1c8244e894851269484a53cf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Lantern_B.fbx
            "fcce9baeb0954f4eb8f414e4c58cf2d3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/MenuBook.fbx
            "580c487803ba449fa9b767eb9dcfe432", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/MenuStand.fbx
            "941982396810454bbe7b90876a8a8120", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/PictureFrame.fbx
            "9d895bd74d3a4050bfd87060bedad617", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Sofa.fbx
            "f84cb37c7f9c4dd0942299bbceaf0f05", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Stool.fbx
            "f01c0831f5734156ba34e1f074784fdc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Table.fbx
            "2871569a72834cff926d31458f7a2c27", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures
            "e5ee55958b0442448697469ddbe414d5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Booth_AlbedoTransparency.png
            "608b30e5c3cf468dae187b2d582b3208", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chair_AlbedoTransparency.png
            "98a52af919e84f358f740de2ca19c709", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chandelier_AlbedoTransparency.png
            "def89cfda1a14310b5b883cb70a4ca78", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chandelier_Mask.png
            "114ffca1dfd64fcbb1e62db0a2583dab", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chest_AlbedoTransparency.png
            "bfa6a23cc13540e2b5e81d2101e3f1ca", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/dummyposter.png
            "1f4759fbc1464ee0a02b6f19e9926699", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Lantern_AlbedoTransparency.png
            "f5f2d79713024fa5a0a8101804989530", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Lantern_Mask.png
            "5fd2f6bfd7b44a91ba99d68b9444d9df", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/MenuBook_AlbedoTransparency.png
            "d09cc6be6c2a461cb9f35bc2278197a3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/PictureFrame_AlbedoTransparency.png
            "bcc1d9b48afd4d5689e0504996b9aa99", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Sofa_AlbedoTransparency.png
            "a5950e8a13bb4e639f8a5feaa7cf7493", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Stool_AlbedoTransparency.png
            "aea10789d07148dfb0bb66732462c519", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Table_AlbedoTransparency.png
            "823b48edd5c347009b01a97f7d80b3ab", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Empty_template
            "3775776ebbb445c6aa3b812f4df251f2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Empty_template/LICENSE.txt
            "de31bbac0328474eab4daf891316ca54", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Empty_template/Property.asset
            "36e17084237747b1a0dcde9d30b14470", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Empty_template/TemplateAssets
            "7750797a7f764794bec37fe99550423d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Empty_template/TemplateAssets/{ID}
            "6ac6545977d54df1ad47a76718df0b83", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Empty_template/TemplateAssets/{ID}/{ID}.unity
            "9897df57952e40368459f56e88fcea32", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template
            "fdc23e55bb7345b185892a99d62f2c6a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/LICENSE.txt
            "9e27008e8f1b4a7ca072bb74835dd820", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/Property.asset
            "60e953703f874a459558c99b3fdb5264", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets
            "6344e156839d4e6d970f7186b7b4386a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}
            "5e79bb13a69f47b3af9e824863d8b505", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/{ID}.unity
            "ba38db74506a4276b0edc5a6b8b814ab", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset
            "2c15239acd2a4200b66f0ccb671249b3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Interior_Western_Fullset.prefab
            "5ef3567fd9ce40db8ae5267699280f63", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials
            "1cbc02056d3e4df7aef224c76744892f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Booth.mat
            "0210e749f0b44be5bd0573809710776d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Chair.mat
            "f0915d34c0f3478d99689ecbb36e572e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Chandelier.mat
            "f9cee3d0ce85402bb10f91d34457fac2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Chest.mat
            "e3569eb4b5bc4d74a29b816ade5f7b5c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Lantern.mat
            "b72823fd25224daa9b39884a815df3da", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/MenuBook.mat
            "795f562c5f904e89ac9cd5d860d02e05", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/PictureFrame.mat
            "ae0b637d9cb94ea494da05862ad39412", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Sofa.mat
            "061aa9f781d74600b69eff7f56e07ec8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Stool.mat
            "e481824ebb19429bae41995d288f55fc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Table.mat
            "be8ad1db67c646b49e86a4631e648911", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models
            "4acb4d2e1d194437925b519c6202ef87", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/1stFloor_Only(Counter_Roof).fbx
            "47f960b1a5784e5d8ff3f85ca9cbae6d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/1stFloor_Only.fbx
            "51c52d4de1aa4ce0835dc70f629db5d3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/2ndFloor.fbx
            "895a6d7816eb4cf58f960cf55f823289", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Booth.fbx
            "ac56901ed2b341deab70dce8c347020a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chair_A.fbx
            "76422b5d8fcf43999ec61c9361a5ae9d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chair_B.fbx
            "0f8381be74af4d4692527f5c22addeef", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chandelier.fbx
            "4ef527e733c74135b9bf2e2d25d4483a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chest.fbx
            "238568a7336f4cc0a9ae920a9986206a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Counter.fbx
            "fcd3e693fdbd495b9da4b60848946846", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Lantern_A.fbx
            "99b202b7580b47a8b38601d784563827", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Lantern_B.fbx
            "d6eaa682ca24432f907e8f3efb55757c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/MenuBook.fbx
            "d595b69f82ff4cdd95a517d8cfb7ba10", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/MenuStand.fbx
            "6760c0d2e84b44209e550d0a7ccb54dd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/PictureFrame.fbx
            "0a2b1332b1284a8e9ec5f2735a7ca91a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Sofa.fbx
            "fd7715afff174c8ab5fcdefdc119e736", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Stool.fbx
            "23fed564a90c4d7bb6697497097f2400", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Table.fbx
            "61a01ff4682d4382aca763421463af96", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures
            "7d6b057f85c34210a37ab103ffad0f54", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Booth_AlbedoTransparency.png
            "1b0dee9b5d034f288d8bf1ab3afb0604", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chair_AlbedoTransparency.png
            "b25ace9064a1420fb0a7a5c4782e2496", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chandelier_AlbedoTransparency.png
            "0d7a281deef148f0ad1d7ace57f1e836", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chandelier_Mask.png
            "3f366747e93649d19b7cc4efacca2e72", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chest_AlbedoTransparency.png
            "8cfdb09044ac487d9d6b67f829e844f3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/dummyposter.png
            "777ba15854fc43509eecc5ea28207b37", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Lantern_AlbedoTransparency.png
            "a946e0fe91204d7faa0fe56659cd0df0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Lantern_Mask.png
            "1e7dee371f6d4fa7b11231086ff12375", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/MenuBook_AlbedoTransparency.png
            "8a841fb4455d4d91af8f60c7442871c9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/PictureFrame_AlbedoTransparency.png
            "06708726d0594fac95974bfa6509a452", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Sofa_AlbedoTransparency.png
            "b19da014a4f24eb2aee0aa11cdb25bf2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Stool_AlbedoTransparency.png
            "f30cc00fe47d46d3b01c5e61f45d5bfb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_A_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Table_AlbedoTransparency.png
            "a44ad0dfa4bc43a46b92458e5513d273", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template
            "5eac464e863bb214fb79f7a948e9da5f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/LICENSE.txt
            "6ed7cded8d128a342bb13f6c2fd4da8b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/Property.asset
            "d4ebe73de1f202744854e4841e885255", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/SharedAssets
            "33c4622636b7e1d4b8fdc94db2553b74", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets
            "c984421dbb302344698a9ec388beb336", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}
            "6738383d479776d409f6144bc527d1cc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "50582cdd3af76cc48af88a2cd20c4ca8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined
            "1ef76dde627445e9a9b556bb3615e678", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Interior_Western_1FOnly_WithCounter_Combined.prefab
            "6067c1f0f634bc04891812f20a763681", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Materials
            "d1054d7e44d644c0849fa72a0c6e35b1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Materials/PictureFrame.mat
            "8cd7bc0e81db6a24e840c5ee92d226d0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Models
            "28822b340e3a4b0bbf495bb420fabdd3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Models/PictureFrame.fbx
            "f26184559b4a6e34293f046cacf0c524", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources
            "a5fe213df7350334da286dec8cc7607f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly
            "aba18e1d1b86427b896baa3c2bc18d02", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "09cb953f852a4b81b1183000d8963fbd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/BakedMaterial-mat-_MainTex-atlas-0.png
            "1e7cf7db24fd442c97ac91bb7c793064", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/BakedMaterial-mat.mat
            "e5e8d1c990e240e38261fd3dbc78fdf4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/Booth_Youfuu_Merged_Mesh0-mesh.asset
            "1f7be84b28ea472bb36e362556bf780f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Resources/1stFloorOnly/Booth_Youfuu_Merged_Mesh0.prefab
            "c4616085447aaf145b9f97f70f4cd5cc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Textures
            "ccf12e672fdf46369bb2fb3d89b78d42", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Textures/dummyposter.png
            "67b711f52a7f4405876e09772620694b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter_Combined/Textures/PictureFrame_AlbedoTransparency.png
            "fbf0ad34f3a75364393950fa1a64d81b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template
            "74de8a972bc227a448a56a6010494385", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/LICENSE.txt
            "5df07937d44c7e8468e788dcb19c5be9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/Property.asset
            "c639bb1efd5531042807e39957414698", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/SharedAssets
            "26b55dfeb33826448a0aefebe556a374", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets
            "dec982955578fa4489db1c70128b8a3b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}
            "3fe7681ba8d4ec4499dcd949db087b3e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/{ID}.unity
            "c48542d875371d646ae2650c365f7efe", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter
            "24bd72a02b3b431fad1e9f322f2b61cf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Interior_Western_1FOnly_WithCounter.prefab
            "5c8374da2217493469545fc50b17be81", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials
            "700a64bd21574389b8e26058e83b46be", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Booth.mat
            "ea59710beac540edbfb95e9ddeb53385", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Chair.mat
            "d1c6e11001f246eeac8314010bc91809", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Chandelier.mat
            "e8cfcd9276a94de791c67873b7f5de78", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Chest.mat
            "0c294ba3996f4228a3a00c5f3f3b327f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Lantern.mat
            "618fd1e4d3554dbf8e3cbbaa4a64ef2a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/MenuBook.mat
            "b59d2b5bc8024579ae97b18ac792956d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/PictureFrame.mat
            "5c34bd02b9cd4ab98329e9ec4893ee9e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Sofa.mat
            "9dd31a1333ad43ddb800ae10937c3f9b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Stool.mat
            "1af2b9ec45d4407b86224a3ddf5fb2f2", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Materials/Table.mat
            "af0b92c77dd7f2d4d883d1fbda7c38df", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models
            "0369f3048773438db6bb3de5c30ece6e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/1stFloor_Only(Counter_Roof).fbx
            "15ebcf0f2d9342bc877766f964558ed5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/1stFloor_Only.fbx
            "ad56ebb5c31044369951feb3a0674273", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Booth.fbx
            "becffde2a76247a9bc5524cc671b79d6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chair_A.fbx
            "90644cf9a7934d059a7902f4833b2f50", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chair_B.fbx
            "095ed998175345b19f5601c2196e1a7e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chandelier.fbx
            "2f83a64c79b043b0b031b71531f545c3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Chest.fbx
            "1204e32f70594855a5add75a8a73701f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Counter.fbx
            "774fa015b227461ab8f62ab2417f3f36", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Lantern_A.fbx
            "49f2bc19034f4b8dac9369aefcb7c841", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Lantern_B.fbx
            "596f32d2c25e43b9b84ec0256ffe677c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/MenuBook.fbx
            "11f48a1a5e6449c497404b3f1a9732e7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/MenuStand.fbx
            "a3bbfa55a27c462e992ad2780ac14884", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/PictureFrame.fbx
            "ed990673c1aa4b6582e04ad0e9b2ba51", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Sofa.fbx
            "8afda42a559d4c22b433449c66972972", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Stool.fbx
            "faabd3aef0f443cfb0b0cf3a98a087aa", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Models/Table.fbx
            "1adb175adf9db824686d440495ef52ca", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures
            "15a7f41ca0d54090a38bc905a533a33e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Booth_AlbedoTransparency.png
            "a514dc3edffb4d088686e71ed89af953", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chair_AlbedoTransparency.png
            "fb8fb0c7507f4c2595a5c477f978505d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chandelier_AlbedoTransparency.png
            "2432a65399844dc4887572aa6b6fff40", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chandelier_Mask.png
            "81de4cb2c22f4a9ba5f3758f102f013c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Chest_AlbedoTransparency.png
            "c6fcfb5568844945ad04ec4d8a4a08bf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/dummyposter.png
            "c8d54374baa64a87b7f623c8293f1839", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Lantern_AlbedoTransparency.png
            "73242582e55942c497fd442e0e2c5186", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Lantern_Mask.png
            "ad2db48db12b4a1a870f86724f781d2b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/MenuBook_AlbedoTransparency.png
            "e18d174390474aa182844a997aea2d1f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/PictureFrame_AlbedoTransparency.png
            "418cb3bcd4f4466fa93aa61efbb4442b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Sofa_AlbedoTransparency.png
            "37023af72d5f4b6996b7fc4ecaecbfbd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Stool_AlbedoTransparency.png
            "4b0a4d70a9aa41fc80704aa5899682f4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithCounter/Textures/Table_AlbedoTransparency.png
            "ef9e353fc2786ba4c9cfa134b672a9e3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template
            "e5e6b1f644a393c42948c2523a11c4a6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/LICENSE.txt
            "dff7a68c2a7e54444aaa3bb77221f8de", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/Property.asset
            "3f878f16eba899743a5365bb6514e9bf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/SharedAssets
            "a035e796a87fe914191b7aeaf767d315", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets
            "620bed168c2a95749a72638a0f0e4d00", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}
            "eb6b4ad1e3b8b7740884cdcb37b81813", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "ff0d9a3568d2cbd4d8b006da0aaff7ae", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined
            "18546fb6ef6d4c71a0db2a218b3586f6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Interior_Western_1FOnly_WithoutCounter_Combined.prefab
            "0ccbf76fdd0150046b90e8c7a75213a3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Materials
            "e9f1587aac434874a73dd4c9de673aae", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Materials/PictureFrame.mat
            "c3c74bc7dc2d76f4c97321b3d8fa043d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Models
            "cd0fda1a529f4754bfcb3a38664ede3e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Models/PictureFrame.fbx
            "fd0595757f1f9bb419f0155cb21d9ae3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources
            "2d9b1afff34c40549ac4108a072a2ef4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2
            "3e1caeafe7c54cb0a5b7e4d481ee51af", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "7b16f5623e214383a365680dcdbb7e08", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/BakedMaterial-mat-_MainTex-atlas-0.png
            "a5265e9e4d2345409a750b6771b15863", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/BakedMaterial-mat.mat
            "26315200999f437e828a6633f1a1ff99", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/Booth_Youfuu_Merged_Mesh0-mesh.asset
            "cb6a4e58dc8e45109b6d482ee2e1e56d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Resources/1stFloorOnly2/Booth_Youfuu_Merged_Mesh0.prefab
            "f710eb9f810d24e4cbf4a1ddd2c4ffa0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Textures
            "257833c9db0443e3ac94185928e5e697", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Textures/dummyposter.png
            "d1025736a08f48daa772d63ebe4d1e22", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_Combined_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter_Combined/Textures/PictureFrame_AlbedoTransparency.png
            "c5931dbee1609cf49a99689c0110712e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template
            "b33bfd062ccda774ba61e8372516b01a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/LICENSE.txt
            "3cb6eb9586020524890c0353b189ae45", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/Property.asset
            "60a10973d8b882d45937bf4273f21c59", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/SharedAssets
            "621c2088bb4d6a040a6063941d234060", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets
            "89e171aece451e64ea90a462edfd1db6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}
            "898759af9f471744bbb23d38e1bd9d8b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/{ID}.unity
            "1279ba099d00e1f46a3f68a030c25d61", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter
            "812f6e5066e948f399386a366dbe6be1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Interior_Western_1FOnly_WithoutCounter.prefab
            "d6f89dca25a41ef4fa823b4de24b6123", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials
            "c2cb2db3e8af487a9e824fff3c425945", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Booth.mat
            "7acf24f8b8d2467c8a1747c9ec19435a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Chair.mat
            "97c9b552cd364a82b8d04d81c25336aa", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Chandelier.mat
            "c76f58f8e6504b51935bca6705c6775d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Chest.mat
            "14a6024499054112bfc3bdfed905607d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Lantern.mat
            "13613998ce7646d3bcc3eaf1772a3d5d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/MenuBook.mat
            "357c4aed5d9f4ae49ae0427d56b59055", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/PictureFrame.mat
            "b993ad75e5d44f8381a639d672313837", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Sofa.mat
            "ea50254c2de14bd7932fae2d4bebc7d8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Materials/Table.mat
            "68198f82993cd7142a2d020ccccbc9f9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models
            "558191d5005f4203affaebf827b32fb3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/1stFloor_Only.fbx
            "a15114e4cba04376bfaceba5a1c3cdf5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Booth.fbx
            "4e8f50a80f44435796c22932a646beb8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chair_A.fbx
            "7fc3d0d19202471ebb6af99102c92c33", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chair_B.fbx
            "d97ec97d8a3842db9dd3a728aae55c30", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chandelier.fbx
            "8e1a9a841ab044d0957e301f065d794d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Chest.fbx
            "9c4073dbcb9f4cdb88b06073ae942a4d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Lantern_B.fbx
            "41f6ea9e7b454dca99a54ac9982d2800", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/MenuBook.fbx
            "43609488295d459181ab9512f24e3b49", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/MenuStand.fbx
            "9cd95c0ea2854d37a04a1694b1272f6f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/PictureFrame.fbx
            "064d78567179469c9aa517ac8b01e355", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Sofa.fbx
            "4670fa6990a5438f92a4177112c9e028", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Models/Table.fbx
            "2f40daa8fa9d77a40b20ad4817f6eb23", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures
            "3108af16077a4cd59aeef58075bc5c06", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Booth_AlbedoTransparency.png
            "bde9391dc43f4f1482c68e6c7b3b193d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chair_AlbedoTransparency.png
            "8c68764ea77d4524b2a1020c8bfe2080", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chandelier_AlbedoTransparency.png
            "a68c216dee2e4ca2903ea9f26040b6c3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chandelier_Mask.png
            "670b6e8ad07243d1b393b7f9a8d24417", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Chest_AlbedoTransparency.png
            "8c46633f3f3d4278b6ecdc137a2f043d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/dummyposter.png
            "b60e10b463484eb1a57669075e570c22", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Lantern_AlbedoTransparency.png
            "0463c5b8696847df83fa4a8911cea9ae", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Lantern_Mask.png
            "60278ba9517f40d1bba8395f9d87f6b1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/MenuBook_AlbedoTransparency.png
            "6dc4adbc5ce74e5393e313d8a940a784", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/PictureFrame_AlbedoTransparency.png
            "8a72d721a2034a78a1eb280f5fb4b72c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Sofa_AlbedoTransparency.png
            "799376ab627f4fa49f3bb287b91c15f1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_1FOnly_WithoutCounter_template/TemplateAssets/{ID}/Interior_Western_1FOnly_WithoutCounter/Textures/Table_AlbedoTransparency.png
            "9f3c7e3220794634ca52c446623ba46d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template
            "12b4c7e2cf8da174db8a2b511716b161", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/LICENSE.txt
            "aa468f46b3b1d144e8090c08b0543f79", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/Property.asset
            "37a6109a7e4752e4b8710bc6055dd1bd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/SharedAssets
            "35bd727c4bd7e5741b84d9af5860cb51", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets
            "d548f335c95a05e40863c41935b2f0d9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}
            "bf85d8da8bd74f44a936639d3f218b6e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/{ID}.unity
            "24423cb2490ba884884a888dd4fb3974", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined
            "41d67b791b2e46d09e0235951eba648a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Interior_Western_2F_Combined.prefab
            "64237aacd5dbbcb428c20f1f289f8b24", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Materials
            "b8089128cd90484cb77334508997c008", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Materials/PictureFrame.mat
            "1d638fd2016fd2a418bce8a36b6693f8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Models
            "565302c804cf463e8f2c6fdf881c19a1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Models/PictureFrame.fbx
            "b6207cb0c73c9a94a9c0ede2850b0173", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources
            "d0fc0a44c14811f438810f7d301553bf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors
            "1af81785e651e114b8dc842cb855f250", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/BakedMaterial-mat-_EmissionMap-atlas-5.png
            "97007039e0b4824469224139f22a7d51", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/BakedMaterial-mat-_MainTex-atlas-0.png
            "9bd74d3c324e8ab44a93bd5635f712cc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/BakedMaterial-mat.mat
            "56b4d9e4030f86a4686d18a51307ee62", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/Booth_Youfuu_Merged_Mesh0.asset
            "925817dbbef64e647bc7d3b2e0402da8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Resources/2Floors/Booth_Youfuu_Merged_Mesh0.prefab
            "53f71ccb7a6d7e140a10add4d7f33dc0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Textures
            "e03ca24f7fe34e72b9fef49eddf82a73", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Textures/dummyposter.png
            "5f036a12849c4bb58e03191b5d9f1af0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_Combined_template/TemplateAssets/{ID}/Interior_Western_2F_Combined/Textures/PictureFrame_AlbedoTransparency.png
            "21f852f58ce32484b8999125fee20c5f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template
            "86c9ba81bef13804ab27c714a8bc06d8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/LICENSE.txt
            "cb58b26ad7cf5de43ab24f1231a8d7e6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/Property.asset
            "a6957a908d31b9d47abe4844a5eada48", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/SharedAssets
            "1bdc55feb65b5de41b1062c6cee5bd7b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets
            "080b8d17d5b73734ea35c0753de1b9ee", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}
            "2e5f45e262399844e898c8bb3961c9ff", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/{ID}.unity
            "bec9f5ccfab949440a26c6ff51fbd010", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F
            "6bf39be7fbc24ab592d74788ebf54b06", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Interior_Western_2F.prefab
            "16b5cf912757b75498593108a051ae81", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials
            "484ac42ccef84ef881e6b1e46017bc35", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Booth.mat
            "2ecfb9a07f31457dbaa41858763d9c9b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Chair.mat
            "f4687604b2d74742b4df344ebd6da633", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Chandelier.mat
            "53f7b28a7852476db1d706995b4e8670", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Chest.mat
            "efecd489dbba4cc6a901e39196363acb", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Lantern.mat
            "13e1f6785ffd4ec693cf24b3bb46b4d6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/MenuBook.mat
            "4ef2d1ed92be4d8bb5a58d9925b61eb7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/PictureFrame.mat
            "f336affc64d24835aa0f6ccad2e5f4a4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Sofa.mat
            "04d7a9b231f842bc91ddeaf7899efa93", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Stool.mat
            "6ab0504426ce4c0d8ae579011dd436a5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Materials/Table.mat
            "65bd935b39283494c805234170d61a49", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models
            "055b08b8cad34ba3a498ed3f5c38c396", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/2ndFloor.fbx
            "8c4161400532490a9e9843a84038c81a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Booth.fbx
            "182b8866259c44d994b40ca0349da4d9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chair_A.fbx
            "524a7cc022214294a844e641da6b82f9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chair_B.fbx
            "25e11d9a210f4828a29190cd1308aaa7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chandelier.fbx
            "4f8368b4bdb647779e7730faf37044ff", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Chest.fbx
            "54bb09f39f694f6791016497daa2085d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Counter.fbx
            "4bb6a08c2f77435d9d4956a286263b3a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Lantern_A.fbx
            "55c041ece5b141d49506bbd76f0b68c3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Lantern_B.fbx
            "8be04189b54c4f3b80bafc506083aaa6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/MenuBook.fbx
            "10dcbf1e877046bda2e897714c1a84a5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/MenuStand.fbx
            "a85968316d2c4d8baa8a2f3600d36c57", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/PictureFrame.fbx
            "982c495e208141b09d4f4ca696b4200b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Sofa.fbx
            "14f5bd5730994713a57203e3359963a7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Stool.fbx
            "5731fe5229e6477b938922be14b0d64b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Models/Table.fbx
            "834fce2d506c730429f4c05a77d9ddc4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures
            "6b909a50ac75482eac6d0533cb73dcda", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Booth_AlbedoTransparency.png
            "de0cceca8ccf4554850e003f50a5a11a", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chair_AlbedoTransparency.png
            "8238078dc7374f9e965908ef46828f2c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chandelier_AlbedoTransparency.png
            "cba9167726a642beb7d51e4436460143", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chandelier_Mask.png
            "4bc4b3cb0b234da98f39588bce10c7e1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Chest_AlbedoTransparency.png
            "e2989b72f35247cb82fcc8b46afd3b84", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/dummyposter.png
            "3867eb87d3e6486c8fcbb9616f34d224", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Lantern_AlbedoTransparency.png
            "fd48f874e97e4f439e84d8736634ff73", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Lantern_Mask.png
            "9879e0c7488d481db5fb351b1bb965fc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/MenuBook_AlbedoTransparency.png
            "194e017321114fc89ec29ee3fde02a54", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/PictureFrame_AlbedoTransparency.png
            "f78f3a113e614bc9a93ab9c3e7459ea7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Sofa_AlbedoTransparency.png
            "8e220de99fc1413ea915052600b83dcd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Stool_AlbedoTransparency.png
            "53ff0e8222974d989c13d10cf96234bc", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_2F_template/TemplateAssets/{ID}/Interior_Western_2F/Textures/Table_AlbedoTransparency.png
            "31302e97808a76c43af9fda93c824803", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Empty_template
            "97368462b15f8d64b8802b46896dfd85", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Empty_template/LICENSE.txt
            "8cc6de1539520484481c2d90f0c87386", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Empty_template/Property.asset
            "351b26fc642140047ab869439652f300", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Empty_template/SharedAssets
            "450e27df93b23f241acc85c03b11e67e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Empty_template/TemplateAssets
            "1d161b4bf0577f04383b3980ec9db23c", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Empty_template/TemplateAssets/{ID}
            "9a42389103c81a7449cb95d94e593232", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Empty_template/TemplateAssets/{ID}/{ID}.unity
            "cd195378975034c4ea585cc56b8b2325", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template
            "07e3342574c11894ebf4417d6ff4ca15", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/LICENSE.txt
            "0842c984f1b6d914ebf84fcd9c18a056", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/Property.asset
            "c63ebb65e695ee14ba8b7f8602016998", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/SharedAssets
            "3a2438cf563569a4680f83e2ee40ffc4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets
            "7c285aba49f835945831f6cbf74750ff", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}
            "a6e188bc42ce96c488cae5e70c54cd8e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/{ID}.unity
            "3188ff3f4c5ed7246b2c5bcef5dc57f1", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset
            "bc1b54073be0427292490ef1306cb9cf", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Interior_Western_Fullset.prefab
            "9043f4a3dd3e15146a8a292a68917ac6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials
            "380982d7119a4fe5a63c9f0212c0698f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Booth.mat
            "59945c5dcde4482ba9a91c723e65fd12", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Chair.mat
            "31418376dcaa49b89c025e4a686c7e88", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Chandelier.mat
            "3b7a9162ac9145eebc3bd4b78e5d96a4", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Chest.mat
            "43f0f85eb7644714a4b9a6b5640a5254", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Lantern.mat
            "c90c49f03d24424eb530e44ca8e6ae1d", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/MenuBook.mat
            "a90efc73b9a74e50b61d17463a169bca", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/PictureFrame.mat
            "74d39a04bb09434db69fea9f280c96f9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Sofa.mat
            "1cdb326c93c04df697f5a802283fa071", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Stool.mat
            "3fdad5b3b90d4d618b3ac45bd4c1cc1b", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Materials/Table.mat
            "7e41dbb3c5e0a114cae2b6c3f5bd584e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models
            "5258a940cb89415595615ca1cf9b716e", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/1stFloor_Only(Counter_Roof).fbx
            "9dcc3681897044a898817f85485266b8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/1stFloor_Only.fbx
            "112dcb1baee64f44919c2aef5b930cd6", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/2ndFloor.fbx
            "1b28ec4b227f4469adab09791010f35f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Booth.fbx
            "ea4108d1ea0a49c0af437e9bcc21fd75", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chair_A.fbx
            "f16c338f9f3c4a76ae3da7ce06c23343", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chair_B.fbx
            "62c810a7e25440d08aaf663b74c0bc90", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chandelier.fbx
            "24c2b36a0a2d4e64ba7f3e5bf8248ba7", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Chest.fbx
            "dd4edae9392a4ee3bc5d62b5c5b0f1fe", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Counter.fbx
            "fc3cd900fb6445e984568bb111673f7f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Lantern_A.fbx
            "3f1cba86c9d049ce87183e95cf064a25", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Lantern_B.fbx
            "0260578da68b41758020ec40b666a8b5", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/MenuBook.fbx
            "440498fb92144404a34bfb8fab0489c9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/MenuStand.fbx
            "7cd13e6958864762bb3f12257fd15af3", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/PictureFrame.fbx
            "e10b6ecf678c46b298f9f15aec6cfd85", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Sofa.fbx
            "ed36c5302a454dafafc9ba2f63166de8", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Stool.fbx
            "9519a3f9dd3a451880df2c3e5618f9e0", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Models/Table.fbx
            "2bb6db0ccebec7246b82939630dd5762", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures
            "7147d24e41ad4367bda6cb0f0d1f0b06", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Booth_AlbedoTransparency.png
            "29d87fbf800d4c6686bdc8d66e1652b9", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chair_AlbedoTransparency.png
            "fa3fd43f5b5b43868cee7530c4e690fd", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chandelier_AlbedoTransparency.png
            "bfdfac949106454985fbc73384fed887", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chandelier_Mask.png
            "a082e40424db469a8fa08756d65d8848", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Chest_AlbedoTransparency.png
            "73989f2d270445e4ada84f5318965527", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/dummyposter.png
            "9f3ec0ed3062442889a2e9f2f490c71f", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Lantern_AlbedoTransparency.png
            "7e2410eb917442829c15beecee7a9699", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Lantern_Mask.png
            "f2e3e5ce8dd14696ac547905c5045c93", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/MenuBook_AlbedoTransparency.png
            "319e6a9a8bef429983a4eb9f5fab5349", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/PictureFrame_AlbedoTransparency.png
            "bcfa2b58470f4c0c80812b88e25e9b69", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Sofa_AlbedoTransparency.png
            "ac33547bba2b420fbad0f366e432f2da", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Stool_AlbedoTransparency.png
            "62b2018edf3a4cf492834e0ae2277b25", // Assets/VitDeck/Templates/JQuesta_Event_Booth_Western_B_Fullset_template/TemplateAssets/{ID}/Interior_Western_Fullset/Textures/Table_AlbedoTransparency.png


            #endregion

            #region VketAssets

            "0de3ccc1017c4a045a4fed5f810c2748",  // Assets/VketAssets/Prefabs/AvatarPedestal/Materials/UI-Lookat.mat
            "d35acdd70bdcab445bbbd6deac832a3b",  // Assets/VketAssets/Prefabs/AvatarPedestal/Shaders/UI-Lookat.shader
            "834f21d704cafe3498f4d2ecc38dc5ea",  // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Background.png
            "86487b9f4f81a774a9c49d53278c76cf",  // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Button.png
            "62f7352a395147043809a2d315af37ae",  // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Change Avatar.png
            "96c692c63aeba764081c1e04790fd3f1",  // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Sample.png
            "2c70a653a699f5c4b9c51c2160786525",  // Assets/VketAssets/Prefabs/CirclePageOpener/Components/CirclePageOpener.dll
            "171b9d597b1e63f4590b8d754491769a",  // Assets/VketAssets/Prefabs/CirclePageOpener/Textures/BUY.png
            "109a7475f1e5fd74ea8ac3ebd42ab182",  // Assets/VketAssets/Prefabs/VketLauncher/VketLauncher.dll
            "59261512e4100df488de6ddd9b530829",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_L.prefab
            "3e6652d46d6d66d4092650094b064987",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_M.prefab
            "87a721a2eb0c25643a5eb305781dc3a8",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_S.prefab
            "104b8771f1874de40bf91473c2afb5ec",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_L.prefab
            "2cdd22b46ff13f2409e7dd60e077eed7",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_M.prefab
            "045501f8edaa2e748857c6c17a96b2f1",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_S.prefab
            "d7a2d6aa4218cdd45854cd81900deba6",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_L.prefab
            "8134e8c0ab5943a479b31c509f2325fb",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_M.prefab
            "fb107661b9b479d4fa95452f7fd46426",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_S.prefab
            "0294f3138a383d44188238141e43a0d2",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Active_2D.anim
            "8ecf1c1367fda5c45b707eaaf1e6e300",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Active_3D.anim
            "826602674183e284685c8212ca89f3ca",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/AvatarPedestal_2D.controller
            "8dd57fafbfdbd5146b2e808a8b28a2ea",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/AvatarPedestal_3D.controller
            "cc64c7910ebf50249bc5cfdc65ba4729",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Deactive_2D.anim
            "68bbad9fbab0708449c847419d62a17e",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Deactive_3D.anim
            "6b468349f6cba0248a76b7d33570fbad",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Idle_2D.anim
            "8d5e148b91b24cf4dae7e22e010f7603",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Idle_3D.anim
            "8efcb83444471ae4f99c5f5fecdd3e6e",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Scripts/AvatarPedestal Udon C# Program Asset.asset
            "0d2cf2386895ff5499a1660a4327ad75",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Scripts/AvatarPedestal.asset
            "63af405779b7d6d44b64d709fb3fbdd7",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_L.prefab
            "ae8b674ab5516664ea5d5c535f5fbc6a",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_M.prefab
            "405b6beaa9b7b9947b9111840f170452",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_S.prefab
            "139aa3624bf91214dabb39362ccf4382",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_L.prefab
            "4cb05397779ec7a48818e05b68c26960",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_M.prefab
            "a4471dc2b540f9e46a5e36fe66ede5e9",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_S.prefab
            "cfec853519dd4de4690152f16894cd49",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/ItemPageOpener2D.prefab
            "91bb88e5f85d499488ebe6a238b396a3",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/ItemPageOpener3D.prefab
            "af49ba9be5e5e2149b9c6dfa6decec82",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Active_2D.anim
            "f770e16ed5ac5c149b9e34d271b9fea4",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Active_3D.anim
            "251fd152628ba744899b986ab59ff7d3",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/CirclePageOpener_2D.controller
            "886d4cde2c016cb4c9ea42c0af58f717",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/CirclePageOpener_3D.controller
            "495ce3af8d25dcd49ab1eb9da5692373",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Deactive_2D.anim
            "a41d2fdf7f5e5eb49ab85919cf41e188",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Deactive_3D.anim
            "f93cc62348e48c64cbdb3a9b069a1d11",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Idle_2D.anim
            "ff7931a8fe75c2142a4e83797c8c21e9",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Idle_3D.anim
            "26ac8287216792149b49a2db74fc0309",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Open_2D.anim
            "72fddf1509a7339498051122d1da2ce5",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Open_3D.anim
            "64d15967613adfa44a4c6926b6b9d714",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Scripts/CirclePageOpener Udon C# Program Asset.asset
            "6ea1e8fa7533f9647996810212fa976e",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Scripts/CirclePageOpener.asset
            "304812fb2352c7c419581d8f68b23f94",  // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/PickupObjectSync.prefab
            "e3fd1bb74f6500f4aac868dd0c369b03",  // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/Scripts/AutoResetPickup Udon C# Program Asset.asset
            "73398b290b7c5ec43a2e158bfc1c45db",  // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/Scripts/AutoResetPickup.asset
            "47accc564d52c0e4abc61201a680477a",  // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/FadeIn.anim
            "f3c75b315c1b019409bf422bfa5ac0fc",  // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/FadeOut.anim
            "79cc3ed8171a44e44a01c2100e57cb0b",  // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/Idle.anim
            "4f06c6b6d95c99e4c9eba1761a599fd6",  // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/WorldBGMFade.controller
            "e6d5c31911ec7404e8b613767bc9c944",  // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/WorldBGMFade.prefab

            #endregion

            #region VketShaderPack

            "6a1bea8b3245cd44a879612d2d6f40d6",  // Assets/VketShaderPack/arktoon Shaders/LICENSE
            "25bd5054a4b6ffb47b73f6fd436e0f56",  // Assets/VketShaderPack/arktoon Shaders/README_ja.txt
            "1dc24fdcb830de545be12a31d953349b",  // Assets/VketShaderPack/arktoon Shaders/Editor/ArktoonInspector.cs
            "4d5d0929a993a6543b9de355f69555d6",  // Assets/VketShaderPack/arktoon Shaders/Editor/ArktoonManager.cs
            "5034690b290c8b74cb03497a06726ad3",  // Assets/VketShaderPack/arktoon Shaders/Editor/ArktoonMigrator.cs
            "f336693355a393a4ea5a94d414b523c1",  // Assets/VketShaderPack/arktoon Shaders/Examples/ExampleScene.unity
            "b926be28e701612428d98637dc2bf8a7",  // Assets/VketShaderPack/arktoon Shaders/Examples/ExampleScene/LightingData.asset
            "085cf3fedd6bb294eacfbd4bc414ff86",  // Assets/VketShaderPack/arktoon Shaders/Examples/ExampleScene/Lightmap-0_comp_dir.png
            "4e89ae95769497940b832301e2796fe7",  // Assets/VketShaderPack/arktoon Shaders/Examples/ExampleScene/Lightmap-0_comp_light.exr
            "0ec5b0f7100c48f458dcf280614787a1",  // Assets/VketShaderPack/arktoon Shaders/Examples/ExampleScene/ReflectionProbe-0.exr
            "2eb350b0dd339cb49b9824cf13995641",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/cloth-sample.fbx
            "f1d089ea7b8a9194daa229671bd7487e",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/HalfSphere.fbx
            "b740ced5626064a469a29ecbad7cde4f",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/HalfSphere.mqo
            "7f8da376b282b48428e6012d1d6b01e4",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/mannequin.controller
            "1b5146a1f3281774a9ae9d86d85b7cb0",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/mannequin.fbx
            "51d178f628b7f114c89afd04967fef93",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/rotate.anim
            "d4952f2db95a16447a3fc2bb0d342c9d",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/roundedCube.fbx
            "19a0ba3d86e749546b76bf5acf5d16ea",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/roundedCube.mqo
            "0bfe6778f100206489baf9dbd0c24646",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/avatar1-helloweenmqo_服_AlbedoTransparency.mat
            "7882bcb890208a14bb86157b6ff1a481",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/Cubemap.png
            "af4dae3c66f957c45a9fb9d57f26dcad",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/FadeTextureExample.png
            "47c95c2343f176e47b666b929de8f68c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/MaskExample.jpg
            "2535c9c47d22fa74cb975bc6bf822ac7",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/MaskExample2.jpg
            "88581c9aef71ea549b2f133599cb89bf",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mat1.mat
            "00689565905a91443932ed9b91bac11c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/Matcap.jpg
            "d96088e780c661443a32b60fa5a2b7aa",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/Matcap2.jpg
            "a3ef914d408315f4a866313ae9b15162",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/Matcap3.png
            "88728f426bf72d74b9abd9ceb8ecbd2c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 1.mat
            "112ba1c1df66b5e47b93c5c355fb8e69",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 10.mat
            "27f323571b8327e409c9b9669fb84d93",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 11.mat
            "7d4ac9335e1cc82488a383bd849a380c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 12.mat
            "eb0465484fd24bd458c85ad5c6554747",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 2.mat
            "d6390657f902d1142a20b5cc7f92ffe2",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 3.mat
            "119d5edced9d6bf469181f8497c65731",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 4.mat
            "2f2236791569d124eb4b48f19730cb06",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 5.mat
            "f651c02bf9fdac1408c87c0e4f6cdd2b",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 6.mat
            "345659f361c837b4cab35176f8c8d671",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 7.mat
            "57338689439fb4a4fa1a42ebf3816059",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 8.mat
            "86c25d309b5f3114ab3f949d7655aea3",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 9.mat
            "a2d8565e76f62d14e9c149040f122c19",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material.mat
            "3784a951dbf03b645afc723f23aea29b",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/roundedCubeAlbedo.png
            "5fa80aa54e3d3d64d808f8989e2e7d68",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/roundedCubeNormal.png
            "1bd6ae9520d378f408445f9d4124d0f7",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/ShadeCap-Soft.png
            "12f178d108ab0394aa4ed4acf1bad8cb",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/ShadeCap.png
            "c7e141183bc6c5c40a37d02d5dc415e6",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/starfield.png
            "a87e62033b0ad4848838ebcf5f89858f",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/violin.mat
            "b407561bc3f21de4c8808646f3a719ca",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/Walls.mat
            "f93b9ae325c77ef4ead760d39eca7b5f",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/cloth/avatar1-helloweenmqo_服_AlbedoTransparency.png
            "b1fd4b404a3a7ae4e99356a0c300f34b",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/cloth/avatar1-helloweenmqo_服_MetallicSmoothness.png
            "367c23b196b1f6749a03f63febbeb990",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/cloth/avatar1-helloweenmqo_服_Normal.png
            "5ebfcc9cd374c614dba1f903f8de36ba",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/cloth/Cloth.mat
            "130e4ea006e957749a3e19016c5b918a",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/EmissiveFreakMaterial 1.mat
            "6182e5d390ecba149a1f8d75312e956e",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/EmissiveFreakMaterial.mat
            "5d87d8e428ab7dc43b51a4ace5e8f55c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/grdient_horizontal.png
            "4d1297e8a783e3242a35e699af99982c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/grdient_left.png
            "358ad584c99802b4da2965f294fdfe92",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/grdient_top.png
            "7570c67b3d1666f40bd3fdc1605ac116",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/grdient_vertical.png
            "4329612c3238cc44091f699ba05da324",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin/mannequin1.mat
            "5cdca66777e3963468a57b44e76b86c4",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin/mannequin2.mat
            "63000287678da044197a3ff745d75c25",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-knit/mannequin-knit.mat
            "f2b7b269124aad04f8ed1394bb7a104b",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-knit/mannequin_hada_AlbedoTransparency.png
            "300593a09f3a3a847a5286da9417f56e",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-knit/mannequin_hada_Normal.png
            "c2c262af144c1b042adc2954103f4e22",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin-green-metal.mat
            "e9bfebf98ae9cae45b922038482fc4da",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin-steel.mat
            "baa8c39629448f14f9f7dd8c1428dbe1",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin_hada_AlbedoTransparency.png
            "d243a1118bcad54469f0c17ced97f1a0",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin_hada_MetallicSmoothness.png
            "7bd75a18577b92e40b20efe0ae74859a",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin_hada_Normal.png
            "d34ddb690407bf04c8c9788205512415",  // Assets/VketShaderPack/arktoon Shaders/Shaders/Cutout.shader
            "18d9a7533c199e740aace730c78d6c60",  // Assets/VketShaderPack/arktoon Shaders/Shaders/EmissiveFreakCutout.shader
            "3d7739f293019494fb8995a1fc38422c",  // Assets/VketShaderPack/arktoon Shaders/Shaders/EmissiveFreakFade.shader
            "ff81093a7ac88134798d4274c55cc425",  // Assets/VketShaderPack/arktoon Shaders/Shaders/EmissiveFreakFadeRefracted.shader
            "6e08acecbe384864d82690f1704a89bf",  // Assets/VketShaderPack/arktoon Shaders/Shaders/EmissiveFreakOpaque.shader
            "e71575e4ccb008d4e883335c3ad49265",  // Assets/VketShaderPack/arktoon Shaders/Shaders/EmissiveFreakStencilReader.shader
            "24eaadc58de76f74085bddf9621fe48a",  // Assets/VketShaderPack/arktoon Shaders/Shaders/EmissiveFreakStencilWriter.shader
            "fd5c20ab9c5485444b5084f464d91504",  // Assets/VketShaderPack/arktoon Shaders/Shaders/Fade.shader
            "ca4a46b6454383540b9b0b4364a2d7ee",  // Assets/VketShaderPack/arktoon Shaders/Shaders/FadeRefracted.shader
            "9566a373fffe627408d31026ce69389d",  // Assets/VketShaderPack/arktoon Shaders/Shaders/Opaque.shader
            "4867c15b078ab3948ab5a758a9bcb047",  // Assets/VketShaderPack/arktoon Shaders/Shaders/StencilReader.shader
            "0d892e826f730774797c3acfca1b43db",  // Assets/VketShaderPack/arktoon Shaders/Shaders/StencilReaderDoubleFadeFade.shader
            "753d0fc07395b8d499b66e6e00b64079",  // Assets/VketShaderPack/arktoon Shaders/Shaders/StencilReaderFade.shader
            "62d584da6ad09fc409aba9a6ea4c76ad",  // Assets/VketShaderPack/arktoon Shaders/Shaders/StencilWriter.shader
            "abc253a50f12dc0478eb8c149b35af54",  // Assets/VketShaderPack/arktoon Shaders/Shaders/StencilWriterMaskTexture.shader
            "e117484d237f25a4f9c117444d3a4ae0",  // Assets/VketShaderPack/arktoon Shaders/Shaders/cginc/arkludeAdd.cginc
            "41f08346347915f4ab25c430bc631734",  // Assets/VketShaderPack/arktoon Shaders/Shaders/cginc/arkludeDecl.cginc
            "c3830c5b3aa068745afa82287a25ceb8",  // Assets/VketShaderPack/arktoon Shaders/Shaders/cginc/arkludeFadeShadowCaster.cginc
            "b7f00477d8c2131439bc5469d268da66",  // Assets/VketShaderPack/arktoon Shaders/Shaders/cginc/arkludeFrag.cginc
            "97f31596e13b1db489cc69f4f2cbcc9e",  // Assets/VketShaderPack/arktoon Shaders/Shaders/cginc/arkludeFragOnlyStencilWrite.cginc
            "5fd6b70947bef774b882d05c744c3281",  // Assets/VketShaderPack/arktoon Shaders/Shaders/cginc/arkludeOther.cginc
            "875f4a9e268dfff44981f8902e14c44c",  // Assets/VketShaderPack/arktoon Shaders/Shaders/cginc/arkludeVertGeom.cginc
            "82e13d2a938694aedb5dbb01bd3ecf07",  // Assets/VketShaderPack/MMS3/LICENSE
            "8dd7c14dadb834c4e8324f7d08c5674e",  // Assets/VketShaderPack/MMS3/MMS3.shader
            "128f4720891e8914ab7e6673099df0f0",  // Assets/VketShaderPack/MMS3/MMS3_Cutout.shader
            "fbaec084851cef64fbd877b3b15716cb",  // Assets/VketShaderPack/MMS3/MMS3_Outline.shader
            "f889d00a055a0488e9ecbf22c558ae76",  // Assets/VketShaderPack/MMS3/MMS3_Stencil_Reader.shader
            "f55508f2ed8cc477f9574099971bc4eb",  // Assets/VketShaderPack/MMS3/MMS3_Stencil_Writer.shader
            "fda424b70f79d4e5488e1cc3ee100a95",  // Assets/VketShaderPack/MMS3/MMS3_Transparent.shader
            "ece969dbfb97d446ba8f8358a78789b5",  // Assets/VketShaderPack/MMS3/Shade_Matcap1.psd
            "429e21194bb37d8478c543a065bd6a6a",  // Assets/VketShaderPack/Mochie/LICENSE
            "909b3ce927e8cf246b13b1dbdef33f62",  // Assets/VketShaderPack/Mochie/Common/Color.cginc
            "d5468ef40ceedc549a0911e23c0b1568",  // Assets/VketShaderPack/Mochie/Common/Noise.cginc
            "71a928ffb0de3b442ab7e52a33f42d54",  // Assets/VketShaderPack/Mochie/Common/Utilities.cginc
            "5a65d8c24e698b44cbf674e0a232926a",  // Assets/VketShaderPack/Mochie/Particle Shader/Particle.shader
            "d1c93822d1541934c8fa436a39f0351a",  // Assets/VketShaderPack/Mochie/Particle Shader/PSDefines.cginc
            "56a4a30195ab7a4459b604ae189b3ccd",  // Assets/VketShaderPack/Mochie/Particle Shader/PSFunctions.cginc
            "0dfb5dc13a225ca4db23b0ee43932e34",  // Assets/VketShaderPack/Mochie/Particle Shader/PSUtilities.cginc
            "7ab63f31ad43f1e4ebab13ed1d4201cf",  // Assets/VketShaderPack/Mochie/Particle Shader/PSXFeatures.cginc
            "0d1d977ca72938b4bb8f3ed06b9a8645",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFX.shader
            "0622846791c27d3499465434f2f63a0f",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXBlur.cginc
            "e06fb4e15a03e164dae45a93c3ab3591",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXDefines.cginc
            "e51e722628c0c834f841cbca164dc53b",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXFunctions.cginc
            "7cbe4084658fd6b4e8b73782d48a461d",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXKernel.cginc
            "9a10756a86708fc4f840711e05cf723c",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXPass.cginc
            "4bd03e585f1830247a19f1af0893e73f",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXXFeatures.cginc
            "87a52d53f3012e448b23af4d55a79d02",  // Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXXPasses.cginc
            "b252ff402bce931488cf8ff5152bf2dc",  // Assets/VketShaderPack/Mochie/Uber Shader/Uber (Outline).shader
            "5398f14cd241f2649988529db4480d1c",  // Assets/VketShaderPack/Mochie/Uber Shader/Uber.shader
            "21947c9bef25458429000c46ca32e021",  // Assets/VketShaderPack/Mochie/Uber Shader/USBRDF.cginc
            "6cd01882b763be542be24bd25c155871",  // Assets/VketShaderPack/Mochie/Uber Shader/USDefines.cginc
            "6e016b6a7bd29c24581e80488f391a0e",  // Assets/VketShaderPack/Mochie/Uber Shader/USFunctions.cginc
            "6390189603c02114c9822185832e97fc",  // Assets/VketShaderPack/Mochie/Uber Shader/USKeyDefines.cginc
            "a517223ef2cd6074b9947340447724b9",  // Assets/VketShaderPack/Mochie/Uber Shader/USLighting.cginc
            "b6948e44e1f92fc4891f424daf8e7bfd",  // Assets/VketShaderPack/Mochie/Uber Shader/USPass.cginc
            "70bd95f95c93df74699e04c703304294",  // Assets/VketShaderPack/Mochie/Uber Shader/USSampling.cginc
            "4ec15cb7a78843d4fb5c7c8bdf19bd9b",  // Assets/VketShaderPack/Mochie/Uber Shader/USSSR.cginc
            "76eed4008ba5d464199dcfc895daf3b7",  // Assets/VketShaderPack/Mochie/Uber Shader/USXFeatures.cginc
            "1da8bba388ad86741b84e6899d501ca7",  // Assets/VketShaderPack/Mochie/Uber Shader/USXGeom.cginc
            "d9b054af17135c745adff39d435e039d",  // Assets/VketShaderPack/Mochie/Unity/Editor/Foldouts.cs
            "e7db49004f057a845a9464ce30210a62",  // Assets/VketShaderPack/Mochie/Unity/Editor/MaterialManager.cs
            "2f59b3e0bf10120419b941583795ef54",  // Assets/VketShaderPack/Mochie/Unity/Editor/MGUI.cs
            "fdc00d0c66b6f3f4eb834fd87b6d760c",  // Assets/VketShaderPack/Mochie/Unity/Editor/PSEditor.cs
            "4689d28cb77840b488838b0a89f5dd78",  // Assets/VketShaderPack/Mochie/Unity/Editor/SFXEditor.cs
            "566cd2268c7d9194087322ca64b68f61",  // Assets/VketShaderPack/Mochie/Unity/Editor/Toggles.cs
            "eed6a60c5f8da544690d739b516ada01",  // Assets/VketShaderPack/Mochie/Unity/Editor/USEditor.cs
            "497f8485774204244abb7ba6c0865927",  // Assets/VketShaderPack/Mochie/Unity/Prefabs/Default.mat
            "3bb643d832d69134f8fbea4efcd0e109",  // Assets/VketShaderPack/Mochie/Unity/Prefabs/Depth Light.prefab
            "cd555b15b892a6342821da231de50d42",  // Assets/VketShaderPack/Mochie/Unity/Prefabs/Screen FX.prefab
            "c5eaa139ce0fb7c4b9ee2604697e997f",  // Assets/VketShaderPack/Mochie/Unity/Resources/ClearTexIcon.png
            "3e38383d19b750046a6fa03b1c2f8bac",  // Assets/VketShaderPack/Mochie/Unity/Resources/CollapseIcon.png
            "09c9c066a27ac424da976a9ae8474231",  // Assets/VketShaderPack/Mochie/Unity/Resources/CopyTo1Icon.png
            "124358866068baa4f90186cb87430c24",  // Assets/VketShaderPack/Mochie/Unity/Resources/CopyTo2Icon.png
            "b69d260e9a20c444cb3ac36d41d2d479",  // Assets/VketShaderPack/Mochie/Unity/Resources/ExpandIcon.png
            "d29b3eb8412f5e64096afc1ab733122d",  // Assets/VketShaderPack/Mochie/Unity/Resources/Header.png
            "29f18c82d04215e4f87185a100e9ff1b",  // Assets/VketShaderPack/Mochie/Unity/Resources/Header_Pro.png
            "1cbf300790ff57b4caf3fbe023eca45f",  // Assets/VketShaderPack/Mochie/Unity/Resources/KeyIcon.psd
            "f632ab1767b9c1e45b285c0731fbd1d8",  // Assets/VketShaderPack/Mochie/Unity/Resources/KeyIcon_Pro.psd
            "8f1c2bbd99970c841b096d9447417468",  // Assets/VketShaderPack/Mochie/Unity/Resources/ParticleHeader.png
            "ca6d24562e19aab4e90be114647a98bb",  // Assets/VketShaderPack/Mochie/Unity/Resources/ParticleHeader_Pro.png
            "31fef82c771a5374b904c64a98fde2ac",  // Assets/VketShaderPack/Mochie/Unity/Resources/Patreon_Icon.png
            "ec636ed50f955cc42a934e1bd42403d0",  // Assets/VketShaderPack/Mochie/Unity/Resources/ResetIcon.png
            "2201e3ff274d60b42ba46809810c7f0e",  // Assets/VketShaderPack/Mochie/Unity/Resources/SFXHeader.png
            "30a883d22a3859443a814b6bba897043",  // Assets/VketShaderPack/Mochie/Unity/Resources/SFXHeader_Pro.png
            "dff4b38eef00de14487e9ee7ee4359b0",  // Assets/VketShaderPack/Mochie/Unity/Resources/StandardIcon.png
            "21cb8a0fd46250e489c418eeff4a2222",  // Assets/VketShaderPack/Mochie/Unity/Resources/Watermark.png
            "0b25d34e04b2c7a4c98d9cc5c69fa830",  // Assets/VketShaderPack/Mochie/Unity/Resources/Watermark_Pro.png
            "7589d70a1d40b7c47857a6722e4a0aae",  // Assets/VketShaderPack/Mochie/Unity/Textures/Blend.png
            "89819f8cb0b9e5d418f6e90ca96ac9c3",  // Assets/VketShaderPack/Mochie/Unity/Textures/Distortion.tif
            "930ac9d4c358e5846af139e693a08bd2",  // Assets/VketShaderPack/Mochie/Unity/Textures/Hair Normal.png
            "2059b62900034054f9f93aafbf8293fb",  // Assets/VketShaderPack/Mochie/Unity/Textures/Perlin (Alpha).jpg
            "dfbb7eeed695dc14d82b08d887041406",  // Assets/VketShaderPack/Mochie/Unity/Textures/Perlin.jpg
            "b8d1261e60bcece48b7708cac8798bfc",  // Assets/VketShaderPack/Mochie/Unity/Textures/Shake Noise.png
            "b7359cc7e3e84444b88656ff6c166220",  // Assets/VketShaderPack/Mochie/Unity/Textures/SSR Noise.png
            "9c8ede69ecd0f824aa80b9929c0b1e5c",  // Assets/VketShaderPack/Mochie/Unity/Textures/Transparent 4x4.png
            "f276a76437cf84847a5986084b4d11f3",  // Assets/VketShaderPack/Mochie/Unity/Textures/Ramps/DefaultRamp.png
            "9674bc46ecefab84b9f135c13b18ce36",  // Assets/VketShaderPack/Mochie/Unity/Textures/Ramps/RampImporter.cs
            "2a5e8a5d481e3574b8274fa7ce4bdc2d",  // Assets/VketShaderPack/MToon-3.4/LICENSE
            "1021e7e6d453b9f4fb2f46a130425deb",  // Assets/VketShaderPack/MToon-3.4/README.md
            "a9bc101fb0471f94a8f99fd242fdd934",  // Assets/VketShaderPack/MToon-3.4/MToon/MToon.asmdef
            "24156f9da0724eb5a159f36c69a7d90a",  // Assets/VketShaderPack/MToon-3.4/MToon/Editor/EditorEnums.cs
            "531922bb16b74a00b81445116c49b09c",  // Assets/VketShaderPack/MToon-3.4/MToon/Editor/EditorUtils.cs
            "dddf8398e965f254cae2d7519d7f67d2",  // Assets/VketShaderPack/MToon-3.4/MToon/Editor/MToon.Editor.asmdef
            "8b43baa9f62f04748bb167ad186f1b1a",  // Assets/VketShaderPack/MToon-3.4/MToon/Editor/MToonInspector.cs
            "1a97144e4ad27a04aafd70f7b915cedb",  // Assets/VketShaderPack/MToon-3.4/MToon/Resources/Shaders/MToon.shader
            "ef6682d138947ed4fbc8fbecfe75cd28",  // Assets/VketShaderPack/MToon-3.4/MToon/Resources/Shaders/MToonCore.cginc
            "084281ffd8b1b8e4a8605725d3b0760b",  // Assets/VketShaderPack/MToon-3.4/MToon/Resources/Shaders/MToonSM3.cginc
            "17d4e0f990fbc794ab41e4fcc196d559",  // Assets/VketShaderPack/MToon-3.4/MToon/Resources/Shaders/MToonSM4.cginc
            "8b731264e8acd0f4b8f56986e5eb2531",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/OutlineWidthModes.unity
            "4f42a26097c877b40a7616aa60580c43",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ex_OutlineWidth_Screen.mat
            "e40a129e14e378c4db040df3fd4a6077",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ex_OutlineWidth_World.mat
            "54da18ba3126f1343924588562df72e0",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ground.mat
            "9639e17dffc656345a70282f7f216672",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Toon.mat
            "9a3fb070d7eb4114b5cf387e2cd60391",  // Assets/VketShaderPack/MToon-3.4/MToon/Scripts/Enums.cs
            "2849b99d94074fcf9e10c5ca3eab15a8",  // Assets/VketShaderPack/MToon-3.4/MToon/Scripts/MToonDefinition.cs
            "9d2012c170a74b3db0002f7ecda53622",  // Assets/VketShaderPack/MToon-3.4/MToon/Scripts/Utils.cs
            "6724aa45c8c349fabd5954a531301aa8",  // Assets/VketShaderPack/MToon-3.4/MToon/Scripts/UtilsGetter.cs
            "b24a672e82874c9fbfef9c2b2dfdab42",  // Assets/VketShaderPack/MToon-3.4/MToon/Scripts/UtilsSetter.cs
            "4702d4b2c1414cc08b4382c3762eebab",  // Assets/VketShaderPack/MToon-3.4/MToon/Scripts/UtilsVersion.cs
            "ac1db82fd6a079c47aa6194a7798f04a",  // Assets/VketShaderPack/Reflex Shader 2/LICENSE
            "81d254e2967e81746a583f5bafc968af",  // Assets/VketShaderPack/Reflex Shader 2/README.md
            "a17df36c78d69f24c8fb7cfff294e132",  // Assets/VketShaderPack/Reflex Shader 2/Reflex Shader 2 Cutout.shader
            "baa2148099f6f3646bdae4319592905e",  // Assets/VketShaderPack/Reflex Shader 2/Reflex Shader 2 Stencil Reader.shader
            "9fc79fcfadbc2c149970dd12704133c4",  // Assets/VketShaderPack/Reflex Shader 2/Reflex Shader 2 Stencil Writer.shader
            "4d2eda1ffb121d549b437db96574d64e",  // Assets/VketShaderPack/Reflex Shader 2/Reflex Shader 2 Transparent.shader
            "da4e037220e1c9a40b77c4c6ff6dcc93",  // Assets/VketShaderPack/Reflex Shader 2/Reflex Shader 2.shader
            "5c1895a85d4c38a4e9f6a050722d5a97",  // Assets/VketShaderPack/Reflex Shader 2/Editor/RSInspector.cs
            "0205e6023718bab428bc3df400f93cd0",  // Assets/VketShaderPack/Reflex Shader 2/Emissive Scroll Tex/Emissive Sample 01.png
            "700ac6f1880ae4a44b4f4e898f3c9fde",  // Assets/VketShaderPack/Reflex Shader 2/Emissive Scroll Tex/Emissive Sample 02.png
            "ee5d32dbd750a9a42b74b0eedf74b2cb",  // Assets/VketShaderPack/Reflex Shader 2/Emissive Scroll Tex/Emissive Sample 03.png
            "f5d8f584674c8984ab029c8868eb5bf3",  // Assets/VketShaderPack/Reflex Shader 2/Functions/Reflex Shader Function.asset
            "25df7b96fb001804e9f8b60b156dfe34",  // Assets/VketShaderPack/Reflex Shader 2/Images/RS_Header.png
            "a34233ce30b26904cbdc837a2b2f4984",  // Assets/VketShaderPack/Reflex Shader 2/Images/RS_Logo.png
            "7266fc3b47fe69d4eb0e07eae7890fe7",  // Assets/VketShaderPack/Reflex Shader 2/Matcaps/Matcap 01.png
            "e832c7c4b2aa8164188c5fafc6b3157f",  // Assets/VketShaderPack/Reflex Shader 2/Matcaps/Matcap 02.png
            "c62a504aa1f92254580fbba47b5d1d1a",  // Assets/VketShaderPack/Reflex Shader 2/Matcaps/Matcap 03.png
            "320eb42ea75aecf40b6d307100f53280",  // Assets/VketShaderPack/Reflex Shader 2/Matcaps/Matcap 04.png
            "c7dbedf5cb40ba240842f08fe47232f7",  // Assets/VketShaderPack/Reflex Shader 2/Matcaps/Shadow 01.png
            "f6172fea687a4bd498140ef4625ba18b",  // Assets/VketShaderPack/Reflex Shader 2/Matcaps/Shadow 02.png
            "13dcfc05fc9ff46279cd0d8b19b6eb16",  // Assets/VketShaderPack/Reflex Shader 2/no_outline/Cutout no_outline.shader
            "f69d22507846543fba38e64372dfe6a8",  // Assets/VketShaderPack/Reflex Shader 2/no_outline/Opaque no_outline.shader
            "240e6a39b9c4c4df083e49e5f139cff0",  // Assets/VketShaderPack/Reflex Shader 2/no_outline/Stencil Reader no_outline.shader
            "37a618d5b552742348253195161d4a74",  // Assets/VketShaderPack/Reflex Shader 2/no_outline/Stencil Writer no_outline.shader
            "7c2607431430f400f86b6fb4a454bede",  // Assets/VketShaderPack/Reflex Shader 2/no_outline/Transparent no_outline.shader
            "44d0643d490e16f4492b7252c658ea1a",  // Assets/VketShaderPack/SCSS-master/LICENSE
            "4c6ec922fb42b2848a1e6fd88c19bf4a",  // Assets/VketShaderPack/SCSS-master/README.md
            "163fd2e733679b948b23e92b2341f8f6",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/Default MultiGradient.asset
            "80684a860e75c9a4295d27ead38010c7",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/Info.txt
            "a7e8258f4d13af1419c0326602f31748",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Sharp.png
            "70853d21e5cf0a945ba9ef1baa2f37fa",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Skin.png
            "6af41be6e81954543bfe50e9b2131c4d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Smooth (old).png
            "6584ffcc7e2c6a746afd371ec1d6ad5d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Smooth.png
            "a8fbd87577f16ea43ac168bbf9ef88f3",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Soft (old).png
            "51b142bdc7b4f7a428477e77eb815bc7",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Soft.png
            "d0d2092a7d8176a419858a5536e205ee",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Toon v2.png
            "7f445efa362f16248af955f190843381",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Toon v3.png
            "ae6fa37de6d2b4e45a6176091e47455c",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/LICENSE.txt
            "63a9cd46c7dd97644b42c0721976f257",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Readme.txt
            "fb2f01db930474c3fbd62634f03ffe4b",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Hard.psd
            "4348a2a80916845739da8629005aef03",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Hard_Hair2.psd
            "5306755cc52e04770bf7169839c6b350",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Soft.psd
            "1f802a1910910432ca435480b93e70ec",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Soft_Hair.psd
            "d247459fa9b47465d92f1eb93eba56e9",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_RimLightMatcap1.psd
            "c2dda37b49c0b4bde9e211e894f7344d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_RimLightMatcap2.psd
            "44d209fdf321840569dd21a5b61e277d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_ShadowMatcap1.psd
            "ecfa3da8397834305821fe311f1cbf15",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_ShadowMatcap2.psd
            "c68fab11bf4dfb044a2f51d7ddc4d064",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136-img1.png
            "48e16bad9d9551b499dfb08af7ee7e31",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136-img2.png
            "fb8f4c7cfbfa3f743b381bda894c2eb6",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136.txt
            "21e7d43547251ef4bb267a4aa24f04b7",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136.url
            "ebd77ce0e53676d49853f56eb043a827",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LICENSE
            "c855d2d0c1361d14a841af5aa24d6d26",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/README.txt
            "b7b167660549b8e48a231f62d2fcb008",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Glare.png
            "3dd155f12c76e1447bf62608fc1bf572",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(LargeFlat).png
            "3dfb01f9d1c32f048ac838f6e3fa8810",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(LargePoint).png
            "9a6b29adf08462e4f98ec4a45cc7c57c",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(MultiFlat).png
            "bd882f7694bebd04eb144979a8787993",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(MultiPoint).png
            "c6cbb49dcbadf93489feca05b6652723",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(SmallFlat).png
            "b3d17e4df2a84274f8810d14ad0d1537",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(SmallPoint).png
            "5866d4cb591aa9443b2cb4948139b112",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Blue).png
            "a369076245553a64eb0f96d537272196",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Green).png
            "a8845002a4d852249b1f5b2d0422279c",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Purple).png
            "0db92e9598eb9f64c82095d66efe6a1a",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Red).png
            "2b71b8337c476dc4b875b2836a0e2720",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Yellow).png
            "86e9818d2a3ca7041b09c97748be153d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing.png
            "70ae0ed388398f14a983b9be841fbf92",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Iridescent(Large).png
            "431e901af18398a40876e71e33afcb9c",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Iridescent(Multi).png
            "d3a73c13da3082b499720fd2e340fd58",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Iridescent(Small).png
            "c3348e9a93cf3f041a47eab885eff5a4",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(Peach).png
            "81aad2673b3c3564e86273be96df3985",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(Red).png
            "51458ebc5861843449e59e63cfbe9312",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(White).png
            "8d80aa31a13e4ca499d7a120c31b5c30",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(Yellow).png
            "1e1bd6119670c6644b39d585be1c7dd4",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(Peach).png
            "de1140e088e6df840abef03788989036",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(Red).png
            "b249fa84e5347e047a14ebd946f5b992",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(White).png
            "eeb275611fdaf2648b0749546abab7e7",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(Yellow).png
            "118b92d83e2a11040921f1eb0de754f2",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Tights_HighDensity.png
            "d7043e6bdc77d9a48bdbfc3fb6dc63b8",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Tights_LowDensity.png
            "21b34471bb21d714695594ed013671e5",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(BlackEnamel・Blue).png
            "4b7f9eac7f86d804fa4651f78c2f77a2",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(BlackEnamel・Red).png
            "a86b7309210462d49937588b29ecb453",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(BlackEnamel・White).png
            "e789df0d8e991dc46bbbcb776c5a3ada",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(Rim).png
            "cfc0ca869f3f6aa488e442597f757c16",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(RimBright).png
            "eba422e248e1b7b46a44eca939e97a7c",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(WhiteEnamel・Rainbow).png
            "d9eed75190795c742b2a4ad01169a572",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow(Blue).png
            "981358a9d84b3254796caa2aed07f755",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow(Red).png
            "cb816f85c59d0594e919df78215b8643",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow(White).png
            "141320f81a2860f45b14a1de5bb46964",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow.png
            "228a97a7223a715439f7b999a17cb9d5",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Blue).png
            "de0bb15fb581f874b8c33b1cc5ea50e4",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Green).png
            "4e89ea8f4509c2d479adc1b6eb4a59b8",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Purple).png
            "bf6207586b81cc14fa15f173c8e3e88d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Red).png
            "731335fba7efbcb4c9c77281e6ebf259",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Yellow).png
            "7237239c7d9b876468e784c193ea453f",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing.png
            "140f68527af730a42884e180331e2385",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_MetalGloss(Yellow).png
            "fc5c401b877c1bf4f90c09420e4564cb",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow(Hemi).png
            "fb8412e5c0ec1864d94ffbc1c6573070",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow.png
            "63de7b1aca5f56547b4566d5c452971d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow・BlueReflection.png
            "cd71180b27fb20b46bd8a67b792511d4",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow・SideRim.png
            "cde5a8eff47aab14f956da09db682183",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_BrownSlick_GlosslessFace.png
            "6019069d567c03e40b2e57285c9cf05b",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_BrownSlick_GlossyBody.png
            "e2f3f51b74c61cb4fa33d42a0d857e74",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_Brown_GlossStrong.png
            "b3a2e207de951c44db9c4bacaee6010f",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_Brown_Rim_GlossWeak.png
            "e2e3379d7afc6c548a77840f6fd5f488",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Glare+Gloss(PointSmall).png
            "874b5960d1ad3b442b9f03199627562f",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Glare.png
            "862bb4f308d31a449b8fbfa82451d751",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(LargeFlat).png
            "fc0cf484220685d4eafa9ed00ef8cc7e",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(LargePoint).png
            "cd6d2060efad2c846afb263d634f1f70",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(MultiFlat).png
            "2e2858828b151be4695fd36ca4d19a40",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(MultiPoint).png
            "5923f328fc4cb4147ab169d1db94b29c",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(SmallFlat).png
            "a3680a23ee096f44b9d976c690a872dd",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(SmallPoint).png
            "5ee24b69dfded3240b1e950e8cfea8bb",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Blue).png
            "aab7586db9bd139439746510e249d68b",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Green).png
            "551ec63cc2428814e811c7b90822a9ea",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Purple).png
            "4e03c1e10a8731844ac2136ea96dff4f",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Red).png
            "4456fab6540937b4f80185dfcdb32acd",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Yellow).png
            "9c2691948a9baf44e8231ff1ddd00b36",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing.png
            "1c368911528c60d429257dc57624517f",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Iridescent(Large).png
            "3d294a5afc79400468719f6af35dabdf",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Iridescent(Multi).png
            "efd84db93a4cca24d93687e84f48fdf8",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Iridescent(Small).png
            "ae7d1c4c107c5794c8c4ec92b3e31630",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Skin_Glare+Gloss(LargePoint).png
            "96cf3bb60ffe3384fbd847ec4857c9dc",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Skin_Glare.png
            "a8ca5b675c614d348ac51cc580b8e5e2",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(Peach).png
            "8ace27bb9234eff44b5ec8f841b8ddaf",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(Red).png
            "865d0a3b58a86df45ac20e870fcf6255",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(White).png
            "bf45007d8a3c0aa4098a23916c68e58d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(Yellow).png
            "cf7bfae60977d664b911c3e163bb92a8",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(Peach).png
            "01a3d35c1bc39f646a22769f40bbbb20",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(Red).png
            "4fed231081a962e428e196625a7a4475",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(White).png
            "478dd3812b01a39469a08b45e94ea6fa",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(Yellow).png
            "4ff7604ea3c143144a465740b84499dc",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Tights_HighDensity.png
            "3d29d801cba569448b6aacb582271a69",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Tights_LowDensity.png
            "020b20d50dee3b64784514e35d8a53b8",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/HairMat.png
            "a2b389612cf565643b4b0bbd236f3335",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Ramp1.png
            "8339ae69dbe9dcc439ff088723737cfb",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Ramp2.png
            "0280c480c48fcbe40ac3bd5b8888b2d7",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/ReadMe.txt
            "f99f096fbf6cf4d40a2f990e8076c1db",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/ShadowMat.png
            "401e17d367f33e849a6fdb867b4ce269",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/ShadowMat_BGR.png
            "10af221457820f04c96c4b2932e290ab",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/SkinMat.png
            "4e1e2c12906898449933f67285cdc085",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/SpecMat.png
            "b0a5e22ce82df9b42a386995879e80d0",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/SpecMat2.png
            "c61dab59da88c87499105c1b046bcf73",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Albedo.png
            "5f8a50cc30df039489b8ee08453375d2",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Metal.png
            "06d8cbe587a3d2c4c967de17cac6c502",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Normal.png
            "721cd36de640a974ca45b613e85cd800",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 1.mat
            "4b8608d176dcf934585ec1b6886e05e4",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 2.mat
            "d469e28ac045d044fb9cb2226a7c9c72",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample.mat
            "af8197deebc61ce459480bd679aa6abc",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample_SCSS.mat
            "a3185396b596ad949854a764984b9171",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Editor/SCSS_Inspector.cs
            "88a031d938963714a8250672469d5214",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Editor/SCSS_InspectorBase.cs
            "07e7aaa47f6b9a04caf3a47e59ff4589",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Editor/SCSS_InspectorTools.cs
            "dd58167f3f5799f4db066008579b778a",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Editor/SCSS_XSGradientEditor.cs
            "0757509132a7ee748b11bc26b6fd10dd",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Editor/SCSS_XSMultiGradient.cs
            "a9a812ee108476f4eae9c507264cc297",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Crosstone (No Outline).shader
            "932c3f8bb2ba7d04480beb8e4c98b2a8",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Crosstone.shader
            "92b4d092592529b4f9a87764c0c44117",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Cutout) (No Outline).shader
            "193c1d1febff24f46bc72d88e8b205f8",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Cutout).shader
            "369d2ecd6fc95bc469360ddecf6b2155",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (No Outline).shader
            "f78fe2d8cca2202429d0c2e0d810c763",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Transparent) (No Outline).shader
            "5028bedf4f7ad6a4aaf7727fead41880",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Transparent).shader
            "a883b384ca4bc054aa10b5f554ae85a3",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/Flat Lit Toon.shader
            "949047d11aa1be843ab010f80e6e1ad7",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/SCSS_Core.cginc
            "ac54125faed4a1c4d8641c311f115c9d",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/SCSS_Forward.cginc
            "ad30dacf242f54a49b203e540fe72e8a",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/SCSS_Input.cginc
            "8acce3fdffc81da43bbff56f95bd5e98",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/SCSS_Shadows.cginc
            "e4f4f1f16f5f7a940a8a91cda2684a75",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/SCSS_UnityGI.cginc
            "4918d8dc352c4f14095b785dedffaab1",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Shaders/SCSS_Utils.cginc
            "eee1fe122a0b923418524ff036e23119",  // Assets/VketShaderPack/SCSS-v1.7/LICENSE
            "392e02194a1ca6b4392a763f27d228f8",  // Assets/VketShaderPack/SCSS-v1.7/README.md
            "a780591bd355dfb42b8d43171c524127",  // Assets/VketShaderPack/Sunao Shader/LICENSE
            "3e696a6fcbf6c3d48b6b18d391ac27f3",  // Assets/VketShaderPack/Sunao Shader/README.txt
            "52db967a50319a342b8d3e03e2c948c5",  // Assets/VketShaderPack/Sunao Shader/Sunao Shader 解説書.url
            "ac4920ac84fea1840bcc25ab63dd1154",  // Assets/VketShaderPack/Sunao Shader/Editor/SunaoShaderGUI.cs
            "58f628f02e892b441aa26d5402c0fb19",  // Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_B.png
            "28a0ceca2c0231940b7704112685d322",  // Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_BS.png
            "a626f2283039de04e867eeb889b593d2",  // Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_W.png
            "ffa077d687eb240489acb287b977dfa4",  // Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_WS.png
            "f5c1047620033614d8f1f260c8eaaf64",  // Assets/VketShaderPack/Sunao Shader/Sample/Sunao_Shader_Samples.unitypackage
            "01846cdaa65259e48a71d9812e4e1c22",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Cutout.shader
            "09296c4f29b71fb4ba42ef8983d8007f",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Cutout_SO.shader
            "3701d6a6f5f988b4a9cea92f1426a955",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Opaque.shader
            "2fb75b0069e4fe147a396141dcf70627",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Opaque_SO.shader
            "7362334fb65c850469785caac3918093",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Stencil_R.shader
            "a95ac57a344b931459880f4ca527efc4",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Stencil_W.shader
            "0b073aeeaec66294aa00c57784f4a0bb",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Transparent.shader
            "cd2723fb285798b4b801e483a793b3c3",  // Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Transparent_SO.shader
            "0bcbd141d25c3594698232b7cf028e95",  // Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Core.cginc
            "a0a8cef7d729dd548bea8c0179114e1a",  // Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Frag.cginc
            "7c91ecb7ec33e624aa825469df256c8d",  // Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Function.cginc
            "349b3c656072d0444812de08c663ff40",  // Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_OL.cginc
            "331fdc83d13aff84cb82da583877f0d7",  // Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_SC.cginc
            "666562b3b8d23d64fa0f6ee5216239b1",  // Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Vert.cginc
            "e30857b716beae5479b313fde1a5efaf",  // Assets/VketShaderPack/Toon/Editor/CopyMaterialParameter.cs
            "cad15f56be91b744aaf8e22339bc598c",  // Assets/VketShaderPack/Toon/Editor/RemoveUnusedMaterialProperties.cs
            "a9775daf5f793f64e98ccd6c4a61bbc8",  // Assets/VketShaderPack/Toon/Editor/RemoveUnusedShaderKeywordsFromUTS2Material.cs
            "e403ef4b1d56fce47b49ec46981d9fcb",  // Assets/VketShaderPack/Toon/Editor/UTS2GUI.cs
            "4c57a42f315f467488f69755e6a7d42c",  // Assets/VketShaderPack/Toon/Shader/README.txt
            "96d4d9f975e6c8849bd1a5c06acfae84",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather.shader
            "ccd13b7f8710b264ea8bd3bc4f51f9e4",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping.shader
            "9c3978743d5db18448a8b945c723a6eb",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping_StencilMask.shader
            "d7da29588857e774bb0650f1fae494c6",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping_StencilOut.shader
            "315897103223dab42a0746aa65ec251a",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_StencilMask.shader
            "2e5cc2da6af713844956264245e092e4",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_StencilOut.shader
            "369d674ae1ba36249bb00e2f73b0cd10",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping.shader
            "8600b2bec3ae31145afa80084df20c61",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping_StencilMask.shader
            "43d0eeb4c46f52841b0941e99ac9b16b",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping_StencilOut.shader
            "97b7edb5fc0f5744c9b264c2224a0b1e",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Transparent.shader
            "3b20fc0febd34f94baf0304bf47841d8",  // Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Transparent_StencilOut.shader
            "af8454e09b3a41448a4140e792059446",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap.shader
            "295fec4a7029edd4eb9522bef07f41ce",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing.shader
            "e32270aa38f4b664b90f04cc475fdb81",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_StencilOut.shader
            "29a860a3f3c4cec43ab821338e28eac8",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_TransClipping.shader
            "d5d9c1f4718235248ad37448b0c74c68",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_TransClipping_StencilOut.shader
            "6439813c08a1f8947bb0ca6599499dd7",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_StencilMask.shader
            "b39692f1382224b4cbe21c12ae51c639",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_StencilOut.shader
            "cd7e85b59edbb7740841003baeb510b5",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping.shader
            "6b4b6d07944415f44b1fc2f0fc24535f",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping_StencilMask.shader
            "31c75b34739dfc64fb57bf49005e942d",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping_StencilOut.shader
            "7737ca8c4e3939f4086a6e08f93c2ebd",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_Transparent.shader
            "be27d4be45de7dd4ab2e69c992876edb",  // Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_Transparent_StencilOut.shader
            "9baf30ce95c751649b14d96da3a4b4d5",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather.shader
            "345def18d0906d544b7d12b050937392",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping.shader
            "7a735f9b121d96349b6da0a077299424",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping_StencilMask.shader
            "ed7fba947f3bccb4cbc78f55d7a56a70",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping_StencilOut.shader
            "1d10c7840eb6ba74c889a27f14ba6081",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile.shader
            "88791c14394118d42a5e176b433af322",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_Clipping.shader
            "41f4ee183cb66ad40bc74a9f8f944974",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_Clipping_StencilMask.shader
            "dec01cbdbc5b8da4ca8671815cda1557",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_StencilMask.shader
            "55e8b9eeaaff205469365133fe7bc744",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_StencilOut.shader
            "d4c592285a93c3844aafdaafffc07ec7",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_TransClipping.shader
            "100d373b596f44d49ac9bb944d671d32",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_TransClipping_StencilMask.shader
            "036bc90bfe3475b4c9fadb85d0520621",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_StencilMask.shader
            "0a1e4c9dcc0e9ea4db38ae9cb5059608",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_StencilOut.shader
            "e8e7d781c3155254b9ea8956c5bd1218",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping.shader
            "79add09e32e5c4541980118f6c4045b6",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping_StencilMask.shader
            "fb47be5a840097b45bac228446468ef3",  // Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping_StencilOut.shader
            "42a47eda2ed77084c9136507eadb8641",  // Assets/VketShaderPack/Toon/Shader/Toon_OutlineObject.shader
            "2e2edd12fbf6bcb4ea1f34c17ee42df5",  // Assets/VketShaderPack/Toon/Shader/Toon_OutlineObject_StencilOut.shader
            "ca035891872022e4f80c952b3916e450",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap.shader
            "9aadc53d7cdc63f4898ea042aa9d853b",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing.shader
            "23e399973d807464fb195291a44a614c",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_Mobile.shader
            "8d33e4e4084e5af449f3e762fecce3c9",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_Mobile_StencilOut.shader
            "415f07ab6fd766048ac6f8c2f2b406a9",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_StencilOut.shader
            "b2a70923168ea0c40a3051a013c93a8a",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_TransClipping.shader
            "d1e11a558d143f14c864edf263332764",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_TransClipping_StencilOut.shader
            "f90e11a40dcf4f745ae6b21b857943fa",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile.shader
            "206c554c8b0c60041a9d242385f543d3",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_StencilMask.shader
            "cfc201757f2519c4bb6ef9265a046582",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_StencilOut.shader
            "cce1da34c52aff745adf0222f56a356c",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_TransClipping.shader
            "e88039bab21b7894e918126e8fce5d1b",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_TransClipping_StencilMask.shader
            "aa2e05ed58ca15441bd0989f008da78b",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_StencilMask.shader
            "923058fda1b61544b93d91eeee772086",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_StencilOut.shader
            "aebd33b74ef849a4882b4a8d55f0f0c9",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping.shader
            "0a05dd221bacbb448afac3d63e6bd833",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping_StencilMask.shader
            "67212ac11ff43b04a833d3986b997a9f",  // Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping_StencilOut.shader
            "80bd7ce6cad775a4e9de24e18eb5e61e",  // Assets/VketShaderPack/Toon/Shader/UCTS_DoubleShadeWithFeather.cginc
            "ec7b5c1d006f6be49b412bcd7a789c78",  // Assets/VketShaderPack/Toon/Shader/UCTS_Outline.cginc
            "eca315d4d2d36194b8be3cf2a6869762",  // Assets/VketShaderPack/Toon/Shader/UCTS_ShadingGradeMap.cginc
            "ae8d06deb98501947846000ba6cd3ab2",  // Assets/VketShaderPack/Toon/Shader/UCTS_ShadowCaster.cginc
            "5b8a1502578ed764c9880a7be65c9672",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess.shader
            "682e6e6cf60a51040ade19437a3f53e2",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess_StencilMask.shader
            "148d1eca2cf299e4eb949d15c4cf95ee",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess_StencilOut.shader
            "e987cf9cca0941042aa68d1dd51ee20f",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess.shader
            "97df86a7afe06ef41b2a2c242b10593e",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess_StencilMask.shader
            "b179fb8a87955a347b5f594a18b43475",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess_StencilOut.shader
            "60fe384b76fb67d40bc7e38411073dd6",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess.shader
            "4a20b66d106d3f5409f759b5193ecdc2",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess_StencilMask.shader
            "a7842aa9522c7584cae2169b8e1ddb86",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess_StencilOut.shader
            "0cb6c9e6216a91e4a9d38cd2acb4ccb6",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Transparent_Tess.shader
            "f28bba8b2f259bb40b697d91849c8794",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Transparent_Tess_StencilOut.shader
            "4876871966ca2344793e439d7391d7b0",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess.shader
            "7c48bdc9fed28c14b8ad0748673b1369",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess_StencilOut.shader
            "d3fb22770ec830b43bdb5ccb973e6f76",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess_TransClipping.shader
            "11e8f1e181e558a47a387492d3ecdb88",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_TransClipping_Tess_StencilOut.shader
            "01494e58d87212f44ab51d29caea84e4",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess.shader
            "24c20b8ed5be113499b40f4e3b6b03e6",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess_StencilMask.shader
            "9cf7e8eb46e9128438d50adf7a841de6",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess_StencilOut.shader
            "3c39a77fda28b5043a7a17c7877cf7b2",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess.shader
            "bf840a439c33c8b4a99d52e6c3d8511f",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess_StencilMask.shader
            "8eff803eae89c994fae3acf2f686fafa",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess_StencilOut.shader
            "0959cb8822a344c4da890457e668fdc9",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Transparent_Tess.shader
            "6d115cf94d14d1842a56dfff76b57f42",  // Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Transparent_Tess_StencilOut.shader
            "f0b2fc9b8a189134da9c7d24f361caf4",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess.shader
            "8c94ee3046ef0574f87f6b658b4e4691",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess_StencilMask.shader
            "c4aed8662ca0f194284f3ab649e66d23",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess_StencilOut.shader
            "1f248db3b28fc5f44aabd7aca618bd1e",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess.shader
            "a3214384442742648aa664ef0039d397",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light.shader
            "3073cd2564e4cde45a19c05e0012d22a",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light_StencilMask.shader
            "7e7690a767a07da4f943439680e70db8",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light_StencilOut.shader
            "08c65988dc25d9f44b791fcc18fb543a",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_StencilMask.shader
            "f937ea4ce96dfbe448afc0fb671198e5",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_StencilOut.shader
            "3fb99ac3775edeb4aa9530db5a614c92",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess.shader
            "9855f226cd8152d4e99085272aceede6",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess_StencilMask.shader
            "2a0d4af863770404faee6488b86fe3c9",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess_StencilOut.shader
            "1847c44f729b68e49ba63610abdf9132",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_OutlineObject_Tess.shader
            "06cae78b869a3234bab02eeb52197e1c",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_OutlineObject_Tess_StencilOut.shader
            "3a1af221400a61a4b94bae19aa79da2b",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess.shader
            "a1449ab672051624ca3160737b630f5e",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_Light.shader
            "79d3dc54c32b69b42be17c48d33575f2",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_Light_StencilOut.shader
            "18c9172cdf36a344f9aca9bbc0e7002d",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_StencilOut.shader
            "54a94f776a43a074c8c2d205bb934005",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_TransClipping_Tess.shader
            "d496a1c70c797ad43836d5bfff575b5f",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_TransClipping_Tess_StencilOut.shader
            "183ea557143786346b1bfc862ad22636",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess.shader
            "356dd5af8f0d40e41b647d3d0a0555c1",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light.shader
            "ffadecfbd9e31f840ba4109fea0f0436",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light_StencilMask.shader
            "98ac5d198a471494da681b7b8d1e1727",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light_StencilOut.shader
            "0d799eb857c0e2c45bbdfb2c033d33e6",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_StencilMask.shader
            "e667137c8b6fd3d4390fc364b2e5c70b",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_StencilOut.shader
            "feba437d8ff93f745a78828529e9a272",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess.shader
            "8d1395a9f4bfad44d8fddd0f2af19b1e",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess_StencilMask.shader
            "08c6bb334aed21c4198cf46b71ebca2d",  // Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess_StencilOut.shader
            "6d04fc34e9717d34d9589f39decf8333",  // Assets/VketShaderPack/Toon/Shader/Tess/UCTS_DoubleShadeWithFeather_tess.cginc
            "c139664fde6401f45a09b0f32279484b",  // Assets/VketShaderPack/Toon/Shader/Tess/UCTS_Outline_Tess.cginc
            "ad7807131760d5544843d7424e535b75",  // Assets/VketShaderPack/Toon/Shader/Tess/UCTS_ShadingGradeMap_tess.cginc
            "6261ac20c5dfa024a98d6ce3921bab70",  // Assets/VketShaderPack/Toon/Shader/Tess/UCTS_ShadowCaster_Tess.cginc
            "13aee1e1f6c49d94fa292dca9910126e",  // Assets/VketShaderPack/Toon/Shader/Tess/UCTS_Tess.cginc
            "b8bbbd51c2e41dd4bbcb0da1b7a48808",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/LICENSE
            "4ebc920fe2745624bbed02e79a222e3d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/README.txt
            "b71e250f3c9f9a54cac228148bc800f7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_Common.cs
            "6b1a45934e0846141979f322772dc3b8",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_DebugViewEditor.cs
            "4f0275352c196ca4d864b6611897bfd7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_ShaderCustomEditor.cs
            "e3269783b9ab81e4f85d813345bc1a7e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_ShaderToolWindow.cs
            "13aceca36091c3546a994c8c02dcc168",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample.unity
            "c5782c4aad60a544caa7f5383e6a0b90",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/README.txt
            "06913336b6f92e04a84576e8f9afd6a9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Avatar_2A-7s.unity
            "befa386322319ee4587ded7eeba1c19a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornellBox.unity
            "7f71cab99cc077946b99cc04d93355ff",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/CameraRotation.anim
            "77eabe6dee64f244b8c92317eb5830c6",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/CameraRotation.controller
            "cf980f93a9a0e814e8260e4040df7ffc",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/Gem.fbx
            "58bdbcbbe65f69f48af5d965efb1e31c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/LightPivot.anim
            "4c54433c553541d45b13620b67509da5",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/LightPivot.controller
            "82c58dbbc5f31aa49ab2e0ebbd5328a1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/Plane.mat
            "799b0ea89036cc54ab56d421374e38ba",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/ppv_bloom.asset
            "dfa3d74db8de0af499aaa01fd0ea3d7e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/UpdateRealGI.cs
            "af5aea2243dd470499bd0bf866c0b9da",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/BlackGem.mat
            "0efac9871ef36134e8cb4e3e0e58e417",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/GrayGem.mat
            "d1543206c7f9ed343b13306b48245ca1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/LavenderGem.mat
            "182eea833aea07742bfa8fc0a4569886",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/PurpleGem.mat
            "6ac01d29450339841a15c26eba3d8f69",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/RedGem.mat
            "670fd4fcf34aac041a7e8e0371e823dd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/TurquoiseGem.mat
            "df3e5d3bc81bf6c46a04d49fc90e6ffe",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/WhiteGem.mat
            "9fc65c41a4b61824fa4ceab8da248ccd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/YellowAndBlueGem.mat
            "2d1676c3e8dbb8a4d881b86906f193c8",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Baked_2a7s_2ero_A.asset
            "3af6ea1e5e16d184da3ddb6d8c119940",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Baked_2a7s_2ero_A.prefab
            "1e28938dd4d2ace42bb692fb63fcb1cd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Baked_2a7s_2ero_B.asset
            "1aba99f0c3bc49e449f300e33ab4d65e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Baked_2a7s_2ero_B.prefab
            "84dfbffad7f596740917a1141ee43da2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/LightBlue.mat
            "2818ac500dfe28a4a85d13db74f5dcbe",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/LightWhite.mat
            "f7eefc425eaa92b4ebffefdbb614d3d9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/Metallic.mat
            "88355daa712318d4eae5fce35352e6dd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidGreen.mat
            "477ec3581917a6d4f8208e7033266223",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidRed.mat
            "3e5c4d6f454685c48af83064384632f6",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidWhite.mat
            "2f80c16eced9cb349a82cdbda5bd188d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidWhiteSmooth.mat
            "a8131972d52e03346bee8239f2411e6a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_armor(Clone)_asset2.mat
            "1429d632eff8a234c93a9b7fb5f5668a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_body(Clone)_asset0.mat
            "a73dfe133639fa84e8e7d782a6aa3b74",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_face(Clone)_asset4.mat
            "43fa3186550698f47a2b59113d4f7a6f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_faceoption(Clone)_asset5.mat
            "442460180ad002b41bb56108bbcfb4dd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_hair(Clone)_asset3.mat
            "262edb4e47175d548ba2702c87fce227",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_photon(Clone)_asset1.mat
            "ca4943be5b3769a489a1cda05ee74f4c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/Transparent.mat
            "2327c096edc905747aa18533af892a14",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornellBox/LightingData.asset
            "307cfcc30b8ff834a9dbb892877b8e12",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornellBox/Lightmap-0_comp_light.exr
            "77ea737153d8e4b4c90cb950dc010279",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornellBox/ReflectionProbe-0.exr
            "2bea43a9896c1de4ba6c734dd3841a1c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornellBox/ReflectionProbe-1.exr
            "0739262731db5a0478c1bbec35cedbe5",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornellBox/ReflectionProbe-2.exr
            "182cb5733aedff348b9a2f07799d130e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/2a7s_2ero_Avatar.prefab
            "389c6d7a40a8f9e4780b541dedda1d1a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/README.txt
            "15d9dbf5cbf00034cb8d86a1259469a3",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_AllShapes.anim
            "bc735c1fbb4e03f47b8f9c9cdb3c46e9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_amazed.anim
            "f87d81f82cc675d47985484d024fdd18",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_AutoBlink.anim
            "4a592603109b8214da0035b121e30cd2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_AutoBlink.controller
            "340faa19254b3c748a03fe92eb315dd9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_badsmile.anim
            "e16dc9fb4aa51014d8ad04405339a2c7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_battlemode.anim
            "c39959b49fe31fa4194981cf50b4bf77",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_sit.overrideController
            "07b354fca8089c444a948bd276683262",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_smile.anim
            "554ce4688f58f5748a13d70dcf18771a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_smile2.anim
            "c4979213951708648848ab54301cb2e9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_stand.overrideController
            "3e4677f38b648be41a369ff85cf58df5",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_surprise.anim
            "01b65e05c8d311c4c93f8769c13123b1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/2a72ero_wink.anim
            "80d01521a3ebf2640b0ff858fb8b4e13",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/IDLE_2a7.anim
            "a8b35788e93b1de4c9d5b9725a093640",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/move_back.anim
            "f549b1c776811c0458accc3efcc44eaa",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/move_front.anim
            "71edd79917f3a3f4c99e5c267cf4e144",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/move_Left.anim
            "a8b9b97c6ec1186488573f096fd2a23f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/move_Right.anim
            "d937351867d16274d94e7cf182cb5b36",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/SIT_2a7.anim
            "15317a9f823fb1340a061d070c9949ff",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/anim/編集用2A-7.controller
            "294a186fb5f0bdf49a1a11378bd8f4d9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/fbx/2a7s_2eroVRC.fbx
            "87becb86f20ba0e419af2c5c8a436ba4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_armor.mat
            "8b15ad46734538841955a43f514e9eeb",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_body.mat
            "1004a60cbe00f9c48b9a4416c792490f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_face.mat
            "c54ec1195bccfbd4a96cab6eda085d3a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_faceoption.mat
            "419055f2e83080543a4c34a4f539967e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_hair.mat
            "249b5835018dde04aa22f00a83f47552",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_photon.mat
            "6ad2bcf19007e9d48a7761cf7d060a33",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_armor.png
            "f8ac13ff4d61a2749b99f8679d818bd9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_armor_AMask.png
            "02e92c1301f7bd440973493d264648de",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_body.png
            "c7701c426ad72f74db46eab5968fd6ec",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_body_MMask.png
            "96d71c655cb43a0419db3c810507eee1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_body_Shade1.png
            "1f406f138ad08c740838a8ca3c5f4866",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_body_Shade2.png
            "0659339834cb17044be0508e9ffe6b67",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_body_ShadeBase.png
            "67a76e2e4360845439df1b5f7b74fa84",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_face.png
            "c4b124e9cad9e8a49ab86cde822a5723",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_faceoption.png
            "f6a48352392a79e4fb6bb2fe1dc3da35",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/2a7s_2ero_hair.png
            "932a27bc2fe7702429e2569679724d57",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/eff.png
            "5c9fbc5e0f4fbfb46ba31c3c08b9e326",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/eff_AMask.png
            "3d12ade8a7e64f84683bcdadff67bdfc",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/tex/eff_EMask.png
            "2a4dc116efeb0db4192f11f17d555b87",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/README.txt
            "c02ebf9b7a5d66c4ead5f94ef99b20c8",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWFロゴ_1024.png
            "54ed4f64546b23741987a94ff9769567",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWFロゴ_256.png
            "b8e19d3beb8c169458f9b150a00f40ec",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWFロゴ_512.png
            "81bd216f29ecf2f46b29029ec01f55a3",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/README.txt
            "2d055c29a461c2a45bc8cb64201404e9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_aft_lounge_1k_128.hdr
            "3f65007764dcb6e41bae49ab65119aec",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_aft_lounge_1k_32.hdr
            "c61e595423756a54498716afa385333c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_circus_arena_1k_128.hdr
            "05ff7cbb74648c2419d2eb2755729aca",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_circus_arena_1k_32.hdr
            "31abf9744b47ba14e8df52c79381e957",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_fireplace_1k_128.hdr
            "e30afce8ff8ab3740a49a6b92e879fa2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_fireplace_1k_32.hdr
            "aa3d86f47f6207547b6e68fc337052f4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_lythwood_lounge_1k_128.hdr
            "bb9610632e748424586247724588439e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_lythwood_lounge_1k_32.hdr
            "4beb010867cc3c74984010f8c168b973",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_lythwood_room_1k_128.hdr
            "80b684ec03e5e1c40943d9eb0e0d32f4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_lythwood_room_1k_32.hdr
            "37389f65764fa0241b75028c86fd22d3",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_museum_of_ethnography_1k_128.hdr
            "aae74124d783ccb40affc2a1983d4f1d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_museum_of_ethnography_1k_32.hdr
            "7e629b3699fb05a49987bde9eec6d9f6",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_royal_esplanade_1k_128.hdr
            "8715c6cd897127f46a46aa5123b5f1b8",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_royal_esplanade_1k_32.hdr
            "4df5f1b4f073ee94caf1e0ed00ace798",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_whale_skeleton_1k_128.hdr
            "1c33a09ae8a21af439ec9a61406c55b8",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_whale_skeleton_1k_32.hdr
            "55f94f02873c1bb4bb1f43eed973a999",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/README.txt
            "08bbac06846e8f147844273a67efe456",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_タイツ用_低デニール.png
            "613d42ca293473648ad045320c99d552",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_タイツ用_高デニール.png
            "179a7b2e065288849bcc911ef080bdc3",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_ラバー光沢1.png
            "090079d91337d09499c80aa2e2256d46",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_ラバー光沢2.png
            "08ab99404bfb3c0468c356d247a7190a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_ラバー光沢3.png
            "d6224555b7ba6d540ae3dfe0dde6f2c7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_光沢(フラット多).png
            "d13ca27834483ea48b672bb915b8dba1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_光沢(フラット少).png
            "c0605cdefe210b14abea15ce9fd3417f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_光沢(ポイント多).png
            "128fe33f130bcf64bbe54c19e96ec49a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_光沢(ポイント少).png
            "9ccc1ecb6ffb01b419fae6aba0dcf8de",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_光沢(大型フラット).png
            "42b40040be19b0d40b96071c8c90e864",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_光沢(大型ポイント).png
            "ad7caeb1ed0fce748acfd8a284820e23",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_照り返し.png
            "6158d64813ee5cc43bc3078670c9e5f2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色白向け(桃).png
            "88c0b9178c875ee488073e573092f4c2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色白向け(白).png
            "e56d0d9a30210464cac0f0efa479ede6",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色白向け(赤).png
            "591b5e30a15d11e49ab61536fb547dcf",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色白向け(黄).png
            "e911f7cd3f4d7d74ab20fa3a09a731ee",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色黒向け(桃).png
            "c42959027d59ab841bdfca20a88e4e0d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色黒向け(白).png
            "17b0ab315388e0f46ba4c0a85d64ac7f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色黒向け(赤).png
            "bb8a3f515ded7fb4fb14d017fa3fb77f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_美肌効果_色黒向け(黄).png
            "ce16c6abbeafbd44ead076da94cfbea9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_虹色光沢(多).png
            "1420cb12f3399a14087808ecf127b252",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_虹色光沢(大型).png
            "6a6ff8276159f0e458f9d30d4507f0ad",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_虹色光沢(少).png
            "c46c03a2561c862429e057772da5354d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_髪用_エンジェルリング(紫).png
            "5db2aaf0a68c706458a44b6ebb8284d7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_髪用_エンジェルリング(緑).png
            "7ca36260c2ddb0945a87c7bc666203cf",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_髪用_エンジェルリング(赤).png
            "e19fae3455aa0924aaddc7bc3e2892dd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_髪用_エンジェルリング(青).png
            "31eccd9da5305c1468ee523f9da69323",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_髪用_エンジェルリング(黄).png
            "29cc22470c914a14bae0039fb4bf4d2a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/LightCap/lcap_WF_髪用_エンジェルリング.png
            "f1134c41d474f1d4788962d9e17cf81b",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_タイツ用_低デニール.png
            "f4dc102937e1110478b0185ed60ab0b1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_タイツ用_高デニール.png
            "8797e28fe1f8d2c459bc986a84755baf",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_シンプル影(半球).png
            "04c7c759eb6253846bab498b29ad5882",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_シンプル影.png
            "b697412ceb9d5274d95ee0347afbdbf7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_シンプル影・左右Rim.png
            "c7b09e8f29efaf34c8cba706ce178111",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_シンプル影・青反射.png
            "558b69af68dc78943b14fdc787eb120d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_光沢(Rimあり).png
            "5b8f370a659d3704d9c3e15a1bfa4f90",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_光沢(Rimあり明るめ).png
            "e1436203ff040b94b873ed59bcab6678",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_光沢(白エナメル・虹).png
            "6f4ac56faaf1d2a43a30414b1d679726",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_光沢(黒エナメル・白).png
            "9363ce1a6bde55e4fa7399d25c7743e9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_光沢(黒エナメル・赤).png
            "609254253550b214f914ce959ebb6d30",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_光沢(黒エナメル・青).png
            "b7f123b5ea2244a4aaba5d042dc00507",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_肌用_褐色_Rimあり光沢弱.png
            "39203179d751754459e2c90b0376e622",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_肌用_褐色_光沢強.png
            "e70581dcea3866e4cb251bb4be0a1739",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_肌用_褐色ぬるてか_光沢あり体用.png
            "0e5bc9a3816fa3d459ad7d38ea598ea3",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_肌用_褐色ぬるてか_光沢あり体用・淡色.png
            "a695e50ea627f7f41b2848b6de359f15",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_肌用_褐色ぬるてか_光沢あり体用・無彩色.png
            "98fe32a79800f6c4688ab111d9c49ba1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_肌用_褐色ぬるてか_光沢なし顔用.png
            "bdb8b77b018e1c04fa2df61b75411cdd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_肌用_褐色ぬるてか_光沢なし顔用・淡色.png
            "5f34a1197ebe183419d78c107bc6e9db",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_金属光沢(黄).png
            "282f8caa209b5d1488f17f966e5a89b3",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_階調影(白).png
            "f85649441a33f9144b15a40a0360c44e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_階調影(赤).png
            "4fabf7d0aa4e95d49b52276367df77b6",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_階調影(青).png
            "26e957bfcb2a91548868cd8d6142d158",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_階調影.png
            "f85432be963532143861e9167b7be9e2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_髪用_エンジェルリング(紫).png
            "c07ebf31730a9bb44bd0c487b696f1fd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_髪用_エンジェルリング(緑).png
            "071ceeffe98b2f049b10e7f02c90c430",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_髪用_エンジェルリング(赤).png
            "7a67adccf40eee149ac090548db5450d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_髪用_エンジェルリング(青).png
            "9acc4c651a02a2c4da47ac7380c7913f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_髪用_エンジェルリング(黄).png
            "ec18245b47abdb448ab5355d170aa59c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影あり_髪用_エンジェルリング.png
            "3446e1de8c0404b428b75ad8a6e87eba",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_光沢(フラット多).png
            "86dccb1fc7795f846a525a8308ee4e54",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_光沢(フラット少).png
            "5b14fa6fceeea4049ba1068eae680fbe",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_光沢(ポイント多).png
            "42aefa086f04a0c4da493cba5f967800",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_光沢(ポイント少).png
            "47c49f8937cce8349b0e0117bdfa74aa",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_光沢(大型フラット).png
            "51a89fb06dc78e44ab0109350d417f91",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_光沢(大型ポイント).png
            "63c7cbccd5cbe6e4c9cbcb0161cb3ef4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_照り返し+光沢(ポイント少).png
            "26851ace9fa99da41a7ff293022395b5",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_照り返し.png
            "b2df000ec11e0e14cb19f772ccb7e6ae",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_肌用_照り返し+光沢(フラッシュ多).png
            "32edf483debd1cd4d836b921d5f84947",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_肌用_照り返し+光沢(フラッシュ少).png
            "8d0efbd5c578c744cbe63d7555965650",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_肌用_照り返し+光沢(大型ポイント).png
            "957f1365028d90946921443d6f5b620f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_肌用_照り返し.png
            "783503ba129c3f54da129007334ca2f2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_肌用_褐色ぬるてか.png
            "2c2a5c30c8ddb3748af2d01f1a170636",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_肌用_褐色ぬるてか_光沢なし.png
            "8f8b55f4812cf3049afc082c5423314e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_虹色光沢(多).png
            "439ee1d7a7da3ff4298b7f19d47074be",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_虹色光沢(大型).png
            "95b371241f4109f49bcfdf908bbfb8a5",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_虹色光沢(少).png
            "255a7e166f0b12a488ea9aa33e3e6dc1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_髪用_エンジェルリング(紫).png
            "3b905a61940627747a08286346fd6098",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_髪用_エンジェルリング(緑).png
            "9a12e63cf5c120644a4963b56353fdee",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_髪用_エンジェルリング(赤).png
            "cd35ff0b3c632c94eaa80cc0273c1d1d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_髪用_エンジェルリング(青).png
            "a5659966a921b7c49a5679b70e631df1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_髪用_エンジェルリング(黄).png
            "0089774353388424d8f87a85c5dd84b2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_影なし_髪用_エンジェルリング.png
            "daef60d7bbc3c9c44a3e80ffe828922d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_水着の光沢_白.png
            "361575d1412309749b8ea179be01f36a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_水着の光沢_青.png
            "cf126589fa05d1346aa939a9565ada80",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色白向け(桃).png
            "f4ff8e51f9e7cf14db04dcc841c5d4ec",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色白向け(白).png
            "b200b5f176f4401439b00ff94e252daf",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色白向け(赤).png
            "945d9c80ea372574fa01168c71306c9a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色白向け(黄).png
            "fd06b399266ff8c44aa5446fc64c74f3",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色黒向け(桃).png
            "05e94f0d1c6880c4182364d36e85e517",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色黒向け(白).png
            "6639c74cf5cfa504787962e571f7368f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色黒向け(赤).png
            "3d3742b7c46abf441a975a99aa5ce800",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/MedianCap/mcap_WF_美肌効果_色黒向け(黄).png
            "0c90f262b70f7634ea0fb53f2912f537",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_ランダム(粗)_1024.png
            "02127e119f3a2504987f0798bfcf1746",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_ランダム(細)_1024.png
            "a441101aa83065349939cbc597424ce4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_凹凸(粗)_1024.png
            "441fc4840e1fdb9438db8ff0e4bda024",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_凹凸(細)_1024.png
            "f89fef9173c00fa4198dc8a319cf21d5",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_平布1_1024.png
            "ab368b9cd1215154d94cbe2142e3c109",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_平布2_1024.png
            "47e74ccc09bb85d4c9e273e09f183fcd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_斑(粗)_1024.png
            "45c7c44b162f6f64aba19a594b3e9bd9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_斑(細)_1024.png
            "0297ab7e9e4a80e4e9bc70a13cc7987b",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_編布(粗)_1024.png
            "202d4cf5665abdc4ca30ed29f524e886",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/noise_編布(細)_1024.png
            "bbf41367697302d4eb03deed8d94c784",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_ランダム(粗)_1024.png
            "c7928488b21f3484391f5060e004cc29",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_ランダム(細)_1024.png
            "5f156cb39cc17004e953ef176689a79c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_凹凸(粗)_1024.png
            "ba587353da6c721418c7a2b4bd4cd7bf",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_凹凸(細)_1024.png
            "ac6eb3c6294756149a288c2f7f5574c2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_平布1_1024.png
            "7153dfc6361998e498d2f7e91713a218",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_平布2_1024.png
            "385ca7e21b743ff44b3cda515ea10c3b",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_斑(粗)_1024.png
            "32013e17de26e81429e188422fa26495",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_斑(細)_1024.png
            "98e490be901bd7c479e60aa479d210f7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_編布(粗)_1024.png
            "813ee6eb54e3e3642a0bac40a9e806e2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise素材/normal_編布(細)_1024.png
            "c7e5995223250464cac205689e058693",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_DebugView.shader
            "58bb80b63bec29d4384e105c53ca6970",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_FakeFur_TransCutout.shader
            "2210f95a2274e9d4faf8a14dac933fdb",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_FakeFur_Transparent.shader
            "c0f75d3ed420fd144a74722588d3bc21",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_Gem_Opaque.shader
            "21f6eaa1dd1f25c4cb29a42c4ff5d98f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_Gem_Transparent.shader
            "4ba701b07ccc81e4aae7f053bf332eab",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_GhostTransparent.shader
            "871fd7a51a8ea3e4980c3fe7b8347619",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_PowerCap_Outline_Opaque.shader
            "58ccf9c912b226146a25726b8a1f04db",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_Tess_PowerCap_Opaque.shader
            "4bd76f6599a5b8e4d88d81300fb74c37",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_Opaque.shader
            "af3422dc9372a89449a9f44d409d9714",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_TransCutout.shader
            "0a7a6cdca16a38548a5d81aca8d4e3ba",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_Transparent.shader
            "4e4be4aab63a2bd4fbcea2390ae92fdf",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_TransparentOverlay.shader
            "a3678756e883b9349ac22fce33313139",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Opaque.shader
            "a5ae7f40ac53e274ea0bc1262e1f6895",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Opaque.shader
            "ab4eb87c406a22f46887cf72178e2685",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_TransCutout.shader
            "5523e041d29d259439fa14bd131f5c82",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent.shader
            "5498b01615002d948bea7542f55e0c07",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent3Pass.shader
            "9350854c6e88f3f4eb873d2f94ff3328",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent_MaskOut.shader
            "ad88000744b4fb241835ba6ec106caf4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent_MaskOut_Blend.shader
            "0733cfc88032e8d4eafce250263c497c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Opaque.shader
            "2cf66b0706c40744baab089297afa895",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_TransCutout.shader
            "747bf283d686334469fb662b2fc4a5c2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Transparent.shader
            "d242cb83664caae4f957030870dd801d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Transparent3Pass.shader
            "dd3a683002b3a6f43bdb6c97bd0985c1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Opaque.shader
            "94ee7f8988740fd4887f8b1ce41f0c1c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_TransCutout.shader
            "3bde56820d1aece41bd22966876a061c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Transparent.shader
            "78d2e3fa0b8eb674aa9cf9e048f79c93",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Transparent3Pass.shader
            "8c7888a4ac175584f81e0b6e7d4af5a7",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TransCutout.shader
            "15212414cba0c7a4aac92d94a4ae8750",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent.shader
            "d1e7b0a18e221a1409ad59065ec157e4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent3Pass.shader
            "2efe527cfcbf0e1408b67463225f552f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_Mask.shader
            "0b53cf0bcd0f9db4fa9d1297d255d06d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_MaskOut.shader
            "d01a5c313ada49e488b2ef8c6b00f56d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_MaskOut_Blend.shader
            "0380b1621ab524c43aeb10eba3346ea6",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Common.cginc
            "ef1a901a2feeb0a45859ecc184e2e3e2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_FakeFur.cginc
            "45af0d16a1af0a947b445e08dd6dead4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Gem.cginc
            "22546fe6fb0bed84e8db3fc80b0b2302",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon.cginc
            "8e439fa11883d4b429904a7fc398851e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Function.cginc
            "074195645f64a224d9482cb666563c89",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Meta.cginc
            "bf91baf439ae72542bd718eb51378f5a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_PowerCap.cginc
            "ad9922cd501663b4cbfbef594d1b22d0",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_ShadowCaster.cginc
            "95ae3c73098e55148862b3125c46785e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Tessellation.cginc
            "261cdf12e5bca1442958cf95a815b493",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Color.shader
            "805db4766a215044da0cb3847cc05d75",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_ColorFade.shader
            "1b0e8ee3ccd31b4439fd21a0b74b5bcb",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Simple.shader
            "fe2d6dc08f1694b4fb5aca4b85419b93",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Texture.shader
            "5b4c1a20adb795441b90d80f2b581d7b",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_TransCutout.shader
            "c14d7f0d267c3e64ba2ba8c749bcab04",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Transparent.shader
            "c640751026d34764b90f5027359d888a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Transparent3Pass.shader
            "46dd63f81fc0acb468f42b4248c47d49",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Transparent_Mask.shader
            "c7f33aeb1c9a2994598fcf89d5a3360c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Transparent_MaskOut.shader
            "1ecd76a113e16a443a90ad5932729a36",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/Unlit_WF_MatcapShadows_Transparent_MaskOut_Blend.shader
            "eb442eb4a8a9b8b4e938199b39363da4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Old/WF_MatcapShadows.cginc
            "8020a337ceab108438d088a3482a4b90",  // Assets/VketShaderPack/VRMShaders/CHANGELOG.md
            "00999fd020bde754ab4ae5f8a5205844",  // Assets/VketShaderPack/VRMShaders/LICENSE.md
            "0905ad83e0b774444bcc48ac9a191d51",  // Assets/VketShaderPack/VRMShaders/package.json
            "4918a8517e721c5429d0f8033ae065c7",  // Assets/VketShaderPack/VRMShaders/README.md
            "21fb6bf38127a35498543f81ba8cc2e2",  // Assets/VketShaderPack/VRMShaders/Documentation/VRMShaders.md
            "bc66ece0f33b52446a0830c05781d4db",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Editor/ShaderProperty.Editor.asmdef
            "5eb12c186c6337e4db278b5f01d47cae",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Editor/ShaderPropMenu.cs
            "50935dd2f9f3fa445a687f30d4dd663b",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/PreShaderPropExporter.cs
            "301b251fd9834274c9228e0532f444f7",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/ShaderProperty.Runtime.asmdef
            "279964035c950b24cb745511298855dd",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/ShaderProps.cs
            "90dcef1978c51e74386b76d77689dc82",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/GLTF/PreExportShaders_GLTF.cs
            "54043e349b047bf4b8f127cd919a757d",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/GLTF/Standard.cs
            "ad4b6b115b83ecd48a513f697afc95f0",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/GLTF/UniGLTF_UniUnlit.cs
            "4f91421c5846d5d48933d2ee4ffeeceb",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Color.cs
            "8273e1e61ad8e914baae94d06836f2ad",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Texture.cs
            "b98a8ee8ca13abb43809305cc4e5571a",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Transparent.cs
            "844490f13976543478d82efe28251941",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Transparent_Cutout.cs
            "625b5ee8b5811dc4a915a2fbb2cb319d",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/VRM/PreExportShaders_VRM.cs
            "4629d794c8969c141a4724e182af082e",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/VRM/VRM_MToon.cs
            "611b546ea471ad34cb7d94740c63b558",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitCutout.cs
            "22a8083880389b3498f421e6a5c340d5",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitTexture.cs
            "140d6538826e0eb448929d3e4bb2f1cd",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitTransparent.cs
            "165ec79b7aac1564a850fb3d3d19396e",  // Assets/VketShaderPack/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitTransparentZWrite.cs
            "60c8346e00a8ddd4cafc5a02eceeec57",  // Assets/VketShaderPack/VRMShaders/UniUnlit/UniUnlit.asmdef
            "529ce3a240c1a7a4bbbb220bbd59686b",  // Assets/VketShaderPack/VRMShaders/UniUnlit/Editor/UniUnlit.Editor.asmdef
            "4c70714358bb2fb4fa96ef08640763fd",  // Assets/VketShaderPack/VRMShaders/UniUnlit/Editor/UniUnlitEditor.cs
            "8c17b56f4bf084c47872edcb95237e4a",  // Assets/VketShaderPack/VRMShaders/UniUnlit/Resources/UniUnlit.shader
            "e96cbbd810384352a6799dd731533178",  // Assets/VketShaderPack/VRMShaders/UniUnlit/Scripts/Utils.cs
            "0c23e5908bcdfaf498f03fc626fe8a46",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/LICENSE
            "86d4b790f390cce47810844e4b4a93d0",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/README.md
            "5686e1cbe30779e4cb12a3cfebd04af4",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0 _ Carbon Fiber.mat
            "80add08b1b71e974cb7445f615a6d45f",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0 _ StippledHalftone.mat
            "072ae31b0e1564b4eb95e3b4437e7d1d",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0.mat
            "56bf125c9c397154ab9ee5a017746a85",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/XSGradientEditor.cs
            "e89d2df0d1b52e4448cda16d9d6eed7d",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/XSMultiGradient.cs
            "0e1d31a0eef7c5644832cbcbfc92e7d5",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/XSReimportMyShadersPlease.cs
            "dee482cbfe1d3634ab799af2c78502f0",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/XSStyles.cs
            "263ae1c7b2037ed4fbf02e938e8bceb4",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/XSTextureMerger.cs
            "005c83a3d97ccf040bdbfacbf03b42dc",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/XSToonInspector.cs
            "65e344abcde5260468f0010b4c73a2fa",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/XSUpdater.cs
            "be9c15115645ef049adaf17bee497ab7",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Editor/Resources/MultiGradient_Object_Ico.png
            "d7083d96cb8a0da48beb300faaf2e125",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSDefines.cginc
            "f7d2bc5531da1c44aa6e753eb1c8636f",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSFrag.cginc
            "4bc0681c9b92ff74ba271d2b561e56cf",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSGeom.cginc
            "3007b66203f38424caffb4c058879c59",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSHelperFunctions.cginc
            "b34fd1827e9b4974db3ee215e80ce465",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSLighting.cginc
            "59e9937e913f34b4c9335c6f6b288c78",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSLightingFunctions.cginc
            "5b58e93d18a5b6e4cb9b99f377f4a994",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSShadowCaster.cginc
            "3e944a29d3c4a044a8bfc8d73ed46f60",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/CGIncludes/XSVert.cginc
            "1f506dc0051cf3f45a07f5b7f3ec7cac",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Plugins/WireframeOverride/CGInc/XSGeom.cginc
            "6732df5575ce46d40a726c4b1fd1f922",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Plugins/WireframeOverride/Shaders/XSToon2.0_WireframeOverride.shader
            "52a12016c80b7754bb152e61e099587e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Plugins/WireframeOverride/Shaders/XSToon2.0_WireframeOverride_A2C.shader
            "e5fbf2c44c61cdb4a9f113a0995b488f",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 Cutout.shader
            "cb3736c178a4f40499e187552b389d4a",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 CutoutA2C Outlined.shader
            "2eb687a5a03872c4aac5ed4518bfcac2",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 CutoutA2C.shader
            "a22455601ad4cc4469967733ddbef64e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 CutoutA2CMasked.shader
            "1cd7a3c6dcaa5a149be88450dc7b72a6",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 Dithered Outlined.shader
            "00c5c2cffb09f62419ee035e43cb1027",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 Dithered.shader
            "dd611dd59dfd3ea4da520b5007f4b549",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 Fade.shader
            "956a7ff9ce5a1cf4c8735b173dfac4bc",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 Outlined.shader
            "62a1e86cebad79d4395e32051831724e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 Transparent RecieveShadowsFromUnderneath.shader
            "ade84c4423293ed47b5a99a571e4d80c",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0 Transparent.shader
            "85c615217d617204cb497ae6838b8bae",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToon2.0.shader
            "39f23e8c24d1e864096d29da0407b88e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Main/Shaders/XSToonStenciler.shader
            "f66d026b6ceed614ba4e5242c17e59b5",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/AO/TriaxialWeave_AO.png
            "40ea18bf7298bd3428adcd1737d4b66e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/CubeMaps/glass_passage_1k.hdr
            "efb6603dbbc0ab040848d6b6e2d2091e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/CubeMaps/short_tunnel_1k.hdr
            "dab1297d5c0a834408f49a7365015920",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/CubeMaps/XSStudio_3Light.exr
            "efc14fb6a410a27428a516b78b346c33",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/CubeMaps/XSStudio_SkyLight.exr
            "8a16b055fdf67054aaea56d1907f39b7",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/CubeMaps/XSStudio_SoftUnder_3Mid.exr
            "6707d30b9abd3e244b6bb7b3797b013b",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Metal/Anistropic Metal.jpg
            "4303d29ccd156034d9950aa050a59f3c",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Metal/ArtisticMetal.exr
            "0ab1477629f706a45bb7b99bbf97e33f",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Metal/FireLitMetal.exr
            "f740bde6462de5e4b96b07daeeefbff8",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Metal/LightSteel.jpg
            "2aee663d3fa347b49b73df5d27cef38e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Metal/MetalAF.exr
            "2eb97550e316c3347831faf08ac6bb64",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Metal/MetallicPurpleGreen.exr
            "79db10ff60487f748a5cd3f0065d7400",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Metal/MetallicRegPurple.png
            "da32fe84b577f0246adf3b4ecc490b69",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Skin/DeepSkintone.exr
            "1e82fa48fd9295540ab46a89ea403a8f",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Skin/LightSkin.exr
            "0818273a570e4084a9f9d258b34ae2c2",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Skin/LightSkin2.exr
            "afa6fb48b4cd0bf48a20623477e78f85",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Skin/Skin.exr
            "5fb787fb7dd30d849837c095d7bf8e01",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Unique/Amber.exr
            "1273e32827ed4f04f9516dbbcd0ac25d",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Unique/BlueRedBacklit.exr
            "2cbdf1f25b78eba409fca976ed98e531",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Unique/Default.exr
            "6b28500662c4f1f48a8661ed99c56a2e",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Unique/Lightbulb.exr
            "3335747e6d5447b49b52f863baaaa7dc",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Unique/Normals.exr
            "420d03330b808f34b8f3f2c0b1c77dfb",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Unique/Painting.jpg
            "eb13dbc9c89b8424c8f21eabee6af2c4",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Matcap/Unique/resin.exr
            "0c540c5cf863ea743b3091ace3a20e07",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Normal Maps/CrossWeave_N.png
            "24055b3e737e1c949ac98a1f42b42f02",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Normal Maps/TriaxialTint.png
            "1632d2058ed6e554cae477f5a18dbcd6",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Normal Maps/TriaxialWeave_N.png
            "c907c0321c6c65741942d4b98c578003",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Shadow Ramps/Generated/gray to white.png
            "a49de73e4c2486943b4fd591c1607441",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Shadow Ramps/Generated/redgradient.png
            "564b27c878c5df04f86d017bb6f75452",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Shadow Ramps/Generated/skingradient.png
            "12043050a25113c4099c34d2a3ae1eb4",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Shadow Ramps/Generated/skingradient2.png
            "1ee69b57a0cfcc24c8fb898e84d8a84f",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Shadow Ramps/Generated/smoothcutoff black to white.png
            "833058007f71b1b42b6d2a052121d494",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Shadow Ramps/MGPresets/Example_MultiGradient.asset
            "cf6c1f21161d44548a43bcd566b5bbd0",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Specular Patterns/Abstract1.png
            "2d494ba3ef3a48e43abe4ae435602b78",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Specular Patterns/Brushed Map.tif
            "6e3ab83cce46dee44b40d0ea5202fce8",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Specular Patterns/Skulls.png
            "a9d899b9b5f746b4cbf7ec49e7b32ccd",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/Textures/Specular Patterns/SpecLines.png

            #endregion

            #region JQPrefabs modified from VketPrefabs

            "0a3bb9a84f4ecbc40b9c12b014f0acae", // Assets/VketAssets
            "b67e5dc5409a2f94ebd14cb850183442", // Assets/VketAssets/Assets
            "1a187ce2a03f5a04b9a173995f1e94e1", // Assets/VketAssets/Assets/VketPrefabs
            "ebc8de035ba5d6c419b38c68f06d18b8", // Assets/VketAssets/Assets/VketPrefabs/LICENSE.txt
            "8ac885989b081be499135bd5e73437ce", // Assets/VketAssets/Assets/VketPrefabs/version.txt
            "2cef855be269a5041bd6424f34d5d2e6", // Assets/VketAssets/Assets/VketPrefabs/GlobalToggleSwitch
            "436d4106716e99d4e9c21e3dd9d7e530", // Assets/VketAssets/Assets/VketPrefabs/GlobalToggleSwitch/GlobalToggleSwitch.prefab
            "468cbe82543e8904db53bfb4bc9dd486", // Assets/VketAssets/Assets/VketPrefabs/GlobalToggleSwitch/Scripts
            "152b3a102d06d434f8ba45039e85ece6", // Assets/VketAssets/Assets/VketPrefabs/GlobalToggleSwitch/Scripts/0cc6d2302397dd346ae57ebfbe42c093.asset
            "0cc6d2302397dd346ae57ebfbe42c093", // Assets/VketAssets/Assets/VketPrefabs/GlobalToggleSwitch/Scripts/GlobalToggleSwitch Udon C# Program Asset.asset
            "04ff02e9bf22d8e4faa3576505b32365", // Assets/VketAssets/Assets/VketPrefabs/GlobalToggleSwitch/Scripts/GlobalToggleSwitch.cs
            "699bb906a2680d843976e70a2e8985fe", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets
            "18f86e14c5fc1d449af4e983f73d9007", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Materials
            "0de3ccc1017c4a045a4fed5f810c2748", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Materials/UI-Lookat.mat
            "5841bbdcae9c57f4ea1443288f957f74", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts
            "31bd08cb1c9908742ab7ced575f28811", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/VketUdonControl.cs
            "0d6e3005839bc1c4cae808158c97aeb3", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/Editor
            "e125af3ba7da62a41aefb41197b4d195", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/Editor/AssemblyBuilder.cs
            "672a8dec0156e614f9de64ffecd0ac01", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/Editor/DictionaryExtension.cs
            "96557f785ce40c0469ee40407efc4ac1", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/Editor/TriggerParameters.cs
            "1056f83269d9ee04eaf9b0a0db30fbd4", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/Editor/VketInteractProgramAsset.cs
            "c00c2e468a7ad97489ae83db8c039100", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/Editor/VketOnBoothProgramAsset.cs
            "9da245cf3d6f1ab4c98ba350e3dc81a9", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Scripts/Editor/VketTriggerProgramAsset.cs
            "1ddef018c4f68b7488b6438e6977ea6d", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Shaders
            "d35acdd70bdcab445bbbd6deac832a3b", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Shaders/UI-Lookat.shader
            "d43c1117bf2a7ab4ca23ca95a551820f", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Textures
            "834f21d704cafe3498f4d2ecc38dc5ea", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Textures/Background.png
            "86487b9f4f81a774a9c49d53278c76cf", // Assets/VketAssets/Assets/VketPrefabs/PrefabAssets/Textures/Button.png
            "e515f930fbcf3ae4aa7a7512815db1e5", // Assets/VketAssets/Assets/VketPrefabs/UITemplate
            "3c0dbec26839f9b4ea24f9606ec62ce4", // Assets/VketAssets/Assets/VketPrefabs/UITemplate/UI_Button.prefab
            "b4625b5c33c27804d889d16704b81c33", // Assets/VketAssets/Assets/VketPrefabs/UITemplate/UI_Image.prefab
            "4dc5396d6e370ef4fa9b9e9458c3f735", // Assets/VketAssets/Assets/VketPrefabs/UITemplate/UI_Text.prefab
            "333992c7f0890014d9a775e3f2303857", // Assets/VketAssets/Assets/VketPrefabs/UITemplate/UI_TextMeshPro.prefab
            "cf213802368d4ff429b58b392a452fc2", // Assets/VketAssets/Assets/VketPrefabs/UITemplate/FontAssets
            "f22d22ce133301c46b2a5a5458e9c996", // Assets/VketAssets/Assets/VketPrefabs/UITemplate/FontAssets/Mplus1-Regular Dynamic.asset
            "ee8fcaf4777106c4a86f7d8e7aebbb42", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal
            "da2f193786576d041aa8d2e860314c22", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_2D.prefab
            "9fffe84a94533884eaf481963546643d", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_3D.prefab
            "1e0f83d3ba1d83045866a6a4dc2e8e83", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_Default.prefab
            "08a895a51ff9b3c45be74940b81f05f9", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations
            "0294f3138a383d44188238141e43a0d2", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Active_2D.anim
            "8ecf1c1367fda5c45b707eaaf1e6e300", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Active_3D.anim
            "826602674183e284685c8212ca89f3ca", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/AvatarPedestal_2D.controller
            "2f0b20cb1dadf3c498b1272896dd3ba5", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/AvatarPedestal_3D.controller
            "cc64c7910ebf50249bc5cfdc65ba4729", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Deactive_2D.anim
            "68bbad9fbab0708449c847419d62a17e", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Deactive_3D.anim
            "6b468349f6cba0248a76b7d33570fbad", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Idle_2D.anim
            "8d5e148b91b24cf4dae7e22e010f7603", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Idle_3D.anim
            "cf07f0e4c426cd141911a052ae670aee", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Open_2D.anim
            "c48a0e2b59d493b4f9f9a865b1471676", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Animations/Open_3D.anim
            "9fb20cd60ad7bec4782e52c3ac311738", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Scripts
            "7fdd6e0e6a66ddb40afafdfe7cbc0e89", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Scripts/62a7876d06fb1d645ab6cb81d87d0a3a.asset
            "62a7876d06fb1d645ab6cb81d87d0a3a", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Scripts/VketAvatarPedestal.asset
            "ebe3df2ed38fdfd479e2fce1c5403a74", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Scripts/VketAvatarPedestal.cs
            "c987c27975b75e64eaa6dd84168906a3", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Textures
            "62f7352a395147043809a2d315af37ae", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Textures/Change Avatar.png
            "96c692c63aeba764081c1e04790fd3f1", // Assets/VketAssets/Assets/VketPrefabs/VketAvatarPedestal/Textures/Sample.png
            "5ac9f39638df52044b725b513fc0e11a", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher
            "8c011f4ab9cc45c4aaddb76bbd8003c5", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/VketLanguageSwitcher.prefab
            "f289fe42f440aa04ab6797a3e1fd2642", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/Scripts
            "3692e13500377f04380bd63d295d7fbc", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/Scripts/26e911c1e4e64964ea73100994e7c984.asset
            "26e911c1e4e64964ea73100994e7c984", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/Scripts/VketLanguageSwitcher.asset
            "450cb8826e2f672478ba0b27310dd446", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/Scripts/VketLanguageSwitcher.cs
            "85534e65bb042a643b9ff8e26325ab72", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/Textures
            "7f697f0a5403d864a9240a9f0d1e83e4", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/Textures/SwitchToEnglish.png
            "1e87d7c02aa11184aab67f6998f6a03b", // Assets/VketAssets/Assets/VketPrefabs/VketLanguageSwitcher/Textures/SwitchToJapanese.png
            "8a11129d17e25624c8ece24ff47896d3", // Assets/VketAssets/Assets/VketPrefabs/VketPickup
            "6d1e9170d4533ed448e46b707a3ee47a", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/VketPickup.prefab
            "417e75772e4b8704483abcecd86a9bb4", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Animations
            "6893d5acfbed8d544856d8eb7cc11133", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Animations/AnimationOverrideEmpty.overrideController
            "3ffeb968a1d1ed244b45c026bb22f30b", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Animations/ModeController.controller
            "be21e07eff32d7e4fbbf7babfed27d88", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Animations/PickupAnimation.fbx
            "5448010b1d4c3764db76a21b128b4976", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Scripts
            "22cb79620122c3046a9d91c51d720baa", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Scripts/ab981b08fcfada8458fc2ec950e16e17.asset
            "7683222f972ff444c910f4920ce600dd", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Scripts/fc11049e6474c5e47bc42f47d1a8efca.asset
            "ab981b08fcfada8458fc2ec950e16e17", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Scripts/VketFollowPickup.asset
            "57498a849a57d5e44bb3fea02cfabbad", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Scripts/VketFollowPickup.cs
            "fc11049e6474c5e47bc42f47d1a8efca", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Scripts/VketPickup.asset
            "b5d9b5598ab43f64e8aca7422be14f5c", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/Scripts/VketPickup.cs

            #endregion
        };

        public static string[] MaterialGUIDs = new string[]
        {
            "852b1a8f6b8cf714ab105ed0b009020c",  // Assets/VitDeck/Templates/07_UC/SharedAssets/FloorGrid(07_UC).mat
            "43952b04c671c85499219a62eb939303",  // Assets/VitDeck/Templates/07_UC/SharedAssets/SampleBooth(07_UC).mat
            "262f8e55a8b27584092f4aef6a6ee290",  // Assets/VitDeck/Templates/07_UC/SharedAssets/Skybox(07_UC).mat

            "0de3ccc1017c4a045a4fed5f810c2748",  // Assets/VketAssets/Prefabs/AvatarPedestal/Materials/UI-Lookat.mat
            "0bfe6778f100206489baf9dbd0c24646",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/avatar1-helloweenmqo_服_AlbedoTransparency.mat
            "88581c9aef71ea549b2f133599cb89bf",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mat1.mat
            "88728f426bf72d74b9abd9ceb8ecbd2c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 1.mat
            "112ba1c1df66b5e47b93c5c355fb8e69",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 10.mat
            "27f323571b8327e409c9b9669fb84d93",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 11.mat
            "7d4ac9335e1cc82488a383bd849a380c",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 12.mat
            "eb0465484fd24bd458c85ad5c6554747",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 2.mat
            "d6390657f902d1142a20b5cc7f92ffe2",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 3.mat
            "119d5edced9d6bf469181f8497c65731",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 4.mat
            "2f2236791569d124eb4b48f19730cb06",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 5.mat
            "f651c02bf9fdac1408c87c0e4f6cdd2b",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 6.mat
            "345659f361c837b4cab35176f8c8d671",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 7.mat
            "57338689439fb4a4fa1a42ebf3816059",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 8.mat
            "86c25d309b5f3114ab3f949d7655aea3",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 9.mat
            "a2d8565e76f62d14e9c149040f122c19",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material.mat
            "a87e62033b0ad4848838ebcf5f89858f",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/violin.mat
            "b407561bc3f21de4c8808646f3a719ca",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/Walls.mat
            "5ebfcc9cd374c614dba1f903f8de36ba",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/cloth/Cloth.mat
            "130e4ea006e957749a3e19016c5b918a",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/EmissiveFreakMaterial 1.mat
            "6182e5d390ecba149a1f8d75312e956e",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/EmissiveFreakMaterial.mat
            "4329612c3238cc44091f699ba05da324",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin/mannequin1.mat
            "5cdca66777e3963468a57b44e76b86c4",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin/mannequin2.mat
            "63000287678da044197a3ff745d75c25",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-knit/mannequin-knit.mat
            "c2c262af144c1b042adc2954103f4e22",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin-green-metal.mat
            "e9bfebf98ae9cae45b922038482fc4da",  // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin-steel.mat
            "497f8485774204244abb7ba6c0865927",  // Assets/VketShaderPack/Mochie/Unity/Prefabs/Default.mat
            "4f42a26097c877b40a7616aa60580c43",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ex_OutlineWidth_Screen.mat
            "e40a129e14e378c4db040df3fd4a6077",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ex_OutlineWidth_World.mat
            "54da18ba3126f1343924588562df72e0",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ground.mat
            "9639e17dffc656345a70282f7f216672",  // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Toon.mat
            "721cd36de640a974ca45b613e85cd800",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 1.mat
            "4b8608d176dcf934585ec1b6886e05e4",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 2.mat
            "d469e28ac045d044fb9cb2226a7c9c72",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample.mat
            "af8197deebc61ce459480bd679aa6abc",  // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample_SCSS.mat
            "82c58dbbc5f31aa49ab2e0ebbd5328a1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/Plane.mat
            "af5aea2243dd470499bd0bf866c0b9da",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/BlackGem.mat
            "0efac9871ef36134e8cb4e3e0e58e417",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/GrayGem.mat
            "d1543206c7f9ed343b13306b48245ca1",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/LavenderGem.mat
            "182eea833aea07742bfa8fc0a4569886",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/PurpleGem.mat
            "6ac01d29450339841a15c26eba3d8f69",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/RedGem.mat
            "670fd4fcf34aac041a7e8e0371e823dd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/TurquoiseGem.mat
            "df3e5d3bc81bf6c46a04d49fc90e6ffe",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/WhiteGem.mat
            "9fc65c41a4b61824fa4ceab8da248ccd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/YellowAndBlueGem.mat
            "84dfbffad7f596740917a1141ee43da2",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/LightBlue.mat
            "2818ac500dfe28a4a85d13db74f5dcbe",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/LightWhite.mat
            "f7eefc425eaa92b4ebffefdbb614d3d9",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/Metallic.mat
            "88355daa712318d4eae5fce35352e6dd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidGreen.mat
            "477ec3581917a6d4f8208e7033266223",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidRed.mat
            "3e5c4d6f454685c48af83064384632f6",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidWhite.mat
            "2f80c16eced9cb349a82cdbda5bd188d",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidWhiteSmooth.mat
            "a8131972d52e03346bee8239f2411e6a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_armor(Clone)_asset2.mat
            "1429d632eff8a234c93a9b7fb5f5668a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_body(Clone)_asset0.mat
            "a73dfe133639fa84e8e7d782a6aa3b74",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_face(Clone)_asset4.mat
            "43fa3186550698f47a2b59113d4f7a6f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_faceoption(Clone)_asset5.mat
            "442460180ad002b41bb56108bbcfb4dd",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_hair(Clone)_asset3.mat
            "262edb4e47175d548ba2702c87fce227",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_photon(Clone)_asset1.mat
            "ca4943be5b3769a489a1cda05ee74f4c",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/Transparent.mat
            "87becb86f20ba0e419af2c5c8a436ba4",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_armor.mat
            "8b15ad46734538841955a43f514e9eeb",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_body.mat
            "1004a60cbe00f9c48b9a4416c792490f",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_face.mat
            "c54ec1195bccfbd4a96cab6eda085d3a",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_faceoption.mat
            "419055f2e83080543a4c34a4f539967e",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_hair.mat
            "249b5835018dde04aa22f00a83f47552",  // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_photon.mat
            "5686e1cbe30779e4cb12a3cfebd04af4",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0 _ Carbon Fiber.mat
            "80add08b1b71e974cb7445f615a6d45f",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0 _ StippledHalftone.mat
            "072ae31b0e1564b4eb95e3b4437e7d1d",  // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0.mat
        };

        public static string[] PickupObjectSyncPrefabGUIDs = new string[]
        {
            "6d1e9170d4533ed448e46b707a3ee47a", // Assets/VketAssets/Assets/VketPrefabs/VketPickup/VketPickup.prefab
        };

        public static string[] AvatarPedestalPrefabGUIDs = new string[]
        {
            "59261512e4100df488de6ddd9b530829",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_L.prefab
            "3e6652d46d6d66d4092650094b064987",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_M.prefab
            "87a721a2eb0c25643a5eb305781dc3a8",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_S.prefab
            "104b8771f1874de40bf91473c2afb5ec",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_L.prefab
            "2cdd22b46ff13f2409e7dd60e077eed7",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_M.prefab
            "045501f8edaa2e748857c6c17a96b2f1",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_S.prefab
            "d7a2d6aa4218cdd45854cd81900deba6",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_L.prefab
            "8134e8c0ab5943a479b31c509f2325fb",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_M.prefab
            "fb107661b9b479d4fa95452f7fd46426",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_S.prefab
        };

        public static string[] UdonBehaviourPrefabGUIDs = new string[]
        {
            "304812fb2352c7c419581d8f68b23f94",  // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/PickupObjectSync.prefab
            "59261512e4100df488de6ddd9b530829",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_L.prefab
            "3e6652d46d6d66d4092650094b064987",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_M.prefab
            "87a721a2eb0c25643a5eb305781dc3a8",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_S.prefab
            "104b8771f1874de40bf91473c2afb5ec",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_L.prefab
            "2cdd22b46ff13f2409e7dd60e077eed7",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_M.prefab
            "045501f8edaa2e748857c6c17a96b2f1",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_S.prefab
            "d7a2d6aa4218cdd45854cd81900deba6",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_L.prefab
            "8134e8c0ab5943a479b31c509f2325fb",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_M.prefab
            "fb107661b9b479d4fa95452f7fd46426",  // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_S.prefab
            "63af405779b7d6d44b64d709fb3fbdd7",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_L.prefab
            "ae8b674ab5516664ea5d5c535f5fbc6a",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_M.prefab
            "405b6beaa9b7b9947b9111840f170452",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_S.prefab
            "139aa3624bf91214dabb39362ccf4382",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_L.prefab
            "4cb05397779ec7a48818e05b68c26960",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_M.prefab
            "a4471dc2b540f9e46a5e36fe66ede5e9",  // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_S.prefab
        };

        public static string[] SizeIgnorePrefabGUIDs = new string[]
        {
            "e6d5c31911ec7404e8b613767bc9c944",  // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/WorldBGMFade.prefab
        };


        public static string[] AudioSourcePrefabGUIDs = new string[]
        {
        };

        public static string[] CanvasPrefabGUIDs = new string[]
        {
        };

        public static string[] PointLightProbeGUIDs = new string[]
        {
        };

        public static string[] VRCSDKPrefabGUIDs = new string[]
        {

            #region VRCSDK

            "2cdbe2e71e2c46e48951c13df254e5b1",  // Assets/VRCSDK/version.txt
            "820ee6e459999be418b410c7af108bc3",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll
            "17e2ad8740ce0ab4eb1a95a73e362865",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll.mdb
            "aecaffc7454b52e448fc0ea1aef2dd1d",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll
            "027e8b8acf565544d9050219e1521b7e",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll.mdb
            "d4055bfc0cd67d642a7eceaf547c4901",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll
            "0da239ac72288814a9c4b799c7674b25",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll.mdb
            "625a50dd0dd525a49a41cb3e3117fa15",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll
            "b93a9778ddf074845b1649181fda7e86",  // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll.mdb
            "34b0990e1522a284b9666d6821cd601c",  // Assets/VRCSDK/Dependencies/DotZLib/DotZLib.dll
            "b609c54f9d3581e4fa22b3e389fd8d33",  // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86/zlibwapi.dll
            "54f59547b5261e64f8256d6daaa01b17",  // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86_64/zlibwapi.dll
            "a2e4b2ce02fa7914895069e5fdbf112d",  // Assets/VRCSDK/Dependencies/librsync/Blake2Sharp.dll
            "912b2ac597cb1ad4c9bdc1a98ec15459",  // Assets/VRCSDK/Dependencies/librsync/librsync.net.dll
            "cb850b86de9091d4db4595959c56f954",  // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Editor/ONSPAudioSourceEditor.cs
            "e503ea6418d27594caa33b93cac1b06a",  // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPAudioSource.cs
            "ad074644ff568a14187a3690cfbd7534",  // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPSettings.cs
            "5a8cc42eaba7a2a41b6ca3be3c40b315",  // Assets/VRCSDK/Dependencies/SharpZipLib/ICSharpCode.SharpZipLib.dll
            "d471b09e7f06a69458457ec63d3532b8",  // Assets/VRCSDK/Dependencies/VRChat/Settings.asset
            "10d9f721d76e07a47bc9e5f61e2fae72",  // Assets/VRCSDK/Dependencies/VRChat/Editor/EnvConfig.cs
            "c3399613f583f3e46b2df27ae87dd5d6",  // Assets/VRCSDK/Dependencies/VRChat/Editor/HDRColorFixerUtility.cs
            "7b8bb626428d0f341b9ed6a68cb5c9cc",  // Assets/VRCSDK/Dependencies/VRChat/Editor/SDKUpdater.cs
            "679ba0056bf110c4db8b550082e73a5f",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderKeywordsUtility.cs
            "4a9696f3dea8a764f9c4bc6d2e652b74",  // Assets/VRCSDK/Dependencies/VRChat/Editor/VRCCachedWWW.cs
            "cb5d1f9882b08564cae97b2b14ad4e8f",  // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_EditorTools.cs
            "f4cf5dd705ab67149afaba40b4a8fa7e",  // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_SdkSplashScreen.cs
            "3d6a1d7b0624f414ba6fb922687a06da",  // Assets/VRCSDK/Dependencies/VRChat/Editor/AWS/S3Manager.cs
            "21332e1f0d937794d916d2402ba1943a",  // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/VRC.SDKBase.Editor.BuildPipeline.asmdef
            "0a1d20f4241085e46bdddc71b691465b",  // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/Samples/VRCSDKBuildRequestedCallbackSample.cs
            "39cdf3092ab81be4b9e623cb5a8819d8",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/ApiCacheEditor.cs
            "0a364ece829b6234888c59987a305a00",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/AutoAddSpatialAudioComponents.cs
            "89005ebc9543e0a4284893c09ca19b1d",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorCoroutine.cs
            "3d6c2e367eaa9564ebf6267ec163cfbd",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorHandling.cs
            "4810e652e8242384c834320970702290",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EventHandlerEditor.cs
            "482185bf29f12074dada194ffef6a682",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/OldTriggerEditors.cs
            "5e83254bb97e84795ac882692ae124ba",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCAvatarDescriptorEditor.cs
            "26a75599848adb449b7aceed5090e35c",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSpawnEditor.cs
            "ed4aad2698d3b62408e69b57c7748791",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSyncEditor.cs
            "8986a640e24a0754ea0aded12234b808",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModEditorWindow.cs
            "792e7964a56e51f4188e1221751642e9",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModsEditor.cs
            "5262a02c32e41e047bdfdfc3b63db8ff",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerStationEditor.cs
            "e9cbc493bbbc443fb92898aa84d221ec",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCSceneDescriptorEditor.cs
            "eeda995d0ceac6443a54716996eab52e",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_AvatarVariationsEditor.cs
            "0ac7998a36f085844847acbc046d4e27",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DataStorageEditor.cs
            "3b63b118c0591b548ba1797e6be4292e",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DestructibleStandardEditor.cs
            "e19a7147a2386554a8e4d6e414f190a2",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_ObjectSyncEditor.cs
            "4aff4e5c0d600c845b29d7b8b7965d68",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PickupEditor.cs
            "5c545625e0bf93045ac1c5864141c5c1",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PlayerAudioOverrideEditor.cs
            "0d2d4cba733f5eb4ba170368e67710d2",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SpatialAudioSourceEditor.cs
            "ae0e74693b7899f47bd98864f94b9311",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoPlayerEditor.cs
            "3f9dccfed0b072f49a307b3f20a7e768",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoStreamEditor.cs
            "3aecd666943878944a811acb9db2ace7",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_TriggerEditor.cs
            "d09b36020f697be4d9a0f5a6a48cfa83",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_WebPanelEditor.cs
            "764e26c1ca28e2e45a30c778c1955a47",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_YouTubeSyncEditor.cs
            "d57b23c04034119448f23c5fdbc57662",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCDestructibleUdonEditor.cs
            "8901d07a685ca424492a3cabff506184",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCPlayerStationEditor3.cs
            "4b2b9ac625bc5b04c887ff9ee9b5fdbe",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCSceneDescriptorEditor3.cs
            "a8cc4c1876b26174fbaeb062178a6bda",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_PickupEditor3.cs
            "3f8f999a8e1ebee4588f94a8a618d7c6",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_SpatialAudioSourceEditor3.cs
            "310a760e312f2984e85eece367bab19a",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/IVRCSdkControlPanelBuilder.cs
            "20b4cdbdda9655947aab6f8f2c90690f",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanel.cs
            "5066cd5c1cc208143a1253cac821714a",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelAccount.cs
            "4c73e735ee0380241b186a8993fa56bf",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilder.cs
            "c768b42ca9a2f2b48afeb1fa03d5e1bf",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilderAttribute.cs
            "c7333cdb3df19724b84b4a1b05093fe0",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelContent.cs
            "f3507a74e4b8cfd469afac127fa5f4e5",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelHelp.cs
            "8357b9b7ef2416946ae86f465a64c0e0",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelSettings.cs
            "f2a720a30f1043247af7742fdfd0b8e5",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelWorldBuilder.cs
            "93710d221addc0243ba90dd20369844b",  // Assets/VRCSDK/Dependencies/VRChat/Editor/SDK3Compatibility/VRCSdk3Analysis.cs
            "c18570190ea21fa4babc80af77d4d766",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/StripPostProcessing.cs
            "b1e8486f7c7c81a4ea45be9776971082",  // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/VRC.SDKBase.Editor.ShaderStripping.asmdef
            "62d40cc4e8f8494695f0102c58b3ea60",  // Assets/VRCSDK/Dependencies/VRChat/Editor/Validation/Performance/SDKPerformanceDisplay.cs
            "da07ab9b78cb0432e95e11e2cb619ea7",  // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.mat
            "94b649c2bd1ac4cac95049605dc5333d",  // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.renderTexture
            "2166f6bbfce69594fad494087eca58e8",  // Assets/VRCSDK/Dependencies/VRChat/Materials/damageGrey.mat
            "e13e96301b7c8214dac6883be5b82bfa",  // Assets/VRCSDK/Dependencies/VRChat/Models/damageSphere.fbx
            "841c3ce718e8b61408005c1cfce6b7de",  // Assets/VRCSDK/Dependencies/VRChat/Models/Materials/lambert2.mat
            "4acdf7b3eb426480bb5acf58638bd493",  // Assets/VRCSDK/Dependencies/VRChat/Resources/awsconfig.xml
            "dd5614b710e774040ab715161f7dfaca",  // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.customizations.json
            "37b4abef7420c4c7ea71dbe76757498a",  // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.json
            "be98467dc5d3c4eb1aeef22952913b0e",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCCam.prefab
            "dce0dda226bd1f147a34f9b4660f5992",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCProjectSettings.prefab
            "b14e1b78a061f8543b2f4120b5c369fa",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKAvatar.prefab
            "248f850c58993ed43bcaad6b934b7c92",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader.png
            "551946bfd2b165f419f297805d1e1256",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader_Oculus_Quest.png
            "d2244637721b4f3458280ffc1f9dd7cc",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkClDialogNewIcon.png
            "38956f4b67ba0984587b1a913d05beea",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeader.png
            "ff7f4f4963793a340bde459bc9975c07",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeaderWithCommunityLabs.png
            "1d151b29d1d1c704daa27e4921e39129",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon1.png
            "8458230047d35d4498b2de453f2cabda",  // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon2.png
            "fc887d4eeb5a941ed86bca0135b05e2b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKWorld.prefab
            "e8e780ff40c6a484294bfec8711ced23",  // Assets/VRCSDK/Dependencies/VRChat/Resources/VRC_PlayerVisualDamage.prefab
            "43066d8a73c579048891e3c123e252a0",  // Assets/VRCSDK/Dependencies/VRChat/Resources/2FAIcons/SDK_Warning_Triangle_icon.png
            "f310c3dbad3125d4e8fc2e00bdc2acb4",  // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/CL_Lab_Icon_256.png
            "36349feed06587e479724a1a09c0b267",  // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/Icon_New.png
            "4109d4977ddfb6548b458318e220ac70",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Good_32.png
            "644caf5607820c7418cf0d248b12f33b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Great_32.png
            "2886eb1248200a94d9eaec82336fbbad",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Horrible_32.png
            "9296abd40c7c1934cb668aae07b41c69",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Medium_32.png
            "e561d0406779ab948b7f155498d101ee",  // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Poor_32.png
            "8ae6e7ea5b8982143aa8c2c4e2fe81c6",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AnimatorPerformanceScanner.asset
            "c2ca835e9f95b464b8a2df5c181ba44e",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AudioPerformanceScanner.asset
            "d162a2d08d890e644b79b605f1d1120e",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ClothPerformanceScanner.asset
            "371dfb95b91b4684eb1ad68d37d81ac9",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/DynamicBonePerformanceScanner.asset
            "69c7115984bf82e46af96d6f144fe463",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LightPerformanceScanner.asset
            "07199be0cf1b2a34f8dff60d486129ea",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LineRendererPerformanceScanner.asset
            "e750aae2c41768e4485dfb9a6de00454",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/MeshPerformanceScanner.asset
            "f4004220746a95a4e84a3909a49d844b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ParticlePerformanceScanner.asset
            "18ec5f6f963b6774fa1b84c5bff0246f",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/PhysicsPerformanceScanner.asset
            "986c284df70b4c34dad7e5ef27a86156",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/TrailRendererPerformanceScanner.asset
            "bf50321b92d503d4a823939356ce856d",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Quest.asset
            "b0d7b483809dd6441bb36507c9f64040",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Windows.asset
            "f0f530dea3891c04e8ab37831627e702",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/AvatarPerformanceStatLevels_Quest.asset
            "e750436d0bab192489da0debe67ee879",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Excellent_Quest.asset
            "b25db21b17fba3d49a7248568fdb9870",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Good_Quest.asset
            "31feb7417182a80469408649071d10ac",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Medium_Quest.asset
            "171503e8193e15447967be1e3ca1e714",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Poor_Quest.asset
            "438f83f183e95f740877d4c22ed91af2",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/AvatarPerformanceStatLevels_Windows.asset
            "88c46902276e7624e8adda9020bef28b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Excellent_Windows.asset
            "38957d57ab5a7f145b954d20fc24b1d4",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Good_Windows.asset
            "65edaefdc2f87414594559cb89383b5b",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Medium_Windows.asset
            "595049d4e162571489f2437524d98a31",  // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Poor_Windows.asset
            "36c0d886a26373c46be857f2fc441071",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/ApiFileHelper.cs
            "acadc6659c5ab3446ad0d5de2563f95f",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/AudioManagerSettings.cs
            "8d047eaa3325d654aa62ccad6f73eb93",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/CommunityLabsConstants.cs
            "e1c693656bf5d584b87df969efeb5536",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/ContentUploadedDialog.cs
            "a3132e0ab7e16494a9d492087a1ca447",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeAPICreation.cs
            "1e5ebf65c5dceeb4c909aa7812bd2999",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeBlueprintCreation.cs
            "2bd5ee5d69ee0f3449bf2f81fcb7f4e3",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeWorldCreation.cs
            "0d49300ad532d4ae6b569b28de5b7dac",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/SceneSaver.cs
            "10121679f780956408f9a434a526f553",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/MaterialFallback/FallbackMaterialCache.cs
            "bef0a8d1d2c547119a62b7d7a5c512ea",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ShaderValidation.cs
            "8a90ec11b51863c4cb2d8a8cee31c2fb",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ValidationUtils.cs
            "9b03724cd556cb047b2da80492ea28a5",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/WorldValidation.cs
            "15ecac6f7fdc1bc4fb723fee6f4635dd",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformance.cs
            "f1ce994297384ff1bc330196df61b7ca",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformanceCategory.cs
            "f28c978154794266b38d686139c6b872",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/MeshUtils.cs
            "8cdca9d06d1b4732b9ccb82a38bb8d9c",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceFilterSet.cs
            "a5ed7498cb1a46c78eab031f5f32448c",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceInfoDisplayLevel.cs
            "5019a55ee9e2404c81bc61a39a010d8d",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceRating.cs
            "4afb61f36d144fc381114cd7f78d13e7",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceScannerSet.cs
            "abda65e062e44213aa3e1f4c82b400a8",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Filters/AbstractPerformanceFilter.cs
            "0bd0691a021844f49444a04a959d6328",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AbstractPerformanceScanner.cs
            "08c8e931d0544866a0f626855d9c1841",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AnimatorPerformanceScanner.cs
            "b3a8bba736414d1aaa9e766da27b56b5",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AudioPerformanceScanner.cs
            "0cec88b5a46f459195f10a2f11fddb2f",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ClothPerformanceScanner.cs
            "a226df494ef04404a9a47c714822ab9f",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/DynamicBonePerformanceScanner.cs
            "405778fdc32c44c1bb9fdd0476fb0007",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LightPerformanceScanner.cs
            "ec87392b85844f7bb526a48ec866a8f0",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LineRendererPerformanceScanner.cs
            "38bca10261df4ddfa10cff3b3bbb9428",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/MeshPerformanceScanner.cs
            "10723e354ff14f98a49ab797b3f005e6",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ParticlePerformanceScanner.cs
            "6a94ecdeecd04f85824cc3244be5712a",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/PhysicsPerformanceScanner.cs
            "2efd714b564547b4be1ebd1f2700668b",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/TrailRendererPerformanceScanner.cs
            "1bf4fb79a49d4b109c4dce6b38e5548e",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStats.cs
            "f742c36dce5730f4d96e37d82c330584",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevel.cs
            "468554b1bfc447f41a20a2f5bae65d16",  // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevelSet.cs
            "9ae7399f0cf902a41a20f3487af8322a",  // Assets/VRCSDK/Dependencies/VRChat/SdkGraphics/SDK_Panel_Banner.png
            "13d3efffb839ced4c8426a88a0c3e98c",  // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGreyNoAlpha.png
            "8d95767408d35544c98f92ef7279b8db",  // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGRNoAlpha.png
            "861bc2dd35aa1534d89330ffa4434b61",  // Assets/VRCSDK/Dependencies/VRChat/Textures/VRChatBanner.png
            "3bb6d22e89000724b90fb830af69384b",  // Assets/VRCSDK/Plugins/sqlite3.dll
            "4ecd63eff847044b68db9453ce219299",  // Assets/VRCSDK/Plugins/VRCCore-Editor.dll
            "b0e1c0f72d838fe49bfe88b987a471bd",  // Assets/VRCSDK/Plugins/VRCCore-Standalone.dll
            "215be632cb025bd429dd50a3fa942168",  // Assets/VRCSDK/Plugins/VRCSDK3-Editor.dll
            "661092b4961be7145bfbe56e1e62337b",  // Assets/VRCSDK/Plugins/VRCSDK3.dll
            "d09383607271b19468447945fda29e86",  // Assets/VRCSDK/Plugins/VRCSDK3Base-Editor.dll
            "bdccfb093344e7545a49b72a64499682",  // Assets/VRCSDK/Plugins/VRCSDK3Base.dll
            "dc5cab6c932db3247aab9f50c5f3bd5f",  // Assets/VRCSDK/Plugins/VRCSDKBase-Editor.dll
            "db48663b319a020429e3b1265f97aff1",  // Assets/VRCSDK/Plugins/VRCSDKBase.dll

            #endregion

            #region Udon

            "45115577ef41a5b4ca741ed302693907",  // Assets/Udon/UdonBehaviour.cs
            "530bdb25a3862ff4c8be42f678c53527",  // Assets/Udon/UdonManager.cs
            "473737f63e15e204aa3a3df7a3a173e3",  // Assets/Udon/version.txt
            "3c1bc1267eab5884ebe7f232c09ee0d9",  // Assets/Udon/VRC.Udon.asmdef
            "84de2da7fe8ad8e439c084731189bc12",  // Assets/Udon/Editor/UdonBehaviourEditor.cs
            "66ebdaa27f6d2d54cbb62abddc493674",  // Assets/Udon/Editor/UdonEditorManager.cs
            "627c4d5cd580ddf41bd320e784fe8b9d",  // Assets/Udon/Editor/VRC.Udon.Editor.asmdef
            "8b6535096cfa29340897276abbdd015f",  // Assets/Udon/Editor/External/VRC.Udon.Compiler.dll
            "585dd63e377866248b16bdba915820ed",  // Assets/Udon/Editor/External/VRC.Udon.EditorBindings.dll
            "b335798a4f28bec40ba9b3d4a15acee7",  // Assets/Udon/Editor/External/VRC.Udon.Graph.dll
            "21dcba1a47cc8c84381629950b692129",  // Assets/Udon/Editor/External/VRC.Udon.UAssembly.dll
            "161140ecae894b84ba7bdd6e44ff4371",  // Assets/Udon/Editor/External/VRC.Udon.VRCGraphModules.dll
            "19cff77330d183441a69ff6c69e07629",  // Assets/Udon/Editor/External/VRC.Udon.VRCTypeResolverModules.dll
            "cac80b40f57c41d4b941dc5059271583",  // Assets/Udon/Editor/GraphModules/VRCInstantiateNodeRegistry.cs
            "e1b5b45f24b268b42826fc5c5497dc15",  // Assets/Udon/Editor/ProgramSources/SerializedUdonProgramAssetEditor.cs
            "0e5ced9511d591140b191bbd9e948e61",  // Assets/Udon/Editor/ProgramSources/Attributes/UdonProgramSourceNewMenuAttribute.cs
            "22203902d63dec94194fefc3e155c43b",  // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAsset.cs
            "3df823f3ab561fc43bcb81286e14b91d",  // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetEditor.cs
            "3c0638314c289c24193b47d1c53c9fca",  // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetImporter.cs
            "4f11136daadff0b44ac2278a314682ab",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAsset.cs
            "31d6811854f59254aa1a263a8d566eb2",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAssetEditor.cs
            "57422d3fdb0cc124189c68f87b7157cd",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/UdonGraphExtensions.cs
            "e2f2300f99ce0ea4a8d9a20b464384df",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/TypeExtension.cs
            "9214873dab0ea8a4b91861cd5a04dae3",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraph.cs
            "f166d8f1c152ef34899019ab9a4fd0f2",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphElementData.cs
            "54dd824c6c614b94183d92710efe4f5f",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphStatus.cs
            "87e2044d3bcb715499ac68cc7380a9ed",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphViewSettings.cs
            "c6f017dc2674fec4da54a57b2655a948",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphWindow.cs
            "5dcd92112af21784ba5bf6383abab768",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterField.cs
            "70616b8b964e3664780fc03f65f27f4f",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterProperty.cs
            "fddc146e8502d7b49a294b6264d66dfd",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonProgramSourceView.cs
            "e5786fc577943ae45953c6f54c97116b",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonWelcomeView.cs
            "aabdd863f82551d40bd3a1b0835d2fc3",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/VideoPlayerElement.cs
            "469db50616185d04e8a46dcd75db12d2",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/GraphElementExtension.cs
            "f4f0ade55ae13b6468a765826f1f2540",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonArrayInspector.cs
            "7e5916b8dd19e4445a9156a457b82ee4",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonComment.cs
            "ba3ecc4c46929404d8c2ec920743b823",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGraphElement.cs
            "1b8045222a10ce04b815642b9cd5ca17",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGroup.cs
            "b006d67642298f04e895b6709ef12429",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonMinimap.cs
            "dcd657bc1dcf357448d27bcfa8c5dc36",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonNode.cs
            "8f83d1d3578dd28498c71a980bca86dd",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonPort.cs
            "c5cfbbfcd7bb5ad4487f1f9388a3a168",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonStackNode.cs
            "2d0a4730c5f61b247b27b54f280300b5",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonVariablesBlackboard.cs
            "6581176c97993bb40976acff208bd0b1",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFocusedSearchWindow.cs
            "b721120e6c1d320448a55fe87a7de824",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFullSearchWindow.cs
            "e94c084f399869b42a21244fd07778c4",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonPortSearchWindow.cs
            "6a6c453fae11b5349a33399e258d1578",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonRegistrySearchWindow.cs
            "e5a10bb1987c27944bd08a88119b2844",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchManager.cs
            "d825ed3ba6aa7f14294e73efefc217d0",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchWindowBase.cs
            "16fc7a7a059deeb458fdcdf719b467a4",  // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonVariableTypeWindow.cs
            "264ec3c8a1d423f42a144da0df6c5ebe",  // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAsset.cs
            "41d70977fa7936441afe41442f1862b2",  // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAssetEditor.cs
            "9e84f8ee45862f04ca6b9f8d5c7f5897",  // Assets/Udon/Editor/Resources/CornerResize.png
            "632470b93f35ec64ab6e3efd639c986c",  // Assets/Udon/Editor/Resources/DarkButtonBG.png
            "d4ca7f47895ab36408e28f4f742fba99",  // Assets/Udon/Editor/Resources/DropdownBG.png
            "f43fd332539599c47b3bb05ea38d5d0d",  // Assets/Udon/Editor/Resources/ToolbarBG.png
            "5cbfe49b858635b44844a178cb934b68",  // Assets/Udon/Editor/Resources/ToolbarButtonBG.png
            "7dade49b2f58f734f8db0983d8e7fb60",  // Assets/Udon/Editor/Resources/UdonChangelog.uxml
            "927841c571a405846b3442bc0aa56220",  // Assets/Udon/Editor/Resources/UdonFlowSlot.png
            "3803fec4c7b065042891595e749524cc",  // Assets/Udon/Editor/Resources/UdonFlowSlotFilled.png
            "7c75c00422f12124faed19bfb8dd96df",  // Assets/Udon/Editor/Resources/UdonFlowSlotFilledLight.png
            "610088fc92e5fc64b8c7f9e9c51f2939",  // Assets/Udon/Editor/Resources/UdonFlowSlotLight.png
            "d47fd176596dfbe4e9e78964b40c93ee",  // Assets/Udon/Editor/Resources/UdonGraphNeonStyle.uss
            "815baa9989198624aa5fec5ecdb42bd0",  // Assets/Udon/Editor/Resources/UdonGraphStyle.uss
            "0e2cfcbd717e75441b108d3ad9de2d29",  // Assets/Udon/Editor/Resources/UdonLogo.png
            "8cf68553c5a4bb140a6341072891aa88",  // Assets/Udon/Editor/Resources/UdonLogoAlpha.png
            "d0608d33a4043b2499adb1fee18f2a64",  // Assets/Udon/Editor/Resources/UdonLogoAlphaWhite.png
            "17102758d03099542afc7a1808745eaf",  // Assets/Udon/Editor/Resources/UdonNodeAccent.png
            "c0230adfeb2abe242b8d64c7e3bd2adc",  // Assets/Udon/Editor/Resources/UdonNodeActiveBackground.png
            "8289cc16393cd3040a9920e71bfe10bc",  // Assets/Udon/Editor/Resources/UdonNodeActiveBackgroundLight.png
            "f47842ead2f80fa46ab6e5bbde409193",  // Assets/Udon/Editor/Resources/UdonNodeBackground.png
            "c9235631e37566447ae4567624755326",  // Assets/Udon/Editor/Resources/UdonNodeBackgroundLight.png
            "2d2675a75fea1d2438859bdb320d544d",  // Assets/Udon/Editor/Resources/UdonNodeInlay.png
            "12f29a8be9fc52640b40f6ffa59336c6",  // Assets/Udon/Editor/Resources/UdonNodeInlayLight.png
            "1ed47570201e1854d9e455e38eecbcf7",  // Assets/Udon/Editor/Resources/UdonSettings.uxml
            "91b7c8d7d899ec04e9568e9385aba34d",  // Assets/Udon/Editor/Resources/UdonSlot.png
            "3a1ab76e09365f14cab0665b40da8843",  // Assets/Udon/Editor/Resources/UdonSlotFilled.png
            "add07ab72e2fc3d4d81143ab77d121f5",  // Assets/Udon/Editor/Resources/UdonSlotFilledLight.png
            "1badb339ed4f23541b6db8a9420aeea9",  // Assets/Udon/Editor/Resources/UdonSlotLight.png
            "37bd184e5e9b13945840f70329f2e0f6",  // Assets/Udon/Editor/Resources/videoStill.png
            "c041fa712f66a5d4f8525cd447dc8b29",  // Assets/Udon/Editor/TypeResolvers/UdonBehaviourTypeResolver.cs
            "02e7e7f5f9fc2c24ab3af0b8780f3623",  // Assets/Udon/Editor/UnityEditorTests/UICompilerTests.cs
            "3c3c5a3876474c648a47177c1875f447",  // Assets/Udon/Editor/UnityEditorTests/UnityEditorTests.asmdef
            "80455fb15755bfd47b1803c8fe84e16e",  // Assets/Udon/External/VRC.Udon.ClientBindings.dll
            "a5e7b2f5005f10e44b082e7c18871cc6",  // Assets/Udon/External/VRC.Udon.Common.dll
            "9d86dc4a513809149af3856eab191a3d",  // Assets/Udon/External/VRC.Udon.Security.dll
            "ecb1eec40b5e47047891ee46e739186a",  // Assets/Udon/External/VRC.Udon.VM.dll
            "92886df353bf1f14489cf2c4578e58af",  // Assets/Udon/External/VRC.Udon.VRCWrapperModules.dll
            "a3a3dda899277cc4ea6aebe18c6b5736",  // Assets/Udon/External/VRC.Udon.Wrapper.dll
            "bf61d954ecb803046953c666facfb904",  // Assets/Udon/ProgramSources/SerializedUdonProgramAsset.cs
            "2fad63ba312d5f44a8ab215c3f5b18f1",  // Assets/Udon/ProgramSources/Abstract/AbstractSerializedUdonProgramAsset.cs
            "7fa64b2d7df72fb4cbf7898a400e86ef",  // Assets/Udon/ProgramSources/Abstract/AbstractUdonProgramSource.cs
            "b1d0b8aa8084bcd44a572d524d7a31bb",  // Assets/Udon/Serialization/Formatters/UdonGameObjectComponentReferenceFormatter.cs
            "f2626352b2a60eb41adc3580ae44c750",  // Assets/Udon/Serialization/Formatters/UdonProgramFormatter.cs
            "ec4e6da38017fe7df076afceb30fa17c",  // Assets/Udon/Serialization/OdinSerializer/LICENSE
            "2105a6c0e5c0955d2d4a704c5e9c9b8f",  // Assets/Udon/Serialization/OdinSerializer/Version.txt
            "f70a94b0bedfa8ec50ed757f72032810",  // Assets/Udon/Serialization/OdinSerializer/VRC.Udon.Serialization.OdinSerializer.asmdef
            "bfaf18dca1f68cc99ebeb0b862179265",  // Assets/Udon/Serialization/OdinSerializer/Config/GlobalSerializationConfig.cs
            "4ac1e1612275111bd50db8a3de8ba9c4",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReader.cs
            "501a7e1356f5fdc8e9bbefcd61a56490",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReaderWriter.cs
            "9638b18c6b6b6532b3b3cd3a73fefc2a",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataWriter.cs
            "dc1fe25e670cf981ed66b3e85c3e4249",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataReader.cs
            "af6696e41807b3c3f9a1d73667f76701",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataWriter.cs
            "ee0465a1838833eb878447b34339d4f4",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataReader.cs
            "1bc9e2503afdd0290574ebc14cf4a16d",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataWriter.cs
            "1361420bc2b384389a065fd2fe59fb22",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryEntryType.cs
            "7a3a6dce9e0b8317b3804b35f48f6a97",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonConfig.cs
            "2ecc39ef0dc55ec10f83bb7eefd4f1db",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataReader.cs
            "3e05b98a26be61fa9203d4a45bfc1e95",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataWriter.cs
            "aad0a34e801ae645b359e4800ef7f636",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonTextReader.cs
            "6a0f5e01b82ae0763f6f907157a2c9c8",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNode.cs
            "eab5938e837a8de93ce64c25399edde6",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReader.cs
            "9321fb650525f4bed18119d187111569",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReaderWriterConfig.cs
            "dd54f07c359d141095a031192c5ca084",  // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataWriter.cs
            "0bdecd79f568c8a3252bb5a9f3e2acdc",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ArrayFormatterLocator.cs
            "c4228cdbba89e2a5d52357b998c3387d",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/DelegateFormatterLocator.cs
            "cf715e98fa96d74c81b4d3f4491d2592",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/FormatterLocator.cs
            "d35d0d1eb290f5d00e273d65e5db09d7",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/GenericCollectionFormatterLocator.cs
            "f2a9beaeecdd6eb929ddb049d7846a14",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/IFormatterLocator.cs
            "cdd12b278851bfdc68ca0d9e1e4f2d28",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ISerializableFormatterLocator.cs
            "876ae9a404abe412e663fd9bc03d3525",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/SelfFormatterLocator.cs
            "00e10f526d476731ebc596ceb66271a6",  // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/TypeFormatterLocator.cs
            "9aaf14140a26e04b861b027d5ddb8fb6",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayFormatter.cs
            "3f5dc00eb17e568de42119a7f0f30ee8",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayListFormatter.cs
            "9598679c29f3e3696941746c26f1ccf8",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/BaseFormatter.cs
            "dff51bfb9b4d71aa78b3e5c8fec8c924",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeFormatter.cs
            "3480954e7eecdc9745c1d08721b2f8b3",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeOffsetFormatter.cs
            "4f17b17e986ae6f3be6a2ea1b716fcaf",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DelegateFormatter.cs
            "4402da708267c579874c808a813bfe62",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DerivedDictionaryFormatter.cs
            "b80567603fe814a8b4341584f8c3b4a6",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DictionaryFormatter.cs
            "5c21ee7e54dff531da57563e2f81fff5",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DoubleLookupDictionaryFormatter.cs
            "54578488936f8484c97ba7c52bfb0563",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EasyBaseFormatter.cs
            "e226537cbfa910681132da3718f41c34",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmittedFormatterAttribute.cs
            "149c482b2ab9c601b8bc2ecc20bbd8d9",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmptyTypeFormatter.cs
            "b7da6bf97199e0bb743f7639c17112ac",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/FormatterEmitter.cs
            "06ccb8250c692f2695d28bfd6bcd4273",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/GenericCollectionFormatter.cs
            "f1eaa1b43658215b6d81013928eac19e",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/HashSetFormatter.cs
            "0fcb040f1c493dc2a5224e446be8b3c9",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/IFormatter.cs
            "5cae1c5d1116a090d70b6d0289061d21",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/KeyValuePairFormatter.cs
            "ba4ee6777a44f6e9a8e2e0a222c0f7db",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ListFormatter.cs
            "21078ce134ce87231526dee77088e7ab",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MethodInfoFormatter.cs
            "ae604bc0ef4ef9938100804f05decb21",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MinimalBaseFormatter.cs
            "dc1b5b3148988d0d4fc2dab60a5c146c",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MultiDimensionalArrayFormatter.cs
            "f9ea00de8051ca957d994e11630671d9",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/NullableFormatter.cs
            "6b6a62ea2fe943a4b261f832e8a1f3dd",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/PrimitiveArrayFormatter.cs
            "8045e4edca7c27f5b16bd90d7101c935",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/QueueFormatter.cs
            "15fa864c9e3363220ceac4ec93c7f5b8",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionFormatter.cs
            "dde0095df6bea6624dfa72a31127bc48",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionOrEmittedBaseFormatter.cs
            "12a47dd574302b77ba3c5ac05cd04541",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SelfFormatterFormatter.cs
            "0f59404c810d015ed87c7e1557188435",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SerializableFormatter.cs
            "087303d0d43cf7ce5af060a0cc0b5d38",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/StackFormatter.cs
            "4b0676b49f03cc50a1e532cf23e3988e",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TimeSpanFormatter.cs
            "c6529471b992ba4080a123aa504ef9ea",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TypeFormatter.cs
            "4a7c8e71a3ef1124db10e72af34e1724",  // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/VersionFormatter.cs
            "23fa5d3fed3b4b9de502257a594b00de",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AllowDeserializeInvalidDataAttribute.cs
            "92726834b08002d525b86fbb012e184f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AlwaysFormatsSelfAttribute.cs
            "72783638708ea644ba5c3e1b91f827f6",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ArchitectureInfo.cs
            "ad4e17831e9503c1f11149997c609477",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/Buffer.cs
            "e7e73146f1e861c27c5608bff4142402",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CachedMemoryStream.cs
            "4fd6ff4077bbbef9b366d8ffd9236173",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomFormatterAttribute.cs
            "e02123fad495d06f2a89e5335f00126c",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomGenericFormatterAttribute.cs
            "97e9e01eb36fd43879b166b6b3c2469b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomLogger.cs
            "95bb5531b6c1d1a5eab8400ea1bd6167",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomSerializationPolicy.cs
            "c2a40a3e6a114e5a50c0af209b8ae35e",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DataFormat.cs
            "0bd9ab6cf3bd913588b6652279b7a6ba",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultLoggers.cs
            "996e793dcc0920d2590cb61f0761d498",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultSerializationBinder.cs
            "c79df97337d89089be40beb2e272df0b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DeserializationContext.cs
            "ae849a3e6d277006f3b4dd58a5765955",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EmittedAssemblyAttribute.cs
            "3b06b106636f38afbb25ddd11e0c597c",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EntryType.cs
            "c73435dff291e72c0d9ce55b59c39145",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ErrorHandlingPolicy.cs
            "df06475ac5299f402ca1bdee3cf7e702",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ExcludeDataFromInspectorAttribute.cs
            "08528593c8dd764b6d928dcee6daca9f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterLocationStep.cs
            "30194d27b77855bf09b9af809a761ca5",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterUtilities.cs
            "32f94aca65b8d09ddd7b3db72e08db3f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IAskIfCanFormatTypes.cs
            "7ef6b6dd5e3be66c3a66753cc7e799de",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalGuidReferenceResolver.cs
            "d1eaa1a505a876bebb9cad40d01989e9",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalIndexReferenceResolver.cs
            "9414cf6a3ea9a51afcf648fe9ea02bed",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalStringReferenceResolver.cs
            "8bab352682356b8a2b02842520a68a11",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ILogger.cs
            "106ca47adfa52732b129015337a1c8cd",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISelfFormatter.cs
            "90bcbfdc0286ca48d51fc578a1e15b8f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISerializationPolicy.cs
            "7de3f23805ad9d4b3d033eef45e3b59b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/LoggingPolicy.cs
            "10eb7be2b7c363367c46bc5699a361a8",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/NodeInfo.cs
            "766bbafe64ad16f63af4b81eb430e380",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/OdinSerializeAttribute.cs
            "3db8c00661ec222984427ab12295940f",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModification.cs
            "23ceed712f987034deb8e92c561a1d3b",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModificationType.cs
            "96fec6c04f13e378def42ea5ad5dc940",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PreviouslySerializedAsAttribute.cs
            "989e99cd5b8f922edc1b13bbc22f4289",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ProperBitConverter.cs
            "82702718797409c332f9174bdad57bbc",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterAttribute.cs
            "a000ffc63858a974eb63d9ef6f91adac",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterLocatorAttribute.cs
            "dca124a461001ad1494664ed95539612",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationAbortException.cs
            "eba33c8e77e2084c660af46be1b547dd",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationConfig.cs
            "1e93880e733f9a6a084cf4061634e7fb",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationContext.cs
            "67a19021ff9e6b27d8e9257ad075055a",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationPolicies.cs
            "08607b6e9c39ec19c1b61341583c2f3e",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationUtility.cs
            "bc69d8fd9d15913a491a45d1e040faf6",  // Assets/Udon/Serialization/OdinSerializer/Core/Misc/TwoWaySerializationBinder.cs
            "0e8d8c5a97fdc322a8b8471aaf02f469",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/BooleanSerializer.cs
            "8aa9f52771b0e4e6f8f0c438a4f0430b",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ByteSerializer.cs
            "d44d1ae83013328d7b855275fa1cfad7",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/CharSerializer.cs
            "5a2a43b51cef79fd0e85028650394b55",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ComplexTypeSerializer.cs
            "50c67937d611e4749188b838e4cff5dc",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DecimalSerializer.cs
            "9fc4716f683bc313c24bfa537cdd97f6",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DoubleSerializer.cs
            "7a5d23b139cd8e692702aa431b071d07",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/EnumSerializer.cs
            "19dcfa9f6a40979fc2b6c3ae0f24b67c",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/GuidSerializer.cs
            "d280b44f7c75a9a18484a84745998130",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int16Serializer.cs
            "eafebb70813195e03b1ba467931eb686",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int32Serializer.cs
            "afe45c48508431a62aba886d943d8501",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int64Serializer.cs
            "6ccaffe3090611c2ada67d49cf834771",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/IntPtrSerializer.cs
            "88f3ec418fdfdd7eabd6134f1de91991",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SByteSerializer.cs
            "29261eaea99f2d34c42cdc0b04f95daa",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Serializer.cs
            "7aa356971fd0b66eb59875b278fa7f03",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SingleSerializer.cs
            "85996580a8691185d06ec342c5c43747",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/StringSerializer.cs
            "3936194ea64890e11a7db8474eb0bbcf",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt16Serializer.cs
            "f30e426f88b471e498dd1853b7bbaee6",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt32Serializer.cs
            "f55c085325e12800428d01e3535cb297",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt64Serializer.cs
            "0ee9dd19c234e4b16c835b9188459e36",  // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UIntPtrSerializer.cs
            "94a6cc2044fcd2cb317b1cdb1e8fcdaf",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportScanner.cs
            "f5fe153775edbadfa2b659e0e35dc881",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportUtilities.cs
            "aaf2f90207414827b53b85dae0eae82e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/OdinPrefabSerializationEditorUtility.cs
            "de5584f66ccc5e072681a310c5987b8c",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnityReferenceResolver.cs
            "f670c1f9aa9ab0c5988e81802c005767",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationInitializer.cs
            "9eb15f2339819bb651c7872d73c89776",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationUtility.cs
            "864fb1c011715f9df2998d71ac8716f6",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/BaseDictionaryKeyPathProvider.cs
            "ef6f699f176c2dfdea788982526f989a",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/DictionaryKeyUtility.cs
            "b513c156933d8b833ccd40d717bf7e2b",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/IDictionaryKeyPathProvider.cs
            "54f653ed4a4e15c07057283c11dce4d9",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/RegisterDictionaryKeyPathProviderAttribute.cs
            "0405ef103432161dff609e75f71f3f55",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector2DictionaryKeyPathProvider.cs
            "1d61e235c606c1c9d7269f7e68471e38",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector3DictionaryKeyPathProvider.cs
            "51bb2cf369b5ea90948a20e4f2ebae48",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector4DictionaryKeyPathProvider.cs
            "3d2976bd61cccf62b11b4d3f02762465",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/AnimationCurveFormatter.cs
            "6ff1b29d64402a15d020739becd8661e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/BoundsFormatter.cs
            "0878ec68b6ab3c9ebc365b6d139e4840",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Color32Formatter.cs
            "25e35581ce6d1febd9ac41864a76ecdb",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorBlockFormatter.cs
            "484768ba343a6a05522c29d81a4ce61d",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorFormatter.cs
            "c3968bef792c5668478ac01be7645b30",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/CoroutineFormatter.cs
            "b5b415c00da8157ac50b8f5543f0b1d9",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientAlphaKeyFormatter.cs
            "8936a3e43078251682f18923139f7aee",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientColorKeyFormatter.cs
            "d5b54660d5342fd45e2e43775538879d",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientFormatter.cs
            "68ac0b27f571616d3ed26c23eef40c8c",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/KeyframeFormatter.cs
            "afc596cd95a1ac316024d16f6fec6536",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/LayerMaskFormatter.cs
            "558323987bf9b75943382a5faa093ee3",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/QuaternionFormatter.cs
            "196809b991e565a48e3d4ad08cb30b5e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/RectFormatter.cs
            "c934302874ac3315ed322feefefa1f9c",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/UnityEventFormatter.cs
            "70c675a7b4c71c685ee39d745ccb058b",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector2Formatter.cs
            "da2644647af1368176103aa87de1dbaf",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector3Formatter.cs
            "60afa8ede3981c383782a01ddc55e943",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector4Formatter.cs
            "ff1ca109149d83b03b39644f8045275e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationFormat.cs
            "8942002e9ac41c2bfd27c4fbedf93f09",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationPolicy.cs
            "7279ec8ad7837f13ec833193ab4282cc",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/ISupportsPrefabSerialization.cs
            "ea095023abd05a7af0da4166dcefdee8",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializationData.cs
            "c3cecb461cebbc940ede3b5ddb72382e",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedBehaviour.cs
            "56b88cfe9935184fe250bda018144f26",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedComponent.cs
            "d1b9fa6342beb9fdfc2c4bc1d8e5e971",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedMonoBehaviour.cs
            "6cb9325ffffee5d6ed94d71590b4049a",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedScriptableObject.cs
            "eefcd68a84ee7903b08c6254c17fafe3",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedStateMachineBehaviour.cs
            "d62f7ab4e5aa075b819d6c71e929686b",  // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedUnityObject.cs
            "78ce67c0b3c1975c520a08d1ff9fd24e",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/FieldInfoExtensions.cs
            "068f5645a5c3f9ce36a580ec57e775d1",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/GarbageFreeIterators.cs
            "0f84614827ff91701149564447a3932b",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/LinqExtensions.cs
            "62088a9c188c943eb4035de16eb6ec32",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MemberInfoExtensions.cs
            "63a9a0384a6fe66fb04f82f325895b30",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MethodInfoExtensions.cs
            "1df9513f03131466eecad22d1b19c4d8",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/Operator.cs
            "da8aea12015a2df5402c9e2d4f1cec5c",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PathUtilities.cs
            "7f13450d6fd82372ffa7ee075a8eb4c9",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PropertyInfoExtensions.cs
            "b554cbd9469011b544a2d92ae85a3b60",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/StringExtensions.cs
            "a6a172cef14a88c7fb714df37bbecedb",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/TypeExtensions.cs
            "eb77f5278e425e91b71e186df29a5f16",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/UnityExtensions.cs
            "787c97af872124f748a4a9b366f325d3",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/AssemblyImportSettingsUtilities.cs
            "146b6bd1e3b0f0926205abf839ec9e6f",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Cache.cs
            "1bd625694c606aab0cb7895da4911c6a",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/DoubleLookupDictionary.cs
            "bda92ec6156282448e883bf8f6a781fd",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/EmitUtilities.cs
            "570028979953bd2c60b7e89ff7cef92e",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/FastTypeComparer.cs
            "42e5d977e21c7a6524213a8a7dbee24a",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Flags.cs
            "783316da32d87acfae14953e341732a3",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ICacheNotificationReceiver.cs
            "1bc635f3755c60fe69f1895dd53974e2",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ImmutableList.cs
            "000592e93b119574207ea3bf59f659e4",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasFieldInfo.cs
            "c1e85c1ef449ccb40e05f0afd3dd717f",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasMethodInfo.cs
            "00bf47593f2a330c1bb41552bdc1233f",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasPropertyInfo.cs
            "5ad884ed6013d621a310ceb4c954f62a",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ReferenceEqualityComparer.cs
            "0fe3820fb4651e200f17905245ec8be2",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnityVersion.cs
            "93b4d01199b118896c756b09a9206fc0",  // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnsafeUtilities.cs
            "f6cfa3d8ec4f885468d17f5b023d2529",  // Assets/Udon/WrapperModules/ExternVRCInstantiate.cs

            #endregion

        };
    }
}