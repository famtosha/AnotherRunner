using UnityEngine;

public class Saw : MonoBehaviour
{
    [SerializeField] private Transform _sawStart;
    [SerializeField] private Transform _sawEnd;
    [SerializeField] private Transform _sawBody;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _offset;

    private float _positionT;

    private void Awake()
    {
        _positionT = _offset;
    }

    private void Update()
    {
        _positionT += _moveSpeed * Time.deltaTime;
        _sawBody.transform.position = Vector3.Lerp(_sawStart.position, _sawEnd.position, Mathf.PingPong(_positionT, 1));
    }
}
