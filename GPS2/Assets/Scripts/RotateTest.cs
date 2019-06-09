using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    public KeyCode pressUp;
    public KeyCode pressDown;
    int rotationDir;

    void Start()
    {
        rotationDir = 0;
    }

    void Update()
    {
        if (Input.GetKey(pressUp))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, rotationDir--);
        if (Input.GetKey(pressDown))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, rotationDir++);
    }
}
