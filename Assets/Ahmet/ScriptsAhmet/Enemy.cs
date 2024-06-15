using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damageToPlayer = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damageToPlayer);
        }
    }
}
