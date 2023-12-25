using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;

    public int defaultHealth;
    private int healthPoint;

    private void Start() => healthPoint = defaultHealth;

    public void TakeDamege (int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        if (healthPoint <= 0)
            Die();
    }

    public void OnTriggerEnter2D(Collider2D collision) => Die();

    protected virtual  void Die()
    {
        var exposion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(exposion, 1);
        Destroy(gameObject);
    }
}
