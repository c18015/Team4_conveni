using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButtonCon : MonoBehaviour {

    public GameObject hatudenGUI;



    // Use this for initialization
    void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {

	}


    public void LightGuiON()
    {
        hatudenGUI.SetActive(true);

    }

    public void LightGuiOFF()
    {
        hatudenGUI.SetActive(false);

    }
}
