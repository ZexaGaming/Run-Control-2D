using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && GameManager.instance.HasCollectedAllKeys())
        {
            // Bir sonraki bölüme geçiþ
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }

    }
}