using UnityEngine;

public class showUnityAD : MonoBehaviour
{
    int status;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Config_level.dieTime >= Config_level.dieTimeMax )
        // {
        if (status == 0)
        {
            status = 1;
            FindObjectOfType<InterstitialAdExample>().ShowAd();
            
        }
            
        // }
    }
}
