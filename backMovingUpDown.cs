using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class backMovingUpDown : MonoBehaviour
{
    int status;

    public float speedY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status == 0)
        {
            moveDown();
        }else
        {
            moveUp();
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    { 

        if (other.gameObject.tag == "coliderUp" || other.gameObject.tag == "coliderDown")
        {
            if (status == 0)
            {
                status = 1;
            }else
            {
                status = 0;
            }
        }
    }

    void moveUp(){
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y + speedY,this.transform.position.z);
    }

    void moveDown(){
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y - speedY,this.transform.position.z);
    }
    
}
