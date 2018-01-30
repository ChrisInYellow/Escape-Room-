using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

    public bool isOn;
    private GameObject spotLight;

    private void Start()
    {
        spotLight = transform.GetChild(0).gameObject;
    }

    public void Activate()
    {
        if (isOn)
        {
            isOn = false;
            spotLight.SetActive(false);
        }
        else
        {
            isOn = true;
            spotLight.SetActive(true);
        }
    }

}
