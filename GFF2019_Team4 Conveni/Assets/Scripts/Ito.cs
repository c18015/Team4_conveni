using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(TouchInput))]
public class Ito : MonoBehaviour
{

    bool Isarea = false;
    public TouchInput touchInput;

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
                    Vector2 tapPosition = touchInput.Position;
                    tapPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Collider2D collider2D = Physics2D.OverlapPoint(tapPosition);

                    Debug.Log(tapPosition);

                    if (collider2D)
                    {
                        RaycastHit2D hitObject = Physics2D.Raycast(tapPosition, Vector2.up);
                        if (hitObject.collider.gameObject.tag == "Friend")
                        {
                            hitObject.collider.gameObject.SetActive(false);
                            Debug.Log("いと切れた！");
                        }
                    }
                    //this.gameObject.SetActive(false);
                    Isarea = false;
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
