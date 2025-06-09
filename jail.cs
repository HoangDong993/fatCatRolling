using UnityEngine;

public class jail : MonoBehaviour
{
    public GameObject jail_Escape;

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
        if (other.gameObject.tag == "Player" && FindObjectOfType<fruit>().status != 2)
        // if (other.gameObject.tag == "Player" && FindObjectOfType<fruit>().status == 1)
        {
            Sound_Menu.PlaySound(soundsGame.hit);
            Sound_Menu.PlaySound(soundsGame.ratGone);
            
            // Vector3 contactPoint = other.transform.position;
            FindObjectOfType<fruit>().spawHit(this.transform.position);

            FindObjectOfType<camera_Script>().camAction = 1;
            GameObject tmp2 = Instantiate(jail_Escape,new Vector3 (this.transform.position.x,this.transform.position.y,4) , Quaternion.identity);
            Destroy(tmp2, 2f);
            general.minusTarget();
            FindObjectOfType<generalWithMono>().checkFinish();
            Destroy(this.gameObject, 0f);

        }

    }
    
}
