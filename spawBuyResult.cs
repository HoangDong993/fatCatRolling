using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawBuyResult : MonoBehaviour
{

    public GameObject obj;
    public GameObject objFAIL;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void spaw(Vector3 pos){
        GameObject tmp = Instantiate(obj, this.transform.position, Quaternion.identity);
        Destroy(tmp,1.5f);
    }

    public void spawBuyFail(Vector3 pos){
        GameObject tmp = Instantiate(objFAIL, this.transform.position, Quaternion.identity);
        Destroy(tmp,1);
    }
}
