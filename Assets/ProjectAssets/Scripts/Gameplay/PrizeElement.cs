using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrizeElement : MonoBehaviour
{
    [SerializeField] internal Image prizeImage;
    [SerializeField] private TextMeshProUGUI optionText;
    [SerializeField] private TextMeshProUGUI prizeValueText;
    private int prizeIndex;
    private int prizeValue;



    internal void SetTextValues()
    {
        optionText.text = prizeIndex.ToString();
        prizeValueText.text = prizeValue.ToString();
    }

    internal void SetPrizeValue(int value)
    {
        prizeValue = value;
    }
    internal void SetOptionValue(int value)
    {
        prizeIndex = value;
    }
}
