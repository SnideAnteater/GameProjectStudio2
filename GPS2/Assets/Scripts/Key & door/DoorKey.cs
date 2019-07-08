using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    public float speed = 10;
    public Door door;
    // Start is called before the first frame update
    void Start()
    {
       

    }
    private void Update()
    {
        this.transform.Rotate(0, 1*Time.deltaTime*speed, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            door.gameObject.SendMessage("Unlock");

        }
    }
}
