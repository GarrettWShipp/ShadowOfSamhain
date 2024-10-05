using SuperPupSystems.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : Attack
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attackKey) && Time.time >= attackNext)
        {
            attackNext = Time.time + attackCooldown;
            attackAnim.SetTrigger("Attack2");
            OnAttackSquare();
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireCube(attackPoint.position, squareAttackRange);
    }
}
