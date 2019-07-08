using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawMovement : MonoBehaviour
{
    public float speed = 5;
    public GameObject[] checkpoints = new GameObject[5];
    private int currentPoint = 0;
    private Vector3 target;
    private bool ascending = true;

    public enum moveType {reversing=0, looping=1};
    public moveType type = moveType.reversing;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        target = checkpoints[currentPoint].transform.position;
        this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(target.x, target.y,this.transform.position.z), Time.deltaTime * speed);
        if(Vector2.Distance(this.transform.position,target) <= 0.1)
        {
            if (type == moveType.reversing)
                ChangePoint();
            else
                ChangePointLoop();
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

        //target = checkpoints[currentPoint].transform.position;

    }

    void ChangePointLoop()
    {

        currentPoint++;
        if (currentPoint >= checkpoints.Length )
        {
            currentPoint = 0;
        }
        

        //target = checkpoints[currentPoint].transform.position;

    }
}
