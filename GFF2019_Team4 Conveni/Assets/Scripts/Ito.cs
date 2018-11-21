using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ito : MonoBehaviour {

    bool Isarea = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Isarea = true;
        Debug.Log("入ってまーす!");
        Debug.Log(Isarea);

        TouchInput.Started += info => 
        {
            Debug.Log("いと切れた");
        };
    }
}
