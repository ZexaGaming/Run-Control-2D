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
            // Anahtar alýndýðýnda karakterin anahtar aldýðýný belirt
            other.GetComponent<CharacterController>().HasKey = true;
            // Anahtar ikonunu etkinleþtir
            keyUI.gameObject.SetActive(true);

            // Anahtarý yok et
            Destroy(gameObject);


        }
    }
}

