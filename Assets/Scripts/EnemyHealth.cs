using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    

    

    private void Die()
    {
        base.Die();
        Debug.Log("Enemy Die");
    }
}
