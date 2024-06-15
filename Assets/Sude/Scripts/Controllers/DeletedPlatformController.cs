using UnityEngine;

public class DeletedPlatformController : MonoBehaviour
{
    DeletedPlatformAnimation _animation;
    DeletePlatform _delete;

    private void Awake()
    {
        _animation = GetComponent<DeletedPlatformAnimation>();
        _delete = GetComponent<DeletePlatform>();
    }

    // Eðer platform ile bir nesne etkileþime geçerse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu çalýþtýr ve platformu bir süre görünmez yap, sonra geri görünür yap
            _animation.OnAnimation();
            _delete.Delete();
        }
    }

    // Eðer platformdan bir nesne etkileþimden çýkarsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu kapat
            _animation.OffAnimation();
        }
    }
}
