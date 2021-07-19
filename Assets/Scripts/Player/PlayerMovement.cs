using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _forwardMovementSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _playerSize;
    [SerializeField] private LayerMask _ignore;
    [SerializeField] private PlayerAnimation _animation;

    private bool _isInputEnable = true;

    private PlayerInput _input;
    private Rigidbody _rb;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _animation?.SetGrounded(IsGrounded());
        if (_isInputEnable)
        {
            transform.Translate(_forwardMovementSpeed * Time.deltaTime, 0, _input.leftRightDelta * _moveSpeed);
            _animation?.SetMovementSpeed(1);
            if (_input.isJump && IsGrounded())
            {
                _rb.AddForce(Vector3.up * _jumpForce);
            }
        }
        else
        {
            _animation?.SetMovementSpeed(0);
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -transform.up, _playerSize, ~_ignore);
    }

    public void Disable()
    {
        _isInputEnable = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position - Vector3.up * _playerSize);
    }
}
