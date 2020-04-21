﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int enemyHealth = 10;

    void Update()
    {
        if (enemyHealth <= 0)
            Destroy(gameObject);
    }
    public void DeductPoints(int DamageAmount)
    {
        enemyHealth -= DamageAmount;
    }
}
