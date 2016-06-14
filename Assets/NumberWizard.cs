using UnityEngine;
using System.Collections;
using UnityEngine.UI; // This is to be able to update our text

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	public int maxGuessesAllowed = 100;
	public Text text;
	
	// Use this for initialization
	void Start () {
		startGame();
	}
	
	void startGame () {
		max = 1001;
		min = 1; 
		nextGuess();
	}

	public void guessHigher() {
		min = guess; 
		nextGuess();
	}
	
	public void guessLower() {
		max = guess;
		nextGuess();
	}	
	
	void nextGuess() {
		guess = Random.Range(min, max++);//guess = (max + min)/2; // Has will now be set to half-way between maximum and minimum
		text.text = guess.ToString(); // Turn generated guess into a String
		maxGuessesAllowed--;
		if(maxGuessesAllowed <= 0) {
			// Load the [Win] scene:
			Application.LoadLevel("Win");
		}
	}
}
