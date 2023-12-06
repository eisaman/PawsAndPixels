using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject restartCanvas;

    void Start()
    {
        // Hide both canvases at the start
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false);
        }

        if (restartCanvas != null)
        {
            restartCanvas.SetActive(false);
        }
    }

    public void ShowGameOverScreen()
    {
        // Show the game-over canvas
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }

        // Hide the restart canvas
        if (restartCanvas != null)
        {
            restartCanvas.SetActive(false);
        }
    }

    public void ShowRestartCanvas()
    {
        // Show the restart canvas
        if (restartCanvas != null)
        {
            restartCanvas.SetActive(true);
        }
    }

    public void RestartGame()
    {

        // Hide the game-over screen and restart canvas
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false);
        }

        if (restartCanvas != null)
        {
            restartCanvas.SetActive(false);
        }

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
