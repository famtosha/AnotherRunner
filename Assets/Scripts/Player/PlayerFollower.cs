using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform _player;

    private void Update()
    {
        if (_player != null) transform.position = _player.position;
    }
}
