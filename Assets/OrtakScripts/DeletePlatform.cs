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
        // Platformun kaybolup tekrar g�r�nmesi i�in coroutine ba�lat
        StartCoroutine(DisappearAndReappear());
    }

    // Platformun kaybolup tekrar g�r�nmesini sa�layan coroutine
    IEnumerator DisappearAndReappear()
    {
        // Platformun g�r�n�r durumda kalmas� i�in belirtilen s�re kadar bekle
        yield return new WaitForSeconds(visibleTime);

        // Platformun Collider2D ve Renderer bile�enlerini devre d��� b�rak (kaybolur)
        platformCollider.enabled = false;
        platformRenderer.enabled = false;

        // Platformun g�r�nmez durumda kalmas� i�in belirtilen s�re kadar bekle
        yield return new WaitForSeconds(invisibleTime);

        // Platformun Collider2D ve Renderer bile�enlerini etkinle�tir (tekrar g�r�n�r)
        platformCollider.enabled = true;
        platformRenderer.enabled = true;
    }
}
