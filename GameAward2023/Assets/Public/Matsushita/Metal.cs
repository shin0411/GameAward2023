using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : JunkBase
{
    /// <summary>
    /// 蓄電器に当たったとき
    /// </summary>
    public override void HitCapacitor()
    {
        JunkBase junkBase = GetComponent<JunkBase>();

        if (junkBase != null)
        {
            junkBase.Explosion();
        }
    }
}