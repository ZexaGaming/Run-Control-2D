using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private float HareketSpeed;
    [SerializeField]
    private float JumpGucu;

    private Animator anim;
    private SpriteRenderer sRenderer;
    Rigidbody2D rb;

    int yon;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        sRenderer = gameObject.GetComponent<SpriteRenderer>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.Translate(yon * HareketSpeed * Time.deltaTime ,0,0);
        if (yon != 0)
        {
            anim.SetBool("Runing", true);
            if (yon > 0)
            {
                sRenderer.flipX = false;
            }
            else if (yon < 0)
            {
                sRenderer.flipX = true;
            }
        }
        else
        {
            anim.SetBool("Runing", false);
        }
    }
    bool YerdeMý()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.4f, 1 << LayerMask.NameToLayer("Zemin"));
        if (hit.collider != null)
        {
            return true;
        }
        else { return false; }
    }
    public void YonKarar(int fonkYon)
    {
        this.yon = fonkYon;
    }
    public void Jump()
    {
        if (YerdeMý())
        {
            Vector2 jumpVector = new Vector2(0, 1) * JumpGucu;
            rb.AddForce(jumpVector); anim.SetTrigger("Jumping");
        }
      
      
    }

}
