using UnityEngine;

public class FireAnimation : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Ate� yanma animasyonu
    public void HitAndOnAnimation()
    {
        animator.SetTrigger("isHit");
    }
}
