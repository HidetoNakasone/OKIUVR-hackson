using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kaiju : MonoBehaviour
{
    public RectTransform kaijuRectTransform;
    public GameDirector gameDirector;
    [SerializeField]private float kaijuSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        MovesKaiju();
        if(kaijuRectTransform.localPosition.x>350);
    }

    void MovesKaiju()
    {
        kaijuRectTransform.localPosition+=new Vector3(kaijuSpeed,0,0);
    }
    
}
