using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowNumberWheel : MonoBehaviour {

    [SerializeField]
    public enum Direction {None, Up, Down };
    public Direction currentDirection = Direction.None;

    public GameObject spinner;
    Animator anim;

    public void Start()
    {
        anim = spinner.gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(currentDirection == Direction.Up)
        {
            anim.SetInteger("numbers", (anim.GetInteger("numbers")+1)%10);
        }

        else if(currentDirection == Direction.Down)
        {
            anim.SetInteger("numbers", (anim.GetInteger("numbers") - 1) % 10);
        }      
    }
}