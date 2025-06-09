using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class slowMotion : MonoBehaviour
{

    public float slowMotionTimeScale;
    public float startTimeScale;
    public float startFixedDeltaTime;

    public int status;

    float time;
    public float time_Max;
    // Start is called before the first frame update
    void Start()
    {
        startTimeScale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        // if (status == 1)
        // {
        //     startSlowMotion();
        //     time += Time.deltaTime;
        //     if (time >= time_Max)
        //     {
        //         stopSlowMotion();
        //         status = 0;
        //         time = 0;
        //     }
            
            
        // }
        
        
       
    }


    void startSlowMotion(){
        Time.timeScale = slowMotionTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime * slowMotionTimeScale;

    }

    void stopSlowMotion(){

        Time.timeScale = startTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime;
    }
}
