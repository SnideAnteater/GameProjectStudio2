using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   // Vector3 lastPos;
   
    // Start is called before the first frame update
    void Start()
    {
        //GameManager.Instance.player = this.gameObject;
       
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject);
            //SceneManager.LoadScene("LosingScene");
        }
        else if (collision.gameObject.tag.Equals("Exit"))
        {
            //SceneManager.LoadScene("WinningScene");
        }
    }


}
