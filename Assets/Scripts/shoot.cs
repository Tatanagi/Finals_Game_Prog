using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class shoot : MonoBehaviour
{
    public TextMeshProUGUI Ammo_Counter;
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public int maxAmmo = 10; // Set your desired maximum ammo count
    private int currentAmmo;

    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmmo > 0 && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Shoot();
        }
        
        Ammo_Counter.text = currentAmmo.ToString();

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        currentAmmo--;

    }

    // Collision Effect
     private void OnTriggerEnter2D(Collider2D collision)
     {
        //Grab Ammo 
        if (collision.CompareTag("Ammo")){
            currentAmmo += 10;
            Destroy(collision.gameObject);
        }
     }

}