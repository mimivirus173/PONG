using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPhys : MonoBehaviour
{
    // Force square will move with
    public float force = 10;
    
    // Directions
    private float y; // Vertical
    private float x; // Horizontal
    
    // Declare RigidBody
    private Rigidbody2D rb;

    // Reset player position and rotation
    private void ResetScene()
    {
        // Reset velocity
        rb.velocity = Vector2.zero;
        rb.Sleep();

        // Move players to default position
        if (gameObject.name == "PlayerLeft")
        {
            transform.position = new Vector2(-8, 0);
        }

        if (gameObject.name == "PlayerRight")
        {
            transform.position = new Vector2 (8, 0);
        }

        transform.eulerAngles = new Vector3 (0, 0, 0);
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
        // Declare which keys to press to move which directions
        if (gameObject.name == "PlayerLeft")
        {
            y = Input.GetAxis("VerticalLeft");
        }
        
        if (gameObject.name == "PlayerRight")
        {
            y = Input.GetAxis("VerticalRight");
        }

        // Player movement
        rb.velocity = new Vector2(0, y * force);
        // rb.AddForce(new Vector2(x * force, y * force));
        // rb.AddTorque(x); // Spin player

        // R to reset 
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
        }

        /*
        // Smooth player movement
        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * force * Time.deltaTime);
        */

        // Rotation
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.AddTorque(x);
            Debug.Log("Q was pressed");
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.AddTorque(x);
            Debug.Log("E was pressed");
        }
    }
}