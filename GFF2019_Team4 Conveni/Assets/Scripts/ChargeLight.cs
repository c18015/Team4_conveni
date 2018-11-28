using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeLight : MonoBehaviour { //発電システムのスクリプト、携帯を横に傾けると発電してくれるはず(未デバッグ)

    public int Energy = 1;　//発電ゲージにプラスする数
    public LightGauge_Controller LGC; //数字を送るスプリクト

    void Start()
    {



    }

    void Update() {

        Vector3 vector = new Vector3();

        vector.x = Input.GetAxis("Horizontal");


        //０より大きくなるとその度に発電ゲージにさっきの数をプラスする。携帯を少しでも傾くと０より大きくなるガバガバシステム　　いつか修正したい。
        if (vector.x != 0)　
        {

            //AddでLightGauge_Controllerのスクリプトに送る
            LGC.AddplusE1(Energy);　
        }






       // Debug.Log(vector.x); 
     

    }

}
