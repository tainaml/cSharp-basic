/*Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("digite o primeiro numero: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("digite o segundo numero: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            int soma = num1 + num2;
            int sub = num1 - num2;
            int mult = num1 * num2;
            int div = num1 / num2;
            int resto = num1 % 4;
            Console.WriteLine($"{num1} + {num2} = {soma}");
            Console.WriteLine($"{num1} - {num2} = {sub}");
            Console.WriteLine($"{num1} * {num2} = {mult}");
            Console.WriteLine($"{num1} / {num2} = {div}");
            Console.WriteLine($"{num1} mod {num2} = {resto}");

            Console.ReadLine();



        }
    }
}
