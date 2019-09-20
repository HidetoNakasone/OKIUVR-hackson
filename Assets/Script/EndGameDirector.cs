using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameDirector : MonoBehaviour
{
    public float e_tb, e_now, p_tb, p_now;
    public Image BgLayer;
    public Text EndMessage;

    public GameObject BgImage_1, BgImage_2, BgImage_3;

    // Start is called before the first frame update
    void Start()
    {
        // 固定？？
        e_tb = 80f;
        p_tb = 85f;

        e_now = 86f;
        p_now = 80f;

        float e_diff = e_now - e_tb;
        float p_diff = p_now - p_tb;

        // Debug.Log(e_diff + " : " + p_diff);

        int judgmentWeight = 5;

        float e_judg = 0;
        float p_judg = 0;

        if(-judgmentWeight >= e_diff && e_diff >= judgmentWeight) {
            e_judg = 0;
        } else if (-judgmentWeight > e_diff) {
            e_judg = -1;
        } else if (e_diff > judgmentWeight) {
            e_judg = 1;
        }

        if(-judgmentWeight >= p_diff && p_diff >= judgmentWeight) {
            p_judg = 0;
        } else if (-judgmentWeight > p_diff) {
            p_judg = -1;
        } else if (p_diff > judgmentWeight) {
            p_judg = 1;
        }

        Debug.Log(e_judg + " : " + p_judg);

        int endNumber = 0;

        if(e_judg == -1) {
            if(p_judg == -1) { endNumber = 1; }
            if(p_judg == 0) { endNumber = 2; }
            if(p_judg == 1) { endNumber = 3; }
        } else if (e_judg == 0) {
            if(p_judg == -1) { endNumber = 4; }
            if(p_judg == 0) { endNumber = 5; }
            if(p_judg == 1) { endNumber = 6; }
        } else if (e_judg == 1) {
            if(p_judg == -1) { endNumber = 7; }
            if(p_judg == 0) { endNumber = 8; }
            if(p_judg == 1) { endNumber = 9; }
        }

        // Debug.Log(endNumber);
        endNumber = 6;  // dev

        BgImage_1.SetActive(false);
        BgImage_2.SetActive(false);
        BgImage_3.SetActive(false);

        switch (endNumber) {
            case 0:
                EndMessage.text = "Error.";
                break;
            case 1:
                EndMessage.text = "ヒーローは太平洋でモンスターを倒したので話題にもならず、感謝されることもない。\nP「これがヒーローなのか。。。孤独だな。」\n";
                BgImage_2.SetActive(true);
                break;
            case 2:
                EndMessage.text = "ヒーローが着いた時には千葉にモンスターはいなかった・・・早すぎたのだ。\n男の子「ねぇーねー、お母さんあの人へんな格好しているよー」\n母親「し！見ちゃ駄目よ！」\nP「・・・帰ろう。」\n";
                break;
            case 3:
                EndMessage.text = "ずどーんっっ！！\n速すぎたヒーローは、そのままスカイツリーへぶっ刺さった。\n東・京・壊・滅\n";
                BgImage_1.SetActive(true);
                break;
            case 4:
                EndMessage.text = "深夜アニメの録画作業に追われ、ヒーローは出発に遅れてしまった。\n千葉壊滅\n";
                BgImage_1.SetActive(true);
                break;
            case 5:
                EndMessage.text = "女の子「誰か助けてーー！！」\nP「僕を呼んだかい？ お嬢ちゃん。」\n女の子「おじちゃん、・・・誰？」\nP「・・・”お兄さん”は、ヒーローをやっているものだ。」\nP「あのモンスターは、”お兄さん”が倒してあげよう！ とうっ！」\n東京へ進行するモンスターは、ヒーローによって無事倒された。\n街を救ったヒーローを、人々は快く迎え。・・・そして伝説となった。ベストエンド。\n";
                BgImage_2.SetActive(true);
                break;
            case 6:
                EndMessage.text = "自衛隊「隊長！千葉は壊滅。モンスター依然、こちらに進行中です！」\n隊長「分かった。レーダー班、モンスターの到着予想時刻は？」\n自衛隊「緊急！ こちらに急速に接近する物体あり！！」\n隊長「なにぃぃぃぃ！！」\n・・・\n弾丸の様にヒーローが東京の防衛線を破壊した。\nいや、もう彼はヒーローではない。。。彼こそがモンスターかもしれない。\n";
                BgImage_3.SetActive(true);
                break;
            case 7:
                EndMessage.text = "東京は壊滅した。それをヒーローはニコ生で視聴していた。\nP「あれ！？ 今回のモンスター、強くね！？」\nP「・・・帰ろう。今、行ってももう遅いしな。」\n完\n";
                BgImage_2.SetActive(true);
                break;
            case 8:
                EndMessage.text = "千葉はもう、モンスターによって壊滅していた。\n男性「お！そこの人、その姿はヒーローではないか？」\nP「いかにも！私はヒーローだ。何がったのだ？」\nP (まぁモンスターに襲われているのは分かるけど)\n男性「も、モンスターが、、街を、、、うぅうぅ。。しくしく。」\nP (・・・やばい！？ トイレが長くて遅れたとは言えない！？)\nP「それは大変でしたね。安心して下さい！奴は僕が倒します！」\nP (あれ？ もしかして千葉が壊滅した今がベストタイミングなのでは！？ ぐへへ。今から東京へ向かう俺、かっこよくね？？ ぐへへ。)\n";
                BgImage_3.SetActive(true);
                break;
            case 9:
                EndMessage.text = "決戦の地、東京。ヒーローは無事にモンスターを撃退した。\nP「おらぁぁぁあ！」\nP「よし！ モンスターを倒したのは 俺だぞぉぉぉ！！！」\n警察官「ちょっと、そこの君。建物壊しすぎだよ。」\nP「え！？ で、でも、あれですよ。。。モンスター倒したのは僕・・」\n警察官「それとこれとは別。はい。これ請求書。サインして！」\n涙。\n";
                BgImage_1.SetActive(true);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(EndMessage.rectTransform.sizeDelta.y);
        RectTransform BgRect = BgLayer.GetComponent<RectTransform> ();

        // width, height
        BgRect.sizeDelta = new Vector2(800f, EndMessage.rectTransform.sizeDelta.y + 40f);

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene("TitleScene");
        }

    }
}
