using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealh2 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthManager healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            TakeDamage(20);
        }
        
        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;

        // Ensure current health doesn't exceed max health
        currentHealth = Mathf.Min(currentHealth, maxHealth);

        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Grab Health
        if (collision.CompareTag("Health"))
        {
            IncreaseHealth(5);
            Destroy(collision.gameObject);
        }
    }
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
