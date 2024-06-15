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
        // Testerenin oyuncuya olan uzakl���
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // E�er testerenin oyuncuya olan uzakl���, oyuncuyu alg�layaca�� aral�ktan k���kse
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

    // E�er platform ile bir nesne etkile�ime ge�erse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu �ld�r
            Debug.Log("Kullan�c� �ld�.");
        }
    }
}
