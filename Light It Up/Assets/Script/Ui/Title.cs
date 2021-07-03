using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] float timeToWait;

    private void Update()
    {
        StartCoroutine(Load());

    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
