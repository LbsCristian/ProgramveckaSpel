using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
      public GameObject pointA;
      public GameObject pointB;
      private Rigidbody2D rb;
      private Transform currentpoint;
      public float speed;
    public GameObject Player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentpoint = pointB.transform;

    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector2 point = currentpoint.position - transform.position;
        if(currentpoint == pointB.transform)
        {
            rb.velocity = new UnityEngine.Vector2(speed, 0);

        }
        else
        {
            rb.velocity = new UnityEngine.Vector2(-speed, 0);
        }
       if(UnityEngine.Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointB.transform)
        {
            currentpoint = pointA.transform;
        }
       if(UnityEngine.Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointA.transform)
        {
            currentpoint = pointB.transform;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
   
}
