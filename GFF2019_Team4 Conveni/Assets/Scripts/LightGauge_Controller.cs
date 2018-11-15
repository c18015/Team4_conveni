using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightGauge_Controller : MonoBehaviour
{
    public float countTime;
    Slider Light_meter;

    // Use this for initialization
    void Start()
    {

        Light_meter = GameObject.Find("Light Gauge").GetComponent<Slider>();

    }

    

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime;


        
        if (countTime > Light_meter.maxValue)
        {
            countTime = Light_meter.maxValue;

        }

        Light_meter.value = countTime; 

    }
}






