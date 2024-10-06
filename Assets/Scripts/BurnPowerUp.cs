using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.Helper;

public class BurnPowerUp : MonoBehaviour
{
    public float burnDuration = 5f;      // Duration of the burning effect
    public float burnDamagePerSecond = 10f;

    public Health health;
    private PlayerManager m_player;

    private void Awake()
    {
        m_player = GetComponent<PlayerManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Check if the player picks up the power-up
        {
            m_player = other.GetComponent<PlayerManager>();

            if (m_player.webPower == false)
            {
                m_player.firePower = true;
            }
            else
            {
                m_player.webPower = false;
                m_player.firePower = true;
            }
            health.Heal(1); 

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
