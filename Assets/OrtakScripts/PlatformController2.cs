using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlatformController2 : MonoBehaviour
{
    public float speed = 1.8f;  
    public float height = 6.5f; 

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
       
        float newX = startPos.x + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(newX, startPos.y, startPos.z);
    }
}
