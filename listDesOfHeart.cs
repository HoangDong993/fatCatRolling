using System.Collections.Generic;
using UnityEngine;

public class listDesOfHeart : MonoBehaviour
{
    public List<GameObject> listDes;
    public int index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 getDes()
    {
        Vector3 des = listDes[index].transform.position;
        index += 1;
        return des;
    }
}
