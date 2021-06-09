using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class playerJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    [SerializeField] float jumpDir;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.right * jumpForce, ForceMode2D.Impulse);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, jumpDir * jumpForce * Time.deltaTime, 0f));
        }

    }
    

   
}
