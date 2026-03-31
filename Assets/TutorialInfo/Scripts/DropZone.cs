using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public CharacterCustomizer customizer;

    public void OnDrop(PointerEventData eventData)
    {
        var item = eventData.pointerDrag;

        if (item != null)
        {
            string itemName = item.name;

            if (itemName.Contains("Shirt"))
                customizer.ChangeShirt(1);

            if (itemName.Contains("Pants"))
                customizer.ChangePants(1);

            if (itemName.Contains("Shoes"))
                customizer.ChangeShoes(1);

            if (itemName.Contains("Hair"))
                customizer.ChangeHair(1);
        }
    }
}
