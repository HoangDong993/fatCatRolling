using UnityEngine;
using TMPro;

public class calStarOfChap : MonoBehaviour
{
    public int chap;
    int star;
    public TMP_Text textOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // FindObjectOfType<SaveLoadJSONDATA_RESULT>().LoadGameToConfig();
         for (int i = 1; i <= 10; i++)
        {
            Debug.Log("heheheheh" + Config_level.playerData.scoreOfStage[(((chap -1 ) * 10) + i )]);
            Debug.Log("hohohoh" + (((chap -1 ) * 10) + i ) );
            star += Config_level.playerData.scoreOfStage[(((chap -1 ) * 10) + i )];
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        showStarGot();
    }


    void showStarGot()
    {

        textOut.text = star.ToString();
    }
}
