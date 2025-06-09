using System.Collections.Generic;
using UnityEngine;

public class LoadChapDeco : MonoBehaviour
{
    public List<GameObject> lstDeco;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lstDeco[Config_level.chap].SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
