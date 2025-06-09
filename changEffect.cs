using System.Collections.Generic;
using UnityEngine;

public class changEffect : MonoBehaviour
{
    public int status;

    public float time;
    public float timeMax;

    public List<GameObject> lstEffect;
    public List<GameObject> lstEffectPOSITION;
    public List<int> lstIndexRandom;

    public int type;
    int indexPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> lstIndexRandomTemp = new List<int>();
        for (int i = 0; i < lstEffectPOSITION.Count; i++)
        {
            lstIndexRandomTemp.Add(i);
        }

        int counttt = lstIndexRandomTemp.Count;
        for (int i = 0; i < counttt; i++)
        {
            int intAdd = lstIndexRandomTemp[Random.Range(0, lstIndexRandomTemp.Count)] ;
            lstIndexRandom.Add(intAdd);
            lstIndexRandomTemp.Remove(intAdd);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (type == 1)
        {
             if (status != 0 && indexPos < lstEffectPOSITION.Count)
           {
            time += Time.deltaTime;

            if (time >= timeMax)
            {
                spawEffect();
                time = 0;
            }
           }
           if (status != 0 && indexPos >= lstEffectPOSITION.Count)
           {
                // FindObjectOfType<changeScenesEffect2>().status = 1;
                status = 0;
           }
        }
       
        else
        {
            if (status != 0)
            {
            time += Time.deltaTime;
            if (time >= timeMax)
            {
                FindObjectOfType<changeScenesEffect2>().status = 1;
                status = 0;
            }

            }
        }

        
        
    }


    void spawEffect()
    {
        Sound_Menu.PlaySound(soundsGame.changeScene2);
        int ranEffetIndex = Random.Range(0, lstEffect.Count);
        GameObject tmp2 = Instantiate(lstEffect[ranEffetIndex], lstEffectPOSITION[lstIndexRandom[indexPos]].transform.position, Quaternion.identity);
        // Destroy(tmp2, 1f);
        indexPos += 1;

    }
}
