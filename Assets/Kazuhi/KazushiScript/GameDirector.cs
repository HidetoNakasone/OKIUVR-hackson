using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
     public bool gamefinished;
     public  RectTransform kaiju;
     public  RectTransform kaijuTokyo;
     public  RectTransform kaijuChiba;
     public  Transform player;
     public  Transform playerTokyo;
     public  Transform playerchiba;
     public  static Transform playerchiba2;

     public static float kaimetuEND;
     public static float justMeetEND;
     public static float SabuuuEND;


/* 
    public static float GetKaijuPosition()
    {
        return kaiju.localPosition.x;
    }
    public static float GetKaijuTokyoPosision()
    {
        return kaijuTokyo.localPosition.x;
    }
    public static float GetkaijuChibaPosition()
    {
        return kaijuChiba.localPosition.x;
    }

    public static float GetPlayerPosition()
    {
        return player.transform.position.x;
    }
    public static float GetPlayerTokyoPosition()
    {
        return playerTokyo.transform.position.x;
    }
    public static float GetPlayerChibaPosition()
    {
        return playerchiba.transform.position.x;
    }
    */

    void Start()
    {
       
    }

    void Update()
    {
        if(gamefinished)
        {
            JudgeEnding();
            SendsEnding();
        }
    }
    void JudgeEnding()
    {
        
    }
    void SendsEnding()
    {

    }

    

/* 
    void GetTokyosabun()
    {
        kaijuTokyoSabun=kaiju.localPosition.x+tokyo.localPosition.x;
    }
    void GetChibasabun()
    {
        kaijuChibaSabun=kaiju.localPosition.x+chiba.localPosition.x;
    }

    public float tokyoCaluculatr(float place)
    {

        float rate=4;
        float sum=kaiju.localPosition.x+place;
        float sabun=sum/rate;
        return sabun;
    }

    public float chibaCaluculater(float place)
    {
        float rate=0.2f;
        float sum=kaiju.localPosition.x+place;
        float sabun=sum*rate;
        return sabun;
    }
    */
}