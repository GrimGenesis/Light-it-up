using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollect : MonoBehaviour
{
    public GameObject[] stars;
    
    private int starCount;
    
    // Start is called before the first frame update
    void Start()
    {
        starCount = GameObject.FindGameObjectsWithTag("Star").Length;    
    }

   public void starAcived()
    {
        int starLeft = GameObject.FindGameObjectsWithTag("Star").Length;
        int starCollected = starCount - starLeft;

        if(starCollected == 3)              //3 star
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);

        }
        else if(starCollected == 2)         //2 star
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else                                //1 star
        {
            stars[0].SetActive(true);
        }
    }
}
