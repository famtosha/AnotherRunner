using UnityEngine;
using Zenject;

public class MainMenu : MonoBehaviour
{
    private SceneLoader _sceneLoader;

    [Inject]
    private void Construct(SceneLoader sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }

    public void LoadGame()
    {
        _sceneLoader.LoadScene(1);
    }
}