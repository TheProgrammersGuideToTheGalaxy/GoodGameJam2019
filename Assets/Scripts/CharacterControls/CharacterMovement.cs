using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private bool isOnGround;
    [SerializeField]
    private bool hasDoubleJumped;
    [SerializeField]
    private bool hasAirDashed;
    [SerializeField]
    private int jumpForce = 16;
    [SerializeField]
    private int movementSpeed = 4;
    [SerializeField]
    private bool facingLeft = false;

    [SerializeField] private CharacterAnimation anim;
    [SerializeField] private Rigidbody2D ownBody;
    [SerializeField] private SpriteRenderer ownSpriteRenderer;

    private void Awake()
    {
        if (facingLeft)
        {
            facingLeft = false;
            Flip();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isOnGround)
            {
                Jump();
            }
            else if (!hasDoubleJumped)
            {
                DoubleJump();
            }
        } else if (Input.GetButtonDown("Air dash") && !isOnGround)
        {
            if (!hasAirDashed)
            {
                AirDash();
            }
        } else if (Input.GetButton("Horizontal"))
        {
            Move();
        } else
        {
            Stand();
        }

        var velocity = ownBody.velocity;
        anim.VerticalSpeed =  velocity.y;
        anim.HorizontalSpeed = velocity.x;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (isOnGround = IsCollidingWithGround(collision))
        {
            anim.Grounded = true;
            hasDoubleJumped = hasAirDashed = false;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        isOnGround = !IsCollidingWithGround(collision);
    }

    private bool IsCollidingWithGround(Collision2D collision)
    {
        bool areFeetColliding = collision.gameObject.transform.position.y > transform.position.y;
        bool isCollidingWithPlatform = collision.gameObject.layer != LayerMask.GetMask("platform");

        return areFeetColliding && isCollidingWithPlatform;
    }

    private void AirDash()
    {
        hasAirDashed = true;
    }

    private void DoubleJump()
    {
        hasDoubleJumped = true;
        anim.IsDoubleJumping = true;
        Jump(); 
    }

    private void Jump()
    {
        isOnGround = false;
        anim.Grounded = false;

        ownBody.velocity = new Vector2(ownBody.velocity.x, jumpForce);
    }

    private void Move()
    {
        float speed = Input.GetAxisRaw("Horizontal") * movementSpeed;
        if(speed < 0 && !facingLeft)
        {
            Flip();
        } else if (speed > 0 && facingLeft)
        {
            Flip();
        }
        ownBody.velocity = new Vector2(speed, ownBody.velocity.y);
    }

    private void Stand()
    {
        ownBody.velocity = new Vector2(0, ownBody.velocity.y);
    }

    private void Flip()
    {
        facingLeft = !facingLeft;
        ownSpriteRenderer.flipX = facingLeft;
    }
}
