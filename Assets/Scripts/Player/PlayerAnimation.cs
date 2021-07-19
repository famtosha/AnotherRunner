using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    private static readonly int _jumpHash = Animator.StringToHash("Jump");
    private static readonly int _landHash = Animator.StringToHash("Land");
    private static readonly int _isGroundedHash = Animator.StringToHash("Grounded");
    private static readonly int _moveSpeed = Animator.StringToHash("MoveSpeed");

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetGrounded(bool value)
    {
        _animator.SetBool(_isGroundedHash, value);
    }

    public void SetMovementSpeed(float value)
    {
        _animator.SetFloat(_moveSpeed, value);
    }
}
