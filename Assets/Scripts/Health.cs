using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : Controls
{

    public const int maxHP = 100;
    public int currentHP = maxHP;
    // Use this for initialization
    public void TakeDam(int amount)
    {
        currentHP -= amount;
        setRSpeed(500);
        if (currentHP <= 0)
        {
            currentHP = 0;
            Debug.Log("TRY AGAIN.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}