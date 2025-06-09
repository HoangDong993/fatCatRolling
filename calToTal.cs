using UnityEngine;
using TMPro;
public class calToTal : MonoBehaviour
{
    public TMP_Text textTime;
    public TMP_Text textStar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        textTime.text = "Time: " + Config_level.totalTime.ToString("#.##") + "s";
        textStar.text = Config_level.totalStar.ToString();
    }
}
