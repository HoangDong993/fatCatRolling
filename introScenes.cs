using UnityEngine;
using TMPro;


public class introScenes : MonoBehaviour
{
    public TMP_Text textOut;
    public TMP_Text textOutChap;
    public string textStr;
    public string textStrChap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // string [] arrayText = 
        // {
        //     "clear them all"
        //     ,"clean all mouse"
        //     ,"Kill Them"
        //     ,"wanna hit all mouse"

        // };
        // int randomIndex = Random.Range(0,arrayText.Length);
        // textStr = arrayText[randomIndex];
        int stageOfChap = Config_level.stage - ((Config_level.chap - 1) * 10 );
        textStr = "Stage: " + stageOfChap.ToString();
        textStrChap = "Chapter " +  Config_level.chap.ToString() ;
        showText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void showText()
    {
        textOut.text = textStr;
        textOutChap.text = textStrChap;
     }

     public void startButtonAction(){
        FindObjectOfType<fruit>().status = 0;
        FindObjectOfType<timeCal>().status = 1;
        this.gameObject.SetActive(false);
     }
}