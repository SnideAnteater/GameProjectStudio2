using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    bool hasKey = false;
    public GameObject destination;
    public float speed = 5;
    Vector3 target;
    bool open = false;

    void Unlock()
    {
        hasKey = true;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(hasKey)
        {
            //Destroy(this.gameObject);
            open = true;
        }
    }
    private void Update()
    {
        target = new Vector3(destination.transform.position.x, destination.transform.position.y, this.transform.position.z);
        if (open)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, target, Time.deltaTime * speed);
        }
    }



}
