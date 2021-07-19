using UnityEngine;

public class Player : MonoBehaviour
{
    private int _coinCount;

    public void Kill()
    {
        Destroy(gameObject);
    }

    public void CollectCoin()
    {
        _coinCount++;
    }
}
