using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System; // Nepiecieðams vecuma aprçíinam

public class NameScript : MonoBehaviour
{
    [Header("UI Ievades Lauki")]
    public TMP_InputField nameInputField; // NameField (tçla vârdam)
    public TMP_InputField yearInputField; // YearField (dzimðanas gadam)

    [Header("UI Izvades Elementi")]
    public TMP_Text outputText;           // OutputText (rezultâtam)
    public Toggle reverseTextToggle;      // Tava Toggle poga

    [Header("Audio Iestatîjumi")]
    public AudioSource audioSource;       // EffectSours
    public AudioClip[] audioClipi;        // Skaòu saraksts

    public void GetText()
    {
        // 1. Iegûstam datus no laukiem
        string vards = nameInputField.text;
        string gadaTeksts = yearInputField.text;

        // 2. Vecuma aprçíina loìika
        int dzimsanasGads;
        bool vaiGadsIrSkaitlis = int.TryParse(gadaTeksts, out dzimsanasGads);
        int pasreizejaisGads = DateTime.Now.Year;
        int vecums = pasreizejaisGads - dzimsanasGads;

        // 3. Rezultâta attçloðana tavâ stilâ
        if (vards != "" && vaiGadsIrSkaitlis)
        {
            outputText.text = "Supervaronis " + vards + " ir " + vecums + " gadus vecs!";

            // Aktivizçjam Toggle tikai tad, ja viss ievadîts pareizi
            reverseTextToggle.interactable = true;
        }
        else
        {
            outputText.text = "Lûdzu, ievadi vârdu un skaitïiem atbilstoðu gadu!";
        }

        // 4. Skaòas atskaòoðana (pirmâ skaòa sarakstâ)
        if (audioSource != null && audioClipi.Length > 0)
        {
            audioSource.PlayOneShot(audioClipi[0]);
        }
    }
}
