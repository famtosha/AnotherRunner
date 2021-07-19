using UnityEngine;
using UnityEngine.UI;
using Zenject;
using TMPro;

public class LevelProgressUI : MonoBehaviour
{
    [SerializeField] private Slider _progress;

    private LevelProgress _levelProgress;


    [Inject]
    private void Construct(LevelProgress levelProgress)
    {
        _levelProgress = levelProgress;
    }

    private void Awake()
    {
        _levelProgress.LevelProgressChanged += OnPogressChanged;
    }

    private void OnDestroy()
    {
        _levelProgress.LevelProgressChanged -= OnPogressChanged;
    }

    private void OnPogressChanged()
    {
        _progress.value = _levelProgress.currentLevelProgress;
    }
}
