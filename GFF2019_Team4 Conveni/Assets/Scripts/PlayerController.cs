using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{  //プレイヤーのすべてがここにある。　マグロ、撮影開始　

    public float moveForce = 5, SneakMultiplier = 1;
    Rigidbody2D myBody;
    public float PlayerHP = 3;

    public float falseTimer = 0.5f;

    public DM_Effect DMFX;

    public AudioClip DamageSE;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {

        myBody = this.GetComponent<Rigidbody2D>();
        audioSource = gameObject.GetComponent<AudioSource>();

    }





    //動画を参考にしたため全くわからん()　知らない関数多すぎぃ！！
    void FixedUpdate()
    {

        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        bool isSneaking = CrossPlatformInputManager.GetButton("Sneak");
        //Debug.Log(isSneaking ? SneakMultiplier : 1);

        myBody.AddForce(moveVec * (isSneaking ? SneakMultiplier : 1));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SpiderDMH")
        {
            DMFX.AddEffectON();

            audioSource.PlayOneShot(DamageSE);

        }
    }
}

   
/*    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "SpiderDMH")
        {
            Debug.Log("強烈な物理的ダメージ");
        }

    }*/
