using UnityEngine;
using System.Collections;

public class DeletePlatform : MonoBehaviour
{
    public float visibleTime = 1.0f;
    public float invisibleTime = 3.0f;
    Collider2D platformCollider;
    Renderer platformRenderer;

    private void Awake()
    {
        platformCollider = GetComponent<Collider2D>();
        platformRenderer = GetComponent<Renderer>();
    }

    public void Delete()
    {
        // Platformun kaybolup tekrar görünmesi için coroutine baþlat
        StartCoroutine(DisappearAndReappear());
    }

    // Platformun kaybolup tekrar görünmesini saðlayan coroutine
    IEnumerator DisappearAndReappear()
    {
        // Platformun görünür durumda kalmasý için belirtilen süre kadar bekle
        yield return new WaitForSeconds(visibleTime);

        // Platformun Collider2D ve Renderer bileþenlerini devre dýþý býrak (kaybolur)
        platformCollider.enabled = false;
        platformRenderer.enabled = false;

        // Platformun görünmez durumda kalmasý için belirtilen süre kadar bekle
        yield return new WaitForSeconds(invisibleTime);

        // Platformun Collider2D ve Renderer bileþenlerini etkinleþtir (tekrar görünür)
        platformCollider.enabled = true;
        platformRenderer.enabled = true;
    }
}
