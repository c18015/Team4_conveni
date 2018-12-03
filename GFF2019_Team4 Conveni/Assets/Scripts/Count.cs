using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour {

    GameObject[] tagObjects;
    public bool Iscount = false;

    //float timer = 0.0f;
    //float interval = 2.0f;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        /*timer += Time.deltaTime;

        if(timer > interval)
        {
            Check("Friend");

            timer = 0;
        }*/

        Check("Friend");
	}

    void Check(string tagname)
    {
        tagObjects = GameObject.FindGameObjectsWithTag(tagname);

        Debug.Log(tagObjects.Length);
        if(tagObjects.Length == 3)
        {
            Iscount = true;
            //Debug.Log(Iscount);
        }

        if(tagObjects.Length == 0)
        {
            Debug.Log(tagname + "タグがついたオブジェクトはありません");
        }
    }
}
