using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed = 5f;


    private Rigidbody2D _rb;
    private Vector2 _movementInput;

    private Vector2 _smoothedMovementInput;
    private Vector2 _movementInputSmoothVelocity;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }


    // Update is called once per frame
    void Update()
    {
        // Input
        
        
    }

    void FixedUpdate()
    {
        // Movement

        // Calculating smoothed movement vector
        _smoothedMovementInput = Vector2.SmoothDamp(
            _smoothedMovementInput,
            _movementInput,
            ref _movementInputSmoothVelocity,
            0.1f
            );

        _rb.velocity = _smoothedMovementInput * movementSpeed;
    }

    public void OnMove(InputValue value)
    {
        // 

        _movementInput = value.Get<Vector2>();
    }



}
