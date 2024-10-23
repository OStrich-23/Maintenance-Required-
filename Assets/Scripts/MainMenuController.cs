using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void NewGame()
    {
        // Load the new game scene
        SceneManager.LoadScene("GameScene");  // Replace with the name of your game scene
    }

    public void ContinueGame()
    {
        // Implement logic to load saved game
        // For now, let's assume it loads the same scene as New Game
        SceneManager.LoadScene("GameScene");
    }

    public void OpenOptions()
    {
        // Open options menu logic (you can load a new scene or enable/disable UI elements)
        Debug.Log("Opening Options");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
