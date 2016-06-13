using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		startGame();
	}
	
	void startGame () {
		max = 1000;
		min = 1; 
		guess = 500;
		max++; // Max will not be rounded to 999
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
		guess = (max + min)/2; // Has will now be set to half-way between maximum and minimum
		print("Higher or lower than " + guess);
		print ("Up arrow for higher, down for lower, return for equal");
	}
}
