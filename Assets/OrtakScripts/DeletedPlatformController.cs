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

    // E�er platform ile bir nesne etkile�ime ge�erse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu �al��t�r ve platformu bir s�re g�r�nmez yap, sonra geri g�r�n�r yap
            _animation.OnAnimation();
            _delete.Delete();
        }
    }

    // E�er platformdan bir nesne etkile�imden ��karsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu kapat
            _animation.OffAnimation();
        }
    }
}
