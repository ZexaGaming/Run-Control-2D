using UnityEngine;

public class BouncingPlatformController : MonoBehaviour
{
    public float jumpForce = 10f;

    // Platform baþka bir nesne ile etkileþime girdiðinde bu fonksiyon çaðrýlýr.
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Eðer etkileþime girilen nesne "Player" etiketine sahip ise
        if (other.gameObject.CompareTag("Player"))
        {
            // Bu nesnenin Rigidbody2D bileþenini al.
            Rigidbody2D playerRb = other.gameObject.GetComponent<Rigidbody2D>();

            // Eðer bu nesnenin Rigidbody2D bileþeni var ise
            if (playerRb != null)
            {
                // Bu nesneye yukarý doðru bir kuvvet uygula.
                playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
            }
        }
    }
}
