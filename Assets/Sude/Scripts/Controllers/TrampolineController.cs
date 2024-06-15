using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    TrampolineAnimation _animation;
    JumpWithTrampoline _jumpTrampoline;

    private void Awake()
    {
        _animation = GetComponent<TrampolineAnimation>();
        _jumpTrampoline = GetComponent<JumpWithTrampoline>();
    }

    // Eðer trampolin ile bir nesne etkileþime geçerse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu çalýþtýr ve oyuncuya trampolin tarafýndan yukarý doðru kuvvet uygula
            _animation.OnAnimation();
            _jumpTrampoline.JumpTrampoline(other);
        }
    }

    // Eðer platformdan bir nesne etkileþimden çýkarsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu durdur
            _animation.OffAnimation();
        }
    }
}
