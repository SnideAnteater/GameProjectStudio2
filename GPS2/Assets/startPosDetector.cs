﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPosDetector : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = player.transform.position;
    }

}