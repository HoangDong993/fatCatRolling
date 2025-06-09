using System.Collections.Generic;
using UnityEngine;

public class loadLockAndStage : MonoBehaviour
{
    public List<GameObject> lstStage;
    public List<GameObject> lstLock;
    public List<GameObject> lstDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int finish = Config_level.playerData.finishAmount;
        for (int i = 1; i < lstStage.Count; i++)
        {
            if ((i +((Config_level.chap -1)* 10) ) <= (finish+1))
            {
                lstStage[i].SetActive(true);
                lstLock[i].SetActive(false);
            }else
            {
                lstStage[i].SetActive(false);
                lstLock[i].SetActive(true);
            }

            if ( (i +((Config_level.chap -1)* 10) ) <= finish)
            {
                lstDone[i].SetActive(true);
            }else
            {
                lstDone[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
