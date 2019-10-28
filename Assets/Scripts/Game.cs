using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Game : MonoBehaviour {

    //Problem is here
    [SerializeField]
    TextMeshProUGUI guessText;

    //Guess Variables
    int min = 1;
    int max = 1000;
    int guess;

	// Use this for initialization
	void Start () {
        UpdateGuess();
        max += 1;
	}
	
    //Number is higher than guess, so adjust minimum to be guess and recalculate guess
    public void NumberHigher()
    {
        min = guess + 1;
        UpdateGuess();
    }

    //Number is lower than guess, so adjust max to be guess and recalculate guess
    public void NumberLower()
    {
        max = guess;
        UpdateGuess();
    }

    void UpdateGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void Win()
    {
        SceneManager.LoadScene("Game Over");
    }
}
