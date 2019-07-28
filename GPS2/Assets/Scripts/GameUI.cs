using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameUI : MonoBehaviour
{
    public GameObject settingUI;
    public GameObject pauseUI;
    public AudioSource music;

    void Start()
    {
        if (music != null)//prevent null errors
            music.volume = PlayerPrefs.GetFloat("MusicVolume");
        pauseUI.SetActive(false);
        settingUI.SetActive(false);
    }

    void Update()
    {
        
    }

    public void isPaused()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void isResumed()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void isSetting()
    {
        pauseUI.SetActive(false);
        settingUI.SetActive(true);

    }

    public void isNotSetting()
    {
        settingUI.SetActive(false);
        pauseUI.SetActive(true);
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
