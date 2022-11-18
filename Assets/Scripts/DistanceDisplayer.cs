using UnityEngine;
using TMPro;

public class DistanceDisplayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _distanceText;
    [SerializeField] private DistanceCalculator _calculator;

    private void Update()
    {
        _distanceText.text = _calculator.Distance.ToString("0.0");
    }
}