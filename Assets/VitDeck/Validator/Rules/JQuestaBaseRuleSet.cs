using System;
using System.Collections.Generic;
using UnityEngine;
using VitDeck.Language;

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

        protected readonly IObjectDetector officialPrefabsDetector;

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

                new UsableComponentListRule(LocalizedMessage.Get("VketRuleSetBase.UsableComponentListRule.Title"),
                    GetComponentReferences(),
                    ignorePrefabGUIDs: VRCUdonSampleOfficialAssetData.GUIDs,
                    unregisteredComponent: ValidationLevel.DISALLOW),

                new MeshRendererRule(LocalizedMessage.Get("VketRuleSetBase.MeshRendererRule.Title")),
            };
        }

        protected abstract Vector3 BoothSizeLimit { get; }

        protected virtual IEnumerable<ComponentReference> GetComponentReferences()
        {
            return new ComponentReference[] {
                new ComponentReference("Mesh Renderer ", new string[]{"UnityEngine.MeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Filter", new string[]{"UnityEngine.MeshFilter"}, ValidationLevel.ALLOW),
            };
        }
    }
}
