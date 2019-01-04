using System.Collections;
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
        NextGuess();
    }

    private void NextGuess()
    {
        _guess = Random.Range(min, max + 1);
        guessText.text = _guess.ToString();
    }

    private void Update()
    {
    }

    public void OnPressHigher()
    {
        min = min != max ? _guess + 1 : _guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = min != max ? _guess - 1 : _guess;
        NextGuess();
    }
}