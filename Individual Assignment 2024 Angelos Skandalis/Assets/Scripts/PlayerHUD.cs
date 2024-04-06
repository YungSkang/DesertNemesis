using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private TMP_Text currentHealthText;
    [SerializeField] private TMP_Text maxHealthText;
    [SerializeField] private Image HUDImage;
    [SerializeField] private Image GreenA;
    [SerializeField] private Image BraceletImage;


    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        currentHealthText.text = currentHealth.ToString();
        maxHealthText.text = maxHealth.ToString();

        if (currentHealth <= 0)
        {
            // Change color to red with reduced alpha (120/255)
            HUDImage.color = new Color(1f, 0f, 0f, 120f / 255f);
        }
        else
        {
            // Reset color to fully transparent red (0 alpha)
            HUDImage.color = new Color(1f, 0f, 0f, 0f);
        }
    }

    public void ShowArrow(bool powerJumpUnlocked)
    {
        if (powerJumpUnlocked)
        {
            GreenA.gameObject.SetActive(true);
        }
        else
        {
            GreenA.gameObject.SetActive(false);
        }
    }

    public void ShowArtifact(bool artifactCollected)
    {
        if (artifactCollected)
        {
            BraceletImage.gameObject.SetActive(true);
        }
        else
        {
            BraceletImage.gameObject.SetActive(false);
        }
    }
}
