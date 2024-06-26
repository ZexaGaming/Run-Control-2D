using UnityEngine;

public class JumpWithTrampoline : MonoBehaviour
{
    public float jumpForce = 4f;

    // Oyuncuya trampolin tarafýndan yukarýya doðru kuvvet uygulama
    public void JumpTrampoline(Collider2D other)
    {
        Rigidbody2D playerRb = other.GetComponent<Rigidbody2D>();
        if (playerRb != null)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        }
    }
}
