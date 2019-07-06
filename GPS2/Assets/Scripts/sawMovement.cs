using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawMovement : MonoBehaviour
{
    public float speed = 5;
    public GameObject[] checkpoints = new GameObject[5];
    private int currentPoint =0 ;
    private Vector3 target;
    private bool ascending = true;
    // Start is called before the first frame update
    void Start()
    {
        target = checkpoints[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(target.x, target.y,this.transform.position.z), Time.deltaTime * speed);
        if(Vector2.Distance(this.transform.position,target) == 0)
        {
            ChangePoint();
        }
    }

    void ChangePoint()
    {
        if (ascending)
            currentPoint++;
        else
            currentPoint--;
        if(currentPoint<=0)
        {
            ascending = true;
        }
        else if(currentPoint>=checkpoints.Length-1)
        {
            ascending = false;
        }

        target = checkpoints[currentPoint].transform.position;

    }
}
