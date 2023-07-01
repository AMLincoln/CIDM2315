/*
Amanda M Lincoln
CIDM 2315-70 Homework 4 Question 3

This program will prompt the user to create an account. The user must be at least 18 years of age in order to create an account. 

References

In response to warning messages from C#, null reference error CS8600 was resolved using the following references:

1. Anusha1907, BartoszKlonowski, BillWagner, bschaeublin, GitHubPang, 13 March 2023, "Resolve nullable warnings", Microsoft Learn, accessed 18 June 2023, https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference.
2. Anton Miki, Selman Genc, 13 October 2014, "Checking Console.ReadLine()!=null", stack overflow, accessed 18 June 2023, https://stackoverflow.com/questions/26338571/checking-console-readline-null
3. Saman, Suman, 21 October 2015, "Exit Methods in C# Application", C# Corner, accessed 30 June 2023, https://www.delftstack.com/howto/csharp/exit-console-application-in-csharp/

*/


namespace Homework4Q3;

class Program
{
    static void Main(string[] args)
    {
        // Main is empty except for call to CreateAccount method due to homework instructions specifying CreateAccount as its' own method versus being included in the Main method block.
        CreateAccount();
    }

    static void CreateAccount()
    {
        Console.WriteLine("Enter Your Username: ");
        // All references of string ? taken from Reference 1
        string ? user_name = Console.ReadLine();
        NullCheck(user_name);

        Console.WriteLine("Enter Your Password: ");
        string ? password = Console.ReadLine();
        NullCheck(password);

        Console.WriteLine("Enter Your Password Again: ");
        string ? password_confirm = Console.ReadLine();
        // NullCheck(password_confirm) proved to be unnecessary because a null value will automatically fail the password == password_confirm check later in the code.

        Console.WriteLine("Enter Your Birthyear: ");
        // Null check not included for this input value, as the system will automatically output an error message if non-integer value is entered.
        int year = Convert.ToInt32(Console.ReadLine());

        bool year_check = CheckAge(year);
        if(year_check == true)
        {
            if (password == password_confirm)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
    }

    static bool CheckAge(int birth_year)
    {
        int age = 2023 - birth_year;
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Method introduced to eliminate null warnings and to prevent user from inputting null values as a username or password. Otherwise the program reads null entries as valid.
    static void NullCheck(string ? input)
    {
        // string.IsNullOrEmpty() taken from from Reference 2
        bool null_check = string.IsNullOrEmpty(input);
        if (null_check == true)
        {
            Console.WriteLine("Please re-run program and enter a non-null value.");
            // Environment.Exit() taken from Reference 3
            Environment.Exit(0);
        }
    }
}

