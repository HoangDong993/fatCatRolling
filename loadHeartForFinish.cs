using System.Collections.Generic;
using UnityEngine;

public class loadHeartForFinish : MonoBehaviour
{
    float distanceToSpaw;
    public float distanceToSpaw_Increase;
    public GameObject posStart;
    public GameObject heart;
    List<GameObject> listHeart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Config_level.heartFinishConfigTime = 0;
        listHeart = new List<GameObject>();
        spawHeart(Config_level.hpNow);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void spawHeart(int hp)
    {
        for (int i = 0; i < hp; i++)
        {
            GameObject tmp2 = Instantiate(heart, new Vector3(posStart.transform.position.x + distanceToSpaw, posStart.transform.position.y, 10), Quaternion.identity);
            distanceToSpaw += distanceToSpaw_Increase;
            listHeart.Add(tmp2);
        }
    }

    public void minusHHeart()
    {
        listHeart[listHeart.Count - 1].SetActive(false);
        listHeart.Remove(listHeart[listHeart.Count - 1]);
    }
}
