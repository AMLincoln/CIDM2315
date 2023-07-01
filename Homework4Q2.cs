/*

Amanda M Lincoln
CIDM 2315-70 Homework 4 Question 2

This program will take four integer values from the user and will print out a list of the input values, as well as the maximum value between them.

MaxValue method is being re-used from Homework 4 Question 1 per the instructor's request.

Author has chosen not to explicitly handle values that are non-integers or that are null. Inputs of these unhandled types will result in an "unhandled exception"
error and a statement that the input string was not in the correct format.

*/

namespace Homework4Q2;

class Program
{
    static void Main(string[] args)
    {
        int input_a = Convert.ToInt32(Console.ReadLine());
        int input_b = Convert.ToInt32(Console.ReadLine());
        int input_c = Convert.ToInt32(Console.ReadLine());
        int input_d = Convert.ToInt32(Console.ReadLine());

        int max1 = MaxValue(input_a, input_b);
        int max2 = MaxValue(input_c, input_d);
        int max3 = MaxValue(max1, max2);

        Console.WriteLine($"a = {input_a}; b={input_b}; c = {input_c}; d={input_d};");
        Console.WriteLine($"The largest number is: {max3}");
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
