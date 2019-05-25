using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   // Vector3 lastPos;
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
           
        }
       else if (hooked && unhook==false)
            transform.position = GameManager.Instance.activeHook.transform.position;
    }

    void Hooked()
    {
        if(unhook==false)
        hooked = true;
       // lastPos = transform.position;
    }

    void Interact()
    {
        hooked = false;
        unhook = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        unhook = false;
    }
}
