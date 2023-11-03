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
    }

    public void Mobile()
    {
        SceneManager.LoadScene("Maze(Mobile)");
    }


}
