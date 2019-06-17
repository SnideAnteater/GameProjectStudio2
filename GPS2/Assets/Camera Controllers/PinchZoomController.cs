using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoomController : MonoBehaviour
{
    [SerializeField] float initDistance = 0f;
    [SerializeField] float curDistance = 0f;
    [SerializeField] float pinchDelta = 0f;
    [SerializeField] float zoomSpeed = 10f;
    [SerializeField] float decayRate = 0.5f;
    bool zoomIn;

    // Update is called once per frame
    void Update()
    {
        GetPinchDelta();
        ZoomCamera();
        DecayZoom();

    }

    private void DecayZoom()
    {
        pinchDelta = Mathf.MoveTowards(pinchDelta, 0f, Time.deltaTime * decayRate);
    }

    private void ZoomCamera()
    {
        Camera.main.transform.Translate(0, 0, pinchDelta * Time.deltaTime * zoomSpeed);
    }

    private void GetPinchDelta()
    {

        //cancel calculation if less than or morethan 2 fingers on screen in teh same frame
        if (Input.touchCount != 2) return;

        Vector3 touchPos0 = Input.GetTouch(0).position;
        

        touchPos0.x = touchPos0.x / Screen.width;
        touchPos0.y = touchPos0.y / Screen.height;

        Vector3 touchPos1 = Input.GetTouch(1).position;
        touchPos1.x = touchPos1.x / Screen.width;
        touchPos1.y = touchPos1.y / Screen.height;
        //check init distance when the second finger first contacts the screen
        if (Input.GetTouch(1).phase == TouchPhase.Began)
        {
            

            this.initDistance = Vector3.Distance(touchPos0, touchPos1);
        }
        //compare distance for zoom in out state & reset initial distance
        if(Vector3.Distance(touchPos0, touchPos1) > curDistance)//check zoomin
        {
            if(zoomIn == false)
            {
                this.initDistance = Vector3.Distance(touchPos0, touchPos1);//change zoom state
            }
            zoomIn = true;
        }
        else if (Vector3.Distance(touchPos0, touchPos1) < curDistance) //check zoomout
        {
            if (zoomIn == true)
            {
                this.initDistance = Vector3.Distance(touchPos0, touchPos1); // change zoom state
            }
            zoomIn = false;
        }
        //get current distance
        this.curDistance = Vector3.Distance(touchPos0,touchPos1);

        //check if eitehr finget is moving, then calculate the delta
        if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
        {
            pinchDelta = curDistance - initDistance;
        }
    }
}
