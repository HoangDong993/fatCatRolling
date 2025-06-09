using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public int status;
    public GameObject idle;
    public GameObject die;
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status == 0)
        {
            idle.SetActive(true);
            die.SetActive(false);
            finish.SetActive(false);
        }else if(status == 1)
        {
            idle.SetActive(false);
            die.SetActive(true);
            finish.SetActive(false);
        }else if(status == 2)
        {
            idle.SetActive(false);
            die.SetActive(false);
            finish.SetActive(true);
        }
    }
}
