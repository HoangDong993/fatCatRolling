using UnityEngine;

public class parent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Config_level.inParent = 1;
        FindObjectOfType<fruit>().gameObject.transform.position = new Vector3(0, 0, FindObjectOfType<fruit>().gameObject.transform.position.z);
        GameObject parent = FindObjectOfType<parent>().gameObject;
        FindObjectOfType<fruit>().gameObject.transform.SetParent(parent.transform, false);
        FindObjectOfType<fruit>().nextPos = FindObjectOfType<fruit>().gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if (Config_level.inParent == 1)
        // {
        //      FindObjectOfType<fruit>().nextPos = FindObjectOfType<fruit>().gameObject.transform.position;
        // }
    }
}
