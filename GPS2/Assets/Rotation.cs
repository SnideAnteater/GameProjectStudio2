using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensitivity = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2)
            this.transform.Rotate(0, 0, touch.deltaPosition.y*sensitivity);
            else
            this.transform.Rotate(0, 0, -(touch.deltaPosition.y*sensitivity));

        }


    }

}
