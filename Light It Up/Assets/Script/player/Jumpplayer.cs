using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpplayer : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb;
    public float jumpPower;
    public int shapeCount ;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //shapeCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        shapeCount = 0;
        setCount();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y);
        Run(direction);

        if(Input.GetButtonDown("Jump"))
        {
            Jump(Vector2.up);
        }
    }

    public void Run(Vector2 dir)
    {
        rb.AddForce(new Vector2(dir.x * speed, 0));
    }

    public void Jump(Vector2 dir)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += dir * jumpPower;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       /* if(collision.gameObject.tag == "Enemy")
        {
            shapeCount--;

            if(shapeCount == 0)
            {
                SceneManager.LoadScene("Win Lose");
            }
        }*/

        if(collision.gameObject.CompareTag("Enemy"))
        {
            shapeCount = shapeCount + 1;
            setCount();
        }
    }

    public void setCount()
    {
        if(shapeCount >= 5)
        {
            SceneManager.LoadScene("Win Lose");
        }
    }

    

}
