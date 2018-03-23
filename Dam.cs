using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dam : MonoBehaviour
{
    public int hp = 100;
    public int damage = 50;
    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            hp -= 10;
        }
    }
}
