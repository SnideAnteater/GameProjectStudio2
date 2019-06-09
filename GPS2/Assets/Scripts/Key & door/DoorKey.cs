using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
     MeshCollider key;
    public Door door;
    // Start is called before the first frame update
    void Start()
    {
        key = this.GetComponent("MeshCollider") as MeshCollider;

    }

    // Update is called once per frame
    void Update()
    {
        
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
