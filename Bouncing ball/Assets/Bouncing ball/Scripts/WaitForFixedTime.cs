using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bouncer
{
    public class WaitForFixedTime : CustomYieldInstruction
    {

        private float waitTime;

        public override bool keepWaiting
        {
            get { return Time.fixedUnscaledTime < waitTime; }
        }

        public WaitForFixedTime(float time)
        {
            waitTime = Time.fixedUnscaledTime + time;
        }

    }
}
