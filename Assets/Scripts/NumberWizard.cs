using System.Collections;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private int max;
    [SerializeField] private int min;
    [SerializeField] private TextMeshProUGUI guessText;
    private int _guess;
    private ArrayList checkedNumbers = new ArrayList();

    private void Start()
    {
        max += 1;
        min -= 1;
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        while (max - min > 1)
        {
            _guess = Random.Range(min, max);
            
            string output = "";
            foreach (var i in checkedNumbers)
            {
                output += i + ", ";
            }

            Debug.Log("Checked numbers: " + output);
            Debug.Log("Min - Max | Guess: " + min + " - " + max + " | " + _guess);

            if (!checkedNumbers.Contains(_guess))
            {
                Debug.Log("New! " + _guess);
          
                checkedNumbers.Add(_guess);
                guessText.text = _guess.ToString();
                break;
            }
        }

        Debug.Log("Loop ended");
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