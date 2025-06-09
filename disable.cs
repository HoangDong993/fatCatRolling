using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour
{
    public int isHugeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lim = 2000;
        if (isHugeObject == 1)
        {
            lim = 4000;
        }
        if (( Config_level.pos_Main_X - this.transform.position.x) >= lim )
        {
            // this.gameObject.SetActive(false);
            Destroy(this.gameObject,0);
        }
    }
}
