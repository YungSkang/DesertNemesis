using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharachterStats
{
    private PlayerHUD hud;
    [SerializeField] private Artifact bracelet;
    [SerializeField] private PowerUp superJump;
    public GameObject rulesShow;
    public GameObject enemy;

    private void Start()
    {
        InitVariables();
        GetReferences();
        Alive();
    }
    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject == enemy))
        {
            TakeDamage(1);
        }
    }

    private void GetReferences() 
    {
        hud = GetComponent<PlayerHUD>();
    }

    public override void Alive()
    {
        base.Alive();
        hud.UpdateHealth(health, maxHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(1);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            superJump.getPower();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            bracelet.getArtifact();
        }

        if (Input.GetKey(KeyCode.M))
        {
            rulesShow.SetActive(true);
        }
        else
        {
            rulesShow.SetActive(false);
        }
    }
}
