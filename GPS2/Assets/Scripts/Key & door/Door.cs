using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    bool hasKey = false;

    void Unlock()
    {
        hasKey = true;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(hasKey)
        {
            Destroy(this.gameObject);
        }
    }
}
