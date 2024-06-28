using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour, IActor
{
    int health;
    int hitDamange;
    int playerSpeed;
    GameObject playerBullet;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {

        float horizontalMovement = Input.GetAxis("Horizontal");
        float veritiacalMovment = Input.GetAxis("Vertical");
        

        Vector3 playerMovemnet = new Vector3(horizontalMovement,veritiacalMovment,0);
        

        rb.velocity = playerMovemnet* playerSpeed;


    }

    public int ApplyDamage()
    {
        return hitDamange;
    }

    public void AssignProperties(SOActor sOActor)
    {
        health = sOActor.health;
        hitDamange = sOActor.hitDamge;
        playerSpeed = sOActor.travelSpeed;
        playerBullet = sOActor.actorBullet;
    }

    public void Die()
    {

    }

    public void TakeDamge(int damage)
    {

    }
}
