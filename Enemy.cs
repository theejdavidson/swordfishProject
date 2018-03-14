using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private float speed = .08f;
    public GameObject player;
    public GameObject bullet;
    public GameObject enemy;
    private float fireRate = 1f;
    private float fireTime = 0.0f;
    private float timer = 0f;
    private float spawn = 4f;

  
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bullet = GameObject.FindGameObjectWithTag("bullet");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        Random r = new Random();
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

        if ((Vector3.Distance(transform.position, player.transform.position) < 40) && (Vector3.Distance(transform.position, player.transform.position) > 10))
        {
            transform.LookAt(player.transform);
            Shoot();
        }
       /* timer += Time.deltaTime;
        if (timer >= spawn)
        {
            SpawnEnemy();
            timer = 0f;
        }
       */ 
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

   /* void SpawnEnemy()
    {
        var enemyClone = (GameObject)Instantiate(enemy, player.transform.position + Vector3.forward *10, transform.rotation);
        
    }
    */

}
