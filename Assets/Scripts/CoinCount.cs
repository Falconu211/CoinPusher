using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject gameOverText;

    static public int coins = 10;

    public int pulsCoin = 1;

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
        EndGame();
    }

    private void CoinPush()
    {
        if (Input.GetKeyDown(KeyCode.Space) && coins > 0)
        {
            float randomPositonX = Random.Range(1, 9);
            float randomPositonY = 6;
            float randomPositonZ = Random.Range(-4, 4);

            Vector3 position = new Vector3(randomPositonX, randomPositonY, randomPositonZ);

            coinPrefab.transform.rotation = Quaternion.LookRotation(position);

            Instantiate(coinPrefab, position, coinPrefab.transform.rotation);

            coins--;

            coinCountText = "Coins:";
            coinText.text = coinCountText += coins;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject coin = other.GameObject();

        Destroy(coin);

        coins += pulsCoin;

        coinCountText = "Coins:";
        coinText.text = coinCountText += coins;
    }

    private void EndGame()
    {
        if (coins <= 0)
        {
            gameOverText.SetActive(true);
        }
    }
}
