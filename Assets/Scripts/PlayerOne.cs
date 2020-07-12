using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    private float speed = 10.0f;
    public Rigidbody2D rb;
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            movement.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            movement.y = -speed;
        }
        else
        {
            movement.y = 0;
        }
    }

    void FixedUpdate()
    {
        movePlayer();
    }

    void movePlayer()
    {
        rb.velocity = movement;
    }
}
