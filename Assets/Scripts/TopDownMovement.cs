using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{    
    private Rigidbody2D movementRigidbody;
    private TopDownController controller;      

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {        
        movementRigidbody = GetComponent<Rigidbody2D>();
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 2f;
        movementRigidbody.velocity = direction;
    }
}