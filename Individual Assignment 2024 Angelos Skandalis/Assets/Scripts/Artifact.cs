using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{
    public GameObject pickupEffect;
    public bool artifactCollected;
    public PlayerHUD hud;

    // Rotation speed
    public float rotationSpeed = 50f;
    private void Start()
    {
        artifactCollected = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    public void getArtifact() 
    {
        Debug.Log("Ancient Artifact Collected!");
        Instantiate(pickupEffect, transform.position, transform.rotation);
        artifactCollected = true;
        hud.ShowArtifact(artifactCollected);
        Destroy(gameObject);
    }
    void PickUp(Collider Player)
    {
        getArtifact();
    }

    void Update()
    {
        // Rotate the PowerUp constantly
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
