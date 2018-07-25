using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    //Game statement
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen; 

	// Use this for initialization
	void Start () {
        print("Hello Console");
        ShowMainMenu("Welcome wizard");
    }
	
    void ShowMainMenu (string greeting) {
        Terminal.ClearScreen();
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What house would you like to be in?    (If you win, you get in the house)\n");
        Terminal.WriteLine("Press 1 for Hufflepuff");
        Terminal.WriteLine("Press 2 for Slytherin");
        Terminal.WriteLine("Press 3 for Gryffindor\n");
        Terminal.WriteLine("Enter your selection: ");
    }
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu("Welcome back");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            RunPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("You didn't choose a valid house");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have choosen house: " + level);
        Terminal.WriteLine("Type the Password: ");
    }
    void RunPassword(string input)
    {
        if (level == 1)
        {
            if (input == "algofacil")
            {
                Terminal.WriteLine("Correct!");
            }
            else
            {
                Terminal.WriteLine("Try again");
            }
        }
        else if (level == 2)
        {
            if (input == "algomedio")
            {
                Terminal.WriteLine("Correct!");
            }
            else
            {
                Terminal.WriteLine("Try again");
            }
        }
    }
}