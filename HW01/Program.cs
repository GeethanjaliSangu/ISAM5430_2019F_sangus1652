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
            Console.WriteLine("Enter number 1");
            String s = Console.ReadLine();
            int num1 = Convert.ToInt32(s);
            Console.WriteLine("Enter number 2");
            s = Console.ReadLine();
            int num2 = Convert.ToInt32(s);
            Console.WriteLine("Enter the operator :(+,-,*,/)");
            string Operator = Console.ReadLine();
            switch (Operator)

            {

                case "+":
                    {
                        int sum = num1 + num2;
                        Console.WriteLine(sum);
                        break;
                    }
                case "-":
                    {
                        int difference = num1 - num2;
                        Console.WriteLine(difference);
                        break;
                    }
                case "*":
                    {
                        int product = num1 * num2;
                        Console.WriteLine(product);
                        break;
                    }
                case "/":
                    {
                        int division = num1 / num2;
                        Console.WriteLine(division);
                        break;
                    }

            }


        }
    }
}
