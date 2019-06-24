using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotFollow : MonoBehaviour
{
    public GameObject character;
    public float sensitivity = 50f;


    // Start is called before the first frame update
    void Start()
    {

        // zoom = Camera.main.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 charaPos = character.transform.position;
      
       
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2)
             //   this.transform.Rotate(0, 0, touch.deltaPosition.normalized.y * Time.deltaTime * sensitivity);//TRY ADD TORQUE OR ADD FORCE
                this.transform.RotateAround(charaPos, new Vector3(0, 0, 1), touch.deltaPosition.normalized.y * Time.deltaTime * sensitivity);
            

            else
                //  this.transform.Rotate(0, 0, -(touch.deltaPosition.normalized.y * Time.deltaTime * sensitivity));
                this.transform.RotateAround(charaPos, new Vector3(0, 0, 1), -(touch.deltaPosition.normalized.y * Time.deltaTime * sensitivity));



        } 
    }
}
