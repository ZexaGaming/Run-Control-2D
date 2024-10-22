using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Image keyUI; // UI'da gösterilecek anahtar ikonu

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Anahtar alındığında karakterin anahtar aldığını belirt
            other.GetComponent<CharacterController>().HasKey = true;
            // Anahtar ikonunu etkinleştir
            keyUI.gameObject.SetActive(true);

            // Anahtarı yok et
            Destroy(gameObject);


        }
    }
}

