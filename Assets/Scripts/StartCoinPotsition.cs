using UnityEngine;

public class StartCoinPosition : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    public int startCoinNumber = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 0; i < startCoinNumber; i++)
        {
            float randomPositonX = Random.Range(-2, 9);
            float PositonY = 2;
            float randomPositonZ = Random.Range(-4, 4);

            Vector3 position = new Vector3(randomPositonX, PositonY, randomPositonZ);

            coinPrefab.transform.rotation = Quaternion.LookRotation(position);

            Instantiate(coinPrefab, position, coinPrefab.transform.rotation);
        }
    }
}
