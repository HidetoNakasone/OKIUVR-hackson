using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kaiju : MonoBehaviour
{
    public RectTransform kaijuRectTransform;
    [SerializeField]private float kaijuSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovesKaiju();
    }

    void MovesKaiju()
    {
        kaijuRectTransform.localPosition+=new Vector3(kaijuSpeed,0,0);
    }
}
