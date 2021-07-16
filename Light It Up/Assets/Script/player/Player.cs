using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public BoxCollider2D col;

    [HideInInspector] public Vector3 pos {  get { return transform.position; } }

	public bool isCol = false;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            isCol = true;
        }
    }
    public void Push(Vector2 force)
	{
		rb.AddForce(force, ForceMode2D.Impulse);
	}

	public void ActivateRb()
	{
		rb.isKinematic = false;
	}

	public void DesactivateRb()
	{
		if(isCol == true)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = 0f;
            rb.isKinematic = true;
        }
        
	}
}

