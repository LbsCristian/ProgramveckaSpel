using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    
    BoxCollider2D CameraTrigger;
    public BoxCollider2D CameraHitbox;
    public Transform respawn;
    public Transform player;
    float targetX;
    public float time;

    Camera currentcam;
    void Start()
    {
        targetX = transform.position.x;
        currentcam = Camera.main;
        CameraTrigger = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,new Vector3(targetX, 0,-10),time);
        time+=1f*Time.deltaTime;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (time >= 1)
            {
                time = 0;
                if (CameraTrigger.offset.x > 0)
                {

                    //transform.position += new Vector3(38, 0, 0);
                    targetX = transform.position.x + 37;
                    respawn.position = player.position + new Vector3(5, 0, 0);
                    player.position += new Vector3(3, 0, 0);
                }
                else
                {
                    targetX = transform.position.x - 38;
                    respawn.position = player.position - new Vector3(5, 0, 0);
                    player.position -= new Vector3(3, 0, 0);
                }
            }
            
            
        }
    }

}
