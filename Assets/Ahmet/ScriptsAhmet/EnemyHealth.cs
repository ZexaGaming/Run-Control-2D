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
        // Ölüm animasyonu veya efektleri burada oynatýlabilir
      /*  var animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }*/

        // Düþmaný yok et
        Destroy(gameObject);
    }
}
