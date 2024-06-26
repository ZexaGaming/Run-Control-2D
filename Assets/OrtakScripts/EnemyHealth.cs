using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // �l�m animasyonu veya efektleri burada oynat�labilir
      /*  var animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }*/

        // D��man� yok et
        Destroy(gameObject);
    }
}
