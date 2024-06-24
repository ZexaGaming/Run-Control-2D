using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;  // Oyuncu objesinin Transform komponenti
    public float moveSpeed = 5f;  // Düþmanýn hareket hýzý
    public float stoppingDistance = 2f;  // Düþmanýn oyuncuya yaklaþma mesafesi

    void Start()
    {
        // Oyuncu objesini sahnede arar ve referans alýr
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Düþmanýn oyuncuya doðru hareket etmesi
        if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}
