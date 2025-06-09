using UnityEngine;

public class SkinPacks : MonoBehaviour
{
    public GameObject Idle;
    public GameObject GO;
    public GameObject DIE;
    public int speedOfPlayer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (speedOfPlayer > 0)
        {
            FindObjectOfType<fruit>().speed = speedOfPlayer;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
