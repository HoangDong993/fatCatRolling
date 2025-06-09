using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class changeSprite : MonoBehaviour
{
    public int status;
    public float time;
    public float timeMax;
    public float timeRandomMin;
    public float timeRandomMax;
    public List<GameObject> lstSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         timeMax = Random.Range(timeRandomMin, timeRandomMax);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= timeMax)
        {
            changeOBJ();
            float ranTimeMax = Random.Range(timeRandomMin, timeRandomMax);
            timeMax = ranTimeMax;
            time = 0;
            

        }
    }


    void changeOBJ()
    {
        disableAllObj();
        int ranIndex = Random.Range(0, lstSprite.Count);
        lstSprite[ranIndex].SetActive(true);
    }


    void disableAllObj()
    {
        for (int i = 0; i < lstSprite.Count; i++)
        {
            lstSprite[i].SetActive(false);
        }
    }
}
