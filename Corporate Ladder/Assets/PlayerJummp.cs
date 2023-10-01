using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    //public Animator anim;
    public Rigidbody2D rb;
    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayer;
    public LayerMask enemyLayer;
    public bool canJump = true;
    public bool isAlive = true;
    //public AudioSource JumpSFX; 

    void Start()
    {
        //anim = gameObject.GetComponentInChildren<Animator>(); 
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (IsGrounded()) {
            canJump = true;
        } else {
            canJump = false;
        }

        if ((Input.GetButtonDown("Jump")) && (canJump) && (isAlive == true))
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
        // anim.SetTrigger("Jump");
        // JumpSFX.Play();

        //Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        //rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 10f, groundLayer);
        if ((groundCheck != null) )
        {
            //Debug.Log("I am trouching ground!");
            return true;
        }
        return false;
    }
}