using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject character;
    public float speed = 0.3f;
    public float threshold = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
     
       // zoom = Camera.main.transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 charaPos = character.transform.position;

        if(Vector2.Distance(charaPos,Camera.main.transform.position)>threshold)
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, new Vector3(charaPos.x, charaPos.y, Camera.main.transform.position.z), speed);
    }
}
