using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnPowerUp : MonoBehaviour
{
    public float burnDuration = 5f;      // Duration of the burning effect
    public float burnDamagePerSecond = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Check if the player picks up the power-up
        {
            // Apply burn effect to enemies
            ApplyBurnToEnemies();

            // Destroy the power-up after use
            Destroy(gameObject);
        }
    }

    private void ApplyBurnToEnemies()
    {
        // Find all enemies in the scene (you can optimize this with more specific checks, like a certain radius or trigger zone)
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            BurningEffect burnEffect = enemy.GetComponent<BurningEffect>();
            if (burnEffect != null)
            {
                burnEffect.ApplyBurn(burnDuration, burnDamagePerSecond);
            }
        }
    }
}
