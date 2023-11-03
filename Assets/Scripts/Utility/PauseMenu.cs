using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
    }

    void Update()
    {
        TriggerMenu();
    }

    public void TriggerMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void PauseGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
