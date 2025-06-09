using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_Script : MonoBehaviour
{
     public int camAction;
     public float timeShake;
    public float timeShakeMax;

    public float timechangeShake;
    public float timechangeShakeMax;
    
    float beginY;
    public int maincharUp_Status;

    public int status_Stay;

    public float speed;

    public GameObject pos_BossAppear;

    public GameObject boss6_Pos;
    public GameObject boss8_Pos;
    public GameObject boss9_Pos;

    public Camera cam;

    public int status_Waring;

    public GameObject Warning;

    public int statusTutoExit;
    




    public GameObject mainChar;
    // Start is called before the first frame update
    void Start()
    {

        // tutorial Pos
        if (Config_level.isTuto == 1)
        {
            
        }else
        {
            
        }

        camAction = 0;
        beginY = this.transform.position.y;



        float h = Screen.height;
        float w = Screen.width;

        if ((w / h) < (1920f / 1080f))
        { 
        float h_nice = w * 0.56f;

        float h_rate =  h/h_nice;

        float cam_rate_zoom = h_rate / 0.99f;

        cam.orthographicSize = cam.orthographicSize * cam_rate_zoom ;
        }

        Config_level.pos_Cam_X = this.transform.position.x;
        Config_level.pos_Cam_Y = this.transform.position.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Config_level.pos_Cam_X = this.transform.position.x;
        Config_level.pos_Cam_Y = this.transform.position.y;


        this.transform.position = new Vector3(mainChar.transform.position.x,mainChar.transform.position.y,this.transform.position.z);

       
        
        
        if (camAction != 0)
        {
            timeShake += Time.deltaTime;
            if (timeShake>=timeShakeMax)
            {
                camAction = 0;
                timeShake = 0;
            }
            if (camAction == 1)
        {
            move_Up();
            timechangeShake += Time.deltaTime;
            if (timechangeShake>= timechangeShakeMax)
            {
                camAction = 2;
                timechangeShake = 0;
            }
        }else if(camAction == 2)
        {
            timechangeShake += Time.deltaTime;
            move_Down();
            if (timechangeShake>= timechangeShakeMax)
            {
                camAction = 1;
                timechangeShake = 0;
            }
        }
        }else
        {
            move_center();
        }


        Camera_config.x = this.transform.position.x;



    }



     public void move_Up(){
        // transform.position = new Vector3(transform.position.x, 30, transform.position.z);
        transform.rotation = Quaternion.Euler(Vector3.forward * 2);
    }

    public void move_Down(){
        // transform.position = new Vector3(transform.position.x, - 30, transform.position.z);
        transform.rotation = Quaternion.Euler(Vector3.forward * -2);
    }

    public void move_center(){
        transform.rotation = Quaternion.Euler(Vector3.forward * 0);
    }
}
