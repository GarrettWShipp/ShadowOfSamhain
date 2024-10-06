using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float originalSpeed = 5f;   // Original speed of the enemy
    public float slowedSpeed = 2f;     // Reduced speed when slowed
    private float currentSpeed;
    private bool isSlowed = false;
    private float slowDuration = 3f;   // Time the slowdown effect lasts
    private float slowTimer = 0f;

    private void Start()
    {
        currentSpeed = originalSpeed;
    }

    private void Update()
    {
        if (isSlowed)
        {
            slowTimer -= Time.deltaTime;

            if (slowTimer <= 0)
            {
                RemoveSlowEffect();
            }
        }

        // Example movement code
        MoveEnemy();
    }

    public void ApplySlow(float slowAmount, float duration)
    {
        slowedSpeed = originalSpeed * (1f - slowAmount);  // Slow amount as percentage
        slowDuration = duration;
        currentSpeed = slowedSpeed;
        slowTimer = slowDuration;
        isSlowed = true;
    }

    private void RemoveSlowEffect()
    {
        currentSpeed = originalSpeed;
        isSlowed = false;
    }

    private void MoveEnemy()
    {
        // Example movement (can be replaced with AI movement code)
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
