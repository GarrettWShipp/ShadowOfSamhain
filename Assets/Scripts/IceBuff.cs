using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/IceBuff")]

public class IceBuff : PowerupEffect
{
    public override void Apply(GameObject target)
    {
        target.GetComponent<SpriteRenderer>().color = Color.cyan;
    }
}

