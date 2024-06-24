using UnityEngine;

public class TrampolineAnimation : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Trampolin çalýþma animasyonu
    public void OnAnimation()
    {
        animator.SetBool("isRidden", true);
    }

    // Trampolin durma animasyonu
    public void OffAnimation()
    {
        animator.SetBool("isRidden", false);
    }
}
