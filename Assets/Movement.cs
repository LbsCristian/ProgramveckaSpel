using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private const double V = -8.5;

    // Start is called before the first frame update
    Rigidbody2D rb;
    public int MovementSpeed = 5;
    public int JumpForce = 10;
    public GameObject Enemy;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*MovementSpeed, rb.velocity.y); 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D otherObj)
    {
        if (otherObj.gameObject.tag == "Enemy")
        {
            Debug.Log("Collided and died");
            transform.position = new Vector2(-8, 1);
        }
    }
}
