using UnityEngine;

public class checkDoneAllMain : MonoBehaviour
{
    public GameObject done;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Prefs.getCOM() == 5)
        {
            done.SetActive(true);
           
        }else
        {
            done.SetActive(false);
           
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
