using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDreamer : MonoBehaviour
{

    public float FullMovementSpeed = 5;
    private float movementSpeed;
    public bool basicAttack = false;
    private float Cooldown = 0;
    private int direction = 1;
    float speedX, speedY;
    Rigidbody2D rb;
    
    void Start()
    {
        movementSpeed = FullMovementSpeed;
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
  

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Cooldown = 0.5f;
                basicAttack = true;
            }

        if (Cooldown > 0) {
                Cooldown -= Time.deltaTime;
        }else if (Cooldown < 0) {
                Cooldown = 0;
            basicAttack = false;
        }
        
        if (basicAttack){
            movementSpeed = 0;
        }else{
            movementSpeed = FullMovementSpeed;
        }
        speedX = 0f;
        speedY = 0f;



        
            if (Input.GetKey(KeyCode.UpArrow))
            {
                speedY = movementSpeed;
                direction = 1;
            }
            if (Input.GetKey(KeyCode.DownArrow)) 
            {
                speedY = -movementSpeed;
                direction = 2;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                speedX = -movementSpeed;
                direction = 3;
            }
            if (Input.GetKey(KeyCode.RightArrow)) 
            {
                speedX = movementSpeed;
                direction = 4;
            }
        

        rb.velocity = new Vector2(speedX, speedY);
    }

}