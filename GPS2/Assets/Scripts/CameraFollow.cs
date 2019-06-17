using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject character;
 
    
    // Start is called before the first frame update
    void Start()
    {
     
       // zoom = Camera.main.transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 charaPos = character.transform.position;
        Camera.main.transform.position = new Vector3(charaPos.x, charaPos.y, Camera.main.transform.position.z);
    }
}
