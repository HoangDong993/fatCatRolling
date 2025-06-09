using UnityEngine;

public class calGOC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float calculatorGoc(Vector3 mainPos,Vector3 desPos,int isMain){
        float goc = 0;
        float gocTemp = 45;
        float x = Mathf.Abs(desPos.x - mainPos.x );
        float y = Mathf.Abs(desPos.y - mainPos.y );

        if (desPos.x == mainPos.x  && desPos.y > mainPos.y)
        {
            goc = 270;
        }if (desPos.x == mainPos.x  && desPos.y < mainPos.y)
        {
            goc = 90;
        }if (desPos.x > mainPos.x  && desPos.y == mainPos.y)
        {
            goc = 0;
        }if (desPos.x == mainPos.x  && desPos.y < mainPos.y)
        {
            goc = 180;
        }
        
        else if (desPos.x > mainPos.x  && desPos.y > mainPos.y)
        {
            goc = Mathf.Atan2(y,x) * Mathf.Rad2Deg;
        }else if(desPos.x < mainPos.x  && desPos.y > mainPos.y)
        {
            goc = 180 -  Mathf.Atan2(y,x) * Mathf.Rad2Deg;
        }else if(desPos.x < mainPos.x  && desPos.y < mainPos.y)
        {
            goc = 180 + Mathf.Atan2(y,x) * Mathf.Rad2Deg;
        }else if(desPos.x > mainPos.x  && desPos.y < mainPos.y)
        {
            goc = 360 - Mathf.Atan2(y,x) * Mathf.Rad2Deg;
        }



        if (isMain == 1)
        {
             Config_level.mainGocNow = goc;
        }
       

        return goc;
    } 

    
}