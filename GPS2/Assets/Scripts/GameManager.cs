using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        if (Instance == null) Instance = this;//assign self as singleton if none exists
        else if (Instance != this) Destroy(this.gameObject);//if singleton exists, kill self

        DontDestroyOnLoad(this.gameObject);
    }


}