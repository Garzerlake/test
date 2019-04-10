using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    // 1 is player pawn, 2 is opponent pawn
    public void AddPiece(int piece)
    {
        if (piece == 1)
        {
            transform.Find("Player Pawn").gameObject.SetActive(true);
        }

        if (piece == 2)
        {
            transform.Find("Opponent Pawn").gameObject.SetActive(true);
        }
    }

    public void RemovePiece()
    {
        transform.Find("Player Pawn").gameObject.SetActive(false);
        transform.Find("Opponent Pawn").gameObject.SetActive(false);
    }
}
