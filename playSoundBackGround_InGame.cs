using UnityEngine;

public class playSoundBackGround_InGame : MonoBehaviour
{
    public int status;
    float time;
    public float timeMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status == 0)
        {
            Sound_Menu.PlaySound(soundsGame.menuInGame);
            status = 1;
        }


        if (status == 1)
        {
            time += Time.deltaTime;
            if (time >= timeMax)
            {
                status = 0;
                time = 0;
            }
        }
    }
}
