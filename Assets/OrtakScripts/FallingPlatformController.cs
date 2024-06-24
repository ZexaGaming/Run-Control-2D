using UnityEngine;

public class FallingPlatformController : MonoBehaviour
{
    FallingPlatformAnimation _animation;
    MoveFallingPlatform _move;
    Transform playerTransform;
    Vector3 initialPosition;
    float detectionRange = 4f;
    float moveDistance = 1f;
    float rightBoundary;
    float leftBoundary;
    bool isMovingRight = true;
    bool isPlayerOnPlatform = false;

    private void Awake()
    {
        _animation = GetComponent<FallingPlatformAnimation>();
        _move = GetComponent<MoveFallingPlatform>();

        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        initialPosition = transform.position;
        rightBoundary = initialPosition.x + moveDistance;
        leftBoundary = initialPosition.x - moveDistance;
    }

    private void Update()
    {
        // Platform e�er sa�a gidiyorsa
        if (isMovingRight)
        {
            // x eksenindeki pozisyonu sa� s�n�ra ula�m��sa
            if (transform.position.x >= rightBoundary)
            {
                // sa�a do�ru gitmiyor olarak i�aretle
                isMovingRight = false;
            }
        }
        else
        {
            // x eksenindeki pozisyonu sol s�n�ra ula�m��sa
            if (transform.position.x <= leftBoundary)
            {
                // sa�a do�ru gidiyor olarak i�aretle
                isMovingRight = true;
            }
        }

        // Platformun oyuncuya olan uzakl���
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // E�er platformun oyuncuya olan uzakl���, oyuncuyu alg�layaca�� aral�ktan k���kse ve oyuncu platform �zerindeyse
        if (distanceToPlayer < detectionRange || isPlayerOnPlatform)
        {
            // Animasyonu �al��t�r ve platformu sa�a hareket ettir
            _animation.OnAnimation();
            _move.MovePlatform(isMovingRight);
        }
        else
        {
            // Animasyonu kapat
            _animation.OffAnimation();
        }
    }

    // E�er platform ile bir nesne etkile�ime ge�erse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu platform ile beraber hareket edecek �ekilde ayarla
            other.transform.parent = this.transform;
        }
    }

    // E�er platformdan bir nesne etkile�imden ��karsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu platformdan ba��ms�z hareket edecek �ekilde ayarla
            other.transform.parent = null;
        }
    }
}
