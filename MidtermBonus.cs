/*
Amanda M Lincoln
CIDM 2315-70 Midterm Bonus

This program emulates the popular game "Rock, Paper, Scissors", with two players consisting of: a computer player that selects choice through random number generation, and
a human player that provides selection through console input. 

References:

1. Anusha1907, BartoszKlonowski, BillWagner, bschaeublin, GitHubPang, 13 March 2023, "Resolve nullable warnings", Microsoft Learn, accessed 18 June 2023, https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference.
2. Saman, Suman, 21 October 2015, "Exit Methods in C# Application", C# Corner, accessed 30 June 2023, https://www.delftstack.com/howto/csharp/exit-console-application-in-csharp/
*/

namespace MidtermBonus;
using System;
class HumanPlayer
{
    public int Points {get; set;}
    public HumanPlayer (int initial)
    {
        Points = initial;
    }
    
    public int GetPoints()
    {
        return Points;
    }

    public void WinRound()
    {
        Points += 5;
    }

    public void LoseRound()
    {
        Points-=5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Please input your choice: rock, paper or scissors.");
        // All instances of string ? taken from Reference 1.
        string ? choice = Console.ReadLine();
        // Following string arrays created in order to slightly expand acceptable user input.
        string [] Rock_Array = {"rock", "Rock", "ROCK"};
        string [] Scissors_Array = {"scissors", "SCISSORS", "Scissors"};
        string [] Paper_Array = {"paper", "PAPER", "Paper"};
        
        if (Rock_Array.Contains(choice))
        {
            Console.WriteLine("--> Your decision: rock");
            return "rock";
        }
        
        else if (Scissors_Array.Contains(choice))
        {
            Console.WriteLine("--> Your decision: scissors");
            return "scissors";
        }

        else if (Paper_Array.Contains(choice))
        {
            Console.WriteLine("--> Your decision: paper");
            return "paper";
        }
        // Else statement included to account for invalid or null input from user.
        else
        {
            Console.WriteLine("\n--> Please enter a valid selection.\n");
            return "invalid";
        }
    }
}

class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0,3);

        if (rnd_num == 0)
        {
            Console.WriteLine("--> Computer decision: rock");
            return "rock";
        }
        else if (rnd_num == 1)
        {
            Console.WriteLine("--> Computer decision: paper");
            return "paper";
        }
        else
        {
            Console.WriteLine("--> Computer decision: scissors");
            return "scissors";
        }
    }
}
class RockPaperScissors
{

    static void Main(string[] args)
    {
        HumanPlayer hp1 = new HumanPlayer (5);
        ComputerPlayer cp1 = new ComputerPlayer();

        while (hp1.Points > 0)
        {
            Console.WriteLine("****Rock Paper Scissors, Start!!****");
            int player_points = hp1.GetPoints();
            Console.WriteLine($"You have {player_points} points");

            string hp_decision = hp1.HumanDecision();
            // Follow on from else statement under HumanDecision() in HumanPlayer class. Returns user to beginning of while loop when invalid value is input.
            if (hp_decision == "invalid")
            {
                continue;
            }
            string cp_decision = cp1.ComputerDecision();

            if (hp_decision == "rock")
            {
                if (cp_decision == "rock")
                {
                    Console.WriteLine("It's a tie");
                }
                else if (cp_decision == "scissors")
                {
                    Console.WriteLine("You Win!");
                    hp1.WinRound();
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    hp1.LoseRound();
                }
            }

            if (hp_decision == "scissors")
            {
                if (cp_decision == "scissors")
                {
                    Console.WriteLine("It's a tie");
                }
                else if (cp_decision == "paper")
                {
                    Console.WriteLine("You Win!");
                    hp1.WinRound();
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    hp1.LoseRound();
                }
            }

            if (hp_decision == "paper")
            {
                if (cp_decision == "paper")
                {
                    Console.WriteLine("It's a tie");
                }
                else if (cp_decision == "rock")
                {
                    Console.WriteLine("You Win!");
                    hp1.WinRound();
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    hp1.LoseRound();
                }
            }

            //Initialized as a null or invalid value check.
            int check = 0;
            //Do while loop will run until a valid selection has been made by the user.
            do
            {
                // If player points are at zero, will not ask user if they wish to continue, and instead display 'Not enough points' message.
                if (hp1.Points == 0)
                {
                    break;
                }
                Console.WriteLine("--> Play again? Input y to continue, or n to exit");
                string ? p_select = Console.ReadLine();
                switch (p_select)
                {
                    // Valid user input slightly expanded to include upper case versions.
                    case "y":
                        check += 1;
                        break;
                    case "Y":
                        check += 1;
                        break;
                    case "n":
                        Console.WriteLine("Thanks for playing!");
                        Environment.Exit(0);
                        break;
                    case "N":
                        Console.WriteLine("Thanks for playing!");
                        // Environment.Exit(0) taken from reference 2.
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection.\n");
                        break;        
                }
            }
            while (check == 0);
        }

        Console.WriteLine("Sorry, you don't have enough points, thanks for playing.");
    }
}
