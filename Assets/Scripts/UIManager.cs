using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject[] Lifes;
    [SerializeField] GameObject PausePanel;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateLifes();
        DisplayScore();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }

    public void DisplayScore()
    {
        scoreText.text = "Score : " + ScoreManager.PlayersScore;
    }

    public void UpdateLifes()
    {
        for (int i = 0; i < GameManager.playerLives; i++)
        {
            Lifes[i].SetActive(true);
        }
    }
}
