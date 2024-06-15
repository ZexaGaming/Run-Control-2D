using UnityEngine;

public class FireController : MonoBehaviour
{
    FireAnimation _animation;
    KillWithFire _killFire;
    bool isInteracting = false;

    private void Awake()
    {
        _animation = GetComponent<FireAnimation>();
        _killFire = GetComponent<KillWithFire>();
    }

    private void Update()
    {
        // Oyuncu ate� tuza��n�n �zerinde ate� yanarken duruyor mu?
        _killFire.IsOnFire();
        // E�er oyuncu ate� tuza�� ile etkile�imdeyse
        if (isInteracting)
        {
            // ve oyuncu ate� tuza��n�n �zerinde ate� yanarken duruyorsa oyuncuyu �ld�r
            _killFire.KillFire();
        }
    }

    // E�er platform ile bir nesne etkile�ime ge�erse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu �al��t�r ve oyuncunun ate� tuza�� ile etkile�imini true yap
            _animation.HitAndOnAnimation();
            isInteracting = true;
        }
    }

    // E�er platformdan bir nesne etkile�imden ��karsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncunun ate� tuza�� ile etkile�imini false yap
            isInteracting = false;
        }
    }
}
