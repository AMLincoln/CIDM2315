/*

Amanda M Lincoln
CIDM 2315-70 Homework 5

This program creates two customer profiles then proceeds to take the following actions in sequential order: 

1. Prints both customer's information to the console 
2. Updates both customer's ID's
3. Prints both customer's information
4. Compares the two customer's age to one anothers and then outputs a message to the console stating which customer is older.

*/

namespace Homework5;

class Customer
{
    private int cus_id = 0;
    public string cus_name = string.Empty;
    public int cus_age = 0;

    public Customer(int inp_id, string inp_name, int inp_age)
    {
        cus_id = inp_id;
        cus_name = inp_name;
        cus_age = inp_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }

    public void CompareAge (Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {  
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age == objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are the same age.");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(inp_id: 110, inp_name: "Alice", inp_age: 28);
        Customer c2 = new Customer(inp_id: 111, inp_name: "Bob", inp_age: 30);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        c1.ChangeID(220);
        c2.ChangeID(221);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        c1.CompareAge(c2);
    }
}
