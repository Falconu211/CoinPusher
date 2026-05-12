using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateAndCountCoins : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject gameOverText;

    static public int coins = 10;

    public int increaseCoin = 1;

    string coinCountText = "Coins:";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinText.text = coinCountText += coins;
        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CoinPush();
        VerifyEndGame();
    }

    private void CoinPush()
    {
        if (Input.GetKeyDown(KeyCode.Space) && coins > 0)
        {
            int generatedCoinsXCoordinateUpperLimitNumber = 9;
            int generatedCoinsXCoordinateLowerLimitNumber = 1;
            int generatedCoinsYCoordinateUpperLimitNumber = 9;
            int generatedCoinsYCoordinateLowerLimitNumber = 3;
            int generatedCoinsZCoordinateUpperLimitNumber = 4;
            int generatedCoinsZCoordinateLowerLimitNumber = -4;

            float randomPositonX = Random.Range(generatedCoinsXCoordinateLowerLimitNumber, generatedCoinsXCoordinateUpperLimitNumber);
            float randomPositonY = Random.Range(generatedCoinsYCoordinateLowerLimitNumber, generatedCoinsYCoordinateUpperLimitNumber);
            float randomPositonZ = Random.Range(generatedCoinsZCoordinateLowerLimitNumber, generatedCoinsZCoordinateUpperLimitNumber);

            Vector3 position = new Vector3(randomPositonX, randomPositonY, randomPositonZ);

            Instantiate(coinPrefab, position, Quaternion.LookRotation(position));

            coins--;

            coinCountText = "Coins:";
            coinText.text = coinCountText += coins;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject coin = other.GameObject();

        Destroy(coin);

        coins += increaseCoin;

        coinCountText = "Coins:";
        coinText.text = coinCountText += coins;
    }

    private void VerifyEndGame()
    {
        if (coins <= 0)
        {
            gameOverText.SetActive(true);
        }
    }
}
