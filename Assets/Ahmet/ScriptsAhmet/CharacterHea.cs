using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public float pushBackForce = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHearts();
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage, Vector2 pushBackDirection)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        UpdateHearts();

        // Püskürtme iþlemi
        rb.AddForce(pushBackDirection * pushBackForce, ForceMode2D.Impulse);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

    private void Die()
    {
        // Ölüm animasyonu veya efektleri burada oynatýlabilir
        var animator = GetComponent<Animator>();
      /*  if (animator != null)
        {
            animator.SetTrigger("Die");
        } */

        // Sahneyi yeniden baþlatma kodu burada olabilir
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
