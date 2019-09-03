using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01_Solution
{
    class Program
    {
        //entry point in the console app
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1=>");
            String s = Console.ReadLine();
            int num1 = Convert.ToInt32(s);
            Console.WriteLine("Enter number 2=>");
            s = Console.ReadLine();
            int num2 = Convert.ToInt32(s);
            Console.WriteLine("Enter the operator =>");
            string Operator = Console.ReadLine();
            if (Operator == "+")
            {
                int sum = num1 + num2;
                Console.WriteLine($"{num1}{Operator}{num2}={sum}");
            }
            if (Operator == "-")
            {
                int difference = num1 - num2;
                Console.WriteLine($"{num1}{Operator}{num2}={difference}");
            }
            if (Operator == "*")
            {
                int product = num1 * num2;
                Console.WriteLine($"{num1}{Operator}{num2}={product}");
            }
            if (Operator == "/")
            {
                int division = num1 / num2;
                Console.WriteLine($"{num1}{Operator}{num2}={division}");
            }
        }
    }
}
