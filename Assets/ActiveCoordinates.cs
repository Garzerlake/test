using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCoordinates : MonoBehaviour
{

    public static int[,] activeCoordinates = new int[3, 3];

    // This is put in awake, so that GameController can read this array in Start().
    private void Awake()
    {
        // 0 is empty, 1 is player piece, 2 is opponent piece
        //               [y, x]
        activeCoordinates[0, 0] = 2;
        activeCoordinates[0, 1] = 2;
        activeCoordinates[0, 2] = 2;
        activeCoordinates[1, 0] = 0;
        activeCoordinates[1, 1] = 0;
        activeCoordinates[1, 2] = 0;
        activeCoordinates[2, 0] = 1;
        activeCoordinates[2, 1] = 1;
        activeCoordinates[2, 2] = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
