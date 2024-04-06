using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Artifact artifact;
    void OnTriggerEnter()
    {
        if (artifact.artifactCollected)
        {
            gameManager.CompleteLevel();
        }
    }
}
