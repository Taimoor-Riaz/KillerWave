using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private void Start()
    {
        if (scoreText)
        {
            scoreText.text = PlayerPrefs.GetInt("Coins").ToString();
        }
        
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
       Debug.Log("ENDSCORE:" + GameManager.Instance.GetComponent<ScoreManager>().PlayersScore);
        SceneManager.LoadScene("GameOver");
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void ShopScene()
    {
        SceneManager.LoadScene("Shop");
    }
}
