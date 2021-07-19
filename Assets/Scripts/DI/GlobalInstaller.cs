using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    [SerializeField] private SceneLoader _sceneLoader;


    public override void InstallBindings()
    {
        
    }
}

public class SceneLoader
{
    public void LoadScene(int buildIndex)
    {

    }
}
