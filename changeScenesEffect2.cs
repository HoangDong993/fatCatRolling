using UnityEngine;

public class changeScenesEffect2 : MonoBehaviour
{
    public GameObject effect;
    public GameObject objDisable;
    public int status;
    public Vector3 posSpaw;
    public float distanceX;
    public float distanceY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       callPosSpaw();
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        

        if (status != 0)
        {
            spawEffect();
            if (objDisable != null)
            {
                objDisable.SetActive(false);
            }
            
            status = 0;
        }
        
    }

    public void spawEffect(){
        // Sound_Menu.PlaySound(soundsGame.changeScene);
        GameObject tmp2 = Instantiate(effect, new Vector3 (posSpaw.x ,posSpaw.y,2.3f), Quaternion.identity);
        // Destroy(tmp2, 1f);
    }

    void callPosSpaw(){
         
        float h = Screen.height;
        float w = Screen.width;
        Vector3 screenPos = new Vector3(w/distanceX,h/distanceY,this.transform.position.z);
        TranformScreenToWorldPos(screenPos);

    }

    void TranformScreenToWorldPos(Vector3 pos){
        Camera mainCam = Camera.main;
        Vector3 screenPos = mainCam.ScreenToWorldPoint(pos);
        posSpaw = screenPos;
    
    }
}