using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform _player;

    private void Update()
    {
        if (_player != null) transform.position = Vector3.Lerp(_player.position, transform.position, 0.5f);
    }
}
