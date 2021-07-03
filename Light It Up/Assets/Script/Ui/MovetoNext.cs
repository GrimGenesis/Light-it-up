using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovetoNext : MonoBehaviour
{
    public GameObject[] Shapes;
    public PolygonCollider2D shapeCol;

    private void Start()
    {
        shapeCol = GetComponent<PolygonCollider2D>();
    }

    private void Update()
    {
        for(int i = 0; i < Shapes.Length; i++)
        {

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
        }
    }

}
