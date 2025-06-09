using UnityEngine;

public class eniFruitShutdown : MonoBehaviour
{
    public float changeX;
    public float changeY;
    int status;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        status = Config_level.indexEniShutdownMoving;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveOBJ();
    }


    void moveOBJ(){

        switch (status)
        {

            case 1:
                {
                    this.transform.position = new Vector3(this.transform.position.x + changeX,this.transform.position.y +  changeY,this.transform.position.z);
                }
                break;
            case 2:
                {
                    this.transform.position = new Vector3(this.transform.position.x + changeX,this.transform.position.y  -  changeY,this.transform.position.z);
                }
                break;
            case 3:
                {
                    this.transform.position = new Vector3(this.transform.position.x - changeX,this.transform.position.y -  changeY,this.transform.position.z);
                }
                break;
            case 4:
                {
                    this.transform.position = new Vector3(this.transform.position.x - changeX,this.transform.position.y +  changeY,this.transform.position.z);
                }
                break;
        }
    }
}
