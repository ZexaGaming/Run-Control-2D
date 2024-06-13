using UnityEngine;

public class FanController : MonoBehaviour
{
    public float force = 10f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRb = other.gameObject.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                playerRb.velocity = new Vector2(playerRb.velocity.x, 0);
                playerRb.AddForce(Vector2.up * force);
            }
        }
    }
}
