using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizer : MonoBehaviour
{
    public Image characterImage;

    public Sprite shirtSprite;
    public Sprite pantsSprite;
    public Sprite shoesSprite;
    public Sprite hairSprite;

    public void ChangeShirt(int id)
    {
        characterImage.sprite = shirtSprite;
    }

    public void ChangePants(int id)
    {
        characterImage.sprite = pantsSprite;
    }

    public void ChangeShoes(int id)
    {
        characterImage.sprite = shoesSprite;
    }

    public void ChangeHair(int id)
    {
        characterImage.sprite = hairSprite;
    }
}
