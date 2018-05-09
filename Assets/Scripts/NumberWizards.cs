using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame ()
	{
		max = max + 1;

		print("Welcome to Number Wizard");
		print("Pick a number in your head");
		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print("I won!");
		}
	}

	void NextGuess ()
	{
		guess = (max + min) / 2;
		print("Higher or lower than " + guess);
		print("Up = higher, down = lower, return = equal");
	}
}
