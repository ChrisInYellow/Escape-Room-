using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour {

    public Animator anim;

    public void OpenDoor()
    {
        anim.SetTrigger("DoorOpens"); 
    }


}
