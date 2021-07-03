using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSelector : MonoBehaviour
{
    
    public Button[] levelButton;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < levelButton.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                levelButton[i].interactable = false;
                text.SetActive(false);
            }
        }    

    /*    for (int i = 0; i < levelAt; i++)
        {
            levelButton[i].interactable = true;
        }*/
    }

  /*  public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
  */
    
    
}
