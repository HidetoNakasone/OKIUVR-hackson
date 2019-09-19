using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float xPositiveSpeed;//  アクセルのベクトル（+xのベクトル）
    [SerializeField]private float xNegativeSpeed;//  ブレーキのベクトル（-xのベクトル）
    public GameDirector gameDirector;
    //[SerializeField]private float AutomaticallySpeed;
    //[SerializeField]private float Speed;//  オートランのベクトル（+xのベクトル）
    //[SerializeField]private float xPositiveRate;//  アクセルの加速割合
    //[SerializeField]private float xNegativeRate;//  ブレーキの加速割合
    [SerializeField]private Rigidbody2D rb2;
    private bool isAccelerated=false;
    private bool isPlayed=false;
    
    void Start()
    {
        rb2=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isPlayed) return;
        SpeedUp();
        SlowDown();  
    } 
    // プレイヤーの自動移動
    void AutomaticallyMove()
    {
        //Speed=Speed+AutomaticallySpeed;
    }
    // アクセル
    void SpeedUp()
    {
        if(isAccelerated==false)
        {
            if(Input.GetMouseButtonUp(0))
            {
                rb2.velocity=new Vector2(xPositiveSpeed,0);
                isAccelerated=true;
                Debug.Log("akuseru");
            }
        }
    }
    // ブレーキ
    void SlowDown()
    {
        if(isAccelerated)
        {
            if(Input.GetMouseButtonUp(1))
            {
                isPlayed=true;
                rb2.velocity=new Vector2(0,0);
                Vector2 brakeVevtor=new Vector2(xNegativeSpeed,0);
                rb2.AddForce(brakeVevtor,ForceMode2D.Impulse);
                Debug.Log("brake");
                //rb2.velocity=new Vector2(0,0);
            }
        }     
    }
}

