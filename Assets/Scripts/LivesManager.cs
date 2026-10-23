using UnityEngine;
using TMPro;

public class LivesManager : MonoBehaviour
{
    public int lives = 3;
    public TMP_Text livesText;

    // 1. Add a public field for the player's respawn script
    public PlayerRespawn playerRespawnScript;

    void Start()
    {
        UpdateLivesUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateLivesUI();

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            // You can trigger your game over logic here
            if (playerRespawnScript != null)
            {
                playerRespawnScript.Respawn();
            }
        }
        
    }

    void UpdateLivesUI()
    {
        livesText.text = " " + lives + " ";
    }
}
