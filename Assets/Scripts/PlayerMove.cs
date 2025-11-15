using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float moveSpeed = 2f;


    private void Update()
    {
        float movement = ProcessInput();
        Move(movement);
    }

    private float ProcessInput()
    {
        float movement = Input.GetAxis("MovePlayer");
        return movement;
    }
    

    private void Move(float movement)
    {

        Vector2 velo = rb2d.velocity;
        velo.y = moveSpeed * movement;
        rb2d.velocity = velo;
    }
}
