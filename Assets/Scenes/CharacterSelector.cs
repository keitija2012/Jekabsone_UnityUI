using UnityEngine;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public GameObject[] characters;

    public void OnCharacterChanged()
    {
        int index = dropdown.value;

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(i == index);
        }
    }
}
