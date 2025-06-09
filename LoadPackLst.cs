using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPackLst : MonoBehaviour
{
    public List<GameObject> lstObj;
    // Start is called before the first frame update
    void Start()
    {    int indexShow = Random.Range(0,lstObj.Count);
         for (int i = 0; i < lstObj.Count; i++)
        {
           if (i == indexShow)
           {
                lstObj[i].SetActive(true);
           }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
