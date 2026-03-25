using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class CharacterCustomizer : MonoBehaviour
{
    [System.Serializable]
    public class BodyPart
    {
        public string partName;
        public SpriteRenderer spriteRenderer;
        public Sprite[] spriteOptions;
    }

    public BodyPart[] bodyParts;
    public TMP_Dropdown dropdown;

    void Start()
    {
        // Aizpilda dropdown
        List<string> options = new List<string>();
        int max = 0;
        foreach (var p in bodyParts)
            if (p.spriteOptions.Length > max) max = p.spriteOptions.Length;

        for (int i = 0; i < max; i++)
            options.Add("Tçls " + (i + 1));

        dropdown.ClearOptions();
        dropdown.AddOptions(options);

        dropdown.onValueChanged.AddListener(ChangeCharacter);
        ChangeCharacter(0);        // parâda pirmo tçlu
    }

    public void ChangeCharacter(int index)
    {
        foreach (var part in bodyParts)
        {
            if (part.spriteOptions.Length > index)
                part.spriteRenderer.sprite = part.spriteOptions[index];
        }
    }
}