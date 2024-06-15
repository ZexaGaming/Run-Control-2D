using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    public int attackDamage = 1;
    public float attackRange = 1f;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public Button attackButton; // Attack Button referansý

    void Start()
    {
        // Attack button reference and listener
        if (attackButton != null)
        {
            attackButton.onClick.AddListener(Attack);
        }
        else
        {
            Debug.LogWarning("Attack Button is not assigned.");
        }
    }

    void Attack()
    {
        // Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        // Damage them
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
