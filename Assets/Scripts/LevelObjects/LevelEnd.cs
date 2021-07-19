using UnityEngine;
using Zenject;

[RequireComponent(typeof(ParticleSystem))]
public class LevelEnd : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    private LevelResultUI _levelResultUI;

    [Inject]
    private void Construct(LevelResultUI levelResultUI)
    {
        _levelResultUI = levelResultUI;
    }

    private void Awake()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            _levelResultUI.ShowVirctoryWindow();
            player.Disable();
        }
    }
}
