using UnityEngine;

public class spawSomethingFirst : MonoBehaviour
{
    public GameObject changeScenesEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject tmp2 = Instantiate(changeScenesEffect, new Vector3(this.transform.position.x, this.transform.position.y, 9), Quaternion.identity);
        Destroy(tmp2, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
