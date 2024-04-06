using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public PlayerHUD hud;
    public bool powerJumpUnlocked;

    // Rotation speed
    public float rotationSpeed = 50f;
    private void Start()
    {
        powerJumpUnlocked = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    public void getPower() 
    {
        Debug.Log("Long Jump Unlocked!");
        Instantiate(pickupEffect, transform.position, transform.rotation);
        powerJumpUnlocked = true;
        hud.ShowArrow(powerJumpUnlocked);
        Destroy(gameObject);
    } 
    void PickUp(Collider Player)
    {
        getPower();
    }

        void Update()
        {
            // Rotate the PowerUp constantly
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
}
