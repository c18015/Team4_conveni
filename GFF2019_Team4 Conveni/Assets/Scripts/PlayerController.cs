using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    public float moveForce = 5, SneakMultiplier = 1;
    Rigidbody2D myBody;

    

    // Use this for initialization
    void Start()
    {

        myBody = this.GetComponent<Rigidbody2D>();

    }

    //動画を参考にしたため全くわからん()　知らない関数多すぎぃ！！
    void FixedUpdate()
    {
        
        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        bool isSneaking = CrossPlatformInputManager.GetButton("Sneak");
        //Debug.Log(isSneaking ? SneakMultiplier : 1);

        myBody.AddForce(moveVec * (isSneaking ? SneakMultiplier : 1));
    }
}
