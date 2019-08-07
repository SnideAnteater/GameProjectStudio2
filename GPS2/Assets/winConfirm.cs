using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winConfirm : MonoBehaviour
{
    public void levelsPressed()
    {
        SceneManager.LoadScene("LevelSelection");
        Time.timeScale = 1f;
    }
}
