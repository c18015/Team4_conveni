using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEND_Controller : MonoBehaviour {


    public GameObject GameEndGUI;




    void Start()
    {
    }
    void Update()
    {
    }


    //ボタンを押すとHatuden_ screenを表示する
    public void GMendGuiON()
    {
        GameEndGUI.SetActive(true);

    }

    //ボタンを押すとHatuden_ screenを非表示にする
    public void GMendGuiOFF()
    {
        GameEndGUI.SetActive(false);

    }
}
