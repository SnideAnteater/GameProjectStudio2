using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Vector3 MovingDirection;
    public bool upDown = false;
    public bool leftRight = false;
    public int maxSpeed;
    private Vector3 startPosition;
    public float DistanceY;
    float PositionY;

    // Use this for initialization
    void Start()
    {
        //maxSpeed = 3;
        startPosition = gameObject.transform.position;
        PositionY = gameObject.transform.position.y + DistanceY;
    }

    // Update is called once per frame
    void Update()
    {
        MoveVertical();
    }

    void MoveVertical()
    {
            

     
    }

    /*bool up = true;
    bool down = false;
    bool left = true;
    bool right = false;
    Vector3 initialPos;
    public float speed = 2.0f;
    float maxDistx;
    float minDistx;
    
    float DistanceTravel;

    void Start()
    {
        initialPos = gameObject.transform.position;
        maxDisty = initialPos.y + DistanceTravel;
        maxDistx = initialPos.x + DistanceTravel;
        minDistx = initialPos.x - DistanceTravel;
        minDisty = initialPos.y - DistanceTravel;
    }
    // Update is called once per frame
    void Update()
    {
        if (upDown == true || leftRight == false)
        {
            if(up == true)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * speed);
                if (transform.position.y > maxDisty)
                {
                    up = false;
                    down = true;
                }
            }

            if (down == true)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * -speed);
                if (transform.position.y < minDisty)
                {
                    up = true;
                    down = false;
                }
            }
        }
    }*/
}
