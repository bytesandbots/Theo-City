using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public Transform bulletFiredPos;
    public float bulletspeed = 100.0f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bulletPrefabs, bulletFiredPos.position, bulletFiredPos.rotation);

            Rigidbody rb = newBullet.GetComponent<Rigidbody>();

            if(rb != null)
            {

                rb.velocity = bulletFiredPos.forward * bulletspeed;

                Destroy(newBullet, 10);
            }
        }
    }
}
