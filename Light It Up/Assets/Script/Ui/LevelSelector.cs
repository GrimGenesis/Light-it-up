using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSelector : MonoBehaviour
{
    
    public Button[] levelButton;
    

    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        for (int i = 0; i < levelButton.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                levelButton[i].interactable = false;
                
            }
        }

        for (int i = 0; i < levelAt; i++)
        {
            if (i + 2 > levelAt)
            {
                levelButton[i].interactable = true;

            }
        }

    }


}
