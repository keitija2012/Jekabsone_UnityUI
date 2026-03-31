using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomizationUI : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
