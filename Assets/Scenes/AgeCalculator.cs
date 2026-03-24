using UnityEngine;
using TMPro;

public class AgeCalculator : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField birthYearInput;
    public TextMeshProUGUI resultText;

    public void CalculateAge()
    {
        string name = nameInput.text;
        int year = int.Parse(birthYearInput.text);

        int age = System.DateTime.Now.Year - year;

        resultText.text = $"Supervaronis {name} ir {age} gadus vecs.";
    }
}
