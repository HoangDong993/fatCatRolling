using System.Collections.Generic;
using UnityEngine;

public class LoadPackSkin : MonoBehaviour
{

    public List<GameObject> lstSkinPacks;
    public int indexTest;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < lstSkinPacks.Count; i++)
        {
            // if (i == Config_level.indexSkin)
            if (i == indexTest)
            {
                lstSkinPacks[i].SetActive(true);
            }
        }

        FindObjectOfType<fruit>().loadSkin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
