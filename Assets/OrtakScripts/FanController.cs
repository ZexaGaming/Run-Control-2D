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
        // Fanýn oyuncuya olan uzaklýðý
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // Eðer fanýn oyuncuya olan uzaklýðý, oyuncuyu algýlayacaðý aralýktan küçükse
        if (distanceToPlayer < detectionRange)
        {
            // animasyonu çalýþtýr
            _animation.OnAnimation();
        }
        else
        {
            // animasyonu kapat
            _animation.OffAnimation();
        }
    }

    // Eðer fan ile bir nesne etkileþime geçerse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuya fan tarafýndan yukarý doðru kuvvet uygula
            _flyFan.FlyFan(other);
        }
    }
}
