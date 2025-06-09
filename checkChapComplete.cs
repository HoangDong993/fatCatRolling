using UnityEngine;

public class checkChapComplete : MonoBehaviour
{
    public GameObject chapCom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Config_level.stage % 10 == 0 && Config_level.stage == Config_level.finishAmountNow)
        {
            spawChapCom();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void spawChapCom()
    {
        GameObject tmp2 = Instantiate(chapCom, this.transform.position, Quaternion.identity);
    }
}
