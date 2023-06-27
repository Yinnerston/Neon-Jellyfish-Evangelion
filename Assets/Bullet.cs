using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 20f;
    public static int count;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 shootDirection;
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection = Vector3.Normalize(shootDirection - transform.position);

        rb.velocity = shootDirection * bulletSpeed;
    }

    // Destroy bullet when trigger is activated
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Bullet.count += 1;
            Debug.Log("Scored a hit! " + Bullet.count);

            Destroy(gameObject);
        }
        else if (collision.tag == "Obstacle")
        {
            Destroy(gameObject);    // Don't increment count
        }
    }
}
