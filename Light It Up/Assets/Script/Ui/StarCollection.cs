using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCollection : MonoBehaviour
{
    public GameObject starText;
    public static int theStar;

    void Update()
    {
        
        starText.GetComponent<Text>().text = "Star Collected :" + theStar;
    }
}
