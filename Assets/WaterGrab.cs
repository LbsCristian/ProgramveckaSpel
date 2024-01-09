using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class WaterGrab : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject Player;

    BoxCollider2D trigger;
    void Start()
    {
        trigger = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.enabled == false)
        {
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 1, Player.transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            trigger.enabled = false;
            

        }
        
        

    }
}
