using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    public int healthAmount = 20; // Amount of health to increase

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealh2 playerHealth = collision.GetComponent<PlayerHealh2>();

            if (playerHealth != null)
            {
                playerHealth.IncreaseHealth(healthAmount);
                Destroy(gameObject);
            }
        }
    }
}
