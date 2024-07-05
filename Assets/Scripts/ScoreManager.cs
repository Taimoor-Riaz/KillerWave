using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static int playerScore;
    public int PlayersScore
    {
        get
        {
            return playerScore;
        }
    }

    public void SetScore(int incomingScore)
    {
        playerScore += incomingScore;
    }
}
