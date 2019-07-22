using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLevel1Script : MonoBehaviour
{
    public GameObject rotateMap;
    public AudioSource deathSound;
    public AudioSource cpSound;

    public Transform cP1;
    public Transform cP2;
    public Transform cP3;

    public GameObject cP1Wall;
    public GameObject cP2Wall;
    public GameObject cP3Wall;

    private bool IsCP1Checked;
    private bool IsCP2Checked;
    private bool IsCP3Checked;

    public float cP1Rotation;
    public float cP2Rotation;
    public float cP3Rotation;


    void Start()
    {

        cP1Wall.SetActive(false);
        cP2Wall.SetActive(false);
        cP3Wall.SetActive(false);
        IsCP1Checked = false;
        IsCP2Checked = false;
        IsCP3Checked = false;

    }

    void Update()
    {
        deathSound.volume = PlayerPrefs.GetFloat("FxVolume");
        cpSound.volume = PlayerPrefs.GetFloat("FxVolume");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            Dead();
        }
        if (other.gameObject.tag == "Failsafe")
        {
            FailsafeTp();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Hazard")
        {
            Dead();
        }
        else if (collision.gameObject.tag == "Exit")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void FailsafeTp()
    {
        if(IsCP3Checked)
        {
            this.gameObject.transform.position = cP3.transform.position;
        }
        else if (IsCP2Checked)
        {
            this.gameObject.transform.position = cP2.transform.position;
        }
        else if (IsCP1Checked)
        {
            this.gameObject.transform.position = cP1.transform.position;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Checkpoint1")
        {
            cpSound.Play();
            cP1Wall.SetActive(true);
            Debug.Log("CP1");
            IsCP1Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint2")
        {
            cpSound.Play();
            cP2Wall.SetActive(true);
            Debug.Log("CP2");
            IsCP2Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint3")
        {
            cpSound.Play();
            cP3Wall.SetActive(true);
            Debug.Log("CP3");
            IsCP3Checked = true;
        }
    }

    private void Dead()
    {
        Debug.Log("Dead");
        deathSound.Play();
        //Destroy(this.gameObject);
        if (IsCP1Checked && !IsCP2Checked && !IsCP3Checked)
        {
            this.gameObject.transform.position = cP1.transform.position;
            ResetRotation(cP1Rotation);
        }
        else if (IsCP1Checked && IsCP2Checked && !IsCP3Checked)
        {
            this.gameObject.transform.position = cP2.transform.position;
            ResetRotation(cP2Rotation);
        }
        else if (IsCP1Checked && IsCP2Checked && IsCP3Checked)
        {
            this.gameObject.transform.position = cP3.transform.position;
            ResetRotation(cP3Rotation);
        }
    }

    private void ResetRotation(float rot)
    {
        // float offsetRot = rotateMap.transform.rotation.z - rot;
        
        rotateMap.transform.RotateAround(this.transform.position, new Vector3(0, 0, -1), rotateMap.transform.rotation.eulerAngles.z);
        rotateMap.transform.RotateAround(this.transform.position, new Vector3(0, 0, 1), rot);
    }
}

