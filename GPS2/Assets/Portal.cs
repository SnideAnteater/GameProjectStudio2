using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public GameObject otherPortal;
    bool isExit = false;
    bool time = true;
    float timer = 3;

    void Start()
    {
        
    }

    void Update()
    {
        if(time == false)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
             {
                 time = true;
                 isExit = false;
                 timer = 3;
             }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isExit == false && time == true)
        {
            collision.transform.position = otherPortal.transform.position + transform.forward + transform.forward + transform.up + transform.up + transform.up;
            isExit = true;
            time = false;
            
        }
    }
}
