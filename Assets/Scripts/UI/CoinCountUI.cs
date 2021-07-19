using UnityEngine;
using TMPro;
using Zenject;

public class CoinCountUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinCointText;

    private Player _player;

    [Inject]
    private void Construct(Player player)
    {
        _player = player;
    }

    private void Awake()
    {
        _player.CoinCountChanged += OnCoinCointChanged;
    }


    private void OnDestroy()
    {
        _player.CoinCountChanged -= OnCoinCointChanged;
    }

    private void OnCoinCointChanged()
    {
        _coinCointText.text = _player.coinCoint.ToString();
    }
}
