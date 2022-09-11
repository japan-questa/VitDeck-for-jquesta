using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vket.UdonManager
{
    //[IgnoreBuild]
    public class VketUdonControl : MonoBehaviour
    {
        public bool start;
        public bool update;
        public bool fixedUpdate;
        public bool lateUpdate;
        public bool postLateUpdate;
        public bool onBoothEnter;
        public bool onBoothExit;
    }
}
