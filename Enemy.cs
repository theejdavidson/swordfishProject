using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    private float speed = .02f;
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 5)
        {
            transform.LookAt(player.transform);
            transform.Translate(speed, 0, speed);
        }
    }
}