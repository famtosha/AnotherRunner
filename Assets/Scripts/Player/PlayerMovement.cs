using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _forwardMovementSpeed;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        transform.Translate(_forwardMovementSpeed * Time.deltaTime, 0, _input.leftRightDelta * _moveSpeed);
    }
}
