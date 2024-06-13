using UnityEngine;
using System.Collections;

public class DeletedPlatformController : MonoBehaviour
{
    public float gorunurSure = 1.0f; // Platformun kaybolmadan �nce bekleyece�i s�re
    public float gorunmezSure = 3.0f; // Platformun kaybolduktan sonra bekleyece�i s�re

    private Collider2D platformCollider;
    private Renderer platformRenderer;

    private void Start()
    {
        platformCollider = GetComponent<Collider2D>();
        platformRenderer = GetComponent<Renderer>();
    }

    // Platform ba�ka bir nesne ile etkile�ime girdi�inde bu fonksiyon �a�r�l�r.
    private void OnCollisionEnter2D(Collision2D other)
    {
        // E�er etkile�ime girilen nesne "Player" etiketine sahip ise
        if (other.gameObject.CompareTag("Player"))
        {
            // Platformun kaybolup tekrar g�r�nmesi i�in Coroutine ba�lat.
            StartCoroutine(DisappearAndReappear());
        }
    }

    // Platformun kaybolup tekrar g�r�nmesini sa�layan Coroutine
    IEnumerator DisappearAndReappear()
    {
        // Platformun g�r�n�r durumda kalmas� i�in belirtilen s�re kadar bekle.
        yield return new WaitForSeconds(gorunurSure);

        // Platformun Collider2D ve Renderer bile�enlerini devre d��� b�rak (kaybolur).
        platformCollider.enabled = false;
        platformRenderer.enabled = false;

        // Platformun g�r�nmez durumda kalmas� i�in belirtilen s�re kadar bekle.
        yield return new WaitForSeconds(gorunmezSure);

        // Platformun Collider2D ve Renderer bile�enlerini etkinle�tir (tekrar g�r�n�r).
        platformCollider.enabled = true;
        platformRenderer.enabled = true;
    }
}
