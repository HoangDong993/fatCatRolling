using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSizeInATime : MonoBehaviour
{
    public float sizeUp;
    public float sizeDown;
    float time;
    public float time_Max;
    int status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= time_Max)
        {
            changeStatus();
            time = 0;
        }

        if (status == 0)
        {
            this.transform.localScale = this.transform.localScale * sizeUp;
        }else
        {
            this.transform.localScale = this.transform.localScale * sizeDown;
        }
        
    }


    void changeStatus(){
        if (status == 0 )
        {
            status = 1;
        }else
        {
            status = 0;
        }
    }
}
