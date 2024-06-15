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
        // Oyuncu ateþ tuzaðýnýn üzerinde ateþ yanarken duruyor mu?
        _killFire.IsOnFire();
        // Eðer oyuncu ateþ tuzaðý ile etkileþimdeyse
        if (isInteracting)
        {
            // ve oyuncu ateþ tuzaðýnýn üzerinde ateþ yanarken duruyorsa oyuncuyu öldür
            _killFire.KillFire();
        }
    }

    // Eðer platform ile bir nesne etkileþime geçerse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu çalýþtýr ve oyuncunun ateþ tuzaðý ile etkileþimini true yap
            _animation.HitAndOnAnimation();
            isInteracting = true;
        }
    }

    // Eðer platformdan bir nesne etkileþimden çýkarsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncunun ateþ tuzaðý ile etkileþimini false yap
            isInteracting = false;
        }
    }
}
