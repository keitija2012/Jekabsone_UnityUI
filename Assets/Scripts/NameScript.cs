using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class NameScript : MonoBehaviour
{
    [Header("UI Ievades Lauki")]
    public TMP_InputField nameInputField;
    public TMP_InputField yearInputField;
    public TMP_Text outputText;
    public Toggle reverseTextToggle;

    [Header("Audio Iestatîjumi")]
    public AudioSource audioSource;
    public AudioClip[] audioClipi;

    [Header("Dropdown un Tçli")]
    public TMP_Dropdown teluDropdown;
    public GameObject zens;
    public GameObject meitene;

    // Galvenâ poga: Vârds, Vecums un Skaòa
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
            outputText.text = "Lûdzu, aizpildi visus laukus pareizi!";
        }

        if (audioSource != null && audioClipi.Length > 0)
        {
            audioSource.PlayOneShot(audioClipi[0]);
        }
    }

    // Tçlu pârslçgðana caur Dropdown
    public void MainitTelu()
    {
        if (teluDropdown.value == 0)
        {
            zens.SetActive(true);
            meitene.SetActive(false);
        }
        else
        {
            zens.SetActive(false);
            meitene.SetActive(true);
        }
    }

    // Apìçrbu pârslçgðana caur Toggle pogâm
    public void GerbtElementu(GameObject elements)
    {
        if (elements != null)
        {
            elements.SetActive(!elements.activeSelf);
        }
    }
}
