using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensitivity = 0.5f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //rb = GetComponentsInChildren<Rigidbody>;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2)
            this.transform.Rotate(0, 0, touch.deltaPosition.y*Time.deltaTime*sensitivity);//TRY ADD TORQUE OR ADD FORCE
            else
            this.transform.Rotate(0, 0, -(touch.deltaPosition.y*Time.deltaTime*sensitivity));
            //Rigidbody.AddTorque(0, 0, -(touch.deltaPosition.y * Time.deltaTime * sensitivity));
        }
    }

}
