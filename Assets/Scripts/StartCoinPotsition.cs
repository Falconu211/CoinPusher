using UnityEngine;

public class StartCoinPosition : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    public int startCoinNumber = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int generatedCoinsXCoordinateUpperLimitNumber = 9;
        int generatedCoinsXCoordinateLowerLimitNumber = -2;
        int generatedCoinsYCoordinateUpperLimitNumber = 9;
        int generatedCoinsYCoordinateLowerLimitNumber = 3;
        int generatedCoinsZCoordinateUpperLimitNumber = 4;
        int generatedCoinsZCoordinateLowerLimitNumber = -4;


        for (int i = 0; i < startCoinNumber; i++)
        {
            float randomPositonX = Random.Range(generatedCoinsXCoordinateLowerLimitNumber, generatedCoinsXCoordinateUpperLimitNumber);
            float randomPositonY = Random.Range(generatedCoinsYCoordinateLowerLimitNumber, generatedCoinsYCoordinateUpperLimitNumber);
            float randomPositonZ = Random.Range(generatedCoinsZCoordinateLowerLimitNumber, generatedCoinsZCoordinateUpperLimitNumber);

            Vector3 position = new Vector3(randomPositonX, randomPositonY, randomPositonZ);

            Instantiate(coinPrefab, position, Quaternion.LookRotation(position));
        }
    }
}
