using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]


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
        Attack();
    }

    void Movement()
    {

        float horizontalMovement = Input.GetAxis("Horizontal");
        float veritiacalMovment = Input.GetAxis("Vertical");


        Vector3 playerMovemnet = new Vector3(horizontalMovement, veritiacalMovment, 0);


        rb.velocity = playerMovemnet * playerSpeed;


    }

    void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(playerBullet, transform.position, Quaternion.identity);
            bullet.transform.parent = this.transform;
            bullet.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

        }
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (health >= 1)
            {
                TakeDamge(other.GetComponent<Enemy>().ApplyDamage());
            }
            if (health <= 0)
            {
                Die();
            }

           
        }
    }
    public void Die()
    {
        GameManager.Instance.LifeLost();
        Destroy(gameObject);
    }

    public void TakeDamge(int damage)
    {
        health -= damage;
    }
}
