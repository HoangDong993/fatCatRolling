using System.Collections.Generic;
using UnityEngine;

public class spawEniPack : MonoBehaviour
{
    public List<GameObject> lstSpaw;

    public int indexSpawNow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        loadSpaw();
    }


    public void loadUP(){
        indexSpawNow += 1;
        
    }

    public void loadSpaw(){
     
        for (int i = 0; i < lstSpaw.Count; i++)
        {
            if (indexSpawNow == i)
            {
                lstSpaw[i].gameObject.SetActive(true);
            }else
            {
                lstSpaw[i].gameObject.SetActive(false);
            }
        }
    }


    public void changelevelRandom(){
           int index = Random.Range(0,lstSpaw.Count); 
           indexSpawNow = index;
    }
}