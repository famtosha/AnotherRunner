using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ExitButton : MonoBehaviour
{
    private SceneLoader _sceneLoader;

    [Inject]
    private void Construct(SceneLoader sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }

    public void LoadMainMenu()
    {
        _sceneLoader.LoadScene(0);
    }
}
