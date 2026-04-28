using Unity.VisualScripting;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject coin = other.GameObject();

        Destroy(coin);
    }
}
