/*
Amanda M Lincoln
CIDM 2315-70 Homework 2 Question 2

In response to warning messages from C#, null reference error CS8600 was resolved using the following two
references:

1. Anusha1907, BartoszKlonowski, BillWagner, bschaeublin, GitHubPang, 13 March 2023, "Resolve nullable warnings", Microsoft Learn, accessed 18 June 2023, https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference.
2. Anton Miki, Selman Genc, 13 October 2014, "Checking Console.ReadLine()!=null", stack overflow, accessed 18 June 2023, https://stackoverflow.com/questions/26338571/checking-console-readline-null.
*/

namespace Homework2Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num: ");

        // All instances of string? taken from reference 1.
        string? input_num1 = Console.ReadLine();
        // All instances of string.IsNullorEmpty(input) taken from reference 2.
        if(string.IsNullOrEmpty(input_num1))
        {
            Console.WriteLine("Please run program again and input integer value for num 1. ");
        }

        else
        {
            int num1 = Convert.ToInt16(input_num1);
            Console.WriteLine("Please input the second num: ");
            string? input_num2 = Console.ReadLine();
            if(string.IsNullOrEmpty(input_num2))
            {
                Console.WriteLine("Please run program again and input integer value for num 2. ");
            }
            else
            {
                int num2 = Convert.ToInt16(input_num2);
                Console.WriteLine("Please input the third num: ");
                string? input_num3 = Console.ReadLine();
                if(string.IsNullOrEmpty(input_num3))
                {
                    Console.WriteLine("Please run program again and input integer value for num 3. ");
                }
                else
                {
                    int num3 = Convert.ToInt16(input_num3);
                    if(num1 < num2)
                    {
                        if(num1 < num3)
                        {
                            Console.WriteLine($"The smallest value is: {num1}");
                        }
                        else 
                        {
                            Console.WriteLine($"The smallest value is: {num3}");
                        }
                    }
                    else
                    {
                        if(num2 < num3)
                        {
                            Console.WriteLine($"The smallest value is: {num2}");
                        }
                        else
                        {
                            Console.WriteLine($"The smallest value is: {num3}");
                        }
                    }
                }  
            }
        }

    }
}
