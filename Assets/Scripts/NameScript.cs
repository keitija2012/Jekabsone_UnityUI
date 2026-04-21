using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class NameScript : MonoBehaviour
{
    [Header("Ievades un Izvades Lauki")]
    public TMP_InputField nameInputField;
    public TMP_InputField yearInputField;
    public TMP_Text outputText;
    public Toggle reverseTextToggle;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip[] audioClipi;

    [Header("Dropdown un Tçli")]
    public TMP_Dropdown teluDropdown; // Ievelc jauno Dropdown
    public GameObject zens;         // Ievelc objektu "Galvenais tçls"
    public GameObject meitene;      // Ievelc objektu "Otrs tçls"

    public void GetText()
    {
        string vards = nameInputField.text;
        int dzimsanasGads;
        bool vaiIrSkaitlis = int.TryParse(yearInputField.text, out dzimsanasGads);
        int vecums = DateTime.Now.Year - dzimsanasGads;

        if (vards != "" && vaiIrSkaitlis)
        {
            outputText.text = "Supervaronis " + vards + " ir " + vecums + " gadus vecs!";
            reverseTextToggle.interactable = true;
        }
        else
        {
            outputText.text = "Lûdzu, aizpildi visus laukus!";
        }

        if (audioSource != null && audioClipi.Length > 0)
        {
            audioSource.PlayOneShot(audioClipi[0]);
        }
    }

    // JAUNA FUNKCIJA: Izsauksies, kad mainîsi Dropdown izvçli
    public void MainitTelu()
    {
        if (teluDropdown.value == 0) // Ja izvçlçts "Zçns"
        {
            zens.SetActive(true);
            meitene.SetActive(false);
        }
        else // Ja izvçlçts "Meitene"
        {
            zens.SetActive(false);
            meitene.SetActive(true);
        }
    }
}
