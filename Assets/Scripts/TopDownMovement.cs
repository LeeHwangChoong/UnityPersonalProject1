using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{    
    Rigidbody2D rb;
    TopDownController controller;      

    private Vector2 movementDirection = Vector2.zero;
    public float speed = 5f;

    private void Awake()
    {        
        rb = GetComponent<Rigidbody2D>();
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    void ApplyMovement(Vector2 direction)
    {
        direction *= speed;
        rb.velocity = direction;
    }
}