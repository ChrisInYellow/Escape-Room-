using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreasurePlate : MonoBehaviour
{
    public float maxWeight;
    public float minWeight;

    public float currentWeight;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ItemProperties>() == true)
        {
            currentWeight += other.gameObject.GetComponent<ItemProperties>().weight;
            CheckWeight();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<ItemProperties>() == true)
        {
            currentWeight -= other.gameObject.GetComponent<ItemProperties>().weight;
            CheckWeight();
        }
    }

    public void CheckWeight ()
    {
        if (currentWeight <= maxWeight && currentWeight >= minWeight)
        {
            Debug.Log("Enough weight");
        }
    }
}
