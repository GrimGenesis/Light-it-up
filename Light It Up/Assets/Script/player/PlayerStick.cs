using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStick : MonoBehaviour
{
    [SerializeField] private Vector2 jumpSpeed;
    public Rigidbody2D rb;
    private BoxCollider2D boxCol2D;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCol2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("Space"))
        {
            jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
            
            
        }
       
    }

    public void jump()
    {
        rb.AddForce(jumpSpeed, ForceMode2D.Impulse);
        rb.gravityScale = 1;
    }
   

}
