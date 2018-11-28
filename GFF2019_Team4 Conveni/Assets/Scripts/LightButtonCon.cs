using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButtonCon : MonoBehaviour {  //発電画面をボタンで表示、非表示するスクリプト

    public GameObject hatudenGUI;



   
    void Start () {        
    }
	void Update () {
	}


    //ボタンを押すとHatuden_ screenを表示する
    public void LightGuiON()
    {
        hatudenGUI.SetActive(true);

    }

    //ボタンを押すとHatuden_ screenを非表示にする
    public void LightGuiOFF()
    {
        hatudenGUI.SetActive(false);

    }
}
