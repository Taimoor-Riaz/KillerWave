using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    SOActor actorModel;

    [SerializeField]
    [Range(0, 10)]
    int quantity;

    [SerializeField]
    private Vector2 spawnAreaMin = new Vector2(-5, -5);  // Define minimum spawn area
    [SerializeField]
    private Vector2 spawnAreaMax = new Vector2(5, 5);    // Define maximum spawn area

    [SerializeField]
    private float minSpawnDelay = 0.5f;
    [SerializeField]
    private float maxSpawnDelay = 2.0f;


    void Awake()
    {
  
        StartCoroutine(FireEnemy(quantity));
    }

    IEnumerator FireEnemy(int qty)
    {
        for (int i = 0; i < qty; i++)
        {
            GameObject enemyUnit = CreateEnemy();
            enemyUnit.GetComponent<Enemy>().AssignProperties(actorModel);
           // enemyUnit.transform.parent = this.transform;
            enemyUnit.gameObject.transform.SetParent(this.transform);
            Vector2 randomPosition = new Vector2(
                        Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                        Random.Range(spawnAreaMin.y, spawnAreaMax.y)
                    );
            enemyUnit.transform.position = randomPosition;
            enemyUnit.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            // Wait for a random delay before spawning the next enemy
            float randomDelay = Random.Range(minSpawnDelay, maxSpawnDelay);    
            yield return new WaitForSeconds(randomDelay);
        }
       
    }

    GameObject CreateEnemy()
    {
        GameObject enemy = GameObject.Instantiate(actorModel.actor) as GameObject;
        enemy.name = actorModel.actorName.ToString();
        return enemy;
    }
}
