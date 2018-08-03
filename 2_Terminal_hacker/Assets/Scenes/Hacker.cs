using UnityEngine;

public class Hacker : MonoBehaviour {
    //Game Configuration
    const string MenuHint = "You may type 'menu' at any time";
    string[] level1Passwords = { "Yellow", "Helga", "easy", "Password", "algofacil" };
    string[] level2Passwords = { "Green", "Salasar", "Malfoy", "Voldemort", "Tom riddle" };
    string[] level3Passwords = { "Red", "Godric", "Hermione", "Potter", "Ronnald" };

    //Game statement
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

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
        else if (input == "exit" || input == "quit" || input == "close")
        {
            Terminal.WriteLine("It close the tab on the web");
            Application.Quit();
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
        bool isValidNumber = (input == "1" || input == "2" || input == "3");
        if (isValidNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
        else
        {
            Terminal.WriteLine("You didn't choose a valid house \ntry again");
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine(MenuHint);
        Terminal.WriteLine("Type the Password, hint: " + password.Anagram());
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
    }

    void RunPassword(string input)
    {
        if (level == 1)
        {
            if (input == password)
            {
                DisplayWinScreen();
            }
            else
            {
                AskForPassword();
            }
        }
        else if (level == 2)
        {
            if (input == password)
            {
                DisplayWinScreen();
            }
            else
            {
                AskForPassword();
            }
        }
        else if (level == 3)
        {
            if (input == password)
            {
                DisplayWinScreen();
            }
            else
            {
                AskForPassword();
            }
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(MenuHint);
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Welcome to Hufflepuff");
                Terminal.WriteLine(@"
 ━━━━━━━━☆ﾟ.*･｡ﾟ  12¼''long, Ash, unicorn hair wand
            "
                );
                break;
            case 2:
                Terminal.WriteLine("Welcome to Slytherin");
                Terminal.WriteLine(@"
━━━━━━━━☆ﾟ.*･｡ﾟ  18'', Elm, dragon heartstring wand
            "
                );
                break;
            case 3:
                Terminal.WriteLine("Welcome to Gryffindor");
                Terminal.WriteLine(@"
━━━━━━━━☆ﾟ.*･｡ﾟ  11'' long, made of holly, and possessed a phoenix feather core
            "
                );
                break;
        }
    }
}