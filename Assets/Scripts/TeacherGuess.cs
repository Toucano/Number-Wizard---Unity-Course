using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TeacherGuess : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    int guess;
    [SerializeField] TextMeshProUGUI guessText;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //Debug.Log("G'day mate, welcome to numba wiz-ud...");
        //Debug.Log("Pick a number, don't tell me what it is...");
        //Debug.Log("The highest number you can pick is: " + max);
        //Debug.Log("The lowest number you can pick is: " + min);
        //Debug.Log("Tell me if your number is higher or lower than: " + guess);
        //Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

        NextGuess();
    }

    // Update is called once per frame


    public void OnPressHigher()
    {
        min = guess + 1; 
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
