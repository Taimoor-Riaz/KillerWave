using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IActor
{
    int travelSpeed;
    int health;
    int hitDamage;
    GameObject fireObject;

    public int ApplyDamage()
    {
        return hitDamage;
    }

    public void AssignProperties(SOActor sOActor)
    {
        health = sOActor.health;
        hitDamage = sOActor.hitDamge;
        travelSpeed = sOActor.travelSpeed;
        fireObject = sOActor.actorBullet;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamge(int damage)
    {
        health -= damage;
    }
}
