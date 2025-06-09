using System.Collections.Generic;
using UnityEngine;

public class pearlMain : MonoBehaviour
{

    public List<GameObject> lstBolt;
    public float ranXY; 
    float time;
    public float timeMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time>=timeMax)
        {
            spawBolt();
            time = 0;
        }
    }


     void spawBolt(){
         
        float ranX = Random.Range(-ranXY,ranXY);
        float ranY = Random.Range(-ranXY,ranXY);
        int indexBolt = Random.Range(0,lstBolt.Count);
        GameObject tmp2 = Instantiate(lstBolt[indexBolt], new Vector3 (this.transform.position.x + ranX,this.transform.position.y + ranY,this.transform.position.z -1), Quaternion.identity);
        Destroy(tmp2, 2f);
    }
}