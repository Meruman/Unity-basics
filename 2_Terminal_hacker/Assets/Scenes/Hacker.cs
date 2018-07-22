using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Hello Console");
        ShowMainMenu("Welcome wizard");
    }
	
    void ShowMainMenu (string greeting) {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What house would you like to be in?    (If you win, you get in the house)\n");
        Terminal.WriteLine("Press 1 for Hufflepuff");
        Terminal.WriteLine("Press 2 for Slytherin");
        Terminal.WriteLine("Press 3 for Gryffindor\n");
        Terminal.WriteLine("Enter your selection: ");
    }
    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu("Welcome back");
        }
        else
        {
            print("You didn't choose anything valid");
        }
    }
}