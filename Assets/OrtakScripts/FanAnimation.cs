using UnityEngine;

public class FanAnimation : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Fan �al��ma animasyonu
    public void OnAnimation()
    {
        animator.SetBool("isRidden", true);
    }

    // Fan durma animasyonu
    public void OffAnimation()
    {
        animator.SetBool("isRidden", false);
    }
}
