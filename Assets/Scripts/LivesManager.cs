using UnityEngine;
using System.Collections;
using TMPro;

public class LivesManager : MonoBehaviour
{
    public int lives = 3;
    public TMP_Text ResultsText;
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
                lives = 3;
                ResultsText.text = "Welp! You got Eaten";
                StartCoroutine(HideTextAfterDelay(3f));
                
                
                UpdateLivesUI();
            }
        }
        
    }
    private IEnumerator HideTextAfterDelay(float delay)
    {
        // Wait for the specified number of seconds
        yield return new WaitForSeconds(delay);

        // Clear the text
        ResultsText.text = "";
    }
    void UpdateLivesUI()
    {
        livesText.text = " " + lives + " ";
    }
}
