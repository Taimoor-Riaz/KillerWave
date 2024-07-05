using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IActor
{
    int health;
    int travelSpeed;
    int fireSpeed;
    int hitPower;

    public float amplitude = 1.0f; // The height of the sine wave
    public float frequency = 1.0f; // The speed of the sine wave
    Vector3 sineVer;
    float time;

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        time += Time.deltaTime;
        sineVer.y = Mathf.Sin(time * frequency) * amplitude;
        Debug.Log(sineVer.y);
        transform.position = new Vector3(transform.position.x -50 * Time.deltaTime,
        transform.position.y + sineVer.y,
        transform.position.z);


    }
    public int ApplyDamage()
    {
        return hitPower;
    }

    public void AssignProperties(SOActor sOActor)
    {
        
    }

    public void Die()
    {
      
    }

    public void TakeDamge(int damage)
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}