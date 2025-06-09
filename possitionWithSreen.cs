using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;



public class possitionWithSreen : MonoBehaviour
{
    public float distanceX;
    public float distanceY;
    Vector3 screenPos;
    Vector3 realPos;

    public TMP_Text textOut;

    public int isNotCoin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Screen.height;
        float w = Screen.width;

        screenPos = new Vector3(w/distanceX,h/distanceY,this.transform.position.z);
        TranformScreenToWorldPos(screenPos);
        this.transform.position = realPos;

        if (isNotCoin == 0)
        {
            showTextCoin();
        }
        
        
    }



    void TranformScreenToWorldPos(Vector3 pos){
        Camera mainCam = Camera.main;
        Vector3 screenPos = mainCam.ScreenToWorldPoint(pos);
        realPos = screenPos;
        realPos.z = this.transform.position.z;
    }


    void showTextCoin(){
        if (textOut != null)
        {
            // textOut.text = Prefs.getCoin().ToString();
        }
    
    }
}
