using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider healthSlider;

    private float currentHealth;
    private float maxHealth = 100f;
    private float healthDecreaseRate = 5f;  // Decrease rate in percentage every 15 seconds

    void Start()
    {
        currentHealth = 10f;
        UpdateHealthUI();
        InvokeRepeating("DecreaseHealthOverTime", 0f, 15f);  // Repeat every 15 seconds
    }

    void UpdateHealthUI()
    {
        healthSlider.value = currentHealth / maxHealth;

        // Check for game over condition
        if (currentHealth <= 0f)
        {
            GameOver();
        }
    }

    void DecreaseHealthOverTime()
    {
        // Decrease health over time
        currentHealth -= maxHealth * (healthDecreaseRate / 100f);

        // Ensure health is within valid range
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

        UpdateHealthUI();
    }

    public void ActivityButtonClicked()
    {
        // Increase health when activity button is clicked
        currentHealth += 10f;

        // Ensure health is within valid range
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

        UpdateHealthUI();
    }

    void GameOver()
    {
        // Implement game-over logic here
        Debug.Log("Game Over!");

        // Show the game-over screen
        GetComponent<GameOver>().ShowGameOverScreen();

        // Check if health is zero to show the restart canvas
        if (currentHealth <= 0f)
        {
            GetComponent<GameOver>().ShowRestartCanvas();
        }
    }

}
