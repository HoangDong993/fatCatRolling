using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdPossition : MonoBehaviour
{
    public float distanceWithMainX;
    // Start is called before the first frame update
    void Start()
    {
        distanceWithMainX = this.transform.position.x - Config_level.pos_Main_X;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Config_level.pos_Main_X + distanceWithMainX,this.transform.position.y,this.transform.position.z);
    }
}
