using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;   
    public int maximumEnemies;
    public int maxScore;
    private void Awake()
    {
        instance = this;
    }
}
