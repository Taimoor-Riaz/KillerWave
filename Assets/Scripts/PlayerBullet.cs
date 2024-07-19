using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour,IActor
{
    [SerializeField] SOActor playerBullet;
    [SerializeField] float speed;
    int health;
    int damage;

    private void Awake()
    {
        AssignProperties(playerBullet);
    }
    private void Update()
    {
        transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Die();        
        }
    }
    private void OnBecameInvisible()
    {
        Die();  
    }

    public int ApplyDamage()
    {
        return damage;
    }

    public void TakeDamge(int damage)
    {
        health -= damage;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void AssignProperties(SOActor sOActor)
    {
        health = sOActor.health;
        damage = sOActor.hitDamge;
    }
}
