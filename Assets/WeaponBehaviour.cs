using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject prefabBullet;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    // Shoot prefabs
    void Shoot()
    {
        Instantiate(prefabBullet, firePoint.position, firePoint.rotation);
    }
}
