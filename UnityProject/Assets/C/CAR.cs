using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR : MonoBehaviour
{
    [Header("前進速度"), Range(0, 100)]
    public float speed = 5.5f;
    [Header("轉彎速度"), Range(0, 100)]
    public float C_speed = 5.5f;
    [Header("是否剎車")]
    public bool OX = false;
    [Header("汽車檔位"), Range(0, 5)]
    public int MOD = 3;
    [Header("品牌")]
    public string CAR_name = "OOF";
    [Header("車色")]
    public Color bady;

    [Header("車輛移動")]//變數欄位 可使用其他的class來當作宣告
    public Transform CAR_RUN;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OX == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                W();
            }
            if (Input.GetKey(KeyCode.S))
            {
                S();
            }
            if (Input.GetKey(KeyCode.A))
            {
                A();
            }
            if (Input.GetKey(KeyCode.D))
            {
                D();
            }
        }else if (OX == true)
        {

        }
        
    }
    

    public void W()
    {
        CAR_RUN.Translate( 0, 0, speed * Time.deltaTime);
    }

    public void S()
    {
        CAR_RUN.Translate(0, 0, -speed * Time.deltaTime);
    }

    public void A()
    {
        CAR_RUN.transform.Rotate(0, -C_speed * Time.deltaTime, 0);
    }

    public void D()
    {
        CAR_RUN.transform.Rotate(0, C_speed * Time.deltaTime, 0);
    }
}
