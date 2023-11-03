using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TypeSelect : MonoBehaviour
{
    public GameObject DeviceSelect;

    public void Windows()
    {
        SceneManager.LoadScene("Maze(Windows)");

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Mobile()
    {
        SceneManager.LoadScene("Maze(Mobile)");

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }


}
