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
            if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Numbers"))
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers")+1)%10);
        }

        else if(currentDirection == Direction.Down)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Numbers"))
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers") - 1) % 10);
        }      
    }
}