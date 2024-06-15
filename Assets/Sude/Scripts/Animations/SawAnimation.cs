using UnityEngine;

public class SawAnimation : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Testere �al��ma animasyonu
    public void OnAnimation()
    {
        animator.SetBool("isInteracting", true);
    }

    // Testere durma animasyonu
    public void OffAnimation()
    {
        animator.SetBool("isInteracting", false);
    }
}
