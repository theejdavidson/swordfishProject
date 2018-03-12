using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private float speed = .08f;
    public GameObject player;
    public GameObject bullet;
    private float fireRate = 1f;
    private float fireTime = 0.0f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bullet = GameObject.FindGameObjectWithTag("bullet");
    }
    void Update()
    {

        if ((Vector3.Distance(transform.position, player.transform.position) < 40 ) && (Vector3.Distance(transform.position, player.transform.position) > 10))
        {
            transform.LookAt(player.transform);
            transform.Translate(speed, 0, speed);
        }
        if((Vector3.Distance(transform.position, player.transform.position) < 10))
        {
            transform.Translate(-speed, 0, -speed);
        }

        if((Vector3.Distance(transform.position, player.transform.position) < 40) && (Vector3.Distance(transform.position, player.transform.position) > 10))
        {
            transform.LookAt(player.transform);
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time > fireTime)
        {
            fireTime = Time.time + fireRate;
            var shot = (GameObject)Instantiate(bullet, transform.position , transform.rotation);
            shot.GetComponent<Rigidbody>().velocity = shot.transform.forward * 5;
            Destroy(shot, 5);
        }
    }

}
