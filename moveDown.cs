using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDown : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y - speed,this.transform.position.z);
    }
}
