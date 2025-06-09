using System.Collections.Generic;
using UnityEngine;

public class sortPosRandom : MonoBehaviour
{
    public List<GameObject> lstOBJ;
    public List<Vector3> lstPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < lstOBJ.Count; i++)
        {
            lstPos.Add(lstOBJ[i].transform.position);
        }

        for (int i = 0; i < lstOBJ.Count; i++)
        {
            int indexPos = Random.Range(0,lstPos.Count);
            lstOBJ[i].transform.position =new Vector3(lstOBJ[i].transform.position.x,lstPos[indexPos].y,lstOBJ[i].transform.position.z) ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
