using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objAppear : MonoBehaviour
{
    float time;
    public float time_Max;
    int status;

    public float sizeUp;
    public float sizeDown;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playSound();
        // FindObjectOfType<Camera_script_Menu>().camAction = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= time_Max && status == 0)
        {
            changeStatus();
            time = 0;
        }

        if (status == 0)
        {
            smaller();
        }
        // else
        // {
        //     bigger();
        // }
    }
    void changeStatus(){
         if (status == 0)
         {
            status = 1;
         }else
         {
            status = 0;
         }
    }


    void bigger(){
         this.transform.localScale = this.transform.localScale * sizeUp;
    }
    void smaller(){
         this.transform.localScale = this.transform.localScale * sizeDown;
    }

    void playSound(){
    
    }
}
