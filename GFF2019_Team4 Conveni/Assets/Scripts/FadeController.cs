using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour {

    float fadeInSpeed = 0.000222f;
    float fadeOutSpeed = 0.000222f;        //透明度が変わるスピードを管理
    float red, green, blue, alpha;   //パネルの色、不透明度を管理
    public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
    public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ

    Image fadeImage;                //透明度を変更するパネルのイメージ

    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alpha = fadeImage.color.a;
    }

    void Update()
    {
        if (Input.GetKey("z"))
        {
            StartFadeIn();
        }

        else
        {
            StartFadeOut();
        }
    }

    void StartFadeIn()
    {
        alpha -= fadeInSpeed;                //a)不透明度を徐々に下げる
        SetAlpha();                      //b)変更した不透明度パネルに反映する
        if (alpha <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            fadeInSpeed = 0;
            fadeImage.enabled = false;    //d)パネルの表示をオフにする
        }
        else
        {
            fadeInSpeed = 0.000222f;
        }
    }

    void StartFadeOut()
    {
        fadeImage.enabled = true;  // a)パネルの表示をオンにする
        alpha += fadeOutSpeed;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alpha >= 0.8)
        {             // d)完全に不透明になったら処理を抜ける
            fadeOutSpeed = 0;
        }
        else
        {
            fadeOutSpeed = 0.000222f;
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}