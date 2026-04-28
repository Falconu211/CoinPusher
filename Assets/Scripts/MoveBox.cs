using TMPro;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time*speed) + 5, 1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject child = transform.Find("CoinScale").gameObject;

        other.transform.parent = child.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
