using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowNumberWheel : MonoBehaviour {

    [SerializeField]
    public enum Direction {None, Up, Down };
    public Direction currentDirection = Direction.None;
    public float cooldown;
    private float max_cooldown; 

    public GameObject spinner;
    Animator anim;
    public Animation currentAnim;

    public void Start()
    {
        max_cooldown = cooldown; 
        anim = spinner.gameObject.GetComponent<Animator>();
        currentAnim = anim.gameObject.GetComponent<Animation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(currentDirection == Direction.Up)
        {
            if (!currentAnim.isPlaying)
            {
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers") + 1) % 10);
            }
        }

        else if(currentDirection == Direction.Down && cooldown == 0)
        {
            if (!currentAnim.isPlaying)
            {
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers") - 1) % 10);
            }
        }      
    }
 
}