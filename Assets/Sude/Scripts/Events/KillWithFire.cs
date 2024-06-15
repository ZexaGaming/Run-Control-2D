using UnityEngine;

public class KillWithFire : MonoBehaviour
{
    Animator animator;
    bool isOnFire = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Oyuncu ateþ tuzaðý üzerinde ateþ yanarken duruyor mu?
    public void IsOnFire()
    {
        // Þu anda ateþ tuzaðý üzerinde çalýþan animasyonu kaydet
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // Eðer þu anda ateþ tuzaðý üzerinde çalýþan animasyonun ismi "On" ise
        if (stateInfo.IsName("Base Layer.On"))
        {
            // oyuncunun ateþ tuzaðý üzerinde ateþ yanarken durma durumunu true yap
            isOnFire = true;
        }
        else
        {
            // oyuncunun ateþ tuzaðý üzerinde ateþ yanarken durma durumunu false yap
            isOnFire = false;
        }
    }

    // Oyuncuyu ateþle öldür
    public void KillFire()
    {
        // Eðer oyuncu ateþ tuzaðýnýn üzerinde ateþ yanarken duruyorsa
        if (isOnFire)
        {
            // oyuncuyu öldür
            Debug.Log("Karakter Öldü.");
        }
    }
}
