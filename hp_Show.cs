using UnityEngine;
using TMPro;
public class hp_Show : MonoBehaviour
{

    public TMP_Text textOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Config_level.hpNow <= 2)
        {
            textOut.color = new Color(255/255, 23/255, 0/255, 255/255);
        }
         showHP();
    }
    
    void showHP(){

        textOut.text =  Config_level.hpNow.ToString(); 
    }
}
