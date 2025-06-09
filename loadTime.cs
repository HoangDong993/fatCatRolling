using UnityEngine;
using TMPro;

public class loadTime : MonoBehaviour
{
    public int stage;

    public TMP_Text textOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textOut.text = Config_level.playerData.timeFinishOfStage[((Config_level.chap - 1) * 10) + stage].ToString() + "s";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
