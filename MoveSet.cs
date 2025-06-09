using System.Collections.Generic;
using UnityEngine;

public class MoveSet : MonoBehaviour
{
    public List<GameObject> listPos;
    public List<GameObject> listObjStatus;
    int indexNext;
    public int status;
    public int statusActive;

    float time;
    public float timeMax;
    Vector2 nextPos;

    public float speed;
    public float rotaAngle;
    public int isFixStatus;
    public int isRan;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = listPos[0].transform.position;
        if (isFixStatus == 0)
        {
            listObjStatus[1].SetActive(false);
        }
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (statusActive ==0)
        {
            time += Time.deltaTime;
        }
       
        if (time >= timeMax)
        {
            // normal posNext
            if (indexNext < (listPos.Count -1) )
            {
                indexNext += 1;
            }else
            {
                indexNext = 0;
            }


            // random posNext
            if (isRan == 1)
            {
                randomPosNext();
            }
            
            
            nextPos = new Vector2(listPos[indexNext].transform.position.x,listPos[indexNext].transform.position.y);
            status = 1;
            changeObj();
            statusActive = 1;
            time = 0;
        }

        if (status == 1)
        {
            move();
        }


        if (isFixStatus == 0)
        {
            
         this.transform.eulerAngles = new Vector3(
        this.transform.eulerAngles.x,
        this.transform.eulerAngles.y,
        rotaAngle
        );
         }
        
    }



    void move(){
        rotaAngle = FindObjectOfType<calGOC>().calculatorGoc(this.transform.position,nextPos,0);
        transform.position = Vector2.MoveTowards(transform.position,new Vector2(nextPos.x,nextPos.y) , speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x,transform.position.y,100);

        if (transform.position.x == nextPos.x && transform.position.y == nextPos.y)
        {
            statusActive = 0;
            status = 0;
            changeObj();
        }
    }


    void randomPosNext(){

        indexNext = Random.Range(0,listPos.Count);
    }


    void changeObj(){
        if (isFixStatus == 0)
        {
            if (status == 0)
            {
            listObjStatus[0].SetActive(true);
            listObjStatus[1].SetActive(false);
            }
            else
            {
            listObjStatus[0].SetActive(false);
            listObjStatus[1].SetActive(true);
            }
        }

        
    }
}