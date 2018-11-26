using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightGauge_Controller : MonoBehaviour
{
    
    Slider Light_Slider;

    // Use this for initialization
    void Start()
    {

        Light_Slider = GameObject.Find("Light Gauge").GetComponent<Slider>();

    }

    float countTime = 600;
   
    // Update is called once per frame
    void Update()
    {

        countTime -= 0.1f;

        if (countTime > 601)
        {
            countTime = 600;
        }



        Light_Slider.value = countTime;       

    }

    public void AddplusE1(int amount)
    {
        countTime += amount;
    }


}






