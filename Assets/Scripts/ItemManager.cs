using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public int healthRestore, armorRestore, doubledmg;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Grab Health
        if (collision.CompareTag("Health"))
        {
            healthRestore += 50;
            Destroy(collision.gameObject);
        }
        // Grab Armor
        if (collision.CompareTag("Armor")){
            armorRestore += 25;
            Destroy(collision.gameObject);
        }
        //Grab Double Damage
        if (collision.CompareTag("DoubleDmg")){
            doubledmg += 3;
            Destroy(collision.gameObject);
        }
    }
}
