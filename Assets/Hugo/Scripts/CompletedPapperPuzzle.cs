using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CompletedPapperPuzzle : MonoBehaviour
{
    [SerializeField]
    public UnityEvent puzzleSolved = new UnityEvent();

    [HideInInspector]
    public float numberOfPlacedPappers = 0;
    public GameObject puzzleSolvedObj;

    public void IncreasePlacedPappers ()
    {
        numberOfPlacedPappers += 1;
        if (numberOfPlacedPappers == 4)
        {
            puzzleSolved.Invoke();
            Instantiate(puzzleSolvedObj, transform.position, Quaternion.identity);
        }
    }
}
