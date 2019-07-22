using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject tpLocation;
    public float timeToSpawn;
    private float timer;


    private void Start()
    {
        timer = timeToSpawn;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Player.transform.position = tpLocation.transform.position;
            tpLocation.SetActive(false);
        }
    }

    void LoseTime()
    {
        if(timer > 0)
        {
            timer = timer - Time.deltaTime;
        }
        else if(timer <= 0)
            {
                tpLocation.SetActive(true);
                timer = timeToSpawn;
            }
    }

    private void Update()
    {
        if(tpLocation.activeInHierarchy == false)
        {
            LoseTime();
        }
    }
}
