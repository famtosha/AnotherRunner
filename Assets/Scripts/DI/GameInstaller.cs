using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Player _player;
    [SerializeField] private LevelResultUI _levelResultUI;
    [SerializeField] private CoinCountUI _coinCountUI;


    public override void InstallBindings()
    {
        Container.Bind<Player>().FromInstance(_player).AsSingle();
        Container.Bind<CoinCountUI>().FromInstance(_coinCountUI).AsSingle();
        Container.Bind<LevelResultUI>().FromInstance(_levelResultUI).AsSingle();
    }
}