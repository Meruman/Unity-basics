using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Hello Console");
        ShowMainMenu();
    }
	
    void ShowMainMenu () {
        Terminal.ClearScreen();
        Terminal.WriteLine("What house would you like to be in?    (If you win, you get in the house)");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for Hufflepuff");
        Terminal.WriteLine("Press 2 for Slytherin");
        Terminal.WriteLine("Press 3 for Gryffindor");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection: ");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
