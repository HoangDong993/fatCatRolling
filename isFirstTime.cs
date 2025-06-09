using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isFirstTime : MonoBehaviour
{
    public GameObject tutoFirst;
    public GameObject buttonGo;
    // Start is called before the first frame update
    void Start()
    {
        if (Prefs.getISFIRST() == 0)
        {
            tutoFirst.SetActive(true);
            buttonGo.SetActive(false);
        }else
        {
            tutoFirst.SetActive(false);
            buttonGo.SetActive(true);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
