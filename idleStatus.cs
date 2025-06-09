using System.Collections.Generic;
using UnityEngine;

public class idleStatus : MonoBehaviour
{
    public int status;
    public GameObject idleEffect;
    public GameObject ori;
    public List<GameObject> objChanges;
    int indexObjChange;
    public float timeChange;
    public float timeChangeMax;
    public float timeRemain;


    public float timeRangeMin;
    public float timeRangeMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeChange += Time.deltaTime;

        if (status == 0)
        {
            if (timeChange >= timeChangeMax)
            {
                changeStatus();
                timeChange = 0;
            }
        }
        else
        {
            if (timeChange >= timeRemain)
            {
                resetStatus();
                timeChange = 0;
            }
        }

    }

    void changeStatus()
    {
        status = 1;
        ori.SetActive(false);
        indexObjChange = Random.Range(0, objChanges.Count);
        objChanges[indexObjChange].SetActive(true);
        spawIdleEffect();

    }

    void resetStatus()
    {
        timeChangeMax = Random.Range(timeRangeMin, timeRangeMax);
        status = 0;
        ori.SetActive(true);
        objChanges[indexObjChange].SetActive(false);

    }
    


     public void spawIdleEffect()
    {
        
        GameObject tmp2 = Instantiate(idleEffect, new Vector3(this.transform.position.x, this.transform.position.y, 10), Quaternion.identity);
        Destroy(tmp2, timeRemain);
    }
}