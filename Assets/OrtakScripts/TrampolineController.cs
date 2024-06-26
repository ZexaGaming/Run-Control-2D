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

    // E�er trampolin ile bir nesne etkile�ime ge�erse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu �al��t�r ve oyuncuya trampolin taraf�ndan yukar� do�ru kuvvet uygula
            _animation.OnAnimation();
            _jumpTrampoline.JumpTrampoline(other);
        }
    }

    // E�er platformdan bir nesne etkile�imden ��karsa
    private void OnTriggerExit2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // animasyonu durdur
            _animation.OffAnimation();
        }
    }
}
