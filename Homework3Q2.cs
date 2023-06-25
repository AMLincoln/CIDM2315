/*Amanda M Lincoln
CIDM 2315-70 Homework 3 Question 2

This program will output a square of # of height/width of input N. 

Author has chosen not to explicitly handle values that are non-integers or that are null. Inputs of these unhandled types will result in an "unhandled exception"
error and a statement that the input string was not in the correct format.
*/

namespace Homework3Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N: ");

        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 1)
        {
            Console.WriteLine("Please input an integer value greater than or equal to 1.");
        }

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }
    }
}
