/* Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("digite o primeiro numero a multiplar: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("digite o segundo numero a multiplar: ");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero a multiplar: ");
            n3 = Convert.ToInt16(Console.ReadLine());

            double multiplicacao = n1 * n2 * n3;

            Console.WriteLine($"{n1} x {n2} x {n3} = {multiplicacao}");

            Console.ReadLine();

        }
    }
}
