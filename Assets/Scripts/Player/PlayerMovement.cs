using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _forwardMovementSpeed;

    private bool _isInputEnable = true;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if (_isInputEnable)
        {
            transform.Translate(_forwardMovementSpeed * Time.deltaTime, 0, _input.leftRightDelta * _moveSpeed);
        }
    }

    public void Disable()
    {
        _isInputEnable = false;
    }
}
