using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    // Start is called before the first frame update
    private const double V = -8.5;
    Rigidbody2D rb;
    public int MovementSpeed = 10;
    int JumpForce;
    public int DeafultJumpForce = 15;
    public GameObject Enemy;


    BoxCollider2D bc;

    [SerializeField]
    BoxCollider2D WaterTrigger;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        bc = gameObject.GetComponent<BoxCollider2D>();
        bc.size = new Vector2(1, 1);
        bc.offset = new Vector2(0, 0f);
        JumpForce = DeafultJumpForce;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * MovementSpeed, rb.velocity.y);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.Z) && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y / 2);
        }

        if (WaterTrigger.enabled == false)
        {
            JumpForce = DeafultJumpForce / 2;
            bc.size = new Vector2(1, 2);
            bc.offset = new Vector2(0, 0.5f);
        }
        else
        {
            JumpForce = DeafultJumpForce;
            bc.size = new Vector2(1, 1);
            bc.offset = new Vector2(0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Water")
        {

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
