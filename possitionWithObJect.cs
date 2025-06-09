using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;



public class possitionWithObJect : MonoBehaviour
{
    public float distanceX;
    public float distanceY;
    Vector3 screenPos;
    Vector3 realPos;

    public GameObject Obj;

    float disXWithObj;

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
        Vector3 screenPos2 = new Vector3(w/50,h,this.transform.position.z);
        TranformScreenToWorldPos2(screenPos2);
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
        screenPos.x = screenPos.x + disXWithObj;
        realPos = screenPos;
        realPos.z = this.transform.position.z;
    }


    void showTextCoin(){
        if (textOut != null)
        {
            // textOut.text = Prefs.getCoin().ToString();
        }
    
    }

     void TranformScreenToWorldPos2(Vector3 pos){
        Camera mainCam = Camera.main;
        Vector3 screenPos = mainCam.ScreenToWorldPoint(pos);
        disXWithObj = Obj.transform.position.x - screenPos.x;
    }
}
