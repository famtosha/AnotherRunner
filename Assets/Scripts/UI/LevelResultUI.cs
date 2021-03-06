using UnityEngine;
using Zenject;

public class LevelResultUI : MonoBehaviour
{
    private SceneLoader _sceneLoader;
    private Player _player;
    private LevelProgress _levelProgress;

    [SerializeField] private GameObject _victoryWindow;
    [SerializeField] private GameObject _loseWindow;

    [Inject]
    private void Construct(SceneLoader sceneLoader, Player player, LevelProgress levelProgress)
    {
        _sceneLoader = sceneLoader;
        _player = player;
    }

    private void Awake()
    {
        _player.PlayerDead += ShowLoseWindow;
    }

    private void OnDestroy()
    {
        _player.PlayerDead -= ShowLoseWindow;
    }

    public void ShowVirctoryWindow()
    {
        _victoryWindow.SetActive(true);
    }

    public void ShowLoseWindow()
    {
        _loseWindow.SetActive(true);
    }

    public void LoadMainMenu()
    {
        _sceneLoader.LoadScene(0);
    }
}
