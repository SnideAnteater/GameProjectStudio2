using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLevel1Script : MonoBehaviour
{
    public Transform cP1;
    public Transform cP2;
    public Transform cP3;

    public GameObject cP1Wall;
    public GameObject cP2Wall;
    public GameObject cP3Wall;

    private bool IsCP1Checked;
    private bool IsCP2Checked;
    private bool IsCP3Checked;


    void Start()
    {

        cP1Wall.SetActive(false);
        cP2Wall.SetActive(false);
        cP3Wall.SetActive(false);
        IsCP1Checked = false;
        IsCP2Checked = false;
        IsCP3Checked = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            Dead();
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

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Checkpoint1")
        {
            cP1Wall.SetActive(true);
            Debug.Log("CP1");
            IsCP1Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint2")
        {
            cP2Wall.SetActive(true);
            Debug.Log("CP2");
            IsCP2Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint3")
        {
            cP3Wall.SetActive(true);
            Debug.Log("CP3");
            IsCP3Checked = true;
        }
    }

    private void Dead()
    {
        Debug.Log("Dead");
        //Destroy(this.gameObject);
        if (IsCP1Checked && !IsCP2Checked && !IsCP3Checked)
        {
            this.gameObject.transform.position = cP1.transform.position;
        }
        else if (IsCP1Checked && IsCP2Checked && !IsCP3Checked)
        {
            this.gameObject.transform.position = cP2.transform.position;
        }
        else if (IsCP1Checked && IsCP2Checked && IsCP3Checked)
        {
            this.gameObject.transform.position = cP3.transform.position;
        }
    }
}

