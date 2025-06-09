using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPack : MonoBehaviour
{

    

    public int indeTest;

    public GameObject tuto;
    public GameObject up;

    // Start is called before the first frame update
    void Start()
    {

     if (Config_level.isTuto == 1)
        {
            tuto.SetActive(true);
            up.SetActive(false);
            
        }else
        {
            tuto.SetActive(false);
            up.SetActive(true);
        }


        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
