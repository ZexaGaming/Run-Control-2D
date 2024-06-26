using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Image keyUI; // UI'da g�sterilecek anahtar ikonu

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Anahtar al�nd���nda karakterin anahtar ald���n� belirt
            other.GetComponent<CharacterController>().HasKey = true;
            // Anahtar ikonunu etkinle�tir
            keyUI.gameObject.SetActive(true);

            // Anahtar� yok et
            Destroy(gameObject);


        }
    }
}

