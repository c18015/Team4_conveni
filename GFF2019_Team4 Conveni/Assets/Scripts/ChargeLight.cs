using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeLight : MonoBehaviour {

    public int Energy = 1;
    public LightGauge_Controller LGC;

    void Start()
    {



    }

    void Update() {

        Vector3 vector = new Vector3();

        vector.x = Input.GetAxis("Horizontal");


        if (vector.x != 0)
        {
            LGC.AddplusE1(Energy);
        }






        Debug.Log(vector.x);
     

    }

}
