using System.Collections.Generic;
using UnityEngine;

public class faceShow : MonoBehaviour
{
    public List<GameObject> listFace;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int hp = Config_level.hpNow;
        listFace[hp].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
