using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Acator",menuName ="Scriptable/Actor")]
public class SOActor : ScriptableObject
{
    public string actorName;
    public int health;
    public int hitDamge;
    public int travelSpeed;
    public int score;
    public ActorType actorType;
    public GameObject actor;
    public GameObject actorBullet;

    public enum ActorType
    {
        Player,
        Enemy,
        PlayerBullet
    }

}
