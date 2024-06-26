using UnityEngine;

public class FanController : MonoBehaviour
{
    FanAnimation _animation;
    FlyWithFan _flyFan;
    Transform playerTransform;
    float detectionRange = 4f;

    private void Awake()
    {
        _animation = GetComponent<FanAnimation>();
        _flyFan = GetComponent<FlyWithFan>();

        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        // Fan�n oyuncuya olan uzakl���
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // E�er fan�n oyuncuya olan uzakl���, oyuncuyu alg�layaca�� aral�ktan k���kse
        if (distanceToPlayer < detectionRange)
        {
            // animasyonu �al��t�r
            _animation.OnAnimation();
        }
        else
        {
            // animasyonu kapat
            _animation.OffAnimation();
        }
    }

    // E�er fan ile bir nesne etkile�ime ge�erse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuya fan taraf�ndan yukar� do�ru kuvvet uygula
            _flyFan.FlyFan(other);
        }
    }
}
