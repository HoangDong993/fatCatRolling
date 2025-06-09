using System.Collections.Generic;
using UnityEngine;

public class totuChap : MonoBehaviour
{
    public List<GameObject> listTuto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listTuto[Config_level.chap].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
