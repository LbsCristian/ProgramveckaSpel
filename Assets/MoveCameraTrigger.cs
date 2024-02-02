using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider2D cameraTrigger;
    public BoxCollider2D cameraHitbox;
    public BoxCollider2D waterTrigger;
    
    void Start()
    {
        cameraTrigger.offset = new Vector2(10, 0);
        cameraHitbox.offset = new Vector2(-27, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (waterTrigger.enabled == false)
        {
            cameraTrigger.offset = new Vector2(-29, 0);
            cameraHitbox.offset = new Vector2(8.6f, 0);
        }
    }
}
