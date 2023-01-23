using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public Button startButton;
    public GameObject startMenu;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<PlayerMovement>().gameStart = false;
        startMenu.SetActive(true);
    }

    public void OnStartButton ()
    {
        FindObjectOfType<PlayerMovement>().gameStart = true;
        startMenu.SetActive(false);
    }
}
