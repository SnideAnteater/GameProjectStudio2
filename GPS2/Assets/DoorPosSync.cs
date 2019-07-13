using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPosSync : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = door.transform.position;
    }

}
