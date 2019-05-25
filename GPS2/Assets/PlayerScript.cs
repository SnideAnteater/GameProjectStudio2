using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector3 lastPos;
    bool hooked = false;
    bool unhook = false;
    // Start is called before the first frame update
    void Start()
    {
        //GameManager.Instance.player = this.gameObject;
        hooked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(unhook)
        {
            if (transform.position != lastPos)
            {
                unhook = false;
            }
        }
       
        if (hooked && unhook==false)
            transform.position = lastPos;
    }

    void Hooked()
    {
        hooked = true;
        lastPos = transform.position;
    }

    void Interact()
    {
        hooked = false;
        unhook = true;
    }
}
