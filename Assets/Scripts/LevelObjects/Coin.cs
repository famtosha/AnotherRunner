using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private ParticleSystem _pickupParcitle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out var player))
        {
            player.CollectCoin();
            Instantiate(_pickupParcitle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
