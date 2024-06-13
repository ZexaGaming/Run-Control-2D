using UnityEngine;
using System.Collections;

public class DeletedPlatformController : MonoBehaviour
{
    public float gorunurSure = 1.0f; // Platformun kaybolmadan önce bekleyeceði süre
    public float gorunmezSure = 3.0f; // Platformun kaybolduktan sonra bekleyeceði süre

    private Collider2D platformCollider;
    private Renderer platformRenderer;

    private void Start()
    {
        platformCollider = GetComponent<Collider2D>();
        platformRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DisappearAndReappear());
        }
    }

    IEnumerator DisappearAndReappear()
    {
        yield return new WaitForSeconds(gorunurSure);

        platformCollider.enabled = false;
        platformRenderer.enabled = false;

        yield return new WaitForSeconds(gorunmezSure);

        platformCollider.enabled = true;
        platformRenderer.enabled = true;
    }
}
