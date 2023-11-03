using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{
    public GameObject PacmanFail;
    public GameObject Confirm;
    public GameObject GAMEOVER;
    public GameObject MainUI;

    // Start is called before the first frame update
    void Start()
    {
        PacmanFail.SetActive(false);
        GAMEOVER.SetActive(false);
        Confirm.SetActive(false);
        MainUI.SetActive(true);
    }

    public void Reveal()
    {
        MainUI.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Maze");
    }

    public void NoPlayAgain()
    {
        Confirm.SetActive(true);
        PacmanFail.SetActive(false);
    }

    public void RealGameOver()
    {
        Application.Quit();
    }
}
