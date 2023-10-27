using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI Message;
    public TextMeshProUGUI PlayAgain;
    public GameObject PacmanFail;
    public GameObject Confirm;
    public GameObject GAMEOVER;
    public Button Yes;
    public Button Exit;
    public float delay = 5;

    // Start is called before the first frame update
    void Start()
    {
        Message.enabled = false;
        PlayAgain.enabled = false;
        Yes.enabled = false;
        Exit.enabled = false;
        PacmanFail.SetActive(false);
        GAMEOVER.SetActive(false);
        Confirm.SetActive(false);
    }

    private void Update()
    {
        Reveal();
        Restart();
        NoPlayAgain();
        RealGameOver();
    }

    public void Reveal()
    {
        Message.enabled = true;

        delay = 5;

        delay -= Time.deltaTime;

        PlayAgain.enabled = true;
        Yes.enabled = true;
        Exit.enabled = true;
        delay = 0;
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

        delay = 5;

        delay -= Time.deltaTime;

        delay = 0;

        Application.Quit();

        GAMEOVER.SetActive(false);
    }
}
