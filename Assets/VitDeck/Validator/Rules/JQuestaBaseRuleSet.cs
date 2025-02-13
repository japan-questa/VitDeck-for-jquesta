using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;
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

        protected abstract string ExportSettingName { get; }

        protected abstract Vector3 BoothSizeLimit { get; }

        public JQuestaBaseRuleSet() : base()
        {
            officialPrefabsDetector = new PrefabPartsDetector(
                JQuestaAssetData.AudioSourcePrefabGUIDs,
                JQuestaAssetData.AvatarPedestalPrefabGUIDs,
                JQuestaAssetData.PickupObjectSyncPrefabGUIDs,
                JQuestaAssetData.CanvasPrefabGUIDs,
                JQuestaAssetData.PointLightProbeGUIDs,
                JQuestaAssetData.UdonBehaviourPrefabGUIDs);
        }

        public virtual IRule[] GetRules()
        {
            // デフォルトで使っていたAttribute式は宣言時にconst以外のメンバーが利用できない。
            // 継承したプロパティを参照して挙動を変えることが出来ない為、直接リストを返す方式に変更した。
            return new IRule[]
            {
                ////////////////////////////////////////////////////////////////
                ////          アバター出展・イベント出展　共通事項          ////
                ////////////////////////////////////////////////////////////////
                
                new UnityVersionRule(LocalizedMessage.Get("VketRuleSetBase.UnityVersionRule.Title", "2019.4.31f1"), "2019.4.31f1"),

                new FolderSizeRule(LocalizedMessage.Get("VketRuleSetBase.FolderSizeRule.Title"), 50 * (int)Math.Pow(2, 20)),

                new BaseFolderPathRule(
                    "ベースフォルダパスルール",
                    new Regex("^Assets/[0-9]{3}$"),
                    "Base Folderは、入稿ツールによってAssets直下へ作成された、半角数字3桁の出展IDのフォルダです。"
                ),

                // VitDeckは常に最新バージョンを使うように
                new VitDeckVersionRule("VitDeckバージョンルール"),

                // 拡張子のホワイトリスト
                new AllowedExtensionsForExportRule(
                    LocalizedMessage.Get("AllowedExtensionsForExportRule.Title"),
                    Exporter.Exporter.GetExportSettings().First(setting => setting.SettingName == ExportSettingName)
                ),

                new ExistInSubmitFolderRule(LocalizedMessage.Get("VketRuleSetBase.ExistInSubmitFolderRule.Title"), JQuestaAssetData.GUIDs, targetFinder),

                new AssetGuidBlacklistRule(LocalizedMessage.Get("VketRuleSetBase.OfficialAssetDontContainRule.Title"), JQuestaAssetData.GUIDs),

                new ContainMatOrTexInAssetRule(LocalizedMessage.Get("VketRuleSetBase.ContainMatOrTexInAssetRule.Title")),

                new EmbeddedMaterialsRule("モデルのMaterials設定で「Use Embedded Materials」を使う"),

                ////////////////////////////////////////////////////////////////
                ////                        入稿データ                      ////
                ////////////////////////////////////////////////////////////////
                
                // ビルドサイズの確認をAndroidプラットフォームで行う
                new UnityPlatformRule("Unityプラットフォーム", UnityPlatformRule.Platform.Android),

                new TextureImporterFormatRule("テクスチャ圧縮形式", "Android", new[]
                {
                    TextureImporterFormat.ASTC_6x6,
                    TextureImporterFormat.ASTC_8x8,
                    TextureImporterFormat.ASTC_10x10,
                }),
                
                ////////////////////////////////////////////////////////////////
                ////                         シーン                         ////
                ////////////////////////////////////////////////////////////////

                new BoothBoundsRule(LocalizedMessage.Get("VketRuleSetBase.BoothBoundsRule.Title"),
                    size: BoothSizeLimit,
                    margin: 0.01f,
                    Vector3.zero,
                    JQuestaAssetData.SizeIgnorePrefabGUIDs),
                
                ////////////////////////////////////////////////////////////////
                ////                     コンポーネント                     ////
                ////////////////////////////////////////////////////////////////

                // コンポーネントのホワイトリスト制限
                new UsableComponentListRule(LocalizedMessage.Get("VketRuleSetBase.UsableComponentListRule.Title"),
                    GetComponentReferences(),
                    ignorePrefabGUIDs: JQuestaAssetData.GUIDs,
                    unregisteredComponent: ValidationLevel.DISALLOW),
                
                
                ////////////////////////////////////////////////////////////////
                ////                 GameObjectのStatic設定                 ////
                ////////////////////////////////////////////////////////////////

                // 出展ID、Reference Object以外のオブジェクトをルートに置かない
                new SceneStructureRule("シーン構造ルール"),

                new StaticFlagRule(LocalizedMessage.Get("VketRuleSetBase.StaticFlagsRule.Title")),

                new MeshRendererRule(LocalizedMessage.Get("VketRuleSetBase.MeshRendererRule.Title")),
            };
        }

        protected virtual IEnumerable<ComponentReference> GetComponentReferences()
        {
            return new ComponentReference[] {
                new ComponentReference("Mesh Renderer ", new string[]{"UnityEngine.MeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Filter", new string[]{"UnityEngine.MeshFilter"}, ValidationLevel.ALLOW),
            };
        }
    }
}
