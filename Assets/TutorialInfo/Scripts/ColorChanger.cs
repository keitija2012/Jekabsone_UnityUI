using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Renderer targetObject;
    public Slider colorSlider;

    void Start()
    {
        colorSlider.onValueChanged.AddListener(ChangeColor);
    }

    void ChangeColor(float value)
    {
        Color newColor = new Color(value, 0.5f, 1f - value);
        targetObject.material.color = newColor;
    }
}
