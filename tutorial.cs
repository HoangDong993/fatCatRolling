using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public List<GameObject> listTuto;
    public int status;

    float time;
    public float time_Max;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        changeSta();

        if (status == 6)
        {
            time += Time.deltaTime;
            if (time >= time_Max)
            {
                addSta();
                time = 0;
            }
        }
    }

    void changeSta() {

        for (int i = 0; i < listTuto.Count; i++)
        {
            if (i == status)
            {
                listTuto[i].SetActive(true);
            } else {
                listTuto[i].SetActive(false);
            }
        }
    }

    public void addSta(){

        status += 1;
    }
}
