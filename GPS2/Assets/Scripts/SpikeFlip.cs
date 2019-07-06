using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeFlip : MonoBehaviour
{
    public float secondsPerFlip = 5;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer>= secondsPerFlip)
        {
            timer = 0;
            Flip();
        }
    }

    private void Flip()
    {
       //if(this.transform.rotation.eulerAngles.x == 180)
       
            this.transform.Rotate(180, 0, 0, Space.Self);
        
    }
}
