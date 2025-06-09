using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyPage : MonoBehaviour
{
    public int pageIndex;
    public GameObject button1;
    public GameObject button2;
    public List<GameObject> lstPages;
    public GameObject pageDone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Prefs.getISSUCC() == 1)
        {
            loadPageDone();
            button1.SetActive(false);
            button2.SetActive(false);
        }else
        {
             loadPage();
        }
       
        
    }

    void loadPage(){

        for (int i = 0; i < lstPages.Count; i++)
        {
            if (i == pageIndex)
            {
                lstPages[i].SetActive(true);
            }else
            {
                lstPages[i].SetActive(false);
            }
        }
    }

     void loadPageDone(){

        for (int i = 0; i < lstPages.Count; i++)
        {
            
                lstPages[i].SetActive(false);
        }
        pageDone.SetActive(true);
    }

    public void nextPage(){

        if (pageIndex < 4)
        {
            pageIndex += 1;
        }
        Sound_Menu.PlaySound(soundsGame.click);
    }


     public void previousPage(){

        if (pageIndex > 0)
        {
            pageIndex -= 1;
        }
        Sound_Menu.PlaySound(soundsGame.click);
    }
}
