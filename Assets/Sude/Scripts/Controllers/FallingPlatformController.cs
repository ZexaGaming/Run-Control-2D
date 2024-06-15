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
        // Platform eðer saða gidiyorsa
        if (isMovingRight)
        {
            // x eksenindeki pozisyonu sað sýnýra ulaþmýþsa
            if (transform.position.x >= rightBoundary)
            {
                // saða doðru gitmiyor olarak iþaretle
                isMovingRight = false;
            }
        }
        else
        {
            // x eksenindeki pozisyonu sol sýnýra ulaþmýþsa
            if (transform.position.x <= leftBoundary)
            {
                // saða doðru gidiyor olarak iþaretle
                isMovingRight = true;
            }
        }

        // Platformun oyuncuya olan uzaklýðý
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // Eðer platformun oyuncuya olan uzaklýðý, oyuncuyu algýlayacaðý aralýktan küçükse ve oyuncu platform üzerindeyse
        if (distanceToPlayer < detectionRange || isPlayerOnPlatform)
        {
            // Animasyonu çalýþtýr ve platformu saða hareket ettir
            _animation.OnAnimation();
            _move.MovePlatform(isMovingRight);
        }
        else
        {
            // Animasyonu kapat
            _animation.OffAnimation();
        }
    }

    // Eðer platform ile bir nesne etkileþime geçerse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu platform ile beraber hareket edecek þekilde ayarla
            other.transform.parent = this.transform;
        }
    }

    // Eðer platformdan bir nesne etkileþimden çýkarsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu platformdan baðýmsýz hareket edecek þekilde ayarla
            other.transform.parent = null;
        }
    }
}
