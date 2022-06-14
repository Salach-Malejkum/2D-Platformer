using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int speed = 4;
    public int jumpSpeed = 4;
    public int jumps = 2;
    public int score = 0;
    public Transform GroundCheck;
    public LayerMask GroundLayer;
    public TMPro.TextMeshProUGUI scoreText;
    public Rigidbody2D rb2d;
    public Animator animator;
    public bool canMove = true;
    public bool movementLeft = false;
    public bool movementRight = false;
    public bool playerJump = false;
    public float distance = 0f;

    private bool isGrounded = true;
    private int reachedRunningPoints = 1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        // Movement();
        // Jump();
        AddDistanceScore();
        UpdateScore();
        
        if (animator != null)
        {
            if (rb2d.velocity.y < -0.1)
            {
                animator.SetBool("GoingDown", true);
                animator.SetBool("GoingUp", false);
            }
            else if (rb2d.velocity.y > 0.1)
            {
                animator.SetBool("GoingUp", true);
                animator.SetBool("GoingDown", false);
            }
            else
            {
                animator.SetBool("GoingUp", false);
                animator.SetBool("GoingDown", false);
            }
        }
    }

    public void Movement()
    {
        AdjustJumps(); 
        if (canMove)
        {
            if (Input.GetKey(KeyCode.A) || movementLeft)
            {
                distance += -speed * Time.deltaTime;

                if (animator != null)
                {
                    animator.SetFloat("Speed", speed);
                }
                
                if (transform.localScale.x > 0)
                {
                    Vector3 tmpVect = transform.localScale;
                    tmpVect.x *= -1;
                    transform.localScale = tmpVect;
                }
            }
            else if (Input.GetKey(KeyCode.D) || movementRight)
            {
                distance += +speed * Time.deltaTime;
                
                if (animator != null)
                {
                    animator.SetFloat("Speed", speed);
                }

                if (transform.localScale.x < 0)
                {
                    Vector3 tmpVect = transform.localScale;
                    tmpVect.x *= -1;
                    transform.localScale = tmpVect;
                }
            }
            else
            {
                if (animator != null)
                {
                    animator.SetFloat("Speed", 0.0f);
                }
            }
        }
        else
        {
            if (animator != null)
            {
                animator.SetFloat("Speed", 0.0f);
            }
        }
        

    }

    void AdjustJumps() 
    {
        if (isGrounded)
        {
            jumps = 1;
        }
    }
    
    public void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheck.GetComponent<CircleCollider2D>().radius, GroundLayer);

        if (animator != null)
        {
            animator.SetBool("isGrounded", isGrounded);
        }
        if (Input.GetKeyDown(KeyCode.W) || playerJump)
        {
            if (jumps > 0)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
                jumps--;
            }
        }
    }

    public void JumpAfterKill()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
    }

    void UpdateScore()
    {
        scoreText.SetText(score.ToString());
    }

    void AddDistanceScore()
    {
        if (distance / 10 % 10 > reachedRunningPoints)
        {
            reachedRunningPoints++;
            score += 10;
        }
    }
}
