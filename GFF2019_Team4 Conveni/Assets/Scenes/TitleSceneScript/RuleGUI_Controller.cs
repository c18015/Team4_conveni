using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleGUI_Controller : MonoBehaviour {
    public GameObject RuleGUI;




    void Start()
    {
    }
    void Update()
    {
    }


    //ボタンを押すとHatuden_ screenを表示する
    public void LightGuiON()
    {
        RuleGUI.SetActive(true);

    }

    //ボタンを押すとHatuden_ screenを非表示にする
    public void LightGuiOFF()
    {
        RuleGUI.SetActive(false);

    }
}
