using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace VitDeck.Validator
{

    /// <summary>
    /// じゃぱんくえすたのアバター出展用のルールセット。
    /// </summary>
    public class JQuestaAvatarRuleSet : JQuestaBaseRuleSet
    {
        public override string RuleSetName => "じゃぱんくえすた - アバター出展";

        protected override string ExportSettingName => "じゃぱんくえすた アバター出展";

        protected override Vector3 BoothSizeLimit => new Vector3(3, 3, 3);

        public new IRule[] GetRules()
        {
            return base.GetRules().Concat(new IRule[]
            {
                ////////////////////////////////////////////////////////////////
                ////                      コンポーネント                    ////
                ////////////////////////////////////////////////////////////////
                
                new ComponentMaxCountRule("メッシュ数制限", typeof(MeshFilter), 2),
                new ComponentMaxCountRule("メッシュ数制限", typeof(MeshRenderer), 2),

                ////////////////////////////////////////////////////////////////
                ////                    使用可能シェーダー                  ////
                ////////////////////////////////////////////////////////////////

                new ShaderWhitelistRule("シェーダーホワイトリストルール", new Dictionary<string, string>()
                {
                    // VRChat SDK (VRCSDK3-Worlds)
                    { "VRChat/Mobile/MatCap Lit", "3ad043b7f9839cb48a75a9238d433dec" },
                    { "VRChat/Mobile/Standard Lite", "0b7113dea2069fc4e8943843eff19f70" },
                    { "VRChat/Mobile/Toon Lit", "affc81f3d164d734d8f13053effb1c5c" },
                }, "入稿規定の使用可能シェーダーをご参照ください。", "https://jquesta.jp/exhibit-avatar.html"),
            }).ToArray();
        }
    }
}
