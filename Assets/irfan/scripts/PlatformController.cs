using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlatformController : MonoBehaviour
{
    public float speed = 3.0f;  // Hareket h�z�
    public float height = 15.5f; // Yukar� ve a�a�� hareket mesafesi

    private Vector3 startPos;

    void Start()
    {
        // Ba�lang�� pozisyonunu kaydedin
        startPos = transform.position;
    }

    void Update()
    {
        // Nesneyi yukar� ve a�a�� hareket ettirin
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}

