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
    private GameObject solutionManager; 
    Animator anim;

    public void Start()
    {
        anim = spinner.gameObject.GetComponent<Animator>();
        solutionManager = transform.parent.parent.gameObject;
        print(solutionManager);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CD)  
            return;
        StartCoroutine(Cooldown(cooldownTimer));
        
        if (currentDirection == Direction.Up)
        {
            FindObjectOfType<AudioManager>().Play("ButtonPress");

            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Numbers"))
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers")+1)%10);

            if (spinnerNumber == SpinnerIdentifier.One)
            {
                
                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerOne(anim.GetInteger("Numbers"));
            }
            if (spinnerNumber == SpinnerIdentifier.Two)
            {

                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerTwo(anim.GetInteger("Numbers"));
            }
            if (spinnerNumber == SpinnerIdentifier.Three)
            {

                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerThree(anim.GetInteger("Numbers"));
            }
            else
            {
                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerFour(anim.GetInteger("Numbers"));
            }
        }

        else if(currentDirection == Direction.Down)
        {
            FindObjectOfType<AudioManager>().Play("ButtonPress");

            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Numbers"))
                anim.SetInteger("Numbers", (anim.GetInteger("Numbers") - 1) % 10);
                if(anim.GetInteger("Numbers") == -1)
                {
                    anim.SetInteger("Numbers", 9);
                }
            if (spinnerNumber == SpinnerIdentifier.One)
            {

                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerOne(anim.GetInteger("Numbers"));
            }
            if (spinnerNumber == SpinnerIdentifier.Two)
            {

                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerTwo(anim.GetInteger("Numbers"));
            }
            if (spinnerNumber == SpinnerIdentifier.Three)
            {

                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerThree(anim.GetInteger("Numbers"));
            }
            else
            {
                solutionManager.GetComponentInParent<SolutionForCombinationLock>().SpinnerFour(anim.GetInteger("Numbers"));
            }
        }      

    }
    IEnumerator Cooldown(float time)
    {
        CD = true;
        yield return new WaitForSeconds(time);
        CD = false;
    }
}