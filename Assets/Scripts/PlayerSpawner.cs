using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public SOActor playerActor;


    private void Start()
    {
        CreatePlayer();
    }

    void CreatePlayer()
    {
        GameObject player = Instantiate(playerActor.actor) as GameObject;
        player.GetComponent<Player>().AssignProperties(playerActor);
        player.transform.position = Vector3.zero;
        player.transform.rotation = Quaternion.Euler(-90,180,0);

    }
}
