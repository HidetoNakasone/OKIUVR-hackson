using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LabGameDirector : MonoBehaviour
{
    public GameObject obj_1, obj_2, obj_3, obj_4, obj_monsterImage_1, obj_monsterImage_2, obj_monsterImage_3, obj_monsterImage_4, InfoMsg_nextSsene;

    public Image obj_bgImage;

    VideoPlayer videoPlayer_1, videoPlayer_2, videoPlayer_3, videoPlayer_4;

    bool isMonsterAction = false;

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

        obj_monsterImage_1.SetActive(false);
        obj_monsterImage_2.SetActive(false);
        obj_monsterImage_3.SetActive(false);
        obj_monsterImage_4.SetActive(false);
        InfoMsg_nextSsene.SetActive(false);

        obj_bgImage.color = new Color(0.3f, 0.6f, 0.8f);

        float monster_run_delayTime = Random.Range(2, 12);
        Invoke("DelayMethod", monster_run_delayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (isMonsterAction) {
                // Enterキーが押され、モンスター出現していた場合の処理。
                Debug.Log("Go Next MoveMap >> ");
                SceneManager.LoadScene("EndScene");
            }
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene("TitleScene");
        }
    }

    void DelayMethod()
    {
        isMonsterAction = true;

        obj_bgImage.color = new Color(0.8f, 0.2f, 0.2f);
        InfoMsg_nextSsene.SetActive(true);

        videoPlayer_1.Stop();
        videoPlayer_2.Stop();
        videoPlayer_3.Stop();
        videoPlayer_4.Stop();

        obj_monsterImage_1.SetActive(true);
        obj_monsterImage_2.SetActive(true);
        obj_monsterImage_3.SetActive(true);
        obj_monsterImage_4.SetActive(true);
    }
}
