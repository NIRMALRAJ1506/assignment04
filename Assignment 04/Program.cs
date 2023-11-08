using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int i = int.Parse(Console.ReadLine());
            if (i > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (i < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if (i == 0)
            {
                Console.WriteLine("The number is zero");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            if (i % 2 == 0)
            {
                Console.WriteLine("The Number is even");
            }
            else
            {
                Console.WriteLine("The Number is odd");
            }
            Console.ReadKey();
        }
    }
}
