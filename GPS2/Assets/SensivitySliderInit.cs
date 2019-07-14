using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensivitySliderInit : MonoBehaviour
{
    public Slider sensitivitySlider;
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.HasKey("Sensitivity"))
        sensitivitySlider.value = PlayerPrefs.GetFloat("Sensitivity");
        else
        PlayerPrefs.SetFloat("Sensitivity", sensitivitySlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("Sensitivity", sensitivitySlider.value);
    }
}
