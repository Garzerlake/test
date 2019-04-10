using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int[,] activeCoordinates = ActiveCoordinates.activeCoordinates;

    // Start is called before the first frame update
    void Start()
    {
        UpdateGame();
        //PlayerTurn();
    }

    private void UpdateGame()
    {
        // I broke the i, j convention by replacing them with y, x respectively.
        // This is to make it easier to understand which iteration corresponds to which 2D array component.
        // 1 is player piece, 2 is opponent piece
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                if (activeCoordinates[y, x] == 0)
                {
                    GameObject.Find("[" + y + ", " + x + "]").GetComponent<SpaceController>().RemovePiece();
                }

                if (activeCoordinates[y, x] == 1)
                {
                    GameObject.Find("[" + y + ", " + x + "]").GetComponent<SpaceController>().AddPiece(1);
                }

                if (activeCoordinates[y, x] == 2)
                {
                    GameObject.Find("[" + y + ", " + x + "]").GetComponent<SpaceController>().AddPiece(2);
                }
            }
        }
    }

    public void UpdateActiveCoordinates()
    {

    }

    public void MovePiece()
    {

    }

    public void PlayerTurn()
    {

    }

    public void OpponentTurn()
    {

    }

    public void EndGame()
    {

    }
}
