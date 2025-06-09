using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class randomSprite : MonoBehaviour
{
    public List<GameObject> lstObj;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0,lstObj.Count);
        for (int i = 0; i < lstObj.Count; i++)
        {
           if (i == index)
           {
                lstObj[i].gameObject.SetActive(true);
                break;
           }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
