using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 2f;
    public SpriteRenderer spriteRenderer;
    public Collider2D coll;
    public Animator animator;

    private bool moveLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.flipX = !moveLeft;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        CheckPlatformBoundaries();
    }

    void Movement()
    {
        Vector3 moveTran = (moveLeft) ? -transform.right : transform.right;
        moveTran *= Time.deltaTime * speed;
        transform.Translate(moveTran);
    }

    void CheckPlatformBoundaries()
    {
        Vector3 raycastDir = (moveLeft) ? Vector3.left : Vector3.right;
        RaycastHit2D hit = Physics2D.Raycast(transform.position + 0.1f * raycastDir + new Vector3(0f, -0.5f, 0f), -Vector2.up, 2f);
        if (hit.collider == null)
        {
            moveLeft = !moveLeft;
            spriteRenderer.flipX = moveLeft;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.transform.position.y > transform.position.y + 0.7f)
            {
                PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
                playerController.score += 200;
                playerController.JumpAfterKill();
                coll.enabled = false;
                animator.Play("Enemy Death");
                Destroy(gameObject, 0.4f);
            }
            else 
            {
                other.gameObject.GetComponent<Collider2D>().enabled = false;
                Animator playerAnim = other.GetComponent<Animator>();
                playerAnim.Play("Death");
                Destroy(other.gameObject, 0.6f);
            }

        }
    }
}
