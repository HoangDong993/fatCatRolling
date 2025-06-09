using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parralax : MonoBehaviour
{
    private float startPos;
    public float paralaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = Config_level.pos_Cam_X * paralaxEffect;

        transform.position = new Vector3(startPos + dist,transform.position.y,transform.position.z);
    }
}
