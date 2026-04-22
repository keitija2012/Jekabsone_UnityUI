using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void SaktTelaVeidosanu()
    {
        // Pârliecinies, ka "ieskaite" ir tieði tâds nosaukums, kâ tavai galvenajai ainai
        SceneManager.LoadScene("ieskaite");
    }

    public void IzietNoSpeles()
    {
        Debug.Log("Spçle tiek aizvçrta!");
        Application.Quit();
    }
}
