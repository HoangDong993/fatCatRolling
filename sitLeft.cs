using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sitLeft : MonoBehaviour
{
    
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x - speed,this.transform.position.y,this.transform.position.z);
        // this.transform.localScale += new Vector3(0.02f,0.02f,1);
    }
}
