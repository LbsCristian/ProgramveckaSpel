using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandlerTest : MonoBehaviour
{
    public Animator anime;
    Rigidbody2D rb;
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        anime.SetFloat("HorizontalInput", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        anime.SetFloat("Y velocity", rb.velocity.y);
        anime.SetBool("Haswater", bc.enabled);
    }
}
