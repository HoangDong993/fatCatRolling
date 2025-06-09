using System.Collections.Generic;
using UnityEngine;

public class colorOfChap : MonoBehaviour
{
    public SpriteRenderer sprite;
    public List<string> listColorCode;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var tempColor = listColorCode[Config_level.chap];
        var m_Red = System.Convert.ToByte(tempColor.Substring(0, 2), 16);
        var m_Green = System.Convert.ToByte(tempColor.Substring(2, 2), 16);
        var m_Blue = System.Convert.ToByte(tempColor.Substring(4, 2), 16);

       // always requires the alpha parameter
       var m_NewColor = new UnityEngine.Color32(m_Red, m_Green, m_Blue, 255);
        sprite.color = m_NewColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
