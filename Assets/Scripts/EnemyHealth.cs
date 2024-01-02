using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemeCount;
    private void Awake() => LivingEnemeCount++;

    private void Die()
    {
        LivingEnemeCount--;
        base.Die();
    }
}
