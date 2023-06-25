/* 
Amanda M Lincoln
CIDM 2315-70 Homework 3 Question 1

This program will determine whether or not a number is prime. Input should be of the integer type, and should be greater than 1, in accordance with the definition of
what a prime number is. 

Author has chosen not to explicitly handle values that are non-integers or that are null. Inputs of these unhandled types will result in an "unhandled exception"
error and a statement that the input string was not in the correct format.
*/

namespace Homework3Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 1)
        {
            // Prime numbers are whole numbers greater than 1.
            Console.WriteLine("Prime numbers are limited to whole numbers greater than 1.");
        }

        // As 2 is a prime number, but has not other value between 1 and itself to compare it to, this value was taken out of the loop and treated as an exception.
        if (N == 2)
        {
            Console.WriteLine("N is prime");
        }

        for( int i = 2; i <= (N-1); i++)
        {
            if ((N % i) == 0)
            {
                Console.WriteLine("N is non-prime");
                break;
            }
            
            if ((i == (N-1)) && (N % i) != 0)
            {
                Console.WriteLine("N is prime");
            }
        }
    }
}
