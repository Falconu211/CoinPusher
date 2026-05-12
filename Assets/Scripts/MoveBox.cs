using TMPro;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    public float speed = 1f;
    private float moveBoxXCoordinatePosition = 5f;
    private float moveBoxYCoordinatePosition = 1f;
    private float moveBoxZCoordinatePosition = 0f;

    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time*speed) + moveBoxXCoordinatePosition, moveBoxYCoordinatePosition, moveBoxZCoordinatePosition);
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
