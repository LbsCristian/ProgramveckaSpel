using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyMovement : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentpoint;
    public float speed;
    float actualspeed;
    public GameObject Player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentpoint = pointB.transform;

    }

    private void OnWillRenderObject()
    {
        actualspeed = speed;
    }
    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector2 point = currentpoint.position - transform.position;
        if (currentpoint == pointB.transform)
        {
            rb.velocity = new UnityEngine.Vector2(actualspeed, 0);

        }
        else
        {
            rb.velocity = new UnityEngine.Vector2(-actualspeed, 0);
        }
        if (UnityEngine.Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointB.transform)
        {
            currentpoint = pointA.transform;
        }
        if (UnityEngine.Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointA.transform)
        {
            currentpoint = pointB.transform;
        }
        if (rb.velocity.x > 0)
        {
            transform.localScale=new Vector3(-8.125f,8.125f,8.125f);
        }
        else
        {
            transform.localScale = new Vector3(8.125f, 8.125f, 8.125f);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }

}