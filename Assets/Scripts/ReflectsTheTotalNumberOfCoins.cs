using TMPro;
using UnityEngine;

public class ReflectsTheTotalNumberOfCoins : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinsCountText;

    void Start()
    {
        string coins = "Coins:";
        coinsCountText.text = coins + GenerateAndCountCoins.coins;
    }
}
