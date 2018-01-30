using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowNumberWheel : MonoBehaviour {

    [SerializeField]
    public enum Direction {None, Up, Down };
    public float cooldownTimer; 
    public Direction currentDirection = Direction.None;
    private bool CD;

    [SerializeField]
    public enum SpinnerIdentifier {None,One,Two,Three,Four};
    public SpinnerIdentifier spinnerNumber = SpinnerIdentifier.None;

    public GameObject spinner;
    Animator anim;

    public void Start()
    {
        anim = spinner.gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CD)  
            return;
        StartCoroutine(Cooldown(cooldownTimer));
        if(currentDirection == Direction.Up)
        {
            if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Numbers"))
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers")+1)%10);
        }

        else if(currentDirection == Direction.Down)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Numbers"))
                if(anim.GetInteger("Numbers") < 0)
                {
                    anim.SetInteger("Numbers", 10);
                }
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers") - 1) % 10);
        }      
    }
    IEnumerator Cooldown(float time)
    {
        CD = true;
        yield return new WaitForSeconds(time);
        CD = false;
    }
}