using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public static int playerLives = 3;
    /// <summary>
    /// GameManager Singelton Class
    /// </summary>
    public static GameManager Instance
    {
        get { return instance; }
    }
    /// <summary>
    /// Player Died or not
    /// </summary>
    bool died = false;
    public bool Died
    {
        get { return died; }
        set { died = value; }
    }
    [HideInInspector]
    public int TotalEnemies;
    [HideInInspector]
    public int TotalScore;

    private void Awake()
    {
        CheckGameManagerIsInTheScene();
    }
    private void Start()
    {
        TotalEnemies = LevelManager.instance.maximumEnemies;
        TotalScore = LevelManager.instance.maxScore;
    }
    void CheckGameManagerIsInTheScene()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);

    }
 
    public void LifeLost()
    {
        //lose life
        if (playerLives >= 1)
        {
            playerLives--;
            Debug.Log("Lives left:" + playerLives);
            GetComponent<ScenesManager>().ResetScene();
        }
        else
        {

            GetComponent<ScenesManager>().GameOver();
            PlayerPrefs.SetInt("Coins", ScoreManager.PlayersScore);
            //reset lives back to 3. 
            playerLives = 3;
        }
    }

    public void DecreseEnemies()
    {
        TotalEnemies--;
        if (TotalEnemies <= 0)
        {
            GetComponent<ScenesManager>().LevelComplete();
        }
    }

    public void CheckScore()
    {
        if(ScoreManager.PlayersScore >= TotalScore)
        {
            GetComponent<ScenesManager>().LevelComplete();
        }
    }
}
