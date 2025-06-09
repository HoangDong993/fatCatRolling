using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public int move_index;

    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
        move_index = 1;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (this.transform.position.x > 666f)
        {
            move_index = 2;
        } else if (this.transform.position.x < -666f)
        {
            move_index = 1;
        }

        if (move_index == 1)
        {
            MoveObjectToRightt();
        }else if (move_index == 2)
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
