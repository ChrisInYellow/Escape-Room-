using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedPapperPuzzle : MonoBehaviour
{
    [HideInInspector]
    public float numberOfPlacedPappers = 0;
    public GameObject puzzleSolved;

    public void IncreasePlacedPappers ()
    {
        numberOfPlacedPappers += 1;
        if (numberOfPlacedPappers == 4)
        {
            Instantiate(puzzleSolved, transform.position, Quaternion.identity);
        }
    }
}
