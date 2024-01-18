using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    
    BoxCollider2D CameraTrigger;
    public Transform respawn;
    public Transform player;

    Camera currentcam;
    void Start()
    {
        currentcam = Camera.main;
        CameraTrigger = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            respawn.position = player.position;
            if (CameraTrigger.offset.x > 0)
            {
                transform.position += new Vector3(38, 0, 0);
            }
            else
            {
                transform.position += new Vector3(-38, 0, 0);
            }
            
        }
    }

}
