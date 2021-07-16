using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NxtLvl : MonoBehaviour
{
    public GameObject player;
    public GameObject shapes;
    public GameObject wincCanvas;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" )
        {
            Time.timeScale = 0f;
            player.SetActive(false);
            shapes.SetActive(false);
           // GetComponent<Star>().StarCollected();
            wincCanvas.SetActive(true);
        }
    }
}
