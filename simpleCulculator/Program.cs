using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCulculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Operator : ");
            string oprator = Console.ReadLine();

            Console.Write(" Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());

            if (oprator == "+")
            {
                Console.WriteLine("Answer is :  " + num1 + num2);
            }
            else if (oprator == "-")
            {
                Console.WriteLine("Answer is : " + (num1 - num2));
            }
            else if (oprator == "*")
            {
                Console.WriteLine("Answer is : " + num1 * num2);
            }

            else if (oprator == "/")
            {
                Console.WriteLine("Answer is: " + num1 / num2);
            }

            else if (oprator == "%")
            {
                Console.WriteLine("Answer is : " + num1 % num2);
            }
            else
            {
                Console.WriteLine("invalid operator ");
            }
                Console.ReadLine();
            
        }
    }
}
