using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingUI;
    public AudioSource buttonSoundEffect;
    public AudioSource music;


    void Start()
    {
        if(music!=null)
        music.volume = PlayerPrefs.GetFloat("MusicVolume");
        settingUI.SetActive(false);
    }

    void Update()
    {
        if (buttonSoundEffect != null)
            buttonSoundEffect.volume = PlayerPrefs.GetFloat("FxVolume");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SettingMenu()
    {
        settingUI.SetActive(true);
    }

    public void Back()
    {
        settingUI.SetActive(false);
    }

    public void LevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }
}

