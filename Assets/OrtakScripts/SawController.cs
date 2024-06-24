using UnityEngine;

public class SawController : MonoBehaviour
{
    SawAnimation _animation;
    Transform playerTransform;
    float detectionRange = 4f;

    private void Awake()
    {
        _animation = GetComponent<SawAnimation>();

        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        // Testerenin oyuncuya olan uzaklýðý
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // Eðer testerenin oyuncuya olan uzaklýðý, oyuncuyu algýlayacaðý aralýktan küçükse
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

    // Eðer platform ile bir nesne etkileþime geçerse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu öldür
            Debug.Log("Kullanýcý öldü.");
        }
    }
}
