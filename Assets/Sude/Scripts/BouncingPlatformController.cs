using UnityEngine;

public class BouncingPlatformController : MonoBehaviour
{
    public float jumpForce = 10f;

    // Platform ba�ka bir nesne ile etkile�ime girdi�inde bu fonksiyon �a�r�l�r.
    private void OnCollisionEnter2D(Collision2D other)
    {
        // E�er etkile�ime girilen nesne "Player" etiketine sahip ise
        if (other.gameObject.CompareTag("Player"))
        {
            // Bu nesnenin Rigidbody2D bile�enini al.
            Rigidbody2D playerRb = other.gameObject.GetComponent<Rigidbody2D>();

            // E�er bu nesnenin Rigidbody2D bile�eni var ise
            if (playerRb != null)
            {
                // Bu nesneye yukar� do�ru bir kuvvet uygula.
                playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
            }
        }
    }
}
