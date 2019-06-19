using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Transform cP1;
    public Transform cP2;
    public Transform cP3;

    private bool IsCP1Checked;
    private bool IsCP2Checked;
    private bool IsCP3Checked;


    void Start()
    {
        IsCP1Checked = false;
        IsCP2Checked = false;
        IsCP3Checked = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Hazard"))
        {
            //Destroy(this.gameObject);
            if(IsCP1Checked)
            {
                this.gameObject.transform.position = cP1.transform.position;
            }
            else if(IsCP1Checked && IsCP2Checked)
            {
                this.gameObject.transform.position = cP2.transform.position;
            }
            else if (IsCP1Checked && IsCP2Checked && IsCP3Checked)
            {
                this.gameObject.transform.position = cP3.transform.position;
            }
        }
        else if (collision.gameObject.tag.Equals("Exit"))
        {
            SceneManager.LoadScene("POC");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Checkpoint1")
        {
            IsCP1Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint2")
        {
            IsCP2Checked = true;
        }
        else if (collider.gameObject.tag == "Checkpoint3")
        {
            IsCP3Checked = true;
        }
    }
}
