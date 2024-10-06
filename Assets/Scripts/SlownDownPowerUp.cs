using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.Helper;

public class SlownDownPowerUp : MonoBehaviour
{
    public float slowAmount = 0.5f;  // Slow down by 50%
    public float slowDuration = 3f;  // Duration of the slow effect

    public Health health;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Check if the player picks up the power-up
        {
            // Apply slow effect to enemies
            ApplySlowToEnemies();

            health.Heal(1);

            // Destroy the power-up after use
            Destroy(gameObject);
        }
    }

    private void ApplySlowToEnemies()
    {
        // Find all enemies in the scene (you can optimize this with more specific checks)
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            EnemyController enemyController = enemy.GetComponent<EnemyController>();
            if (enemyController != null)
            {
                enemyController.ApplySlow(slowAmount, slowDuration);
            }
        }
    }
}
