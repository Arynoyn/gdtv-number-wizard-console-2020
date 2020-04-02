using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;
	// Use this for initialization
	void Start () {
	    StartGame();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)){
             max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I won!");
            StartGame();
        }
	}
    
    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;
        
        Debug.Log("===============================================");
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number in your head but don't tell me!");
        
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);
        
        Debug.Log("Is the number higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        
        max++;
    }
    
    void NextGuess(){
        guess = (max + min) / 2;
        Debug.Log("Higher or lower than " + guess);
        Debug.Log("Up = higher, down = lower, return = equal");
    }
    
}
