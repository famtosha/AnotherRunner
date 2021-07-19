using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class SceneLoader : MonoBehaviour
{
    private Animator _animator;
    private AsyncOperation _loadOperation;

    private readonly int isOpenedHash = Animator.StringToHash("Hide");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void LoadScene(int buildIndex)
    {
        if (_loadOperation != null)
        {
            Debug.LogError($"Scene already loading");
            return;
        }
        var state = SceneManager.LoadSceneAsync(buildIndex);
        state.allowSceneActivation = false;
        OpenLoadScreen();
        _loadOperation = state;
        _loadOperation.completed += OnSceneLoaded;
    }


    private void OnSceneLoaded(AsyncOperation obj)
    {
        CloseLoadScreen();
        _loadOperation.completed -= OnSceneLoaded;
        _loadOperation = null;
    }

    private void OpenLoadScreen()
    {
        _animator.SetBool(isOpenedHash, true);
        StartCoroutine(WaitLoadAnimation());
        IEnumerator WaitLoadAnimation()
        {
            yield return new WaitForSeconds(0.5f);
            _loadOperation.allowSceneActivation = true;
        }
    }

    private void CloseLoadScreen()
    {
        _animator.SetBool(isOpenedHash, false);
    }
}
