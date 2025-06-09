using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eniFruit1 : MonoBehaviour
{

    public GameObject shutEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {

            if (other.gameObject.tag == "Player"){

                // shutdown moving direction
                // if (other.gameObject.transform.position.x < transform.position.x)
                // {
                //     if (other.gameObject.transform.position.y < transform.position.y)
                //     {
                //         Config_level.indexEniShutdownMoving = 1;
                //     }else
                //     {
                //         Config_level.indexEniShutdownMoving = 2;
                //     }
                // }else
                // {
                //     if (other.gameObject.transform.position.y < transform.position.y)
                //     {
                //         Config_level.indexEniShutdownMoving = 4;
                //     }else
                //     {
                //         Config_level.indexEniShutdownMoving = 3;
                //     }
                // }

                // if (FindObjectOfType<fruit>().status == 0)
                // {
                // FindObjectOfType<fruit>().status = 2;
                // FindObjectOfType<fruit>().changeStatus();
                // }else
                // {
                    FindObjectOfType<camera_Script>().camAction = 1;
                    Config_level.point += 1;
                    spawShutdown();
                    Destroy(this.gameObject, 0);
                // }


                
                
            }

    }

    void spawShutdown(){
        GameObject tmp2 = Instantiate(shutEffect, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        Destroy(tmp2, 1f);
    }

   
}
