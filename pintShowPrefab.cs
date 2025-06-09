using UnityEngine;
using TMPro;

public class pintShowPrefab : MonoBehaviour
{
     public TMP_Text textOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        showPoint();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void showPoint(){

        textOut.text = Config_level.point.ToString(); 
    }
}
