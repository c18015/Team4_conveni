using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour {　　//クモさんを管理するスクリプト

    public GameObject player;
    public float MoveSpeed2;　//クモさんの移動速度



    // Use this for initialization
    void Start () {

   
        player = GameObject.FindGameObjectWithTag("Player");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //プレイヤーがコライダー(感知範囲)に入ったら PlayerLook()をする
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("感知圏内にプレイヤーが入りました。");

            PlayerLook();

        }
    }

    //プレイヤーのほうを向く
    void PlayerLook()
    {
        var vec = (player.transform.position - this.transform.position).normalized;
        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, vec);

        transform.Translate(0, 1 * MoveSpeed2 * Time.deltaTime, 0);
    }

}
