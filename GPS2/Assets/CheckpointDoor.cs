using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDoor : MonoBehaviour
{
    public GameObject doorDestination;
    public GameObject closePos;
    private bool triggered = false;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && triggered == false)
        {
            doorDestination.transform.position = new Vector3(closePos.transform.position.x, closePos.transform.position.y, closePos.transform.position.z);
        }
    }
}
