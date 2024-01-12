using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideWater : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    BoxCollider2D watercollider;

    [SerializeField]
    GameObject Water;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Water")
        {
            transform.parent = Water.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Water")
        {
            transform.parent = null;
        }
    }
}
