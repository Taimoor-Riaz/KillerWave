using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    //public SOActor playerActor;
    //GameObject playerShip;

    //private void Start()
    //{
    //    CreatePlayer();
    //}

    //void CreatePlayer()
    //{
    //    playerShip = GameObject.Instantiate(playerActor.actor) as GameObject;
    //    playerShip.GetComponent<Player>().AssignProperties(playerActor);

    //    //SET PLAYER UP
    //    playerShip.transform.rotation = Quaternion.Euler(-90, 180, 0);
    //    playerShip.transform.localScale = new Vector3(60, 60, 60);
    //    playerShip.name = "Player";
    //    playerShip.transform.SetParent(this.transform);
    //    playerShip.transform.position = Vector3.zero;

    //}

    public SOActor playerActor;
    GameObject playerShip;
    private void Start()
    {
        CreatePlayer();
    }

    void CreatePlayer()
    {
        playerShip = Instantiate(playerActor.actor) as GameObject;
        


        playerShip.transform.position = Vector3.zero; //(0,0,0)
        playerShip.transform.parent = this.transform;  // Set parent object ka instatntia ke 
        playerShip.transform.localScale = new Vector3(60, 60, 60);
        playerShip.transform.rotation = Quaternion.Euler(-90,0,180);
        playerShip.name = "Player";
    }
}
