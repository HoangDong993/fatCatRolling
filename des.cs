using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class des : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (FindObjectOfType<fruit>().status == 1)
            {
                if (Config_level.isSpeedChange == 2)
                {
                FindObjectOfType<fruit>().speed = FindObjectOfType<fruit>().speedOri;
                }
                
                FindObjectOfType<fruit>().setPostNow(this.transform.position);
                FindObjectOfType<fruit>().spawStop();
                FindObjectOfType<fruit>().status = 0;
                FindObjectOfType<fruit>().changeStatus();
                checkHP();
                Destroy(this.gameObject, 0);
            }
        }
        // else if (other.gameObject.tag == "SpeedUp")
        // {
        //     Destroy(this.gameObject, 0f);
        // }

    }


    void checkHP()
    {
        if (FindObjectOfType<generalWithMono>().checkFinish())
        {

        }
        else
        {
            if (Config_level.hpNow <= 0)
            {
                FindObjectOfType<generalWithMono>().GameOver();
                
            }
        }
    }

    bool checkFinish()
    {

        if (Config_level.pointTargetNow <= 0)
        {
            FindObjectOfType<scenesStatusConfig>().go("GameFinish", 2, 1, null);
            return true;
        }
        return false;
    }
}
