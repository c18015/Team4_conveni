using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickStartButton()
    {
        Application.LoadLevel("Main");
    }
}
