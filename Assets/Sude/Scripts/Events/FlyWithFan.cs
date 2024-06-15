using UnityEngine;

public class FlyWithFan : MonoBehaviour
{
    public float force = 5f;

    // Oyuncuya fan tarafýndan yukarý doðru kuvvet uygulama
    public void FlyFan(Collider2D other)
    {
        Rigidbody2D playerRb = other.GetComponent<Rigidbody2D>();
        if (playerRb != null)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, 0);
            playerRb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
}
