using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    
    BoxCollider2D CameraTrigger;

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
            if (CameraTrigger.offset.x > 0)
            {
                transform.position += new Vector3(19, 0, 0);
            }
            else
            {
                transform.position += new Vector3(-19, 0, 0);
            }
            
        }
    }

}
