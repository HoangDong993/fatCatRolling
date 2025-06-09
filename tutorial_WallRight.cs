using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_WallRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


    void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.tag == "Player")
        {
            if (FindObjectOfType<tutorial>().status == 0)
            {
                FindObjectOfType<tutorial>().addSta();
            }else if (FindObjectOfType<tutorial>().status == 2)
            {
                FindObjectOfType<tutorial>().addSta();
            }
            
        }
    }
}
