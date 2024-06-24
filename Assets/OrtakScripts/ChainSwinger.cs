using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChainSwinger : MonoBehaviour
{


    public float swingForce = 7f;       // Uygulanacak kuvvetin büyüklüðü
    public float swingFrequency = 1.5f;   // Sallanma frekansý

    private Rigidbody2D rb;
    private float time;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        time = 0f;
    }

    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        float force = Mathf.Sin(time * swingFrequency) * swingForce;

        rb.AddForce(new Vector2(force, 0));
    }
}


