using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCam : MonoBehaviour
{
    [SerializeField] float timeToPause;


    void Start()
    {
       
    }

    void Update()
    {
        StartCoroutine(TimePaused());    
    }

    IEnumerator TimePaused()
    {
        yield return new WaitForSeconds(timeToPause);
        Destroy(gameObject);
    }
}
