using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LabGameDirector : MonoBehaviour
{
    public GameObject obj_1, obj_2, obj_3, obj_4;
    VideoPlayer videoPlayer_1, videoPlayer_2, videoPlayer_3, videoPlayer_4;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer_1 = obj_1.GetComponent<VideoPlayer>();
        videoPlayer_2 = obj_2.GetComponent<VideoPlayer>();
        videoPlayer_3 = obj_3.GetComponent<VideoPlayer>();
        videoPlayer_4 = obj_4.GetComponent<VideoPlayer>();

        videoPlayer_1.frame = 10;
        videoPlayer_2.frame = 30;
        videoPlayer_3.frame = 50;
        videoPlayer_4.frame = 70;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            videoPlayer_1.Stop();
            videoPlayer_2.Stop();
            videoPlayer_3.Stop();
            videoPlayer_4.Stop();
        }
    }
}
