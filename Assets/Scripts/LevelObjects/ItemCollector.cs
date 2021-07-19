using UnityEngine;

[RequireComponent(typeof(Player))]
public class ItemCollector : MonoBehaviour
{
    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Coin>(out var coin))
        {
            _player.CollectCoin();
            coin.DestroyCoin();
        }
    }
}
