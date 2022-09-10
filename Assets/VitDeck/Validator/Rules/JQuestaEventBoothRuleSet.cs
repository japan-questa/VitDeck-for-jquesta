#if VRC_SDK_VRCSDK3
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
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

        public new IRule[] GetRules()
        {
            return base.GetRules().Concat(new IRule[]
            {
                new LightmapSizeLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.LightMapsLimitRule.Title", 1, 256),
                    lightmapCountLimit: 1,
                    lightmapResolutionLimit: 256),

                new ReflectionProbeRule(
                    LocalizedMessage.Get("VketRuleSetBase.ReflectionProbeRule.Title"),
                    new[]{ ReflectionProbeMode.Custom, ReflectionProbeMode.Baked }),

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
            }).ToArray();
        }

        protected override Vector3 BoothSizeLimit => new Vector3(4, 5, 4);

        protected override IEnumerable<ComponentReference> GetComponentReferences()
        {
            return base.GetComponentReferences().Concat(new[]
            {
                new ComponentReference("Collider", new string[]{"UnityEngine.SphereCollider", "UnityEngine.BoxCollider", "UnityEngine.SphereCollider", "UnityEngine.CapsuleCollider"}, ValidationLevel.ALLOW),
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
