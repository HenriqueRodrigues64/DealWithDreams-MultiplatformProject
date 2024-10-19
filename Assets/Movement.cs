using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHiker : MonoBehaviour
{

    public float movementSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        speedX = 0f;
        speedY = 0f;
        if (Input.GetKey(KeyCode.W)) // Move up
        {
            speedY = movementSpeed;
        }
        if (Input.GetKey(KeyCode.S)) // Move down
        {
            speedY = -movementSpeed;
        }
        if (Input.GetKey(KeyCode.A)) // Move left
        {
            speedX = -movementSpeed;
        }
        if (Input.GetKey(KeyCode.D)) // Move right
        {
            speedX = movementSpeed;
        }

        rb.velocity = new Vector2(speedX, speedY);
    }
}