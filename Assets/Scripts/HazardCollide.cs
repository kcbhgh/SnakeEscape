using UnityEngine;

public class HazardCollide : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LivesManager livesManager =
                FindFirstObjectByType<LivesManager>();

            if (livesManager != null)
            {
                livesManager.LoseLife();
            }
        }
    }
}