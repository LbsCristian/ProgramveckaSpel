
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class WaterGrab : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject Player;

    [SerializeField]
    BoxCollider2D trigger;

    [SerializeField]
    BoxCollider2D watercollider;

    [SerializeField]
    BoxCollider2D CameraTrigger;
    Rigidbody2D rb;

    [SerializeField]
    BoxCollider2D DropCheck;
    RaycastHit2D[] results = new RaycastHit2D[10];

    public int wow;
    private bool pickUpAllowed;

    float direction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && trigger.enabled == false)
        {
            if (DropCheck.Cast(new Vector2(0, 0), results, 1) == 0)
            {
                transform.position += new Vector3(1.5f * direction, 0, 0);
                watercollider.enabled = true;
                rb.velocity = new Vector2(0, 0);
                trigger.enabled = true;
                rb.isKinematic = false;
            }


        }
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.X))
        {
            PickUp();
        }

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            direction = Input.GetAxisRaw("Horizontal");
        }
        if (trigger.enabled == false)
        {
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 2.36f, Player.transform.position.z);
        }
        if (direction == 1)
        {
            DropCheck.offset = new Vector2(0.18f, 0);
        }
        else
        {
            DropCheck.offset = new Vector2(-0.18f, 0);
        }
        wow = DropCheck.Cast(new Vector2(0, 0), results, 1);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = true;
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = false;
        }

    }
    private void PickUp()
    {
        trigger.enabled = false;
        CameraTrigger.offset = new Vector2(-29, 0);
        watercollider.enabled = false;
        rb.isKinematic = true;
    }
}
