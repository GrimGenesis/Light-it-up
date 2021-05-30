using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class playerJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
/*    public GameObject Shapes;
    public GameObject player;
    public GameObject [] obsName;
    public Animation[] Anim;*/
    [SerializeField] float jumpDir;
/*    [HideInInspector]
    public Animation[] myAnim = new Animation[4];

    

    [System.Serializable]
    public class Animation
    {
        public Animation myAnim = new Animation();
        public Button myAnimButton;
        public string myAnimButtonName;
        public string myAnimation;
        public bool myAnimButtonPressed = false;
    }

    private GameObject Animate;
    private Button[] buttons;
    int animCount;

    void Awake()
    {
        Animate = Shapes.transform.GetChild(1).gameObject;
        buttons = Animate.GetComponentsInChildren<Button>();

        int i = 0;
        foreach (Animation mc in myAnim)
        {
            Debug.Log(i + 1);
            mc.myAnim = Anim[i];
            mc.myAnimButton = buttons[i];
            mc.myAnimButtonName = i.ToString();
            i++;
        }
    }*/

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            rb.AddForce(Vector3.right * jumpForce, ForceMode2D.Impulse);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, jumpDir * jumpForce * Time.deltaTime, 0f));
        }

    }
    
/*    public void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Enemy")
        {
            for (int i = 1; i <= myAnim.Length; i++)
            {
                if (myAnim[i - 1].myAnimButtonPressed == true)
                {
                    Animation an = player.GetComponent<Animation>();
                    an.myAnim = myAnim[i - 1].myAnim;

                 //   TrailRenderer tr = player.GetComponent<TrailRenderer>();
                 //   tr.material.color = myAnim[i - 1].myAnim;

                    GameObject canvas = GameObject.Find("Canvas");
                    canvas.SetActive(false); // can't find the fault

                    //SceneManager.LoadScene(1);
                }
            }
        }*/

    

 //   }

   
}
