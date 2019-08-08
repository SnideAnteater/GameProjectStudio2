using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winConfirm : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void replay()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
    }

    public void level3()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
    }

    public void level2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }

    public void level1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
}
