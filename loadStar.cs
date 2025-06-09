using System.Collections.Generic;
using UnityEngine;

public class loadStar : MonoBehaviour
{
    public List<GameObject> listStar;
    public int stage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Config_level.playerData.scoreOfStage[stage] > 0)
        // {
            listStar[Config_level.playerData.scoreOfStage[
                ((Config_level.chap - 1) * 10) + stage
                ]].SetActive(true); 
        // }
        
    }
}
