using UnityEngine;

public class thisIsStage : MonoBehaviour
{
    public int hp;

    public float distanceX;
    public float distanceY;
    Vector3 screenPos;
    Vector3 realPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Config_level.hpNow = hp;

        float h = Screen.height;
        float w = Screen.width;

        screenPos = new Vector3(w / distanceX, h / distanceY, this.transform.position.z);
        TranformScreenToWorldPos(screenPos);
        FindObjectOfType<loadHeart>().transform.position = realPos;

        FindObjectOfType<loadHeart>().spawHeart(hp);
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    void TranformScreenToWorldPos(Vector3 pos){
        Camera mainCam = Camera.main;
        Vector3 screenPos = mainCam.ScreenToWorldPoint(pos);
        realPos = screenPos;
        realPos.z = this.transform.position.z;
    }
}
