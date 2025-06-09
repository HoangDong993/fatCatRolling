using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOBJ : MonoBehaviour
{
    public float speedX;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x +speedX,this.transform.position.y + speedY,this.transform.position.z);
    }
}
