using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Enemy {
    public int max = 0;
    private float timer = 0f;
    private float spawn = 2f;
    // Use this for initialization
    void Start () {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= spawn && max < 0)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        var enemyClone = (GameObject)Instantiate(enemy, transform.position, transform.rotation);
        max++;
    }

}
