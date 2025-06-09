using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_Parent : MonoBehaviour
{

    public int status;
    public GameObject childButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


    public void changeStatus(){

        if (status == 0)
        {
            childButton.SetActive(true);
            status = 1;
        }else
        {
            childButton.SetActive(false);
            status = 0;
        }
    }
}
