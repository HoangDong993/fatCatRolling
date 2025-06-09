using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Config_Main_Stage : MonoBehaviour
{

    int level;
    public GameObject lvAll;


    public int status;

    public float timego;
    public float timegoMax;
    public int stage;
    public int chap;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (status == 1)
        {
            // lvAll.SetActive(false);
            timego += Time.deltaTime;
            if (timego >= timegoMax)
            {
                status = 2;
                timego = 0;

            }
        }
        if (status == 2)
        {
            string lv = level.ToString();
            if (level == 101)
            {
                SceneManager.LoadScene("PreAdventure");
            }
            else if (level == 100)
            {
                SceneManager.LoadScene("SuperF");
            }
            else if (level == 1000)
            {
                SceneManager.LoadScene("Tutorial");
            }

        }
    }



    public void playSound()
    {
        Sound_Menu.PlaySound(soundsGame.click);

    }

    public void playSoundBack()
    {
        Sound_Menu.PlaySound(soundsGame.click);

    }





    public void endless()
    {
        FindObjectOfType<cover>().coverButton.SetActive(true);
        playSound();
        FindObjectOfType<changEffect>().status = 1;
        Config_level.isTuto = 0;
        Config_level.stage = ((Config_level.chap - 1) * 10) + stage;
        level = 100;
        if (stage % 10 == 1)
        {
            level = 1000;
        }

        status = 1;

    }

    public void Go()
    {

        playSound();
        status = 1;
        level = 100;
    }



    public void mainFirst()
    {
        playSoundBack();
        SceneManager.LoadScene("MainScreenFirst");
    }


    public void chaps()
    {
        playSoundBack();
        SceneManager.LoadScene("MainScreen_Chap");
    }

    public void replay()
    {
        playSoundBack();
        SceneManager.LoadScene("SuperF");
    }

    public void nextStage()
    {
            String scenNext = "SuperF";
            if (Config_level.stage % 10 == 0 && Config_level.stage == Config_level.finishAmountNow)
            {
                scenNext = "MainScreen_Chap";
                Config_level.isChapCom = 1;
            }
            playSoundBack();
            if (Config_level.stage % 10 == 0)
            {
                Config_level.chap += 1;
            }
             Config_level.stage += 1;

            SceneManager.LoadScene(scenNext);


    }


    public void stages()
    {
        playSoundBack();
        SceneManager.LoadScene("MainScreen_Stage");
    }

    public void tutoo()
    {
        playSoundBack();
        SceneManager.LoadScene("Tutorial");
    }

    public void reloadTest()
    {
        playSoundBack();
        SceneManager.LoadScene("SuperF");
    }


    public void chaptersList()
    {
        playSoundBack();
        Config_level.chap = chap;
        SceneManager.LoadScene("MainScreen_Chap");
    }

    public void chapters()
    {
        playSoundBack();
        Config_level.chap = chap;
        SceneManager.LoadScene("MainScreen_Stage");
    }
    
   

   


}
