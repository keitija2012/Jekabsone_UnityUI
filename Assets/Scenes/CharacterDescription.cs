using UnityEngine;
using TMPro;

public class CharacterDescription : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TextMeshProUGUI descriptionText;

    public string[] descriptions;

    void Start()
    {
        UpdateDescription();
    }

    public void UpdateDescription()
    {
        int index = dropdown.value;
        descriptionText.text = descriptions[index];
    }
}
