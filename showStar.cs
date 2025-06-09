using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showStar : MonoBehaviour
{
    public List<GameObject> lisPos;
    public GameObject star;
    int index;
    float time;
    public float timeMax;
    public TMP_Text textHP;
    public TMP_Text textHPScore;
    public TMP_Text textScoreOld;
    public TMP_Text textTime;
    int hp;
    int hpScore;
    public int hpTesst;
    public GameObject faceResu;
    public GameObject posFaceResu;
    public GameObject button;
    public GameObject checkChapCom;

    int status;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // TEST
        // Config_level.hpNow = hpTesst;



        hp = Config_level.hpNow;

        if (hp == 0)
        {
            spawFaceResu();
        }



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        showTextHP();
        if (Config_level.hpNow > 0 && index < Config_level.hpNow)
        {
            // time += Time.deltaTime;
            if (time >= timeMax)
            {
                hp -= 1;
                hpScore += 1;
                FindObjectOfType<Camera_script_Menu>().camAction = 1;
                showTextHP();
                spawStar(lisPos[index].transform.position);
                index += 1;
                time = 0;
            }

        }
        else if (Config_level.hpNow > 0 && index == Config_level.hpNow)
        {
            if (status == 0)
            {
                time += Time.deltaTime;
                if (time >= timeMax)
                {
                    playSoundDone();
                    spawFaceResu();
                    status = 1;
                }
            }

            calGold();

        }

    }


    void spawStar(Vector3 pos)
    {
        GameObject tmp2 = Instantiate(star, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
    }


    void showTextHP()
    {

        textHP.text = "Move: " + hp;
        textHPScore.text = "Score: " + hpScore;
        textScoreOld.text = "Old Score: " + Config_level.oldPointNow;



    }


    void calGold()
    {
        textTime.text = Config_level.timeFinishStageNow.ToString("#.##") + " s";
    }


    public void calShowStar(GameObject pos)
    {

        hpScore += 1;
        playSound();
        FindObjectOfType<Camera_script_Menu>().camAction = 1;
        showTextHP();
        spawStar(pos.transform.position);
        index += 1;
    }

    void spawFaceResu()
    {
        GameObject tmp2 = Instantiate(faceResu, new Vector3(posFaceResu.transform.position.x, posFaceResu.transform.position.y, posFaceResu.transform.position.z), Quaternion.identity);
        button.SetActive(true);
        checkChapCom.SetActive(true);
    }


    void playSound()
    {
        switch (hpScore)
        {

            case 1:
                {
                    Sound_Menu.PlaySound(soundsGame.heart1);
                }
                break;
            case 2:
                {
                    Sound_Menu.PlaySound(soundsGame.heart2);
                }
                break;
            case 3:
                {
                    Sound_Menu.PlaySound(soundsGame.heart3);
                }
                break;
        }
    }
    
     void playSoundDone()
    {
        switch (hpScore)
        {

            case 1:
                {
                    Sound_Menu.PlaySound(soundsGame.heart1_Done);
                }
                break;
            case 2:
                {
                    Sound_Menu.PlaySound(soundsGame.heart2_Done);
                }
                break;
            case 3:
                {
                    Sound_Menu.PlaySound(soundsGame.heart3_Done);
                }
            break;
        }
    }
}