using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSE : MonoBehaviour {

    private AudioSource audioSource;
    //　鳴らす音声クリップ
    [SerializeField]
    private AudioClip appearSE;

    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(appearSE);
        }
    }
}