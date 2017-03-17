/*Write a C# Sharp program to swap two numbers.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero: ");
            int num_1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("digite um outro numero: ");
            int num_2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"First number: {num_2}");
            Console.WriteLine($"Second number: {num_1}");

            Console.ReadLine();
        }

            
    }
}
