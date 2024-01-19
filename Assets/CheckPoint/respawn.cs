using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Vector3 respawnpoint;
    public Transform respawnobject;
    public Transform water;
    public BoxCollider2D watertrigger;
    bool reached = false;

    private void Start()
    {
        reached = false;
    }
    public void RespawnNow()
    {
        respawnpoint = respawnobject.position;
        transform.position = respawnpoint;
        if (reached == true)
        {
            water.position = respawnpoint;
        }
        
    }
    private void Update()
    {
        if (watertrigger.enabled == false)
        {
            reached = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "death")
        {
            RespawnNow();
        }
    }
}
