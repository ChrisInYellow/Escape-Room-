using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPuzzle : MonoBehaviour {

    public bool cubeChecker = false;
    public GameObject correctCube;

	void Start () {
		
	}
	

	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == correctCube)
        {
            cubeChecker = true;
        }

        if (cubeChecker ==  true)
        {
            Debug.Log("Win");
            //opendoor
        }
    }
}
