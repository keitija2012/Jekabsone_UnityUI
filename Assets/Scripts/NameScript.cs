using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    private string text;
    private string[] sampleText = { "Hello", "Have a nice day", "Nice to see you", "Look what's here", "Goodbye" };
    private int randomIx;

    [Header("GameObject Atsauces")]
    public GameObject inputField;
    public GameObject outputField;
    public GameObject reverseTextToggle;

    [Header("Audio sadaïa")]
    public AudioSource audioSource;
    public AudioClip clickSound;

    // Galvenâ funkcija, ko izsauks poga
    public void OnButtonClick()
    {
        // 1. Izvçlamies nejauðu indeksu
        randomIx = Random.Range(0, sampleText.Length);

        // 2. Iegûstam tekstu no InputField komponentes
        text = inputField.GetComponent<TMP_InputField>().text;

        // 3. Ja teksts nav tukðs, izvadâm to ar lielo burtu efektu
        if (!string.IsNullOrEmpty(text))
        {
            // Apvienojam nejauðo sveicienu ar lietotâja vârdu (lielajiem burtiem)
            outputField.GetComponent<TMP_Text>().text = sampleText[randomIx] + " " + text.ToUpper() + "!";

            // Aktivizçjam papildus objektu, ja tâds ir pievienots
            if (reverseTextToggle != null)
            {
                reverseTextToggle.SetActive(true);
            }
        }

        // 4. Atskaòojam skaòu
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}