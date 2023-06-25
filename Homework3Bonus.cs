/* 
Amanda M Lincoln
CIDM 2315-70 Homework 3 Bonus

This program will generate a right-justified right triangle of N height, with the triangle consisting of numbers that match their respective row. This program will
only function correctly if the input integer is between 1 and 9.

Author has chosen not to explicitly handle values that are non-integers or that are null. Inputs of these unhandled types will result in an "unhandled exception"
error and a statement that the input string was not in the correct format.
*/

namespace Homework3Bonus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N: ");

        int N = Convert.ToInt32(Console.ReadLine());

        // Numbers greater than or equal to 10 cause the right triangle to be disproportionate due to having two symbols in each number.
        if ((N < 1) || N >= 10)
        {
            Console.WriteLine("Please input an integer value between 1 and 9.");
        }

        else
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = (N - i); j >= 0; j--)
                {
                    if (j == 0)
                    {
                        for (int k = 0; k <=N; k++)
                        {
                            if (k == i)
                            {
                                break;
                            }

                            Console.Write(i);
                        }
                    }
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }    
        }
    }
}
