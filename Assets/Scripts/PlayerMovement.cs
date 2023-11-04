using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GroundChecker _groundChecker;
    
    private Rigidbody _rigidbody;
    private float _playerSpeed = 15.0f;
    private float _playerJumpForce = 250.0f;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_groundChecker.IsOnGround())
        {
            Move();
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.IsOnGround())
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up * _playerJumpForce); // jump method
        // invoke counter method  
    }

    private void Move()
    {
        float moveZAxis = Input.GetAxis("Vertical") * _playerSpeed * Time.deltaTime;
        float moveXAxis = Input.GetAxis("Horizontal") * _playerSpeed * Time.deltaTime;

        Vector3 moveVector = new Vector3(moveXAxis, 0f, moveZAxis); 

        _rigidbody.AddForce(moveVector * _playerSpeed);
    }
}
