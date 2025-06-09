using UnityEngine;
using TMPro;

public class textTarget : MonoBehaviour
{
    public TMP_Text textOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        showText();
    }

    public void showText(){

         textOut.text = FindObjectOfType<targetConfig>().pointTarget.ToString();
    }
}
