/*

Amanda M Lincoln
CIDM 2315-70 Homework 4 Question 1

This program will take two integer values from the user and will print out a list of the input values, as well as the maximum value between the two.

Author has chosen not to explicitly handle values that are non-integers or that are null. Inputs of these unhandled types will result in an "unhandled exception"
error and a statement that the input string was not in the correct format.

*/

namespace Homework4Q1;

class Program
{
    static void Main(string[] args)
    {
        int input_a = Convert.ToInt32(Console.ReadLine());
        int input_b = Convert.ToInt32(Console.ReadLine());

        int max = MaxValue(input_a, input_b);

        Console.WriteLine($"a = {input_a}; b={input_b}");
        Console.WriteLine($"The largest number is: {max}");
    }

    static int MaxValue(int x, int y)
    {
        if (x >= y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}
