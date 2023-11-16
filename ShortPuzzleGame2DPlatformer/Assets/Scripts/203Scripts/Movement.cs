using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody2D rb;
    public float Speed;
    public float rotationSpeed;
    public Animator animator;
    float movement;
    public bool isFacingRight;

    [Header("Jumping")]
    public float jumpPower;
    public LayerMask jumpMask;
    public Transform feet;

    [Header("Dashing")]
    public float dashSpeed;
    public float dashTime;
    public float dashingCooldown;
    public bool canDash = true;
    public bool isDashing;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement = Input.GetAxisRaw("Horizontal");

        Flip();

        if (movement != 0)
        {
            if (movement > 0)
            {
                rb.velocity = new Vector2(movement * Speed, rb.velocity.y);
                animator.SetBool("isWalking", true);
            }
            else if (movement < 0)
            {
                rb.velocity = new Vector2(movement * Speed, rb.velocity.y);
                animator.SetBool("isWalking", true);
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            Jump();
        }
        if (Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0f)
        {
            animator.SetBool("isJumping", true);
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        if (isGrounded())
        {
            animator.SetBool("isJumping", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }
    }

    public void Flip()
    {
        movement = Input.GetAxisRaw("Horizontal");

        if (isFacingRight && movement > 0f || !isFacingRight && movement < 0f) 
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }

    public bool isGrounded()
    {
        return Physics2D.OverlapCircle(feet.position, 0.4f, jumpMask);
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashSpeed, 0f);

        yield return new WaitForSeconds(dashTime);

        rb.gravityScale = originalGravity;
        isDashing = false;

        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }

}
