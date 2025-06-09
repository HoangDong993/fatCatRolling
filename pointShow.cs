using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class pointShow : MonoBehaviour
{

    public TMP_Text textOut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        showPoint();
    }

    void showPoint(){

        textOut.text = Config_level.point.ToString(); 
    }
}
