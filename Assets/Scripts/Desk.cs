using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour {

    private Animator anim;
    public GameObject drawerItem;

    private void Start()
    {
        anim = transform.GetChild(0).GetComponent<Animator>();
    }

    public void Open()
    {
        anim.SetBool("Open", true);
        StartCoroutine(SpawnItem(0.5f));
    }

    private IEnumerator SpawnItem(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject item = Instantiate(drawerItem, transform.GetChild(0).position, Quaternion.identity);
        item.transform.position -= item.transform.forward / 10;
    }
}
