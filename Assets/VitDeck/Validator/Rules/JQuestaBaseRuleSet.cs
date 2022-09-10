#if VRC_SDK_VRCSDK3
using System;
using UnityEngine;
using VitDeck.Language;
using VRC.SDKBase;

namespace VitDeck.Validator
{

    /// <summary>
    /// じゃぱんくえすたの基本ルールセット。
    /// </summary>
    /// <remarks>
    /// 変数をabstractまたはvirtualプロパティで宣言し、継承先で上書きすることでワールドによる制限の違いを表現する。
    /// </remarks>
    public abstract class JQuestaBaseRuleSet : IRuleSet
    {
        public abstract string RuleSetName { get; }

        private readonly VRCSampleTargetFinder targetFinder = new VRCSampleTargetFinder();
        public IValidationTargetFinder TargetFinder => targetFinder;

        private readonly IObjectDetector officialPrefabsDetector;

        public JQuestaBaseRuleSet() : base()
        {
            officialPrefabsDetector = new PrefabPartsDetector(
                VRCUdonSampleOfficialAssetData.AudioSourcePrefabGUIDs,
                VRCUdonSampleOfficialAssetData.AvatarPedestalPrefabGUIDs,
                VRCUdonSampleOfficialAssetData.PickupObjectSyncPrefabGUIDs,
                VRCUdonSampleOfficialAssetData.CanvasPrefabGUIDs,
                VRCUdonSampleOfficialAssetData.PointLightProbeGUIDs,
                VRCUdonSampleOfficialAssetData.UdonBehaviourPrefabGUIDs);
        }

        public IRule[] GetRules()
        {
            // デフォルトで使っていたAttribute式は宣言時にconst以外のメンバーが利用できない。
            // 継承したプロパティを参照して挙動を変えることが出来ない為、直接リストを返す方式に変更した。
            return new IRule[]
            {

                new UnityVersionRule(LocalizedMessage.Get("VketRuleSetBase.UnityVersionRule.Title", "2019.4.31f1"), "2019.4.31f1"),

                new ExistInSubmitFolderRule(LocalizedMessage.Get("VketRuleSetBase.ExistInSubmitFolderRule.Title"), VRCUdonSampleOfficialAssetData.GUIDs, targetFinder),

                new AssetGuidBlacklistRule(LocalizedMessage.Get("VketRuleSetBase.OfficialAssetDontContainRule.Title"), VRCUdonSampleOfficialAssetData.GUIDs),

                new ContainMatOrTexInAssetRule(LocalizedMessage.Get("VketRuleSetBase.ContainMatOrTexInAssetRule.Title")),

                new FolderSizeRule(LocalizedMessage.Get("VketRuleSetBase.FolderSizeRule.Title"), 50 * (int)Math.Pow(2, 20)),

                new ExhibitStructureRule(LocalizedMessage.Get("VketRuleSetBase.ExhibitStructureRule.Title")),

                new StaticFlagRule(LocalizedMessage.Get("VketRuleSetBase.StaticFlagsRule.Title")),

                new BoothBoundsRule(LocalizedMessage.Get("VketRuleSetBase.BoothBoundsRule.Title"),
                    size: BoothSizeLimit,
                    margin: 0.01f,
                    Vector3.zero,
                    VRCUdonSampleOfficialAssetData.SizeIgnorePrefabGUIDs),

                new LightmapSizeLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.LightMapsLimitRule.Title", 1, 256),
                    lightmapCountLimit: 1,
                    lightmapResolutionLimit: 256),

                new UsableComponentListRule(LocalizedMessage.Get("VketRuleSetBase.UsableComponentListRule.Title"),
                    GetComponentReferences(),
                    ignorePrefabGUIDs: VRCUdonSampleOfficialAssetData.GUIDs,
                    unregisteredComponent: ValidationLevel.DISALLOW),

                new MeshRendererRule(LocalizedMessage.Get("VketRuleSetBase.MeshRendererRule.Title")),

                new ReflectionProbeRule(LocalizedMessage.Get("VketRuleSetBase.ReflectionProbeRule.Title")),

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

                new AnimatorComponentRule(
                    LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentRule.Title"),
                    new[] { typeof(VRC_Pickup) },
                    officialPrefabsDetector),

                new CanvasRenderModeRule(LocalizedMessage.Get("VketRuleSetBase.CanvasRenderModeRule.Title")),

                new PrefabLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.PickupObjectSyncPrefabLimitRule.Title", 5),
                    VRCUdonSampleOfficialAssetData.PickupObjectSyncPrefabGUIDs,
                    limit: 5),

                new AnimatorComponentMaxCountRule(LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentMaxCountRule.Title"), limit: 20),

                // Udon Behaviour
                // UdonBehaviourを含むオブジェクト、UdonBehaviourによって操作を行うオブジェクトは全て入稿ルール C.Scene内階層規定におけるDynamicオブジェクトの階層下に入れてください
                new UdonDynamicObjectParentRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonDynamicObjectParentRule.Title")), 
                
                // 全てのUdonBehaviourオブジェクトの親であるDynamicオブジェクトは初期でInactive状態にしてください
                new UdonDynamicObjectInactiveRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonDynamicObjectInactiveRule.Title")), 

                // UdonBehaviourを含むオブジェクトのLayerはUserLayer23としてください
                new UdonBehaviourLayerConstraintRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonBehaviourLayerConstraintRule.Title")),

                // AllowOwnershipTransferOnCollisionは必ずFalseにすること
                new UdonBehaviourAllowOwnershipTransferOnCollisionIsFalseRule(LocalizedMessage.Get("UdonBehaviourAllowOwnershipTransferOnCollisionIsFalseRule.Title")),

                // VRCPickup は UdonBehaviour [AutoResetPickup] を持つ必要があります。
                new VRCPickupUdonBehaviourRule(LocalizedMessage.Get("VketUdonRuleSetBase.X08_VRCPickupUdonBehaviourRule.Title")), 
            };
        }

        protected abstract Vector3 BoothSizeLimit { get; }

        private ComponentReference[] GetComponentReferences()
        {
            return new ComponentReference[] {
                new ComponentReference("Collider", new string[]{"UnityEngine.SphereCollider", "UnityEngine.BoxCollider", "UnityEngine.SphereCollider", "UnityEngine.CapsuleCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("Skinned Mesh Renderer", new string[]{"UnityEngine.SkinnedMeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Renderer ", new string[]{"UnityEngine.MeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Filter", new string[]{"UnityEngine.MeshFilter"}, ValidationLevel.ALLOW),
                new ComponentReference("Particle System", new string[]{"UnityEngine.ParticleSystem", "UnityEngine.ParticleSystemRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Light", new string[]{"UnityEngine.Light"}, ValidationLevel.ALLOW),
                new ComponentReference("ReflectionProbe", new string[]{"UnityEngine.ReflectionProbe"}, ValidationLevel.ALLOW),
                new ComponentReference("Animator", new string[]{"UnityEngine.Animator"}, ValidationLevel.ALLOW),
                new ComponentReference("Audio Source", new string[]{"UnityEngine.AudioSource"}, ValidationLevel.ALLOW),
                new ComponentReference("Canvas", new string[]{"UnityEngine.Canvas", "UnityEngine.CanvasGroup", "UnityEngine.RectTransform", "UnityEngine.UI.CanvasScaler", "UnityEngine.UI.GraphicRaycaster", "UnityEngine.UI.AspectRatioFitter", "UnityEngine.UI.LayoutElement", "UnityEngine.UI.ContentSizeFitter", "UnityEngine.UI.HorizontalLayoutGroup", "UnityEngine.UI.VerticalLayoutGroup", "UnityEngine.UI.GridLayoutGroup", "UnityEngine.UI.Text", "UnityEngine.UI.Image", "UnityEngine.UI.RawImage", "UnityEngine.UI.Mask", "UnityEngine.UI.RectMask2D", "UnityEngine.UI.Button", "UnityEngine.UI.InputField", "UnityEngine.UI.Toggle", "UnityEngine.UI.ToggleGroup", "UnityEngine.UI.Slider", "UnityEngine.UI.Scrollbar", "UnityEngine.UI.Dropdown", "UnityEngine.UI.ScrollRect", "UnityEngine.UI.Selectable", "UnityEngine.UI.Shadow", "UnityEngine.UI.Outline", "UnityEngine.UI.PositionAsUV1", "UnityEngine.RectTransform", "UnityEngine.CanvasRenderer"}, ValidationLevel.ALLOW),

                // VRCSDK3
                //// VRC_Trigger is obsolete. Use instead Udon Behaviour
                new ComponentReference("VRC Station", new string[]{"VRC.SDKBase.VRCStation", "VRC.SDK3.Components.VRCStation"}, ValidationLevel.ALLOW),
            };
        }
    }
}
#endif
