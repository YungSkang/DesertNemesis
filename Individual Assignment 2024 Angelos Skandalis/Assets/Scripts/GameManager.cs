using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject failLevelUI;
    public void CompleteLevel() 
    {
        Debug.Log("You Won!");
        completeLevelUI.SetActive(true);
    }

    public void EndGame(bool gameHasEnded) 
    {
            failLevelUI.SetActive(true);
        Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
    }
    void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
