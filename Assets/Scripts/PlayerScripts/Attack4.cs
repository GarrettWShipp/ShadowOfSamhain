using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack4 : Attack
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OnAttackCircle();
        
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, circleAttackRange);
    }
}
