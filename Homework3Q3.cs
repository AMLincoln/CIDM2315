/*Amanda M Lincoln
CIDM 2315-70 Homework 3 Question 3

This program will output a left-justified right triangle of N height, with the triangle consisting of a number of * consistent with the row number it is in.

Author has chosen not to explicitly handle values that are non-integers or that are null. Inputs of these unhandled types will result in an "unhandled exception"
error and a statement that the input string was not in the correct format.
*/

namespace Homework3Q3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N: ");

        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 1)
        {
            Console.WriteLine("Please input an integer value greater than or equal to 1");
        }

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N; j++)
            {
                if (j > i)
                {
                    break;
                }
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
