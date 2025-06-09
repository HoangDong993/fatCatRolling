using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapControl : MonoBehaviour
{
    public int status;
    public int pageIndex;
    public GameObject button1;
    public GameObject button2;
    public List<GameObject> lstChap;
    public GameObject pageDone;
    public GameObject unlock;
    // Start is called before the first frame update
    void Start()
    {
        pageIndex = 1;
        if (Config_level.isChapCom == 1)
        {
            pageIndex = Config_level.chap;
            // spawUnlock();
            Config_level.isChapCom = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (status == 0)
        {
            loadPage();
            status = 1;
        }




    }

    void loadPage()
    {

        for (int i = 0; i < lstChap.Count; i++)
        {
            if (i == pageIndex)
            {
                lstChap[i].SetActive(true);
            }
            else
            {
                lstChap[i].SetActive(false);
            }
        }
    }

    public void nextPage()
    {

        if (pageIndex < 6)
        {
            pageIndex += 1;
        }
        status = 0;
        Sound_Menu.PlaySound(soundsGame.click);
    }


    public void previousPage()
    {

        if (pageIndex > 1)
        {
            pageIndex -= 1;
        }
        status = 0;
        Sound_Menu.PlaySound(soundsGame.click);
    }
    

    void spawUnlock()
    {
        GameObject tmp2 = Instantiate(unlock, new Vector3 (this.transform.position.x,this.transform.position.y,100), Quaternion.identity);
    }
}
