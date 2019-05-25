using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public MeshCollider hook;
    // Start is called before the first frame update
    void Start()
    {
        hook = this.GetComponent("MeshCollider") as MeshCollider;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.SendMessage("Hooked");
        }
    }
}
