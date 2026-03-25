using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    public GameObject[] characters;
    public Image characterImage;
    public Sprite[] characterSprites;

    void Start()
    {
        dropdown.onValueChanged.AddListener(OnCharacterChanged);
        OnCharacterChanged(dropdown.value);
    }

    void OnCharacterChanged(int index)
    {
        // Aktivizç pareizo 3D tçlu
        for (int i = 0; i < characters.Length; i++)
            characters[i].SetActive(i == index);

        // Nomaina attçlu UI
        characterImage.sprite = characterSprites[index];
    }
}
