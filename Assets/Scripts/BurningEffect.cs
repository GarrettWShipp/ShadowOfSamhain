using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningEffect : MonoBehaviour
{
    public float burnDuration = 5f;      // Duration of the burning effect
    public float damagePerSecond = 10f;  // How much damage per second
    private float burnTimer = 0f;
    private bool isBurning = false;

    //private EnemyHealth enemyHealth;     // Assume the enemy has a health script

    private void Start()
    {
        //enemyHealth = GetComponent<EnemyHealth>();
    }

    private void Update()
    {
        if (isBurning)
        {
            burnTimer -= Time.deltaTime;

            if (burnTimer > 0)
            {
                ApplyBurnDamage();
            }
            else
            {
                StopBurning();
            }
        }
    }

    public void ApplyBurn(float duration, float damage)
    {
        burnDuration = duration;
        damagePerSecond = damage;
        burnTimer = burnDuration;
        isBurning = true;
    }

    private void ApplyBurnDamage()
    {
        // Deal damage per second
        float damage = damagePerSecond * Time.deltaTime;
        //enemyHealth.TakeDamage(damage);
    }

    private void StopBurning()
    {
        isBurning = false;
        burnTimer = 0;
    }
}
