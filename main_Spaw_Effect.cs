using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_Spaw_Effect : MonoBehaviour
{
    public float time;
    public float time_Max;
    public List<GameObject> lstOBJ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time >= time_Max)
        {
            spaw();
            time = 0;
        } 
    }


    void spaw(){

        int ran = Random.Range(0,lstOBJ.Count);
        GameObject tmp = Instantiate(lstOBJ[ran],new Vector3 (this.transform.position.x,this.transform.position.y,9.8f) , Quaternion.identity);
        Destroy(tmp,5f);
    }
}
