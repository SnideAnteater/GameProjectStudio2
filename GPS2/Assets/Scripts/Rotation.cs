using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensitivity = 0.5f;
    public Rigidbody rb;
    float curRotation;
    Vector3 eulerAngleVelocity;
    bool jiggle;


    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        curRotation = this.transform.rotation.z;
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2)
                this.transform.Rotate(0, 0, touch.deltaPosition.normalized.y*Time.deltaTime*sensitivity);//TRY ADD TORQUE OR ADD FORCE
                
             // rb.AddTorque(0, 0, touch.deltaPosition.y * Time.deltaTime * sensitivity);

            else
                //  rb.AddTorque(0, 0, touch.deltaPosition.y * Time.deltaTime * sensitivity);
              
            
            this.transform.Rotate(0, 0, -(touch.deltaPosition.normalized.y * Time.deltaTime*sensitivity));
           
        } //add torque or transform rotate

       /* if (Input.touchCount > 0) // move rotation
        {
            Touch touch = Input.GetTouch(0);



            if (touch.position.x > Screen.width / 2)
            {
                eulerAngleVelocity = new Vector3(0, 0, touch.deltaPosition.y);
               
            }
            else
            { 
            eulerAngleVelocity = new Vector3(0, 0, -touch.deltaPosition.y);
            
            }
            
            Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime*sensitivity);
            rb.MoveRotation(rb.rotation * deltaRotation);


        }*/
       
    }

    
}
