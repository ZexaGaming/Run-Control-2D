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

    // Platform baþka bir nesne ile etkileþime girdiðinde bu fonksiyon çaðrýlýr.
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Eðer etkileþime girilen nesne "Player" etiketine sahip ise
        if (other.gameObject.CompareTag("Player"))
        {
            // Platformun kaybolup tekrar görünmesi için Coroutine baþlat.
            StartCoroutine(DisappearAndReappear());
        }
    }

    // Platformun kaybolup tekrar görünmesini saðlayan Coroutine
    IEnumerator DisappearAndReappear()
    {
        // Platformun görünür durumda kalmasý için belirtilen süre kadar bekle.
        yield return new WaitForSeconds(gorunurSure);

        // Platformun Collider2D ve Renderer bileþenlerini devre dýþý býrak (kaybolur).
        platformCollider.enabled = false;
        platformRenderer.enabled = false;

        // Platformun görünmez durumda kalmasý için belirtilen süre kadar bekle.
        yield return new WaitForSeconds(gorunmezSure);

        // Platformun Collider2D ve Renderer bileþenlerini etkinleþtir (tekrar görünür).
        platformCollider.enabled = true;
        platformRenderer.enabled = true;
    }
}
