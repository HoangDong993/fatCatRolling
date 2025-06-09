using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawFruit : MonoBehaviour
{

    public List<GameObject> lstObj;
    public float time;
    public float timeMax;
    public float ranMinY;
    public float ranMaxY;
    public List<GameObject> lstPosSpaw;

    // public GameObject appearEffect;

    public float speedPlayer;

    public string speedShow;
    // Start is called before the first frame update
    void Start()
    {
        // spawAppear();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FindObjectOfType<targetConfig>().speed = speedShow;
        time += Time.deltaTime;
        if (time >= timeMax)
        {
            spawObj();
            time = 0;
        }
    }


     void spawObj(){
        int ranIndex = Random.Range(0,lstPosSpaw.Count);
        int ranIndexOBJ = Random.Range(0,lstObj.Count);
        GameObject tmp2 = Instantiate(lstObj[ranIndexOBJ], lstPosSpaw[ranIndex].transform.position, Quaternion.identity);
        // Destroy(tmp2, 11f);

     }

    //  void spawAppear(){
    //     GameObject cam = FindObjectOfType<camera_Script>().gameObject;
    //     GameObject tmp2 = Instantiate(appearEffect, new Vector3(0, 0, -1), Quaternion.identity);
    //     Destroy(tmp2, 2f);

    //  }
}
