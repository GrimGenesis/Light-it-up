using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundchk;
    public float chkRadius;
    public LayerMask ground;

    [Header("Jump")]
    private int extraJump;
    public int extraJumpVal;

/*    public float obsjumpTime = 0.2f;
    public float slideSpeed = 0.3f;
    public float stickDist = 0.5f;
    bool isStick = false;
    RaycastHit2D stickChk;
    float jumpTime;
*/
    // Start is called before the first frame update
    void Start()
    {
        extraJump = extraJumpVal;
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundchk.position, chkRadius, ground);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

 /*       // Stick

        stickChk = Physics2D.Raycast(transform.position, new Vector2(stickDist, 0), stickDist, ground);

        if(stickChk && !isGrounded)
        {
            isStick = true;
            jumpTime = Time.time + jumpTime;
        }
        else if(jumpTime < Time.time)
        {
            isStick = false;
        }

        if(isStick)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, 0f, 0f));
        }*/
    }
 
    void Update()
    {
        if(isGrounded == false)
        {
            extraJump = extraJumpVal;
        }

        if(Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;

        }
        else if(Input.GetKeyDown(KeyCode.Space) && extraJump == 0 && isGrounded == false)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
