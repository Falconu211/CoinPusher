using TMPro;
using UnityEngine;

public class TitleCoins : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinsCountText;

    void Start()
    {
        string coins = "Coins:";
        coinsCountText.text = coins + CoinCount.coins;
    }
}
