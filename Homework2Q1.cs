/*
Amanda M Lincoln
CIDM 2315-70 Homework 2 Question 1

In response to warning messages from C#, null reference error CS8600 was resolved using the following two
references:

1. Anusha1907, BartoszKlonowski, BillWagner, bschaeublin, GitHubPang, 13 March 2023, "Resolve nullable warnings", Microsoft Learn, accessed 18 June 2023, https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference.
2. Anton Miki, Selman Genc, 13 October 2014, "Checking Console.ReadLine()!=null", stack overflow, accessed 18 June 2023, https://stackoverflow.com/questions/26338571/checking-console-readline-null.

*/



namespace Homework2Q1V1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade: ");
        // string? taken from Reference 1
        string? user_input = Console.ReadLine(); 
        // string.IsNullOrEmpty(user_input) taken from Reference 2
        if(string.IsNullOrEmpty(user_input)) 
        {
            Console.WriteLine("Please run program again and input a non-null value.");
        }
        else
        {
            switch(user_input)
            {
                case "A":
                    Console.WriteLine("GPA Point: 4");
                    break;
                case "a":
                    Console.WriteLine("GPA Point: 4");
                    break;
                case "B":
                    Console.WriteLine("GPA Point: 3");
                    break;
                case "b":
                    Console.WriteLine("GPA Point: 3");
                    break;
                case "C":
                    Console.WriteLine("GPA Point: 2");
                    break;
                case "c":
                    Console.WriteLine("GPA Point: 2");
                    break;
                case "D":
                    Console.WriteLine("GPA Point: 1");
                    break;
                case "d":
                    Console.WriteLine("GPA Point: 1");
                    break;
                case "F":
                    Console.WriteLine("GPA Point: 0");
                    break;
                case "f":
                    Console.WriteLine("GPA Point: 0");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }
        }
    }
}
