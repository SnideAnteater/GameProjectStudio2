using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    public KeyCode pressUp;
    public KeyCode pressDown;
    float rotationDir;
    public GameObject player;
    public float sensitivity = 1;
    Vector3 charaPos;

    void Start()
    {
        rotationDir = this.transform.eulerAngles.z;
    }

    void Update()
    {
        charaPos = player.transform.position;
        if (Input.GetKey(pressUp))
            //GetComponent<Transform>().eulerAngles = new Vector3(0, 0, rotationDir--);
            this.transform.RotateAround(charaPos, new Vector3(0, 0, 1), 1 * Time.deltaTime * sensitivity);
        if (Input.GetKey(pressDown))
            //GetComponent<Transform>().eulerAngles = new Vector3(0, 0, rotationDir++);
            this.transform.RotateAround(charaPos, new Vector3(0, 0, 1), -1 * Time.deltaTime * sensitivity);
    }
}
