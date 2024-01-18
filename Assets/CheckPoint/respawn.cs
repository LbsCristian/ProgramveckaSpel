using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Vector3 respawnpoint;

    public void RespawnNow()
    {
        transform.position = respawnpoint;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "death")
        {
            RespawnNow();
        }
    }
}
