using TMPro;
using UnityEngine;


public class NumberWizard : MonoBehaviour
{
    [SerializeField] private int max;
    [SerializeField] private int min;
    [SerializeField] private TextMeshProUGUI guessText;
    private int _guess;

    private void Start()
    {
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        int sum = min + max;
        _guess = sum < 1999 ? sum / 2 : 1000;
        guessText.text = _guess.ToString();
    }

    private void Update()
    {
    }

    public void OnPressHigher()
    {
        min = _guess;
        CalculateGuess();
    }

    public void OnPressLower()
    {
        max = _guess;
        CalculateGuess();
    }
}