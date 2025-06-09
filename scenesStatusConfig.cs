using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesStatusConfig : MonoBehaviour
{
    public int status;

    public float time;
    public float time_Max;

    public String targetScene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        status = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status != 0)
        {
            time += Time.deltaTime;
            if (time >= time_Max)
            {
                SceneManager.LoadScene(targetScene);
                time = 0;
            }
        }
    }


    public void gameOver()
    {
        targetScene = "GameOver";
        time_Max = 2;
        status = 4;
    }

    public void go(String targetSceneIn, float timeMaxIn, int statusIn, String objectName_Disable)
    {
        if (objectName_Disable != null && objectName_Disable != "")
        {
            GameObject obj = GameObject.Find(objectName_Disable);
            obj.SetActive(false);
        }
        targetScene = targetSceneIn;
        time_Max = timeMaxIn;
        status = statusIn;
    }
    
}