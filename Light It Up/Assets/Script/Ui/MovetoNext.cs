using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveToNext : MonoBehaviour
{
  //  public int nextSceneLoad;
    public GameObject[] shapeAnim;
    public bool animActive = false;
    public GameObject player;
    public GameObject shapes;
    public GameObject wincCanvas;

    // Start is called before the first frame update
    void Start()
    {
   //     nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        shapeAnim = GameObject.FindGameObjectsWithTag("Anim");
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
          for(int i =0; i<shapeAnim.Length; i++)
            {
                if(shapeAnim[i].activeInHierarchy)
                {
                    animActive = true;
                }
            }
            
          if(animActive == true)
            {
                Time.timeScale = 0f;
                player.SetActive(false);
                shapes.SetActive(false);
                GetComponent<Star>().StarCollected();
                wincCanvas.SetActive(true);
            }

        }
    }
}
