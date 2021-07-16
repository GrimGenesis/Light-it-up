using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject[] stars;
    private int starCount;

    // Start is called before the first frame update
    void Start()
    {
        starCount = GameObject.FindGameObjectsWithTag("Star").Length;
    }

    public void StarCollected()
    {
        int starLeft = GameObject.FindGameObjectsWithTag("Star").Length;
        int starcollect = starCount - starLeft;

        if(starcollect == 1)
        {
            stars[0].SetActive(true);
        }
        else if(starcollect == 2)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }

    }
}
