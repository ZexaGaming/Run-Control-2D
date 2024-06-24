using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlatformController : MonoBehaviour
{
    public float speed = 3.0f;  // Hareket hýzý
    public float height = 15.5f; // Yukarý ve aþaðý hareket mesafesi

    private Vector3 startPos;

    void Start()
    {
        // Baþlangýç pozisyonunu kaydedin
        startPos = transform.position;
    }

    void Update()
    {
        // Nesneyi yukarý ve aþaðý hareket ettirin
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}

