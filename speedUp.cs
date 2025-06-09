using UnityEngine;

public class speedUp : MonoBehaviour
{
    public GameObject desofMain;
    public GameObject speedUp1;
    public GameObject speedUp2;

    
    public float speedMainOri;
    public float speedUP;
    int status;
    public int isQuay;
    public int speedQuay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        speedMainOri = FindObjectOfType<fruit>().speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (isQuay == 1)
        {
            transform.Rotate(new Vector3(0, 0, speedQuay));
        }
            
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player" && status == 0)
        {
            isQuay = 0;
            if (FindObjectOfType<fruit>().status == 0)
            {
                FindObjectOfType<fruit>().status = 1;
                FindObjectOfType<fruit>().changeStatus();
            }
            if (FindObjectOfType<des>() != null)
            {
                Destroy(FindObjectOfType<des>().gameObject, 0f);
            }
            Config_level.isSpeedChange = 1;
            FindObjectOfType<fruit>().speed = speedMainOri * speedUP;
            FindObjectOfType<fruit>().gameObject.transform.position = this.transform.position;

            FindObjectOfType<fruit>().nextPos = desofMain.transform.position;
            FindObjectOfType<fruit>().calRo();
            FindObjectOfType<fruit>().spawDes(desofMain.transform.position);
            changeStatus();


        }else if (other.gameObject.tag == "des" && status == 0)
        {
            Destroy(other.gameObject,0f);
        }
    }

    void changeStatus()
    {
        speedUp1.SetActive(false); 
        speedUp2.SetActive(true);
        status =1;
        
    }

}