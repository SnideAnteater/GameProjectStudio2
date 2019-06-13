using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Vector3 MovingDirection;
    public enum dir { vertical=0, horizontal};
    public dir direction = dir.vertical;
    public float speed = 1;
    public float Distance;
    float updatePositionX;
    float updatePositionY;
    float change = 1;   //change course of direction
    private Vector3 startPosition;



    // Use this for initialization
    void Start()
    {
        startPosition = gameObject.transform.position; //takes the x,y,z positions
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if(direction == dir.vertical)
        {
            updatePositionY = this.transform.position.y; //updates to object current position
            if(updatePositionY >= startPosition.y + Distance)
            {
                change *= -1;
            }
            else if(updatePositionY <= startPosition.y - Distance)
            {
                change *= -1;
            }
            this.transform.Translate( 0, Time.deltaTime * change * speed , 0);

        }
        else if(direction == dir.horizontal)
        {
            updatePositionX = this.transform.position.x;
            if (updatePositionX >= startPosition.x + Distance)
            {
                change *= -1;
            }
            else if (updatePositionX <= startPosition.x - Distance)
            {
                change *= -1;
            }
            this.transform.Translate(Time.deltaTime * change * speed, 0, 0);
        }
    }
}
