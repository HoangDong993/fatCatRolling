using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeObj : MonoBehaviour
{
    public int status;
     public float timeShake;
    public float timeShakeMax;

    public float timechangeShake;
    public float timechangeShakeMax;
    // Start is called before the first frame update
    void Start()
    {
        status = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  if (status != 0)
        // {
        //     timeShake += Time.deltaTime;
        //     if (timeShake>=timeShakeMax)
        //     {
        //         status = 0;
        //         timeShake = 0;
        //     }
        // if (status == 1)
        // {
        //     move_Up();
        //     timechangeShake += Time.deltaTime;
        //     if (timechangeShake>= timechangeShakeMax)
        //     {
        //         status = 2;
        //         timechangeShake = 0;
        //     }
        // }else if(status == 2)
        // {
        //     timechangeShake += Time.deltaTime;
        //     move_Down();
        //     if (timechangeShake>= timechangeShakeMax)
        //     {
        //         status = 1;
        //         timechangeShake = 0;
        //     }
        // }
        // }else
        // {
        //     move_center();
        // }


        // Camera_config.x = this.transform.position.x;
    }



     public void move_Up(){
        // transform.position = new Vector3(transform.position.x, 30, transform.position.z);
        transform.rotation = Quaternion.Euler(Vector3.forward * 3);
    }

    public void move_Down(){
        // transform.position = new Vector3(transform.position.x, - 30, transform.position.z);
        transform.rotation = Quaternion.Euler(Vector3.forward * -3);
    }

    public void move_center(){
        transform.rotation = Quaternion.Euler(Vector3.forward * 0);
    }
}
