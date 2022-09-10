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

        public new IRule[] GetRules()
        {
            return base.GetRules().Concat(new IRule[]
            {

            }).ToArray();
        }

        protected override Vector3 BoothSizeLimit => new Vector3(3, 3, 3);
    }
}
