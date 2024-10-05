using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Powerups/FireBuff")]

public class FireBuff : PowerupEffect
{
    public override void Apply(GameObject target)
    {
        target.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
