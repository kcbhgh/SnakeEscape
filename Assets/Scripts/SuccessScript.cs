using TMPro;
using UnityEngine;
using System.Collections;

public class SuccessScript : MonoBehaviour
{
    public PlayerRespawn playerRespawnScript;
    public TMP_Text SuccessText;
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You Win");
            if (playerRespawnScript != null)
            {
                playerRespawnScript.Respawn();
            }
            SuccessText.text = " You Win! ";
            StartCoroutine(HideTextAfterDelay(3f));
        }
    }
    private IEnumerator HideTextAfterDelay(float delay)
    {
        // Wait for the specified number of seconds
        yield return new WaitForSeconds(delay);

        // Clear the text
        SuccessText.text = "";
    }
}
