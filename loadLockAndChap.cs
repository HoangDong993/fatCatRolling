using System.Collections.Generic;
using UnityEngine;

public class loadLockAndChap : MonoBehaviour
{
    public List<GameObject> lstChap;
    public List<GameObject> lstLock;
    public List<GameObject> lstDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int finish = Config_level.playerData.finishAmount;
        for (int i = 1; i < lstChap.Count; i++)
        {
            if ( (i-1) <= (finish/10))
            {
                lstChap[i].SetActive(true);
                lstLock[i].SetActive(false);
            }else
            {
                lstChap[i].SetActive(false);
                lstLock[i].SetActive(true);
            }

            if ( (i-1) <= (finish/10))
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
