using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_WallLeft : MonoBehaviour
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
            if (FindObjectOfType<tutorial>().status == 1)
            {
                FindObjectOfType<tutorial>().addSta();
            }else if (FindObjectOfType<tutorial>().status == 3)
            {
                FindObjectOfType<tutorial>().addSta();
            }
            
        }
    }

    
}
