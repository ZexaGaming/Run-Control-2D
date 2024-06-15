using UnityEngine;

public class FallingPlatformAnimation : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Platform �al��ma animasyonu
    public void OnAnimation()
    {
        animator.SetBool("isRidden", true);
    }

    // Platform durma animasyonu
    public void OffAnimation()
    {
        animator.SetBool("isRidden", false);
    }
}
