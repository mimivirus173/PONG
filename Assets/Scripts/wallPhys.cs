using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallPhys : MonoBehaviour
{
    // Declare RigidBody
    private Rigidbody2D rb;

    // Reset wall rotation and position
    private void ResetPos()
    {
        if (gameObject.name == "WallUp")
        {
            transform.position = new Vector2(0, 5.25F);
            transform.eulerAngles = new Vector3(0, 0, 90);
        } else if (gameObject.name == "WallRight")
        {
            transform.position = new Vector2(11.5F, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (gameObject.name == "WallDown")
        {
            transform.position = new Vector2(0, -5.25F);
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (gameObject.name == "WallLeft")
        {
            transform.position = new Vector2(-11.5F, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Load in RigidBody2D into rb
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // R to reset position
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPos();
        }
    }
}
