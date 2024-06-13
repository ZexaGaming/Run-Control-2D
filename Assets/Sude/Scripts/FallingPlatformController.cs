using UnityEngine;

public class FallingPlatformController : MonoBehaviour
{
    bool playerOnPlatform = false;
    public float speed = 2f;
    public float finishPosition = 0.9f;
    Animator animator;
    Transform playerTransform;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (playerOnPlatform && transform.position.x < finishPosition)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerOnPlatform = true;
            animator.SetBool("isRidden", true);
            playerTransform = other.transform;
            playerTransform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerOnPlatform = false;
            animator.SetBool("isRidden", false);
            playerTransform.SetParent(null);
            playerTransform = null;
        }
    }
}
