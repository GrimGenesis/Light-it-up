using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangeAnim : MonoBehaviour
{

    public GameObject Anim;
    public ParticleSystem Vfx;
    // Start is called before the first frame update
    void Start()
    {
        //  Anim = GetComponent<Animator>();
        Vfx.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Anim.SetActive(true);
            StartCoroutine(enableVfx());
        }
    }

    IEnumerator enableVfx()
    {
        Vfx.Play();
        yield return new WaitForSeconds(0.5f);
        Vfx.Stop();
    }
}
