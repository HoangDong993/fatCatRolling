using System.Collections.Generic;
using UnityEngine;

public class loadStage : MonoBehaviour
{
    public List<GameObject> lstStage;

    public int indexTEST;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int stageNow = Config_level.stage;
      

        // test
        // stageNow = ((Config_level.chap -1 ) * 10) + indexTEST;
        // Config_level.stage = stageNow;

        for (int i = 0; i < lstStage.Count; i++)
        {
            if (i == stageNow)
            {
                lstStage[i].gameObject.SetActive(true);
            }
            else
            {
                lstStage[i].gameObject.SetActive(false);
            }
        }
        
        callTargetPoint();
    }

    // Update is called once per frame
    void Update()
    {

    }
    

     void callTargetPoint()
    {
        Object[] obs = FindObjectsOfType<jail>();
        Config_level.pointTargetNow = obs.Length;
     
    }
}
