using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballPhys : MonoBehaviour
{   
    private Rigidbody2D rb;

    // Score variables
    public static int scoreLeft = 0;
    public static int scoreRight = 0;

    System.Random rnd = new System.Random();

    // Reset position
    void ResetPos()
    {
        transform.position = new Vector2(0, 0);
        rb.AddForce(new Vector2(rnd.Next(300, 350), rnd.Next(50, 100)));
    }

    // On collision
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Left is hit");
            scoreRight++;
            ResetPos();
            Debug.Log("Left: " + scoreLeft + ", Right: " + scoreRight);
        } 
        if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Right is hit");
            scoreLeft++;
            ResetPos();
            Debug.Log($"Left: " + scoreLeft +", Right: " + scoreRight);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Load in RigidBody2D into rb
        rb = GetComponent<Rigidbody2D>();

        // Add force
        rb.AddForce(new Vector2(200, 200));
    }

    // Update is called once per frame
    void Update()
    {
        // R to reset 
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPos();
        }

        if (scoreLeft == 5 || scoreRight == 5)
        {
            SceneManager.LoadScene(2);
        }
    }
}
