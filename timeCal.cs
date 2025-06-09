using UnityEngine;
using TMPro;
using System;

public class timeCal : MonoBehaviour
{
    public TMP_Text textOut;
    float timeStage;

    public int status;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status == 1)
        {
             timeStage += Time.deltaTime;
            var str = timeStage.ToString("#.##");
            timeStage = float.Parse(str);
            // Debug.Log(timeStage);
            Config_level.timeFinishStageNow = timeStage;
        }
       
        showText();
    }

    void showText(){
        textOut.text = timeStage.ToString(); 
     }
}
