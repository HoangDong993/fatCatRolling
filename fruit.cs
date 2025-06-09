using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class fruit : MonoBehaviour
{
    public float speed;
     public float speedOri;

    public int status;
    // 0: idle
    // 1: moving
    // 2: over
    // 3: finish
    // 4: idleEffect


    public Touch touchd;
    public Vector3 nextPos;

    public List<GameObject> lstElectric;
    public GameObject Idle;
    public GameObject GO;
    public GameObject DIE;
    public GameObject des;

    public GameObject hit;

    public float rotaAngle;
    public GameObject movingEffect;
    public GameObject movingEffect_Shape;
    public GameObject stopPos;
    public GameObject stopObj;
    float timeSpawMovingEffect;
    public float timeSpawMovingEffect_Max;


    public GameObject posLim1;
    public GameObject posLim2;


    public GameObject attack;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        speedOri = speed;
        status = 200;
        //  Debug.Log(Application.targetFrameRate);
        nextPos = this.transform.position;
        lstElectric = new List<GameObject>();
        // loadSkin();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status != 2 && status != 100 && status != 200)
        {
            if (Config_level.inParent == 0)
            {
                move();
            }

        }


        if (status == 1)
        {
            timeSpawMovingEffect += Time.deltaTime;
            if (timeSpawMovingEffect >= timeSpawMovingEffect_Max)
            {
                spawMovingEffect();
                timeSpawMovingEffect = 0;
            }

        }

        this.transform.eulerAngles = new Vector3(
        this.transform.eulerAngles.x,
        this.transform.eulerAngles.y,
        rotaAngle
        );


    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (status == 0)
            {
                Sound_Menu.PlaySound(soundsGame.go);
                Vector3 mousePos = Input.mousePosition;
                Vector3 mousePosScreen = Camera.main.ScreenToWorldPoint(mousePos);
                
                 if (mousePosScreen.x > posLim1.transform.position.x
                 && mousePosScreen.y > posLim1.transform.position.y
                 && mousePosScreen.x < posLim2.transform.position.x
                 && mousePosScreen.y < posLim2.transform.position.y
                 )
                 {
                Config_level.inParent = 0;
                this.gameObject.transform.SetParent(null);
                general.minusHP();
                FindObjectOfType<loadHeart>().minusHHeart();
                status = 1;
                changeStatus();
                spawDes(mousePosScreen);
                nextPos = new Vector3(mousePosScreen.x, mousePosScreen.y, this.transform.position.z);
                rotaAngle = FindObjectOfType<calGOC>().calculatorGoc(this.transform.position, nextPos, 1);
                Config_level.mainGocNow = rotaAngle;

                }

 
            }

        }
    }


    void spawMovingEffect()
    {


        GameObject tmp2 = Instantiate(movingEffect, new Vector3(this.transform.position.x, this.transform.position.y, 9), Quaternion.identity);
        Destroy(tmp2, 0.5f);

        GameObject tmp3 = Instantiate(movingEffect_Shape, new Vector3(this.transform.position.x, this.transform.position.y, 9), Quaternion.identity);
    }


    void move()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(nextPos.x, nextPos.y), speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, 10);
    }



    public void changeStatus()
    {
        for (int i = 0; i < lstElectric.Count; i++)
        {
            if (i == status)
            {
                lstElectric[i].SetActive(true);
            }
            else
            {
                lstElectric[i].SetActive(false);
            }
        }
    }


    public void spawDes(Vector3 pos)
    {
        GameObject tmp2 = Instantiate(des, new Vector3(pos.x, pos.y, this.transform.position.z), Quaternion.identity);
        // Destroy(tmp2, 100f);
    }

    public void spawAttack(Vector3 pos)
    {
        GameObject tmp2 = Instantiate(attack,new  Vector3(pos.x,pos.y,3.2f) , Quaternion.identity);
        Destroy(tmp2, 0.2f);
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "avoid")
        {
            // Vector3 contactPoint = other.ClosestPoint(transform.position);
            Vector3 contactPoint = other.transform.position;
            spawHit(contactPoint);


        }
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "avoidArea")
        {
            if (status == 0)
            {
                status = 2;
                changeStatus();
            }


        }

    }


    public void setPostNow(Vector3 pos)
    {
        transform.position = pos;
    }

    public void loadSkin()
    {
        int indexSkin = Config_level.indexSkin;

        Idle = FindObjectOfType<SkinPacks>().Idle;
        GO = FindObjectOfType<SkinPacks>().GO;
        DIE = FindObjectOfType<SkinPacks>().DIE;


        lstElectric.Add(Idle);
        lstElectric.Add(GO);
        lstElectric.Add(DIE);

    }


    public void spawHit(Vector3 pos)
    {

        GameObject tmp2 = Instantiate(hit, new Vector3(pos.x, pos.y, 4), Quaternion.identity);
        Destroy(tmp2, 0.2f);
    }


    void setDirection(Vector3 posDes)
    {

        if (transform.position.x < posDes.x)
        {
            if (transform.position.y < posDes.y)
            {
                Config_level.indexEniShutdownMoving = 1;
            }
            else
            {
                Config_level.indexEniShutdownMoving = 2;
            }
        }
        else
        {
            if (transform.position.y < posDes.y)
            {
                Config_level.indexEniShutdownMoving = 4;
            }
            else
            {
                Config_level.indexEniShutdownMoving = 3;
            }
        }

    }


    public void spawStop()
    {

        GameObject tmp2 = Instantiate(stopObj, new Vector3(stopPos.transform.position.x, stopPos.transform.position.y, 10), Quaternion.identity);
        Destroy(tmp2, 0.5f);
    }
    

     public void calRo(){
        rotaAngle = FindObjectOfType<calGOC>().calculatorGoc(this.transform.position,nextPos,1);
    }



    

    



}