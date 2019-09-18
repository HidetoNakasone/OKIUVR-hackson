using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwPlayer : MonoBehaviour
{ 
    public Transform playerTS;
    [SerializeField]private Transform cameraTS;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowCamera();
    }

    void FollowCamera()
    {
        Vector3 currentPlayerPos=new Vector3(playerTS.position.x,playerTS.position.y,cameraTS.position.z);
        cameraTS.position=currentPlayerPos;
    }
}
