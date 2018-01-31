using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemProperties : MonoBehaviour
{
    public float weight;

    private Vector3 velocity;
    private bool grounded;
    Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        if (grounded == false)
        {
            rb.AddForce(new Vector3(0, -weight, 0));
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other == true)
        {
            grounded = true;
        }
    }
}
