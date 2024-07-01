using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] float speed;
    private void Update()
    {
        transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
    }
}
