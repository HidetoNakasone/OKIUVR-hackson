using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TokyoTower : MonoBehaviour
{
    public GameDirector gameDirector;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void  OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player") gameDirector.gamefinished=true;
       
        //other.gameObject.tag=!UIDebug.Log("Seikou");
    }
}
