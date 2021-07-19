using UnityEngine;
using System;

[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    public event Action CoinCountChanged;
    public event Action PlayerDead;

    private int _coinCount;
    public int coinCoint => _coinCount;

    private PlayerMovement _movement;

    private void Awake()
    {
        CoinCountChanged?.Invoke();
        _movement = GetComponent<PlayerMovement>();
    }

    public void Kill()
    {
        PlayerDead?.Invoke();
        Destroy(gameObject);
    }

    public void Disable()
    {
        _movement.Disable();
    }

    public void CollectCoin()
    {
        _coinCount++;
        CoinCountChanged?.Invoke();
    }
}