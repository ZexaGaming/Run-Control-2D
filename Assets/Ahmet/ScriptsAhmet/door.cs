using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
  //  public string nextSceneName; // Ge�ilecek sahnenin ad�
    private Collider2D doorCollider;

    void Start()
    {
        doorCollider = GetComponent<Collider2D>();
        if (doorCollider == null)
        {
            Debug.LogError("Kap�n�n Collider2D bile�eni bulunamad�.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.GetComponent<CharacterController>().HasKey)
        {
            // Kap�n�n collider'�n� devre d��� b�rak
            doorCollider.enabled = false;

            // Yeni sahneye ge�i� yap
            SceneManager.LoadScene(1);
        }
    }
}
