using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsMenu;
    public GameObject startMenu;
    public GameObject settingsMenu;

   
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Credits()
    {
        startMenu.SetActive(false);
        creditsMenu.SetActive(true);
        
       
    }

    public void Settings()
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void creditsBack()
    {
        creditsMenu.SetActive(false);
        startMenu.SetActive(true);
    }

    public void settingsBack()
    {
        settingsMenu.SetActive(false);
        startMenu.SetActive(true);
    }
}
