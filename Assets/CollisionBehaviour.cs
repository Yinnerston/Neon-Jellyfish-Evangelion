using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    // Why are we deleting private
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fin")
        {
            Debug.Log("We trigger something yay.");
        }
        else
        {
            Debug.Log(collision.tag);
        }
    }
}
