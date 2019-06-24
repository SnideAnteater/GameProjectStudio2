using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Transform cP1;
    public Transform cP2;
    public Transform cP3;
    public Transform Chase1;
    public Transform Chase2;

    private bool IsCP1Checked;
    private bool IsCP2Checked;
    private bool IsCP3Checked;


    void Start()
    {
        IsCP1Checked = false;
        IsCP2Checked = false;
        IsCP3Checked = false;

    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "Hazard")
        {
            //Debug.Log("Dead");
            //Destroy(this.gameObject);
            if(IsCP1Checked)
            {
                this.gameObject.transform.position = cP1.transform.position;
            }
            else if(IsCP1Checked && IsCP2Checked)
            {
                Chase1.gameObject.SetActive(false);
                this.gameObject.transform.position = cP2.transform.position;
            }
            else if (IsCP1Checked && IsCP2Checked && IsCP3Checked)
            {
                Chase2.gameObject.SetActive(false);
                this.gameObject.transform.position = cP3.transform.position;
            }
            else
            {
                SceneManager.LoadScene("POC");
            }
        }*/
        /*else*/ if (collision.gameObject.tag == "Exit")
        {
            SceneManager.LoadScene("POC");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Checkpoint1")
        {
            Debug.Log("CP1");
            IsCP1Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint2")
        {
            Debug.Log("CP2");
            Chase1.gameObject.SetActive(true);
            IsCP2Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint3")
        {
            Debug.Log("CP3");
            Chase2.gameObject.SetActive(true);
            IsCP3Checked = true;
        }
    }
}
