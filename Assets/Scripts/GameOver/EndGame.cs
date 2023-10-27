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
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        Message.enabled = true;

        yield return new WaitForSeconds(delay);

        PlayAgain.enabled = true;
        Yes.enabled = true;
        Exit.enabled = true;
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
    }
}
