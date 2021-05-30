using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsDetect : MonoBehaviour
{
    private float timeBtwJump;

    public Transform attackPos;

    public float startTimeBtwJump;
    public float dirRange;

    public LayerMask obsLayer;

    void Update()
    {
        if (timeBtwJump <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Collider2D[] obsToRange = Physics2D.OverlapCircleAll(attackPos.position, dirRange, obsLayer);
                for (int i = 0; i < obsToRange.Length; i++)
                {
                    obsToRange[i].GetComponent<SquareAnim>().Player = GameObject.FindGameObjectWithTag("Player");
                }
            }

            timeBtwJump = startTimeBtwJump;
        }
        else
        {
            timeBtwJump -= Time.deltaTime;
        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, dirRange);
    }
}