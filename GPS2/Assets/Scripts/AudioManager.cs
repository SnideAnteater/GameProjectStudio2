using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource music;
    public Slider volume;
    public Slider fxVolume;

    void Start()
    {
        volume.value = PlayerPrefs.GetFloat("MusicVolume");
        fxVolume.value = PlayerPrefs.GetFloat("FxVolume");
    }

    void Update()
    {
        music.volume = volume.value;
    }

    public void VolumePrefs()
    {
        PlayerPrefs.SetFloat("MusicVolume", music.volume);
        PlayerPrefs.SetFloat("FxVolume", fxVolume.value);
    }
}
