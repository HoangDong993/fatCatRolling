using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainX : MonoBehaviour
{

    public GameObject main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(main.transform.position.x,main.transform.position.y,main.transform.position.z);
    }
}
