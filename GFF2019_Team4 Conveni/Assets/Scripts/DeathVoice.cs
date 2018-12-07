using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathVoice : MonoBehaviour {

    public AudioClip bgmSound;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "kogumo")
        {
            audioSource.PlayOneShot(bgmSound);
        }
    }
}
