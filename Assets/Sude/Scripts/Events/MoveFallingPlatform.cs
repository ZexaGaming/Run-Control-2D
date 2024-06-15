using UnityEngine;

public class MoveFallingPlatform : MonoBehaviour
{
    public float moveSpeed = 1f;

    // Platformu hareket ettirme
    public void MovePlatform(bool isMovingRight)
    {
        if (isMovingRight)
        {
            MoveRightPlatform();
        }
        else
        {
            MoveLeftPlatform();
        }
    }

    // Platformu saða hareket ettirme
    private void MoveRightPlatform()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    // Platformu sola hareket ettirme
    private void MoveLeftPlatform()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}

