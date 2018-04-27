using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Controls
{

    private float speed = .13f;
    public GameObject player;
    public GameObject bullet;
    public GameObject enemy;
    private float fireRate = .5f;
    private float fireTime = 0.0f;
    public float enemyHP = 2000;
    public float test;
    public Transform enemyTransform;
 


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bullet = GameObject.FindGameObjectWithTag("bullet");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        Random r = new Random();
    }
    void Update()
    {

        if ((Vector3.Distance(transform.position, player.transform.position) < 70))
        {
            transform.LookAt(player.transform);
            transform.Translate(speed, 0, speed);
        }
        if ((Vector3.Distance(transform.position, player.transform.position) < 15))
        {
            transform.LookAt(player.transform);
            transform.Translate(-speed, 0, -speed);
        }

        if ((Vector3.Distance(transform.position, player.transform.position) < 70) && (Vector3.Distance(transform.position, player.transform.position) > 5))
        {
            transform.LookAt(player.transform);
            Shoot();

        }
        test = getRSpeed();
        
    }

    void Shoot()
    {
        if (Time.time > fireTime)
        {
            
            fireTime = Time.time + fireRate;
            var shot = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().velocity = shot.transform.forward * 20;
            Destroy(shot, 3);
        }
    }

 
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Sword") && RotateSpeed > 500)
        {
            Destroy(gameObject);

        }
    }

}
