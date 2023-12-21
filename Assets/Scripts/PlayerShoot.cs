using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval;
    private float lastBulletTime;
    [SerializeField ]private Vector3 bulletOffset;

  
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }

        

    }
    private void ShootBullet()
    {
        var bullet = Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }

}
