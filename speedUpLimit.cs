using UnityEngine;

public class speedUpLimit : MonoBehaviour
{
    public float time;
    public float timeMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Config_level.isSpeedChange == 1)
        {
            time += Time.deltaTime;
            if (time >= timeMax)
            {
                Config_level.isSpeedChange = 3;
                time = 0;
            }
        }

        if (Config_level.isSpeedChange == 3)
        {
            FindObjectOfType<fruit>().speed = FindObjectOfType<fruit>().speedOri;
        }
    }
}