using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawANY : MonoBehaviour
{

    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void spaw(Vector3 pos,float remainTime){
        GameObject tmp = Instantiate(obj, pos, Quaternion.identity);
        Destroy(tmp,remainTime);
    }
}
