using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.Helper;

public class SlownDownPowerUp : MonoBehaviour
{

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

            if (m_player.firePower == false)
            {
                m_player.webPower = true;
            }
            else
            {
                m_player.firePower = false;
                m_player.webPower = true;
            }
            
            m_player.health.Heal(1);

            // Destroy the power-up after use
            Destroy(gameObject);
        }
    }

}
