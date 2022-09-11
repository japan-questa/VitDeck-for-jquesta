#if VRC_SDK_VRCSDK3
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEditor;
using VitDeck.Language;
using VRC.SDKBase;

namespace VitDeck.Validator
{

    /// <summary>
    /// じゃぱんくえすたのイベント出展 (ブース) 用のルールセット。
    /// </summary>
    public class JQuestaEventBoothRuleSet : JQuestaBaseRuleSet
    {
        public override string RuleSetName => "じゃぱんくえすた - イベント出展 (ブース)";

        protected override string ExportSettingName => "じゃぱんくえすた イベント出展 (ブース)";

        protected override Vector3 BoothSizeLimit => new Vector3(4, 5, 4);

        public new IRule[] GetRules()
        {
            return base.GetRules().Concat(new IRule[]
            {
                ////////////////////////////////////////////////////////////////
                ////                        入稿データ                      ////
                ////////////////////////////////////////////////////////////////
                
                new LightmapSizeLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.LightMapsLimitRule.Title", 1, 256),
                    lightmapCountLimit: 1,
                    lightmapResolutionLimit: 256),

                new TextureImporterFormatRule("テクスチャ圧縮形式", "Android", new[]
                {
                    TextureImporterFormat.ASTC_6x6,
                    TextureImporterFormat.ASTC_8x8,
                    TextureImporterFormat.ASTC_10x10,
                }),

                ////////////////////////////////////////////////////////////////
                ////                      コンポーネント                    ////
                ////////////////////////////////////////////////////////////////
                
                // VRC Pickup
                new PrefabLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.PickupObjectSyncPrefabLimitRule.Title", 5),
                    JQuestaAssetData.PickupObjectSyncPrefabGUIDs,
                    limit: 5),

                // Animator
                new AnimatorComponentMaxCountRule(LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentMaxCountRule.Title"), limit: 20),
                new AnimatorComponentRule(
                    LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentRule.Title"),
                    new[] { typeof(VRC_Pickup) },
                    officialPrefabsDetector),

                // Light
                new LightConfigRule(
                    LocalizedMessage.Get("VketRuleSetBase.PointLightConfigRule.Title"),
                    LightType.Point,
                    new LightConfigRule.LightConfig(new[] { LightmapBakeType.Baked })),

                new LightConfigRule(LocalizedMessage.Get("VketRuleSetBase.SpotLightConfigRule.Title"),
                    LightType.Spot,
                    new LightConfigRule.LightConfig(new[] { LightmapBakeType.Baked })),

                new LightConfigRule(
                    LocalizedMessage.Get("VketRuleSetBase.AreaLightConfigRule.Title"),
                    LightType.Area,
                    new LightConfigRule.LightConfig(new[] { LightmapBakeType.Baked })),

                // Canvas
                new CanvasRenderModeRule(LocalizedMessage.Get("VketRuleSetBase.CanvasRenderModeRule.Title")),

                // RigidBodyはisKinematicへチェックを入れる
                new RigidbodyRule(LocalizedMessage.Get("VketRuleSetBase.RigidbodyRule.Title")),

                // Reflection Probe
                new ComponentMaxCountRule("ReflectionProbe数制限", typeof(ReflectionProbe), 1),
                new ReflectionProbeRule(
                    LocalizedMessage.Get("VketRuleSetBase.ReflectionProbeRule.Title"),
                    new[]{ ReflectionProbeMode.Custom, ReflectionProbeMode.Baked }),

                // Audio Source
                new ComponentMaxCountRule("AudioSource数制限", typeof(AudioSource), 1),

                // Udon Behaviour
                // 全てのUdonBehaviourオブジェクトの親であるDynamicオブジェクトは初期でInactive状態にしてください
                new UdonDynamicObjectInactiveRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonDynamicObjectInactiveRule.Title")), 
                // UdonBehaviourを含むオブジェクトのLayerはUserLayer23としてください
                new UdonBehaviourLayerConstraintRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonBehaviourLayerConstraintRule.Title")),
                // AllowOwnershipTransferOnCollisionは必ずFalseにすること
                new UdonBehaviourAllowOwnershipTransferOnCollisionIsFalseRule(LocalizedMessage.Get("UdonBehaviourAllowOwnershipTransferOnCollisionIsFalseRule.Title")),
                // VRCPickup は UdonBehaviour [AutoResetPickup] を持つ必要があります。
                new VRCPickupUdonBehaviourRule(LocalizedMessage.Get("VketUdonRuleSetBase.X08_VRCPickupUdonBehaviourRule.Title")),

                ////////////////////////////////////////////////////////////////
                ////                    使用可能シェーダー                  ////
                ////////////////////////////////////////////////////////////////
                
                new ShaderWhitelistRule("シェーダーホワイトリストルール", new Dictionary<string, string>()
                {
                    // VRChat SDK (VRCSDK3-Worlds)
                    { "VRChat/Mobile/Bumped Diffuse", "f8c1f8ac363df824899534a0b30eef00" },
                    { "VRChat/Mobile/Bumped Mapped Specular", "584dc70fbb9834e48beb29e3206e3ca0" },
                    { "VRChat/Mobile/Diffuse", "2dcd9e0568e0a6f45b92c60ba2eb16a0" },
                    { "VRChat/Mobile/Lightmapped", "b1f7ecc80417c414b9d62ce541d5bcbf" },
                    { "VRChat/Mobile/MatCap Lit", "3ad043b7f9839cb48a75a9238d433dec" },
                    { "VRChat/Mobile/Particles/Additive", "9200bec112b65ec4fbbbd33fa89c20f4" },
                    { "VRChat/Mobile/Particles/Multiply", "d5b89f0c74ccf5049ba803c14a090378" },
                    { "VRChat/Mobile/Skybox", "c0d3cb006bb294142bef136f492f2568" },
                    { "VRChat/Mobile/Standard Lite", "0b7113dea2069fc4e8943843eff19f70" },
                    { "VRChat/Mobile/Toon Lit", "affc81f3d164d734d8f13053effb1c5c" },
                    // ビルトインシェーダー
                    { "UI/Default", null },
                    { "UI/Default Font", null },
                    { "UI/DefaultETC1", null },
                    { "UI/Lit/Bumped", null },
                    { "UI/Lit/Detail", null },
                    { "UI/Lit/Refraction", null },
                    { "UI/Lit/Refraction Detail", null },
                    { "UI/Lit/Transparent", null },
                    { "UI/Unlit/Detail", null },
                    { "UI/Unlit/Text", null },
                    { "UI/Unlit/Text Detail", null },
                    { "UI/Unlit/Transparent", null },
                    { "GUI/Text Shader", null },
                    { "Particles/Standard Surface", null },
                    { "Particles/Standard Unlit", null },
                    { "Sprites/Default", null },
                    { "Sprites/Diffuse", null },
                    { "Sprites/Mask", null },
                    { "Unlit/Color", null },
                    { "Unlit/Texture", null },
                    { "Unlit/Transparent", null },
                    { "Unlit/Transparent Cutout", null },
                    { "Autodesk Interactive", null },
                    { "Standard", null },
                    { "Standard (Specular setup)", null },
                    // TextMesh Pro
                    { "TextMeshPro/Mobile/Distance Field", "fe393ace9b354375a9cb14cdbbc28be4" },
                    // VRMShaders (UniVRM)
                    { "UniGLTF/NormalMapDecoder", "53762a37d0a403e42a4921e3e3b84915" },
                    { "UniGLTF/NormalMapEncoder", "3e39586253f31b34f87fa7e133449b1e" },
                    { "UniGLTF/StandardVColor", "5ef7bdb14a8f23043805e41692d10787" },
                    { "UniGLTF/UniUnlit", "8c17b56f4bf084c47872edcb95237e4a" },
                    { "VRM/MToon", "1a97144e4ad27a04aafd70f7b915cedb" },
                    { "VRM/UnlitCutout", "4c9ce97af40038f45811fc4b0975a483" },
                    { "VRM/UnlitTexture", "1a70c9898704e1a4691843883f5101af" },
                    { "VRM/UnlitTransparent", "df359ad0838642d4fa0339514fcbbb2d" },
                    { "VRM/UnlitTransparentZWrite", "429a3203ab2959741aab76fa2856b450" },
                }, "入稿規定の使用可能シェーダーをご参照ください。", "https://jquesta.jp/exhibit-event.html"),

                ////////////////////////////////////////////////////////////////
                ////                 GameObjectのStatic設定                 ////
                ////////////////////////////////////////////////////////////////

                // UdonBehaviourを含むオブジェクト、UdonBehaviourによって操作を行うオブジェクトは全て入稿ルール C.Scene内階層規定におけるDynamicオブジェクトの階層下に入れてください
                new UdonDynamicObjectParentRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonDynamicObjectParentRule.Title")),
            }).ToArray();

        }

        protected override IEnumerable<ComponentReference> GetComponentReferences()
        {
            return base.GetComponentReferences().Concat(new[]
            {
                new ComponentReference("Collider", new string[]{"UnityEngine.SphereCollider", "UnityEngine.BoxCollider", "UnityEngine.SphereCollider", "UnityEngine.CapsuleCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("Rigidbody", new string[]{"UnityEngine.Rigidbody"}, ValidationLevel.ALLOW),
                new ComponentReference("Skinned Mesh Renderer", new string[]{"UnityEngine.SkinnedMeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Particle System", new string[]{"UnityEngine.ParticleSystem", "UnityEngine.ParticleSystemRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Light", new string[]{"UnityEngine.Light"}, ValidationLevel.ALLOW),
                new ComponentReference("ReflectionProbe", new string[]{"UnityEngine.ReflectionProbe"}, ValidationLevel.ALLOW),
                new ComponentReference("Animator", new string[]{"UnityEngine.Animator"}, ValidationLevel.ALLOW),
                new ComponentReference("Audio Source", new string[]{"UnityEngine.AudioSource"}, ValidationLevel.ALLOW),
                new ComponentReference("Canvas", new string[]{"UnityEngine.Canvas", "UnityEngine.CanvasGroup", "UnityEngine.RectTransform", "UnityEngine.UI.CanvasScaler", "UnityEngine.UI.GraphicRaycaster", "UnityEngine.UI.AspectRatioFitter", "UnityEngine.UI.LayoutElement", "UnityEngine.UI.ContentSizeFitter", "UnityEngine.UI.HorizontalLayoutGroup", "UnityEngine.UI.VerticalLayoutGroup", "UnityEngine.UI.GridLayoutGroup", "UnityEngine.UI.Text", "UnityEngine.UI.Image", "UnityEngine.UI.RawImage", "UnityEngine.UI.Mask", "UnityEngine.UI.RectMask2D", "UnityEngine.UI.Button", "UnityEngine.UI.InputField", "UnityEngine.UI.Toggle", "UnityEngine.UI.ToggleGroup", "UnityEngine.UI.Slider", "UnityEngine.UI.Scrollbar", "UnityEngine.UI.Dropdown", "UnityEngine.UI.ScrollRect", "UnityEngine.UI.Selectable", "UnityEngine.UI.Shadow", "UnityEngine.UI.Outline", "UnityEngine.UI.PositionAsUV1", "UnityEngine.RectTransform", "UnityEngine.CanvasRenderer"}, ValidationLevel.ALLOW),

                // VRCSDK3
                //// VRC_Trigger is obsolete. Use instead Udon Behaviour
                new ComponentReference("VRC Station", new string[]{"VRC.SDKBase.VRCStation", "VRC.SDK3.Components.VRCStation"}, ValidationLevel.ALLOW),
            });
        }
    }
}
#endif
