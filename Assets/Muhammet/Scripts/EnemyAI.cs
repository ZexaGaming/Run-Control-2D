using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;  // Oyuncu objesinin Transform komponenti
    public float moveSpeed = 5f;  // D��man�n hareket h�z�
    public float stoppingDistance = 2f;  // D��man�n oyuncuya yakla�ma mesafesi

    void Start()
    {
        // Oyuncu objesini sahnede arar ve referans al�r
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // D��man�n oyuncuya do�ru hareket etmesi
        if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}
