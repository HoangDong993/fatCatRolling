using UnityEngine;
using TMPro;

public class chapShow : MonoBehaviour
{
     public TMP_Text textChap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textChap.text = "Chapter " + Config_level.chap;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
