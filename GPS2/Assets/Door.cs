using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    void Unlock()
    {
        Destroy(this.gameObject);
    }
}
