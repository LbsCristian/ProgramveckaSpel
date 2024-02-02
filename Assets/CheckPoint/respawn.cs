using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Vector3 respawnpoint;
    public Transform respawnobject;
    public Transform water;
    public BoxCollider2D watertrigger;
    Rigidbody2D rb;
    bool reached = false;
    Animator anime;
    public int respawnTimer = 0;
    private void Start()
    {
        reached = false;
        anime = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
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
            if (collision.gameObject.tag == "death")
            {
                anime.SetTrigger("debt");
            }
        } 
    
}
