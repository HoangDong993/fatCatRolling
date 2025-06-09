using UnityEngine;

public class changeGoc : MonoBehaviour
{
    public float rotaAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotaAngle = Config_level.mainGocNow;
        this.transform.eulerAngles = new Vector3(
       this.transform.eulerAngles.x,
       this.transform.eulerAngles.y,
       rotaAngle
       );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
