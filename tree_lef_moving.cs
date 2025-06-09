using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_lef_moving : MonoBehaviour
{
    int status;
    public float timeMoving;
    public float timeMovingMax;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        status = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeMoving += Time.deltaTime;
        if (timeMoving >= timeMovingMax)
        {
            if (status == 0)
            {
                status = 1;
            }else
            {
                status = 0;
            }
            timeMoving = 0;
        }

        if (status ==1)
            {
                MoveObjectToRightt();
            }else
            {
                MoveObjectToleftt();
            }
    }


    public void MoveObjectToRightt(){
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
    }

    public void MoveObjectToleftt(){
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
    }
}
