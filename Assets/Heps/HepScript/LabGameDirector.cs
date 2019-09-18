using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LabGameDirector : MonoBehaviour
{
    public GameObject obj, obj_2, obj_3;
    VideoPlayer videoPlayer, videoPlayer_2, videoPlayer_3;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = obj.GetComponent<VideoPlayer>();
        videoPlayer_2 = obj_2.GetComponent<VideoPlayer>();
        videoPlayer_3 = obj_3.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            videoPlayer.Stop();
            videoPlayer_2.Stop();
            videoPlayer_3.Stop();
        }
    }
}
