using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskDrawer : MonoBehaviour {

    public bool isOpen;
    private Animator drawerAnim;

    private void Start()
    {
        drawerAnim = transform.GetChild(0).GetComponent<Animator>();
    }

    public void OpenDrawer()
    {
        if (isOpen)
        {
            drawerAnim.SetBool("Open", true);
        }
    }

    public void Update()
    {
        if (isOpen)
        {
            drawerAnim.SetBool("Open", true);
        }
    }


}
