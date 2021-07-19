using UnityEngine;
using Zenject;
using System;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private Transform _levelStart;
    [SerializeField] private Transform _levelEnd;

    public float currentLevelProgress { get; private set; }
    public event Action LevelProgressChanged;

    private Player _player;

    [Inject]
    private void Construct(Player player)
    {
        _player = player;
    }

    private void Awake()
    {
        LevelProgressChanged?.Invoke();
    }

    private void Update()
    {
        if(_player != null)
        {
            var newProgress = GetLevelProgress(_player.gameObject.transform.position);

            if (newProgress != currentLevelProgress) LevelProgressChanged?.Invoke();

            currentLevelProgress = newProgress;
        }
    }

    private float GetLevelProgress(Vector3 playerPosition)
    {
        var pointOnLine = MathfHelper.PointOnLine(_levelStart.position, _levelEnd.position, playerPosition);
        var t = MathfHelper.InverseLerp(_levelStart.position, _levelEnd.position, pointOnLine);
        t = Mathf.Clamp01(t);
        return t;
    }
}
