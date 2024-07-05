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

    GameObject gameCamera;

    private void Awake()
    {
        CheckGameManagerIsInTheScene();
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
    private void Start()
    {
        CameraSetting();
    }

    void CameraSetting()
    {
        gameCamera = GameObject.FindGameObjectWithTag("MainCamera");
        gameCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
        gameCamera.GetComponent<Camera>().backgroundColor = Color.black;
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
            //reset lives back to 3. 
            playerLives = 3;
        }
    }
}
