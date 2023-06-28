using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBehaviour : MonoBehaviour
{

    [SerializeField] public static float health = 100f;
    // Should probably be in the enemy gameObject?
    [SerializeField] float damageTaken = 10f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(flashDamage());
            PlayerHealthBehaviour.health -= damageTaken;
        }
    }

    private IEnumerator flashDamage()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;  // TODO: Why is this buggy when i set it to playerTint??? --> Makes my guy disappear

    }
}
