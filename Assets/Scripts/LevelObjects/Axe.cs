using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField] private float _rotationAngle;
    [SerializeField] private float _moveSpeed;
    private float _rotationT;

    private void Update()
    {
        Rotate();
    }


    private void Rotate()
    {
        _rotationT += _moveSpeed * Time.deltaTime;
        float currentRotationState = Mathf.PingPong(_rotationT, 1);
        currentRotationState = currentRotationState.Remap(0, 1, -_rotationAngle, _rotationAngle);
        transform.rotation = Quaternion.Euler(currentRotationState, 0, 0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out var player))
        {
            player.Kill();
        }
    }
}
