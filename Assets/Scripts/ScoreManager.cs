using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

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
        PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins")+PlayersScore);
        UIManager.Instance.DisplayScore();
    }
}
