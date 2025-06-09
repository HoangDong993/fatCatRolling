using UnityEngine;

public class heartFinish : MonoBehaviour
{
    Vector3 nextPos;
    public float speed;
    float time;
    public float timeMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextPos = FindObjectOfType<listDesOfHeart>().getDes();
        timeMax += Config_level.heartFinishConfigTime;
        Config_level.heartFinishConfigTime += 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= timeMax)
        {
             move();
        }
        
    }
    
    void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(nextPos.x, nextPos.y,90), speed * Time.deltaTime);
    }
}
