using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Customization");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }
}

