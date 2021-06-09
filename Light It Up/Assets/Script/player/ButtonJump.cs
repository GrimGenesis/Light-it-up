using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    [SerializeField] float jumpDir;

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
        rb.AddForce(Vector3.left * jumpForce, ForceMode2D.Impulse);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, -jumpDir * jumpForce * Time.deltaTime, 0f));
    }

    public void rightJump()
    {
        rb.AddForce(Vector3.right * jumpForce, ForceMode2D.Impulse);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, jumpDir * jumpForce * Time.deltaTime, 0f));
    }
}
