using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float flySpeed = 10f;

    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }


    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }
}
