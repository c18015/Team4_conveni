using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ito : MonoBehaviour
{

    bool Isarea = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
          
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Isarea = true;

        Debug.Log("入ったよ－！");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Isarea = true;
        Debug.Log("入ってまーす!");
        Debug.Log(Isarea);

        if (collision.gameObject.tag == "Player")
        {
            TouchInput.Started += info =>
            {
                if (Isarea)
                {
                    this.gameObject.SetActive(false);
                    Isarea = false;

                    Debug.Log("いと切れた…？");
                }
            };
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("出たよー！");
        Isarea = false;
    }
}
