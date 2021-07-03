using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class LevelNew : MonoBehaviour
{
    

    public GameObject gameShapesMenu;
    public GameObject[] Shapess;

    [HideInInspector]
    public GameObject[] myShapes = new GameObject[5];

    [System.Serializable]
    public class MyShapess
    {
        public Animation myShapesAnim;
        public string myShapesAnimName;
        public bool myShapesAnimPlay = false;
    }

    private Animation[] Anim;
    int shapeCount;


    void Awake()
    {
        myShapes = gameShapesMenu.transform.GetChild(1).gameObject;
        Anim = myShapes.GetComponentsInChildren<Animation>(); //all button children of "color_bg" gameobject

        int i = 0;
        foreach (MyShapess mc in myShapess)
        {
            Debug.Log(i + 1);
            mc.myShapes = Shapess[i];
            mc.myShapesAnim = Anim[i];
            mc.myShapesAnimName = i.ToString();
            i++;
        }
    }

    void Update()
    {
        for (int i = 1; i <= myShapess.Length; i++)
        {
            var go = Inspector.current.currentSelectedGameObject;
            if (go == null)
            {
                // do nothing
            }
            else if (go.name == "===Shapes===" + i.ToString())
            {
                myShapess[i - 1].myShapesAnimPlay = true;
                myShapess[i - 1].myShapesAnim.Play(OnAnimPlay);
            }
        }
    }

    void OnAnimPlay()
    {
        for (int i = 1; i <= myShapess.Length; i++)
        {
            if (myShapess[i - 1].myShapesAnimPlay == true)
            {
                Animation An = player.GetComponent<Animation>();
                An.Animation = myShapess[i - 1].myShapes;



                SceneManager.LoadScene(5);
            }
        }
    }
}
