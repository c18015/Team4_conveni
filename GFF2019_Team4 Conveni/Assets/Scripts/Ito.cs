using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ito : MonoBehaviour
{
    bool Isarea = false;   
    public TouchInput touchInput;
    public Count count;

    public GameObject kumo;

    RaycastHit2D hitObject;

    bool Iscount;
    

    //private int count;

    // Use this for initialization
    void Start()
    {
        //Iscount = count.Iscount;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count.Iscount);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (count.Iscount == true)
        {
            Instantiate(
                kumo,
                gameObject.transform.position,
                Quaternion.identity
                );

            Debug.Log("蜘蛛出現！");
            
        }
        //Isarea = true;

        //Debug.Log("入ったよ－！");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Isarea = true;
        //Debug.Log("入ってまーす!");
        //Debug.Log(Isarea);

        if (collision.gameObject.tag == "Player")
        {
            TouchInput.Started += info =>
            {
                if (Isarea)
                {
                    Vector2 tapPosition = touchInput.Position;
                    tapPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Collider2D collider2D = Physics2D.OverlapPoint(tapPosition);

                    if (collider2D)
                    {
                        RaycastHit2D hitObject = Physics2D.Raycast(tapPosition, Vector2.up);
                        if (hitObject.collider.gameObject.tag == "Friend")
                        {
                            

                            hitObject.collider.gameObject.SetActive(false);
                                                        
                            //Debug.Log("いと切れた！");    
                            if (hitObject.collider.gameObject == false)
                            {
                                
                            }
                        }
                        
                    }
                    
                    Isarea = false;
                }                
            };
        }        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("出たよー！");
        Isarea = false;
    }
}
