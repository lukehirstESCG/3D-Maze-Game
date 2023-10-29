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
    public GameObject EnergyBar;

    // Start is called before the first frame update
    void Start()
    {
        PacmanFail.SetActive(false);
        GAMEOVER.SetActive(false);
        Confirm.SetActive(false);
        EnergyBar.SetActive(true);
    }

    public void Reveal()
    {
        EnergyBar.SetActive(false);
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
        Confirm.SetActive(false);
        GAMEOVER.SetActive(true);

        Application.Quit();

        GAMEOVER.SetActive(false);
    }
}
