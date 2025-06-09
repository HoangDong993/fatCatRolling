using UnityEngine;

public class checkDoneAll : MonoBehaviour
{
    public GameObject notDone;
    public GameObject done;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Config_level.stage == 60)
        {
            done.SetActive(true);
            notDone.SetActive(false);
        }else
        {
            done.SetActive(false);
            notDone.SetActive(true);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
