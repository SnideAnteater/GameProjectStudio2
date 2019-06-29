using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformPhysics : MonoBehaviour
{
    private float xMove, yMove, prevX, prevY;
    bool contact;
    private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Player"))
        {
            GetPos();
            print("contact");
            contact = true;
            
            player = other.gameObject;
        }
           
    }

    private void OnTriggerExit(Collider other)
    {
        print("contact nulled");
        contact = false;
    }

    private void Update()
    {
        if(contact)
        {
            MoveSync();
            GetPos();
        }
        
    }

    private void GetPos()
    {
        prevX = this.transform.position.x;
        prevY = this.transform.position.y;
    }

    private void MoveSync()
    {
        xMove = this.transform.position.x - prevX ;
        yMove = this.transform.position.y - prevY ;
        player.transform.Translate(xMove, yMove, 0,Space.World);
    }


}
