using UnityEngine;

public class eniSure : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
            
            if (other.gameObject.tag == "Player"){
                Sound_Menu.PlaySound(soundsGame.attack);
                Vector3 contactPoint = other.ClosestPoint(transform.position);
                if (FindObjectOfType<fruit>().status != 2 && FindObjectOfType<fruit>().status != 3 )
                {
                FindObjectOfType<fruit>().spawAttack(contactPoint);
                    FindObjectOfType<generalWithMono>().GameOver();
                }
              
                
            }

    }
}
