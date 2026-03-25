using UnityEngine;
using UnityEngine.UI;

public class ClothesToggle : MonoBehaviour
{
    public Toggle toggle;
    public GameObject targetObject;

    void Start()
    {
        toggle.onValueChanged.AddListener(OnToggleChanged);
        OnToggleChanged(toggle.isOn);
    }

    void OnToggleChanged(bool isOn)
    {
        targetObject.SetActive(isOn);
    }
}
