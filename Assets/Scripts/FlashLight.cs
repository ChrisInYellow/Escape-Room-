using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

    public bool isOn;
    public bool batteryIsIn;
    private GameObject spotLight;

    private void Start()
    {
        spotLight = transform.GetChild(0).transform.gameObject;
    }

    public void Activate()
    {
        if(batteryIsIn)
            spotLight.SetActive(true);
    }

    public void DeActivate()
    {
        spotLight.SetActive(false);
    }

    public void batteryInput()
    {
        batteryIsIn = true;
           
        Activate();
        
    }
    
}
