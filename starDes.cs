using UnityEngine;

public class starDes : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }


    void OnTriggerEnter2D(Collider2D other)
    {

        other.gameObject.SetActive(false);
        FindObjectOfType<showStar>().calShowStar(this.gameObject);
    }
    

    
}
