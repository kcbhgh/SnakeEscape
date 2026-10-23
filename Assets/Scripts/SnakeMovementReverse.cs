
using UnityEngine;

public class SnakeMovementReverse : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(
            Time.time * speed,
            distance * 2
        ) - distance;

        transform.position = new Vector3(
            startPosition.x - movement,
            startPosition.y,
            startPosition.z
        );
    }
}
