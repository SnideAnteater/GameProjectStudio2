using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointGateMovement : MonoBehaviour
{
    public GameObject doorDestination;
    public float speed = 1.0f;
    bool enable=false;
    // Start is called before the first frame update
    void Awake()
    {
        enable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(enable)
        this.transform.position = Vector3.MoveTowards(this.transform.position,new Vector3(doorDestination.transform.position.x, doorDestination.transform.position.y, this.transform.position.z), Time.deltaTime*speed);
    }
}
