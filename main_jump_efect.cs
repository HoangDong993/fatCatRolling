using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_jump_efect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.localScale += new Vector3(0.04f,0.04f,1);
    }
}
