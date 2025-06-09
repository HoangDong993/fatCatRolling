using UnityEngine;

public class rotation_For_A_Time : MonoBehaviour
{
    int status;
    public float time;
    public float time_Max;
    public float rota;
    public float rotaLimit;
    public float min;
    public float max;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= time_Max)
        {
            if (rota > 0)
            {
                rota = Random.Range(min, max);
            }
            else
            {
                rota = Random.Range(-max, -min);
            }
            rota = rota * (-1);
            time = 0;
        }

        if (this.transform.eulerAngles.z >= rotaLimit)
        {
            //     Debug.Log("ROTAAAAA :" + this.transform.eulerAngles.z);
            //     this.transform.eulerAngles = new Vector3(
            //    this.transform.eulerAngles.x,
            //    this.transform.eulerAngles.y,
            //   1
            //    );

            transform.rotation = Quaternion.Euler(0, 0, 1);
        }
        else if (this.transform.eulerAngles.z <= (rotaLimit * (-1)))
        {
            //     Debug.Log("ROTAAAAA222222 :" + this.transform.eulerAngles.z);
            //     this.transform.eulerAngles = new Vector3(
            //    this.transform.eulerAngles.x,
            //    this.transform.eulerAngles.y,
            //   1
            //    );

            transform.rotation = Quaternion.Euler(0, 0, 1);
        }

        this.transform.eulerAngles = new Vector3(
        this.transform.eulerAngles.x,
        this.transform.eulerAngles.y,
        this.transform.eulerAngles.z + rota
         );
        
    // Debug.Log("ROTNOWWWWWWWW :" + this.transform.eulerAngles.z);
    }
}
