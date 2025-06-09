using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Config_Main_First : MonoBehaviour
{

     int level;
    public GameObject lvAll;


    public int status;

    public float timego;
    public float timegoMax;
    public int stage;

    public int isTest;
    public int comTest;
    public GameObject rolling;
    // Start is called before the first frame update
    void Start()
    {


         // TEST reset
        if (isTest == 1)
        {
            Prefs.setCOM(comTest);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (status == 1)
        {
            lvAll.SetActive(false);
            rolling.SetActive(true);
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
                SceneManager.LoadScene("MainScreen_Chap");
            }else if (level == 100)
            {
                SceneManager.LoadScene("LevelEndless");
            }
            
        }
    }


     public void playSound(){
        Sound_Menu.PlaySound(soundsGame.click);

    }

    public void playSoundBack(){
        Sound_Menu.PlaySound(soundsGame.click);

    }


    public void shopSit(){
        playSound();
        SceneManager.LoadScene("ShopSit");
    }

    public void shopRope(){
        playSound();
        SceneManager.LoadScene("ShopRope");
    }

    public void shopSkin(){
        playSound();
        SceneManager.LoadScene("ShopSkin");
    }


    public void endless(){
        playSound();
        Config_level.isTuto = 0;
        Config_level.stage = stage;
        status = 1;
        level = 100;
    }


    public void stages(){
        playSound();
        Sound_Menu.PlaySound(soundsGame.go);
        Config_level.isTuto = 0;
        Config_level.stage = stage;
        status = 1;
        level = 101;
    }


   


    public void mainFirst(){
        playSoundBack();
        SceneManager.LoadScene("MainScreenFirst");
    }

    public void achievement(){
        playSoundBack();
        SceneManager.LoadScene("Achievement");
    }
    public void getRewards(){
        playSound();
        SceneManager.LoadScene("RewardAD");
    }


    public void adventure(){
        playSoundBack();
        SceneManager.LoadScene("LevelEndless");
    }


}
