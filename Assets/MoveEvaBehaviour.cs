using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEvaBehaviour : MonoBehaviour
{
    // Let's make jellyfish mnove spin in circles
    private float evaSpeed = 5f;
    private float evaRotationSpeed = 100f;
    private void Update()
    {
        // Spin in circles
        transform.Rotate(0, 0, evaRotationSpeed * Time.deltaTime);
        transform.Translate(0, evaSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
