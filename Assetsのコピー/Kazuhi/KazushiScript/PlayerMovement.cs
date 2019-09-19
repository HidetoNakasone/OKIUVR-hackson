using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float xSpeed;//  プレイヤーの移動スピード
    [SerializeField]private float AutomaticallySpeed;
    [SerializeField]private float xPositiveRate;//  アクセルの加速割合
    [SerializeField]private float xNegativeRate;//  ブレーキの加速割合
    [SerializeField]private Rigidbody2D rb2;
    
    void Start()
    {
        rb2=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        AutomaticallyMove();
        SpeedUp();
        SlowDown();
    }
    void AutomaticallyMove()
    {
        rb2.AddForce(transform.right*AutomaticallySpeed,0);
        //rb2.velocity=transform.right*AutomaticallySpeed;
    }
    // プレイヤーの自動移動
    void SpeedUp()
    {
        if(Input.GetMouseButton(0))
        {
            IncreasexPositiveRate();
            rb2.AddForce(transform.right*xSpeed,0);
        }
    }

    void SlowDown()
    {
        if(Input.GetMouseButton(1))
        {
            if(xSpeed>0)
            {
                IncreasexNegativeRate();
                rb2.AddForce(transform.right*-xSpeed,0);
            }
        }
    }
    void IncreasexPositiveRate()
    {
        xSpeed+=xSpeed*xPositiveRate;
    }

    void IncreasexNegativeRate()
    {
        xSpeed-=xSpeed*xNegativeRate;
    }
}

