using UnityEngine;

public class KillWithFire : MonoBehaviour
{
    Animator animator;
    bool isOnFire = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Oyuncu ate� tuza�� �zerinde ate� yanarken duruyor mu?
    public void IsOnFire()
    {
        // �u anda ate� tuza�� �zerinde �al��an animasyonu kaydet
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // E�er �u anda ate� tuza�� �zerinde �al��an animasyonun ismi "On" ise
        if (stateInfo.IsName("Base Layer.On"))
        {
            // oyuncunun ate� tuza�� �zerinde ate� yanarken durma durumunu true yap
            isOnFire = true;
        }
        else
        {
            // oyuncunun ate� tuza�� �zerinde ate� yanarken durma durumunu false yap
            isOnFire = false;
        }
    }

    // Oyuncuyu ate�le �ld�r
    public void KillFire()
    {
        // E�er oyuncu ate� tuza��n�n �zerinde ate� yanarken duruyorsa
        if (isOnFire)
        {
            // oyuncuyu �ld�r
            Debug.Log("Karakter �ld�.");
        }
    }
}
