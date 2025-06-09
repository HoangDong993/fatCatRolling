using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSize : MonoBehaviour
{
    public float sizeUp;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.localScale = this.transform.localScale * sizeUp;
        this.transform.position = new Vector3(transform.position.x, transform.position.y+speed, transform.position.z);
    }
}
