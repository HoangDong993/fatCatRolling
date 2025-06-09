using UnityEngine;

public class generalWithMono : MonoBehaviour
{

    public GameObject finish;
    public GameObject gameOver;
    public GameObject cover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public bool checkFinish()
    {

        if (Config_level.pointTargetNow <= 0 && FindObjectOfType<fruit>().status != 2)
        {
            Sound_Menu.PlaySound(soundsGame.finish);
            FindObjectOfType<timeCal>().status = 0;
            cover.SetActive(true);
            if (Config_level.hpNow > 3)
            {
                Config_level.hpNow = 3;
            }
            FindObjectOfType<SaveLoadJSONDATA_RESULT>().saveStageNow(Config_level.hpNow);
            FindObjectOfType<scenesStatusConfig>().go("GameFinish", 4f, 1, null);
            FindObjectOfType<fruit>().status = 100;
            showFinish();
            FindObjectOfType<changEffect>().status = 1;
            return true;
        }
        return false;
    }

    public void GameOver()
    {
        if (FindObjectOfType<fruit>().status != 100)
        {
            Sound_Menu.PlaySound(soundsGame.gameOver);
            FindObjectOfType<fruit>().status = 2;
            FindObjectOfType<fruit>().changeStatus();
            FindObjectOfType<scenesStatusConfig>().go("GameOver", 2, 1, null);
            showGameOver();
            

          
        }

    }

    public void showFinish()
    {

        GameObject tmp2 = Instantiate(finish, new Vector3(0, 0, 5), Quaternion.identity);
        Destroy(tmp2, 10f);

    }

    public void showGameOver()
    {

        GameObject tmp2 = Instantiate(gameOver, new Vector3(0, 0, 5), Quaternion.identity);
        Destroy(tmp2, 10f);

    }

}
