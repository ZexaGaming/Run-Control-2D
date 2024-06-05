using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
  //  public string nextSceneName; // Geçilecek sahnenin adý
    private Collider2D doorCollider;

    void Start()
    {
        doorCollider = GetComponent<Collider2D>();
        if (doorCollider == null)
        {
            Debug.LogError("Kapýnýn Collider2D bileþeni bulunamadý.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.GetComponent<CharacterController>().HasKey)
        {
            // Kapýnýn collider'ýný devre dýþý býrak
            doorCollider.enabled = false;

            // Yeni sahneye geçiþ yap
            SceneManager.LoadScene(1);
        }
    }
}
