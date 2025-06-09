using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOBJInATime : MonoBehaviour
{
    public float speedX;
    public float speedY;
    float time;
    public float timeMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= timeMax)
        {
            speedX *= -1;
            speedY *= -1;
            time = 0 ;
        }
        this.transform.position = new Vector3(this.transform.position.x +speedX,this.transform.position.y + speedY,this.transform.position.z);
    }
}
