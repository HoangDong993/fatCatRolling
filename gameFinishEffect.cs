using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameFinishEffect : MonoBehaviour
{
    public int status;
    public int objectIndex;
    public List<GameObject> lstOBJ;
    float time;
    public float time_Max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status == 1)
        {
            showNext();
        time += Time.deltaTime;
        if (time >= time_Max)
        {
            time = 0;
            if (objectIndex < lstOBJ.Count -1)
            {
                addIndex();
            }else
            {
                loadGo();
                time_Max = time_Max * 3;
            }
            
        }
        }
        
    }


    void addIndex(){
        objectIndex += 1;
        playSoundShow();

    }


    void showNext(){
          for (int i = 0; i < lstOBJ.Count; i++)
        {
           if (i == objectIndex)
           {
                lstOBJ[i].SetActive(true);
           }
        }
        
    }

    void loadGo(){

        SceneManager.LoadScene("Achievement");
    }


    void playSoundShow(){
        //  Sound_Menu.PlaySound(soundsGame.click);

    }

    
}
