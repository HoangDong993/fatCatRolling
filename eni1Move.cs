using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eni1Move : MonoBehaviour
{
    public float speed;
    float timeGo;
    public float timeGoMax;
    public int status;
    // Start is called before the first frame update
    void Start()
    {
        // speed = speed * Config_level.levelInGame;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (status == 0)
        {
            timeGo += Time.deltaTime;
            if (timeGo >= timeGoMax)
            {
                status = 1;
            }
        }
        

        if (status == 1)
        {
            
             transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<main>().transform.position, speed * Time.deltaTime);
        }
        
    }
}
