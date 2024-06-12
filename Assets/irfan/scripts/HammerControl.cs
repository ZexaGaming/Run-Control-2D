using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerControl : MonoBehaviour
{


    public float swingSpeed = 9.0f;
    public float swingAmount = 120.0f;

    private float startRotation;
    private bool swingingForward = true;

    void Start()
    {
        startRotation = transform.rotation.eulerAngles.z;
    }

    void Update()
    {
        float swingFactor = swingingForward ? 1 : -1;
        transform.rotation = Quaternion.Euler(0, 0, startRotation + Mathf.Sin(Time.time * swingSpeed) * swingAmount * swingFactor);

        // Çekiç sallama yönünü deðiþtir
        if (Mathf.Abs(Mathf.Sin(Time.time * swingSpeed)) < 0.01f)
        {
            swingingForward = !swingingForward;
        }
    }
}