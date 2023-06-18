/*
Amanda M Lincoln
CIDM 2315-70 Homework 2 Bonus

In response to warning messages from C#, null reference error CS8600 was resolved using the following two
references:

1. Anusha1907, BartoszKlonowski, BillWagner, bschaeublin, GitHubPang, 13 March 2023, "Resolve nullable warnings", Microsoft Learn, accessed 18 June 2023, https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference.
2. Anton Miki, Selman Genc, 13 October 2014, "Checking Console.ReadLine()!=null", stack overflow, accessed 18 June 2023, https://stackoverflow.com/questions/26338571/checking-console-readline-null.

This calculator will only work using the Gregorian calendar.
*/



namespace Homework2Bonus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year : ");
        // String? taken from reference 1.
        string? input_yr = Console.ReadLine();
        // string.IsNullorEmpty(input) taken from reference 2.
        if(string.IsNullOrEmpty(input_yr))
        {
            Console.WriteLine("Please run program again and input a valid year from 1582 onwards.");
        }
        else
        {
            int year = Convert.ToInt16(input_yr);
            //Leap year rules were not introduced until 1582 according to the Gregorian calendar.
            if(year < 1582)
            {
                Console.WriteLine("Please run program again and input a valid year from 1582 onwards.");
            }
            else if((year%4==0) && (year%100!=0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else if(year%400==0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
        
    }
}
