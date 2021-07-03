using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJump : MonoBehaviour
{
    public Rigidbody2D rb;
    //public float jumpForce;
    [SerializeField] float jumpSpeed;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void leftJump()
    {
        //rb.AddForce(Vector2.left, ForceMode2D.Impulse);
        Jump(Vector2.up);
        transform.position += transform.right * -jumpSpeed * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, -jumpDir * jumpForce * Time.deltaTime, 0f));
    }

    public void rightJump()
    {
        //rb.AddForce(Vector2.right , ForceMode2D.Impulse);
        Jump(Vector2.up);
        transform.position += transform.right * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, jumpDir * jumpForce * Time.deltaTime, 0f));
    }

    public void Jump(Vector2 dir)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += dir * jumpPower;

    }
}
